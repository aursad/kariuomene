using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Kariuomene.ViewModel;

namespace Kariuomene.DataModel
{
    public class Naujienos
    {
        private readonly string _url;
        private HtmlDocument _htmlDocument;
        private NaujienosDataModel _naujienosDataModel;

        public Naujienos(string url)
        {
            _url = url;
        }

        public Naujienos()
        {
            
        }

        public async Task<NaujienosDataModel> GetData()
        {
            try
            {
                _htmlDocument = new HtmlDocument();
                using (var client = new HttpClient())
                {
                    _htmlDocument.LoadHtml(await client.GetStringAsync(_url));
                }

                _naujienosDataModel = new NaujienosDataModel
                {
                    Naujienos = GetNaujienas()
                };
                return _naujienosDataModel;
            }
            catch (Exception e)
            {
                throw new Exception("Can't receive information.", e);
            }
        }

        public async Task<NaujienaModel> GetFullNaujienaModel(NaujienaModel model)
        {
            try
            {
                var htmlDocument = new HtmlDocument();
                using (var client = new HttpClient())
                {
                    model.Url = model.Url.Replace("www", "2015");

                    htmlDocument.LoadHtml(await client.GetStringAsync(model.Url));
                }

                var imageUrl = htmlDocument.DocumentNode.Descendants("img").ToList().FirstOrDefault(q => q.XPath == "/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[3]/div[2]/div[1]/img[1]");
                if (imageUrl != null)
                {
                    var getSrcAttr = imageUrl.Attributes.FirstOrDefault(q => q.Name == "src");
                    if (getSrcAttr != null)
                    {
                        using (var client = new HttpClient())
                        {
                            model.Image = await client.GetByteArrayAsync(getSrcAttr.Value);
                        }
                    }
                }

                var pusblishNode = htmlDocument.DocumentNode.Descendants().ToList().FirstOrDefault(q => q.XPath == "/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[2]");
                if (pusblishNode != null) model.Publish = pusblishNode.InnerText;


                var parsed = htmlDocument.DocumentNode.Descendants("div").ToList().FirstOrDefault(q => q.XPath == "/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[3]/div[2]");
                if (parsed != null)
                    foreach (var node in parsed.DescendantsAndSelf("p").ToList().FindAll(q => q.XPath.Contains("/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[3]/div[2]")))
                    {
                        model.FullText += node.InnerText.Trim(new[] { '\n', '\t' });
                    }
                return model;
            }
            catch (Exception e)
            {
                throw new Exception("Can't receive information.", e);
            }
        }

        private IList<NaujienaModel> GetNaujienas()
        {
            var list = new List<NaujienaModel>();
            var parsed = _htmlDocument.DocumentNode.Descendants("div").ToList().FirstOrDefault(q => q.XPath.Contains("/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[1]/div[1]"));

            if (parsed != null)
                foreach (var node in parsed.DescendantsAndSelf("a").ToList().FindAll(q => q.XPath.Contains("/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[1]/div[1]")))
                {
                    var getHrefAttr = node.Attributes.FirstOrDefault(q => q.Name == "href");
                    if (getHrefAttr != null)
                    {
                        list.Add(new NaujienaModel
                        {
                            Title = node.InnerText.Trim(new[] { '\n', '\t' }),
                            Url = getHrefAttr.Value
                        });
                    }
                }
            return list;
        }
    }
}
