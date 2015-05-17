using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Newtonsoft.Json;

namespace Kariuomene.DataModel
{
    public class DepartmentDataModel
    {
        public Task<IList<DepartmentDto>> Departments
        {
            get { return GetList(); }
        }

        private async Task<IList<DepartmentDto>> GetList()
        {
            try
            {
                var temporaryFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

                var sampleFile = await temporaryFolder.OpenStreamForReadAsync(@"Assets\departmentData.json");
                using (var streamReader = new StreamReader(sampleFile))
                {
                    var s = streamReader.ReadToEnd();

                    var dataModel = JsonConvert.DeserializeObject<List<DepartmentDto>>(s);
                    return dataModel;
                }
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        } 
    }

    public class DepartmentDto
    {
        public int Id { get; set; }
        public string Region { get; set; }
        public int Regionnr { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

}
