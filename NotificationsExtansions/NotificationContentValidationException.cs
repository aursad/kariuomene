using System.Runtime.InteropServices;

namespace NotificationsExtansions
{
    /// <summary>
    /// Exception returned when invalid notification content is provided.
    /// </summary>
    internal sealed class NotificationContentValidationException : COMException
    {
        public NotificationContentValidationException(string message)
            : base(message, unchecked((int)0x80070057))
        {
        }
    }
}