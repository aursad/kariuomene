using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Kariuomene.DataModel
{
    public class RegionDataModel
    {
        public Task<IList<RegionDto>> Regions
        {
            get { return GetList(); }
        }

        private async Task<IList<RegionDto>> GetList()
        {
            try
            {
                var temporaryFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

                var sampleFile = await temporaryFolder.OpenStreamForReadAsync(@"Assets\regionsData.json");
                using (var streamReader = new StreamReader(sampleFile))
                {
                    var s = streamReader.ReadToEnd();

                    var dataModel = JsonConvert.DeserializeObject<List<RegionDto>>(s);
                    return dataModel;
                }
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        } 
    }

    public class RegionDto
    {
        public string Id { get; set; }
        public int Nr { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
    }

}
