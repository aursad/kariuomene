// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using NotificationsExtansions.ToastContent;
#if !WINRT_NOT_PRESENT

#endif

namespace NotificationsExtansions
{
    internal sealed class ToastAudio : IToastAudio
    {
        internal ToastAudio() { }

        public ToastAudioContent Content
        {
            get { return m_Content; }
            set
            {
                if (!Enum.IsDefined(typeof(ToastAudioContent), value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                m_Content = value;
            }
        }

        public bool Loop
        {
            get { return m_Loop; }
            set { m_Loop = value; }
        }

        private ToastAudioContent m_Content = ToastAudioContent.Default;
        private bool m_Loop = false;
    }
}
