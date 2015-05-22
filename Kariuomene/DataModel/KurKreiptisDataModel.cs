using System.Collections.Generic;

namespace Kariuomene.DataModel
{
    public class KurKreiptisDataModel
    {
        public IEnumerable<KurKreiptisLocationModel> List
        {
            get { return GetList(); }
        }

        private IEnumerable<KurKreiptisLocationModel> GetList()
        {
            var list = new List<KurKreiptisLocationModel>
            {
                new KurKreiptisLocationModel
                {
                    Address = "Mindaugo g. 26, Vilnius",
                    Name = "Vilniaus regioninis Karo prievolės ir komplektavimo skyrius",
                    Phone = new[] {"(8-5) 2103 702", "2103 720, 2103 773"},
                    Latitude = 54.6755517,
                    Longitude = 25.2748163
                },
                new KurKreiptisLocationModel
                {
                    Address = "Amatų g. 4, Molėtai",
                    Name = "Molėtų Karo prievolės ir komplektavimo poskyris",
                    Phone = new []{"8 (383) 52 963","8 (612) 96 193"},
                    Latitude = 55.2298399,
                    Longitude = 25.4130267
                },
                new KurKreiptisLocationModel
                {
                    Address = "Dvaro g. 77, Šiauliai",
                    Name = "Šiaulių regioninis Karo prievolės ir komplektavimo skyriusa",
                    Phone = new []{"(8-41) 524 682"},
                    Latitude = 55.9334149,
                    Longitude = 23.3125949
                },
                new KurKreiptisLocationModel
                {
                    Address = "Karaliaus Mindaugo g. 1, Telšiai",
                    Name = "Telšių Karo prievolės ir komplektavimo poskyris",
                    Phone = new []{"(8-444) 74 886"},
                    Latitude = 55.9890738,
                    Longitude = 22.2401822
                },
                new KurKreiptisLocationModel
                {
                    Address = "Dembavos g. 30, Dembava",
                    Name = "Panevėžio regioninis Karo prievolės ir komplektavimo skyrius",
                    Phone = new []{"(8-45) 594 556", "(8-45) 594 532"},
                    Latitude = 55.7367568,
                    Longitude = 24.4067091
                },
                new KurKreiptisLocationModel
                {
                    Address = "Maironio g. 9, Utena",
                    Name = "Utenos Karo prievolės ir komplektavimo poskyris",
                    Phone = new []{"8-389) 59 475"},
                    Latitude = 55.4995168,
                    Longitude = 25.6008547
                },
                new KurKreiptisLocationModel
                {
                    Address = "Vytauto g. 5, Klaipėda",
                    Name = "Klaipėdos regioninis Karo prievolės ir komplektavimo skyrius",
                    Phone = new []{"(8-46) 412 611 "},
                    Latitude = 55.7132133,
                    Longitude = 21.1347973
                },
                new KurKreiptisLocationModel
                {
                    Address = "Vinco Kudirkos g. 9, Tauragė",
                    Name = "Tauragės Karo prievolės ir komplektavimo poskyris",
                    Phone = new []{"(8-446) 61 697"},
                    Latitude = 55.2548639,
                    Longitude = 22.2848375
                },
                new KurKreiptisLocationModel
                {
                    Address = "Jonavos g. 64, Kaunas",
                    Name = "Kauno karo prievolės centras",
                    Phone = new []{"(8-37) 332401"},
                    Latitude = 54.906194,
                    Longitude = 23.902933
                },
                new KurKreiptisLocationModel
                {
                    Address = "Naujoji g. 2-320, Alytus",
                    Name = "Alytaus regioninis Karo prievolės ir komplektavimo skyrius",
                    Phone = new []{"(8-315) 74 139"},
                    Latitude = 54.3961954,
                    Longitude = 24.0377409
                },
                new KurKreiptisLocationModel
                {
                    Address = "Vytauto Didžiojo g. 7-1, Jurbarkas",
                    Name = "Jurbarko Karo prievolės ir komplektavimo poskyris",
                    Phone = new []{"8 (447) 53471"},
                    Latitude = 55.0759781,
                    Longitude = 22.7682844
                },
                new KurKreiptisLocationModel
                {
                    Address = "Kauno g. 3, Marijampolė",
                    Name = "Marijampolės Karo prievolės ir komplektavimo poskyris",
                    Phone = new []{"(8-343) 54 628"},
                    Latitude = 54.5582812,
                    Longitude = 23.3498702
                }
            };

            return list;
        }
    }
}
