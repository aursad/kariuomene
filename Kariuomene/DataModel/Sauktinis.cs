using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Kariuomene.ViewModel;

namespace Kariuomene.DataModel
{
    public class Sauktinis
    {
        private readonly string _url;
        private SauktinisModel _sauktinis;
        private HtmlDocument _document;

        public Sauktinis(string url)
        {
            _url = url;
        }

        public async Task<SauktinisModel> GetData()
        {
            try
            {
                _document = new HtmlDocument();
                using (var client = new HttpClient())
                {
                    _document.LoadHtml(await client.GetStringAsync(_url));
                }

                _sauktinis = new SauktinisModel
                {
                    Viso = GetVisusSauktinius(),
                    Rinktines = GetRinktinesModels()
                };
                return _sauktinis;
            }
            catch (Exception e)
            {
                throw new Exception("Can't receive information.", e);
            }
        }

        private int GetVisusSauktinius()
        {
            var parsed = _document.DocumentNode.Descendants("strong").ToList();

            var parsedDec = parsed.FirstOrDefault(q => q.XPath.Contains("/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[1]/div[1]/p[7]/strong[2]"));
            return Convert.ToInt32(parsedDec.InnerText);
        }

        private IList<RinktinesModel> GetRinktinesModels()
        {
            var list = new List<RinktinesModel>();

            var parsed = _document.DocumentNode.Descendants("table").ToList().FirstOrDefault(q => q.XPath == "/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[1]/div[1]/table[1]");

            int[] position = { 2 };
            var parsedList = parsed.Descendants("tr").ToList();
            foreach (var node in parsedList.Where(q => q.XPath == string.Format("/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[{0}]", position[0])))
            {
                var apygarda = node.DescendantsAndSelf("p").ToList().FirstOrDefault(q => q.XPath == string.Format("{0}/td[1]/p[1]", node.XPath));

                var memoryNode = node.Descendants("strong").ToList();
                var miestas = memoryNode.FirstOrDefault(q => q.XPath == string.Format("{0}/td[1]/p[2]/strong[1]", node.XPath));
                var kiekis = memoryNode.FirstOrDefault(q => q.XPath == string.Format("{0}/td[2]/strong[1]", node.XPath));

                list.Add(new RinktinesModel
                {
                    Apygarda = apygarda.InnerText,
                    Miestas = miestas.InnerText,
                    Prasymu = Convert.ToInt32(kiekis.InnerText)
                });

                if (position[0] < 7) { position[0]++; } else { break; }
            }
            return list;
        }
    }
}
