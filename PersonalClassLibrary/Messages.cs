using System.Windows;
using System.Windows.Forms;

namespace PersonalClassLibrary
{
    public static class Messages
    {
        private static string messageType;

        /// <summary>
        /// Show error massage box.
        /// </summary>
        /// <param name="message"></param>
        public static void MessageBoxError(this string message)
        {
            messageType = "Error";
            System.Windows.MessageBox.Show(message, messageType, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Show warning massage box.
        /// </summary>
        /// <param name="message"></param>
        public static void MessageBoxWarning(this string message)
        {
            messageType = "Warning";
            System.Windows.MessageBox.Show(message, messageType, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        /// <summary>
        /// Show information massage box.
        /// </summary>
        /// <param name="message"></param>
        public static void MessageBoxInformation(this string message)
        {
            messageType = "Information";
            System.Windows.MessageBox.Show(message, messageType, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
