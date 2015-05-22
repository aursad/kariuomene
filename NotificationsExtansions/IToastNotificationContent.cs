using Windows.UI.Notifications;

namespace NotificationsExtansions.ToastContent
{
    /// <summary>
    /// Base toast notification content interface.
    /// </summary>
    public interface IToastNotificationContent : INotificationContent
    {
        /// <summary>
        /// Whether strict validation should be applied when the Xml or notification object is created,
        /// and when some of the properties are assigned.
        /// </summary>
        bool StrictValidation { get; set; }

        /// <summary>
        /// The language of the content being displayed.  The language should be specified using the
        /// abbreviated language code as defined by BCP 47.
        /// </summary>
        string Lang { get; set; }

        /// <summary>
        /// The BaseUri that should be used for image locations.  Relative image locations use this
        /// field as their base Uri.  The BaseUri must begin with http://, https://, ms-appx:///, or
        /// ms-appdata:///local/.
        /// </summary>
        string BaseUri { get; set; }

        /// <summary>
        /// Controls if query strings that denote the client configuration of contrast, scale, and language setting should be appended to the Src
        /// If true, Windows will append query strings onto images that exist in this template
        /// If false (the default, Windows will not append query strings onto images that exist in this template
        /// Query string details:
        /// Parameter: ms-contrast
        ///     Values: standard, black, white
        /// Parameter: ms-scale
        ///     Values: 80, 100, 140, 180
        /// Parameter: ms-lang
        ///     Values: The BCP 47 language tag set in the notification xml, or if omitted, the current preferred language of the user
        /// </summary>
        bool AddImageQuery { get; set; }

        /// <summary>
        /// The launch parameter passed into the Windows Store app when the toast is activated.
        /// </summary>
        string Launch { get; set; }

        /// <summary>
        /// The audio that should be played when the toast is displayed.
        /// </summary>
        IToastAudio Audio { get; }

        /// <summary>
        /// The length that the toast should be displayed on screen.
        /// </summary>
        ToastDuration Duration { get; set; }

        /// <summary>
        /// IncomingCall action buttons will be displayed on the toast if one of the option flags (ShowVideoCommand/ShowVoiceCommand/ShowDeclineCommand) is set to true.
        /// To enable IncomingCall toasts for an app, ensure that the Lock Screen Call extension is enabled in the application manifest.
        /// </summary>
        IIncomingCallCommands IncomingCallCommands { get; }

        /// <summary>
        /// Alarm action buttons will be displayed on the toast if one of the option flags (ShowSnoozeCommand/ShowDismissCommand) is set to true.
        /// To enable Alarm toasts for an app, ensure the app declares itself as Alarm capable.
        /// The app needs to be set as the Primary Alarm on the PC Settings page (only one app can exist as the alarm app at a given time).
        /// </summary>
        IAlarmCommands AlarmCommands { get; }

#if !WINRT_NOT_PRESENT
        /// <summary>
        /// Creates a WinRT ToastNotification object based on the content.
        /// </summary>
        /// <returns>A WinRT ToastNotification object based on the content.</returns>
        ToastNotification CreateNotification();
#endif
    }
}