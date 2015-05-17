using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage;
using Kariuomene.ViewModel;
using Newtonsoft.Json;

namespace Kariuomene.Common
{
    public class CacheProvider
    {
        readonly StorageFolder _temporaryFolder = ApplicationData.Current.TemporaryFolder;

        public async void Write(SauktinisModel dataModel, bool updateCacheTime = true)
        {
            if (updateCacheTime)
            {
                dataModel.CacheDateTime = DateTime.Now;
            }
            var dataModelJson = JsonConvert.SerializeObject(dataModel, Formatting.Indented);

            var sampleFile = await _temporaryFolder.CreateFileAsync(App.FileNameForData, CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteTextAsync(sampleFile, dataModelJson);
        }

        public async Task<SauktinisModel> Read()
        {
            try
            {
                var sampleFile = await _temporaryFolder.GetFileAsync(App.FileNameForData);
                if (sampleFile != null)
                {
                    var dataModel = JsonConvert.DeserializeObject<SauktinisModel>(await FileIO.ReadTextAsync(sampleFile));
                    return dataModel;
                }
                return null;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        public async Task<NaujienaModel> Read(NaujienaModel naujienaModel)
        {
            try
            {
                var sampleFile = await _temporaryFolder.GetFileAsync(App.FileNameForData);
                if (sampleFile != null)
                {
                    var dataModel = JsonConvert.DeserializeObject<SauktinisModel>(await FileIO.ReadTextAsync(sampleFile));
                    var itemReceiver =
                        dataModel.Naujienos.FirstOrDefault(q => q.Title.Contains(naujienaModel.Title));

                    return itemReceiver;
                }
                return null;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        public async void Write(NaujienaModel naujienaModel)
        {
            try
            {
                var sampleFile = await _temporaryFolder.GetFileAsync(App.FileNameForData);
                if (sampleFile != null)
                {
                    var dataModel = JsonConvert.DeserializeObject<SauktinisModel>(await FileIO.ReadTextAsync(sampleFile));

                    var cachedNaujienaModel = dataModel.Naujienos.FirstOrDefault(q => q.Title.Contains(naujienaModel.Title));
                    if (cachedNaujienaModel != null)
                    {
                        var i = dataModel.Naujienos.IndexOf(cachedNaujienaModel);
                        dataModel.Naujienos.Remove(cachedNaujienaModel);

                        cachedNaujienaModel = naujienaModel;
                        cachedNaujienaModel.Cached = DateTime.Now;

                        dataModel.Naujienos.Insert(i, cachedNaujienaModel);

                        Write(dataModel, false);
                    }
                }
            }
            catch(FileNotFoundException)
            {
            }
        }
    }
}
