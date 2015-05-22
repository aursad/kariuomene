// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved


#if !WINRT_NOT_PRESENT

#endif

namespace NotificationsExtansions
{
    internal sealed class NotificationContentText : INotificationContentText
    {
        internal NotificationContentText() { }

        public string Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }

        public string Lang
        {
            get { return m_Lang; }
            set { m_Lang = value; }
        }

        private string m_Text;
        private string m_Lang;
    }
}