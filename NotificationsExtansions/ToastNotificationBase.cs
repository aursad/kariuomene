using System;
using System.Text;
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using NotificationsExtansions.ToastContent;

namespace NotificationsExtansions
{
    internal class ToastNotificationBase : NotificationBase, IToastNotificationContent
    {
        public ToastNotificationBase(string templateName, int imageCount, int textCount) :
            base(templateName: templateName, fallbackName: null, imageCount: imageCount, textCount: textCount)
        {
        }

        private bool AudioSrcIsLooping()
        {
            return
                (Audio.Content == ToastAudioContent.LoopingAlarm) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm2) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm3) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm4) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm5) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm6) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm7) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm8) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm9) ||
                (Audio.Content == ToastAudioContent.LoopingAlarm10) ||
                (Audio.Content == ToastAudioContent.LoopingCall) ||
                (Audio.Content == ToastAudioContent.LoopingCall2) ||
                (Audio.Content == ToastAudioContent.LoopingCall3) ||
                (Audio.Content == ToastAudioContent.LoopingCall4) ||
                (Audio.Content == ToastAudioContent.LoopingCall5) ||
                (Audio.Content == ToastAudioContent.LoopingCall6) ||
                (Audio.Content == ToastAudioContent.LoopingCall7) ||
                (Audio.Content == ToastAudioContent.LoopingCall8) ||
                (Audio.Content == ToastAudioContent.LoopingCall9) ||
                (Audio.Content == ToastAudioContent.LoopingCall10);
        }

        private void ValidateAudio()
        {
            if (StrictValidation)
            {
                if (Audio.Loop && Duration != ToastDuration.Long)
                {
                    throw new NotificationContentValidationException("Looping audio is only available for long duration toasts.");
                }
                if (Audio.Loop && !AudioSrcIsLooping())
                {
                    throw new NotificationContentValidationException(
                        "A looping audio src must be chosen if the looping audio property is set.");
                }
                if (!Audio.Loop && AudioSrcIsLooping())
                {
                    throw new NotificationContentValidationException(
                        "The looping audio property needs to be set if a looping audio src is chosen.");
                }
            }
        }

        private void AppendAudioTag(StringBuilder builder)
        {
            if (Audio.Content != ToastAudioContent.Default)
            {
                builder.Append("<audio");
                if (Audio.Content == ToastAudioContent.Silent)
                {
                    builder.Append(" silent='true'/>");
                }
                else
                {
                    if (Audio.Loop == true)
                    {
                        builder.Append(" loop='true'");
                    }

                    // The default looping sound is LoopingCall - save size by not adding it.
                    if (Audio.Content != ToastAudioContent.LoopingCall)
                    {
                        string audioSrc = null;
                        switch (Audio.Content)
                        {
                            case ToastAudioContent.IM:
                                audioSrc = "ms-winsoundevent:Notification.IM";
                                break;
                            case ToastAudioContent.Mail:
                                audioSrc = "ms-winsoundevent:Notification.Mail";
                                break;
                            case ToastAudioContent.Reminder:
                                audioSrc = "ms-winsoundevent:Notification.Reminder";
                                break;
                            case ToastAudioContent.SMS:
                                audioSrc = "ms-winsoundevent:Notification.SMS";
                                break;
                            case ToastAudioContent.LoopingAlarm:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm";
                                break;
                            case ToastAudioContent.LoopingAlarm2:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm2";
                                break;
                            case ToastAudioContent.LoopingAlarm3:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm3";
                                break;
                            case ToastAudioContent.LoopingAlarm4:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm4";
                                break;
                            case ToastAudioContent.LoopingAlarm5:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm5";
                                break;
                            case ToastAudioContent.LoopingAlarm6:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm6";
                                break;
                            case ToastAudioContent.LoopingAlarm7:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm7";
                                break;
                            case ToastAudioContent.LoopingAlarm8:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm8";
                                break;
                            case ToastAudioContent.LoopingAlarm9:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm9";
                                break;
                            case ToastAudioContent.LoopingAlarm10:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Alarm10";
                                break;
                            case ToastAudioContent.LoopingCall:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call";
                                break;
                            case ToastAudioContent.LoopingCall2:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call2";
                                break;
                            case ToastAudioContent.LoopingCall3:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call3";
                                break;
                            case ToastAudioContent.LoopingCall4:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call4";
                                break;
                            case ToastAudioContent.LoopingCall5:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call5";
                                break;
                            case ToastAudioContent.LoopingCall6:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call6";
                                break;
                            case ToastAudioContent.LoopingCall7:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call7";
                                break;
                            case ToastAudioContent.LoopingCall8:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call8";
                                break;
                            case ToastAudioContent.LoopingCall9:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call9";
                                break;
                            case ToastAudioContent.LoopingCall10:
                                audioSrc = "ms-winsoundevent:Notification.Looping.Call10";
                                break;
                        }
                        builder.AppendFormat(" src='{0}'", audioSrc);
                    }
                }
                builder.Append("/>");
            }
        }

        private bool IsIncomingCallToast()
        {
            return (IncomingCallCommands.ShowVideoCommand || IncomingCallCommands.ShowVoiceCommand || IncomingCallCommands.ShowDeclineCommand);
        }

        private bool IsAlarmToast()
        {
            return (AlarmCommands.ShowSnoozeCommand || AlarmCommands.ShowDismissCommand);
        }

        private void ValidateCommands()
        {
            if (StrictValidation)
            {
                if (IsIncomingCallToast() && IsAlarmToast())
                {
                    throw new NotificationContentValidationException(
                        "IncomingCall and Alarm properties cannot be included on a single toast.");
                }

                if (!IncomingCallCommands.ShowVideoCommand && !string.IsNullOrEmpty(IncomingCallCommands.VideoArgument))
                {
                    throw new NotificationContentValidationException(
                        "Video argument should not be set if the Video button is not shown.");
                }

                if (!IncomingCallCommands.ShowVoiceCommand && !string.IsNullOrEmpty(IncomingCallCommands.VoiceArgument))
                {
                    throw new NotificationContentValidationException(
                        "Voice argument should not be set if the Voice button is not shown.");
                }

                if (!IncomingCallCommands.ShowDeclineCommand && !string.IsNullOrEmpty(IncomingCallCommands.DeclineArgument))
                {
                    throw new NotificationContentValidationException(
                        "Decline argument should not be set if the Video button is not shown.");
                }

                if (!AlarmCommands.ShowSnoozeCommand && !string.IsNullOrEmpty(AlarmCommands.SnoozeArgument))
                {
                    throw new NotificationContentValidationException(
                        "Snooze argument should not be set if the Snooze button is not shown.");
                }

                if (!AlarmCommands.ShowDismissCommand && !string.IsNullOrEmpty(AlarmCommands.DismissArgument))
                {
                    throw new NotificationContentValidationException(
                        "Dismiss argument should not be set if the Dismiss button is not shown.");
                }
            }
        }

        private void AppendIncomingCallCommandsTag(StringBuilder builder)
        {
            builder.Append("<commands scenario='incomingcall'>");
            string CommandIDFormat = "<command id='{0}'";
            string ArgumentFormat = "arguments='{0}'";
            if (IncomingCallCommands.ShowVideoCommand)
            {
                builder.AppendFormat(CommandIDFormat, "video");
                if (!string.IsNullOrEmpty(IncomingCallCommands.VideoArgument))
                {
                    builder.AppendFormat(ArgumentFormat, Util.HttpEncode(IncomingCallCommands.VideoArgument));
                }
                builder.Append("/>");
            }
            if (IncomingCallCommands.ShowVoiceCommand)
            {
                builder.AppendFormat(CommandIDFormat, "voice");
                if (!string.IsNullOrEmpty(IncomingCallCommands.VoiceArgument))
                {
                    builder.AppendFormat(ArgumentFormat, Util.HttpEncode(IncomingCallCommands.VoiceArgument));
                }
                builder.Append("/>");
            }
            if (IncomingCallCommands.ShowDeclineCommand)
            {
                builder.AppendFormat(CommandIDFormat, "decline");
                if (!string.IsNullOrEmpty(IncomingCallCommands.DeclineArgument))
                {
                    builder.AppendFormat(ArgumentFormat, Util.HttpEncode(IncomingCallCommands.DeclineArgument));
                }
                builder.Append("/>");
            }
            builder.Append("</commands>");
        }

        private void AppendAlarmCommandsTag(StringBuilder builder)
        {
            builder.Append("<commands scenario='alarm'>");
            string CommandIDFormat = "<command id='{0}'";
            string ArgumentFormat = "arguments='{0}'";
            if (AlarmCommands.ShowSnoozeCommand)
            {
                builder.AppendFormat(CommandIDFormat, "snooze");
                if (!string.IsNullOrEmpty(AlarmCommands.SnoozeArgument))
                {
                    builder.AppendFormat(ArgumentFormat, Util.HttpEncode(AlarmCommands.SnoozeArgument));
                }
                builder.Append("/>");
            }
            if (AlarmCommands.ShowDismissCommand)
            {
                builder.AppendFormat(CommandIDFormat, "dismiss");
                if (!string.IsNullOrEmpty(AlarmCommands.DismissArgument))
                {
                    builder.AppendFormat(ArgumentFormat, Util.HttpEncode(AlarmCommands.DismissArgument));
                }
                builder.Append("/>");
            }
            builder.Append("</commands>");
        }

        public override string GetContent()
        {
            ValidateAudio();
            ValidateCommands();

            StringBuilder builder = new StringBuilder("<toast");
            if (!String.IsNullOrEmpty(Launch))
            {
                builder.AppendFormat(" launch='{0}'", Util.HttpEncode(Launch));
            }
            if (Duration != ToastDuration.Short)
            {
                builder.AppendFormat(" duration='{0}'", Duration.ToString().ToLowerInvariant());
            }
            builder.Append(">");

            builder.AppendFormat("<visual version='{0}'", Util.NOTIFICATION_CONTENT_VERSION);
            if (!String.IsNullOrWhiteSpace(Lang))
            {
                builder.AppendFormat(" lang='{0}'", Util.HttpEncode(Lang));
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

            builder.AppendFormat("<binding template='{0}'>{1}</binding>", TemplateName, SerializeProperties(Lang, BaseUri, AddImageQuery));
            builder.Append("</visual>");

            AppendAudioTag(builder);

            if (IsIncomingCallToast())
            {
                AppendIncomingCallCommandsTag(builder);
            }

            if (IsAlarmToast())
            {
                AppendAlarmCommandsTag(builder);
            }

            builder.Append("</toast>");

            return builder.ToString();
        }

#if !WINRT_NOT_PRESENT
        public ToastNotification CreateNotification()
        {
            if (StrictValidation)
            {
                if (IsAlarmToast())
                {
                    throw new NotificationContentValidationException(
                        "The ToastNotification object should not be used for alarms." +
                        "Use the results of GetContent() to construct a ScheduledToastNotification object.");
                }
            }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(GetContent());
            return new ToastNotification(xmlDoc);
        }
#endif

        public IToastAudio Audio
        {
            get { return m_Audio; }
        }

        public IIncomingCallCommands IncomingCallCommands
        {
            get { return m_IncomingCallCommands; }
        }

        public IAlarmCommands AlarmCommands
        {
            get { return m_AlarmCommands; }
        }

        public string Launch
        {
            get { return m_Launch; }
            set { m_Launch = value; }
        }

        public ToastDuration Duration
        {
            get { return m_Duration; }
            set
            {
                if (!Enum.IsDefined(typeof(ToastDuration), value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                m_Duration = value;
            }
        }

        private string m_Launch;
        private IToastAudio m_Audio = new ToastAudio();
        private IIncomingCallCommands m_IncomingCallCommands = new IncomingCallCommands();
        private IAlarmCommands m_AlarmCommands = new AlarmCommands();
        private ToastDuration m_Duration = ToastDuration.Short;
    }
}