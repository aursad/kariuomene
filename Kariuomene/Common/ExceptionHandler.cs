using System;
using System.Diagnostics;
using Windows.UI.Popups;

namespace Kariuomene.Common
{
    public static class ExceptionHandler
    {
        public static void LogException(Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }

        /// <summary>
        /// Handles failure for application exception on UI thread (or initiated from UI thread via async void handler)
        /// </summary>
        public static async void HandleException(Exception ex)
        {
            LogException(ex);

            var dialog = new MessageDialog(GetDisplayMessage(ex), "Klaida");
            await dialog.ShowAsync();
        }

        /// <summary>
        /// Gets the error message to display from an exception
        /// </summary>
        private static string GetDisplayMessage(Exception ex)
        {
            return ex.Message;
        }

    }
}