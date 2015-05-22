using System;
using System.Text;
using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare310x310Base : TileNotificationBase
    {
        public TileSquare310x310Base(string templateName, string fallbackName, int imageCount, int textCount)
            : base(templateName, null, imageCount, textCount)
        {
        }

        public IWide310x150TileNotificationContent Wide310x150Content
        {
            get { return m_Wide310x150Content; }
            set { m_Wide310x150Content = value; }
        }

        public bool RequireWide310x150Content
        {
            get { return m_RequireWide310x150Content; }
            set { m_RequireWide310x150Content = value; }
        }

        public override string GetContent()
        {
            if (RequireWide310x150Content && Wide310x150Content == null)
            {
                throw new NotificationContentValidationException(
                    "Wide310x150 tile content should be included with each large tile. " +
                    "If this behavior is undesired, use the RequireWide310x150Content property.");
            }

            if (Wide310x150Content != null && Wide310x150Content.RequireSquare150x150Content && Wide310x150Content.Square150x150Content == null)
            {
                throw new NotificationContentValidationException(
                    "This tile's wide content requires square content. " +
                    "If this behavior is undesired, use the Wide310x150Content.RequireSquare150x150Content property.");
            }

            StringBuilder visualNode = new StringBuilder(String.Empty);
            visualNode.AppendFormat("<visual version='{0}'", TileUtil.NOTIFICATION_CONTENT_VERSION);
            if (!String.IsNullOrWhiteSpace(Lang))
            {
                visualNode.AppendFormat(" lang='{0}'", Util.HttpEncode(Lang));
            }
            if (Branding != TileBranding.Logo)
            {
                visualNode.AppendFormat(" branding='{0}'", Branding.ToString().ToLowerInvariant());
            }
            if (!String.IsNullOrWhiteSpace(BaseUri))
            {
                visualNode.AppendFormat(" baseUri='{0}'", Util.HttpEncode(BaseUri));
            }
            if (AddImageQuery)
            {
                visualNode.AppendFormat(" addImageQuery='true'");
            }
            visualNode.Append(">");

            StringBuilder builder = new StringBuilder(String.Empty);
            builder.AppendFormat("<tile>{0}", visualNode);
            if (Wide310x150Content != null)
            {
                IWide310x150TileInternal wideBase = Wide310x150Content as IWide310x150TileInternal;
                if (wideBase == null)
                {
                    throw new NotificationContentValidationException("The provided wide tile content class is unsupported.");
                }
                builder.Append(wideBase.SerializeBindings(Lang, BaseUri, Branding, AddImageQuery));
            }
            builder.AppendFormat("<binding template='{0}'", TemplateName);
            if (!String.IsNullOrWhiteSpace(FallbackName))
            {
                builder.AppendFormat(" fallback='{0}'", FallbackName);
            }
            if (!String.IsNullOrWhiteSpace(ContentId))
            {
                builder.AppendFormat(" contentId='{0}'", ContentId.ToLowerInvariant());
            }
            builder.AppendFormat(">{0}</binding></visual></tile>", SerializeProperties(Lang, BaseUri, AddImageQuery));

            return builder.ToString();
        }

        private IWide310x150TileNotificationContent m_Wide310x150Content = null;
        private bool m_RequireWide310x150Content = true;
    }
}