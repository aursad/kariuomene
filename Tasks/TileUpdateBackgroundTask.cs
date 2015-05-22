using System;
using System.Diagnostics;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;

namespace Tasks
{
    public sealed class TileUpdateBackgroundTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {

            Debug.WriteLine("ServicingComplete " + taskInstance.Task.Name + " starting..."); 
            var deferral = taskInstance.GetDeferral();

            taskInstance.Canceled += OnCanceled;

            TileUpdateManager.CreateTileUpdaterForApplication().Clear();
            BadgeUpdateManager.CreateBadgeUpdaterForApplication().Clear();
            // Download the feed.
            //var feed = await GetMSDNBlogFeed();

            // Update the live tile with the feed items.
            UpdateTile();

            // Inform the system that the task is finished.
            deferral.Complete();
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

        private static void UpdateTile()
        {
            var rnd = new Random();
            var sauktiniuKiekis = rnd.Next(2000, 6666); 

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

