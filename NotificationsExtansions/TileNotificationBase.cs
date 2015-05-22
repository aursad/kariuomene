using System;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal abstract class TileNotificationBase : NotificationBase
    {
        public TileNotificationBase(string templateName, string fallbackName, int imageCount, int textCount)
            : base(templateName, fallbackName, imageCount, textCount)
        {
        }

        public TileBranding Branding
        {
            get { return m_Branding; }
            set
            {
                if (!Enum.IsDefined(typeof(TileBranding), value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                m_Branding = value;
            }
        }

        public string ContentId
        {
            get { return m_ContentId; }
            set { m_ContentId = value; }
        }

#if !WINRT_NOT_PRESENT
        public TileNotification CreateNotification()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(GetContent());
            return new TileNotification(xmlDoc);
        }
#endif

        private TileBranding m_Branding = TileBranding.Logo;
        private string m_ContentId = null;
    }
}