using NotificationsExtansions.ToastContent;

namespace NotificationsExtansions
{
    internal sealed class IncomingCallCommands : IIncomingCallCommands
    {
        internal IncomingCallCommands() { }

        public bool ShowVideoCommand
        {
            get { return m_Video; }
            set { m_Video = value; }
        }

        public string VideoArgument
        {
            get { return m_VideoArgument; }
            set { m_VideoArgument = value; }
        }

        public bool ShowVoiceCommand
        {
            get { return m_Voice; }
            set { m_Voice = value; }
        }

        public string VoiceArgument
        {
            get { return m_VoiceArgument; }
            set { m_VoiceArgument = value; }
        }

        public bool ShowDeclineCommand
        {
            get { return m_Decline; }
            set { m_Decline = value; }
        }

        public string DeclineArgument
        {
            get { return m_DeclineArgument; }
            set { m_DeclineArgument = value; }
        }

        private bool m_Video = false;
        private bool m_Voice = false;
        private bool m_Decline = false;

        private string m_VideoArgument = string.Empty;
        private string m_VoiceArgument = string.Empty;
        private string m_DeclineArgument = string.Empty;
    }
}