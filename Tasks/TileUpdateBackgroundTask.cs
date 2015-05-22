using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;
using HtmlAgilityPack;

namespace Tasks
{
    public sealed class TileUpdateBackgroundTask : IBackgroundTask
    {
        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            Debug.WriteLine("ServicingComplete " + taskInstance.Task.Name + " starting..."); 
            var deferral = taskInstance.GetDeferral();

            taskInstance.Canceled += OnCanceled;

            TileUpdateManager.CreateTileUpdaterForApplication().Clear();
            BadgeUpdateManager.CreateBadgeUpdaterForApplication().Clear();

            var dataRequest = await GetData();
            UpdateTile(dataRequest);

            deferral.Complete();
        }

        private async Task<int> GetData()
        {
            try
            {
                var document = new HtmlDocument();
                using (var client = new HttpClient())
                {
                    document.LoadHtml(await client.GetStringAsync("http://2015.kam.lt/lt/aktuali_informacija_apie_privalomaja_karine_tarnyba/new_2716.html"));
                }

                return GetVisusSauktinius(document);
            }
            catch (Exception e)
            {
                throw new Exception("Can't receive information.", e);
            }
        }

        private int GetVisusSauktinius(HtmlDocument document)
        {
            var parsed = document.DocumentNode.Descendants("strong").ToList();

            var parsedDec = parsed.FirstOrDefault(q => q.XPath.Contains("/html[1]/body[1]/div[1]/div[3]/table[1]/tr[1]/td[2]/div[1]/div[1]/div[1]/p[7]/strong[2]"));
            return Convert.ToInt32(parsedDec.InnerText);
        }

        // 
        // Handles background task cancellation. 
        // 
        private void OnCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason)
        {
            // 
            // Indicate that the background task is canceled. 
            // 

            Debug.WriteLine("ServicingComplete " + sender.Task.Name + " Cancel Requested...");
        }

        private static void UpdateTile(int sauktiniuKiekis)
        {
            var tileXmlString = string.Format(@"<tile>
                          <visual version='3'>
                            <binding template='TileSquare150x150PeekImageAndText02' fallback='TileSquarePeekImageAndText04'>
                              <image id='1' src='Assets/Square150x150Logo.scale-100.png' alt='tileImage'/>
                              <text id='1'>{0}</text>
                              <text id='2'>{1}</text>
                            </binding>
                            <binding template='TileWide310x150PeekImage01' fallback='TileWidePeekImage01'>
                              <image id='1' src='Assets/Square150x150Logo.scale-100.png' alt='tileImage'/>
                              <text id='1'>{0}</text>
                              <text id='2'>{1}</text>
                            </binding> 
                          </visual>
                        </tile>", sauktiniuKiekis, "Šauktinių dabar");

            // Create a DOM.
            var tileDom = new Windows.Data.Xml.Dom.XmlDocument();

            // Load the xml string into the DOM.
            tileDom.LoadXml(tileXmlString);

            // Create a tile notification.
            var tile = new TileNotification(tileDom);

            // Send the notification to the application? tile.
            TileUpdateManager.CreateTileUpdaterForApplication("App").Update(tile);
        }
    }
}

