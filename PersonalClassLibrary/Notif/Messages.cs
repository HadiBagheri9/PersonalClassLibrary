using System.Windows;
using System.Windows.Forms;

namespace PersonalClassLibrary.Notif
{
    public static class Messages
    {
        private static string messageType;

        /// <summary>
        /// Show error massage box.
        /// </summary>
        /// <param name="message"></param>
        public static void MessageBoxError(this string message, string messageType = "Error")
        {
            System.Windows.MessageBox.Show(message, messageType, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Show warning massage box.
        /// </summary>
        /// <param name="message"></param>
        public static void MessageBoxWarning(this string message, string messageType = "Warning")
        {
            System.Windows.MessageBox.Show(message, messageType, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        /// <summary>
        /// Show information massage box.
        /// </summary>
        /// <param name="message"></param>
        public static void MessageBoxInformation(this string message, string messageType = "Information")
        {
            System.Windows.MessageBox.Show(message, messageType, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
