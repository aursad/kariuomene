using System;
using System.Text;
using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileWide310x150Base : TileNotificationBase, IWide310x150TileInternal
    {
        public TileWide310x150Base(string templateName, string fallbackName, int imageCount, int textCount)
            : base(templateName, fallbackName, imageCount, textCount)
        {
        }

        public ISquare150x150TileNotificationContent Square150x150Content
        {
            get { return m_Square150x150Content; }
            set { m_Square150x150Content = value; }
        }

        public bool RequireSquare150x150Content
        {
            get { return m_RequireSquare150x150Content; }
            set { m_RequireSquare150x150Content = value; }
        }

        public override string GetContent()
        {
            if (RequireSquare150x150Content && Square150x150Content == null)
            {
                throw new NotificationContentValidationException(
                    "Square150x150 tile content should be included with each wide tile. " +
                    "If this behavior is undesired, use the RequireSquare150x150Content property.");
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
            if (Square150x150Content != null)
            {
                ISquare150x150TileInternal squareBase = Square150x150Content as ISquare150x150TileInternal;
                if (squareBase == null)
                {
                    throw new NotificationContentValidationException("The provided square tile content class is unsupported.");
                }
                builder.Append(squareBase.SerializeBinding(Lang, BaseUri, Branding, AddImageQuery));
            }
            builder.AppendFormat("<binding template='{0}'", TemplateName);
            if (!String.IsNullOrWhiteSpace(FallbackName))
            {
                builder.AppendFormat(" fallback='{0}'", FallbackName);
            }
            builder.AppendFormat(">{0}</binding></visual></tile>", SerializeProperties(Lang, BaseUri, AddImageQuery));
            return builder.ToString();
        }

        public string SerializeBindings(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery)
        {
            StringBuilder bindingNode = new StringBuilder(String.Empty);
            if (Square150x150Content != null)
            {
                ISquare150x150TileInternal squareBase = Square150x150Content as ISquare150x150TileInternal;
                if (squareBase == null)
                {
                    throw new NotificationContentValidationException("The provided square tile content class is unsupported.");
                }
                bindingNode.Append(squareBase.SerializeBinding(Lang, BaseUri, Branding, AddImageQuery));
            }

            bindingNode.AppendFormat("<binding template='{0}'", TemplateName);
            if (!String.IsNullOrWhiteSpace(FallbackName))
            {
                bindingNode.AppendFormat(" fallback='{0}'", FallbackName);
            }
            if (!String.IsNullOrWhiteSpace(Lang) && !Lang.Equals(globalLang))
            {
                bindingNode.AppendFormat(" lang='{0}'", Util.HttpEncode(Lang));
                globalLang = Lang;
            }
            if (Branding != TileBranding.Logo && Branding != globalBranding)
            {
                bindingNode.AppendFormat(" branding='{0}'", Branding.ToString().ToLowerInvariant());
            }
            if (!String.IsNullOrWhiteSpace(BaseUri) && !BaseUri.Equals(globalBaseUri))
            {
                bindingNode.AppendFormat(" baseUri='{0}'", Util.HttpEncode(BaseUri));
                globalBaseUri = BaseUri;
            }
            if (AddImageQueryNullable != null && AddImageQueryNullable != globalAddImageQuery)
            {
                bindingNode.AppendFormat(" addImageQuery='{0}'", AddImageQuery.ToString().ToLowerInvariant());
                globalAddImageQuery = AddImageQuery;
            }
            if (!String.IsNullOrWhiteSpace(ContentId))
            {
                bindingNode.AppendFormat(" contentId='{0}'", ContentId.ToLowerInvariant());
            }
            bindingNode.AppendFormat(">{0}</binding>", SerializeProperties(globalLang, globalBaseUri, globalAddImageQuery));

            return bindingNode.ToString();
        }

        private ISquare150x150TileNotificationContent m_Square150x150Content = null;
        private bool m_RequireSquare150x150Content = true;
    }
}