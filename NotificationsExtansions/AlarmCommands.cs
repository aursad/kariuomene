using NotificationsExtansions.ToastContent;

namespace NotificationsExtansions
{
    internal sealed class AlarmCommands : IAlarmCommands
    {
        internal AlarmCommands() { }

        public bool ShowSnoozeCommand
        {
            get { return m_Snooze; }
            set { m_Snooze = value; }
        }

        public string SnoozeArgument
        {
            get { return m_SnoozeArgument; }
            set { m_SnoozeArgument = value; }
        }

        public bool ShowDismissCommand
        {
            get { return m_Dismiss; }
            set { m_Dismiss = value; }
        }

        public string DismissArgument
        {
            get { return m_DismissArgument; }
            set { m_DismissArgument = value; }
        }

        private bool m_Snooze = false;
        private bool m_Dismiss = false;

        private string m_SnoozeArgument = string.Empty;
        private string m_DismissArgument = string.Empty;
    }
}