namespace NotificationsExtansions.ToastContent
{
    /// <summary>
    /// Type representing the incoming call command properties which is contained within
    /// a toast notification content object.
    /// </summary>
    public interface IIncomingCallCommands
    {
        /// <summary>
        /// Whether the toast shows the video button.
        /// </summary>
        bool ShowVideoCommand { get; set; }

        /// <summary>
        /// The argument passed to the app when the video command is invoked.
        /// </summary>
        string VideoArgument { get; set; }

        /// <summary>
        /// Whether the toast shows the voice button.
        /// </summary>
        bool ShowVoiceCommand { get; set; }

        /// <summary>
        /// The argument passed to the app when the voice command is invoked.
        /// </summary>
        string VoiceArgument { get; set; }

        /// <summary>
        /// Whether the toast shows the decline button.
        /// </summary>
        bool ShowDeclineCommand { get; set; }

        /// <summary>
        /// The argument passed to the app when the decline command is invoked.
        /// </summary>
        string DeclineArgument { get; set; }
    }
}