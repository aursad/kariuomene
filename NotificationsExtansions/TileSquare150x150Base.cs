using System;
using System.Text;
using NotificationsExtansions.TileContent;

namespace NotificationsExtansions
{
    internal class TileSquare150x150Base : TileNotificationBase, ISquare150x150TileInternal
    {
        public TileSquare150x150Base(string templateName, string fallbackName, int imageCount, int textCount)
            : base(templateName, fallbackName, imageCount, textCount)
        {
        }

        public ISquare71x71TileNotificationContent Square71x71Content
        {
            get { return m_Square71x71Content; }
            set { m_Square71x71Content = value; }
        }

        public bool RequireSquare71x71Content
        {
            get { return m_RequireSquare71x71Content; }
            set { m_RequireSquare71x71Content = value; }
        }

        public override string GetContent()
        {
            if (RequireSquare71x71Content && Square71x71Content == null)
            {
                throw new NotificationContentValidationException(
                    "Square71x71 tile content should be included with each medium tile. " +
                    "If this behavior is undesired, use the RequireSquare71x71Content property.");
            }

            StringBuilder builder = new StringBuilder(String.Empty);
            builder.AppendFormat("<tile><visual version='{0}'", TileUtil.NOTIFICATION_CONTENT_VERSION);
            if (!String.IsNullOrWhiteSpace(Lang))
            {
                builder.AppendFormat(" lang='{0}'", Util.HttpEncode(Lang));
            }
            if (Branding != TileBranding.Logo)
            {
                builder.AppendFormat(" branding='{0}'", Branding.ToString().ToLowerInvariant());
            }
            if (!String.IsNullOrWhiteSpace(BaseUri))
            {
                builder.AppendFormat(" baseUri='{0}'", Util.HttpEncode(BaseUri));
            }
            if (AddImageQuery)
            {
                builder.AppendFormat(" addImageQuery='true'");
            }
            builder.Append(">");

            if (Square71x71Content != null)
            {
                ISquare71x71TileInternal smallTileBase = Square71x71Content as ISquare71x71TileInternal;
                if (smallTileBase == null)
                {
                    throw new NotificationContentValidationException("The provided small tile content class is unsupported.");
                }
                builder.Append(smallTileBase.SerializeBinding(Lang, BaseUri, Branding, AddImageQuery));
            }

            builder.Append(SerializeBinding(Lang, BaseUri, Branding, AddImageQuery));
            builder.Append("</visual></tile>");
            return builder.ToString();
        }

        public string SerializeBinding(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery)
        {
            StringBuilder bindingNode = new StringBuilder(String.Empty);

            if (Square71x71Content != null)
            {
                ISquare71x71TileInternal smallTileBase = Square71x71Content as ISquare71x71TileInternal;
                if (smallTileBase == null)
                {
                    throw new NotificationContentValidationException("The provided small tile content class is unsupported.");
                }
                bindingNode.Append(smallTileBase.SerializeBinding(Lang, BaseUri, Branding, AddImageQuery));
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

        private ISquare71x71TileNotificationContent m_Square71x71Content = null;
        private bool m_RequireSquare71x71Content = false;
    }
}