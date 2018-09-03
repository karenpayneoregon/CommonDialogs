using System;
using System.Windows;

namespace WpfDialogSamples.Classes
{
    public static class CommonDialogs
    {
        /// <summary>
        /// Ask a question with No as the default button
        /// </summary>
        /// <param name="pMessage"></param>
        /// <param name="pTitle">Title which defaults to 'Question'</param>
        /// <returns></returns>
        public static bool Question(string pMessage, string pTitle = "Question")
        {
            return (System.Windows.MessageBox.Show(pMessage, pTitle, MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes);
        }
        /// <summary>
        /// Ask a question with the ability to define the default button to Yes or No
        /// </summary>
        /// <param name="pMessage"></param>
        /// <param name="pTitle">Title for message box</param>
        /// <param name="pDefaultButton"></param>
        /// <returns></returns>
        public static bool Question(string pMessage, string pTitle, MessageBoxResult pDefaultButton)
        {
            MessageBoxResult button = 0;
            if (pDefaultButton == MessageBoxResult.No)
            {
                button = MessageBoxResult.No;
            }

            return (System.Windows.MessageBox.Show(pMessage, pTitle, MessageBoxButton.YesNo, MessageBoxImage.Question, button) == MessageBoxResult.Yes);
        }
        /// <summary>
        /// Present a message without an icon
        /// </summary>
        /// <param name="pMessage"></param>
        /// <param name="pTitle"></param>
        /// <remarks>
        /// No icon means no sound
        /// </remarks>
        public static void MessageBox(string pMessage, string pTitle = "Alert")
        {
            System.Windows.MessageBox.Show(pMessage, pTitle, MessageBoxButton.OK, MessageBoxImage.None);
        }
        /// <summary>
        /// Present a message without an icon
        /// </summary>
        /// <param name="pMessage"></param>
        public static void InformationDialog(string pMessage)
        {
            System.Windows.MessageBox.Show(pMessage, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        public static void InformationDialog(string pMessage, string pTitle)
        {
            System.Windows.MessageBox.Show(pMessage, pTitle, MessageBoxButton.OK, MessageBoxImage.Information);
        }
        /// <summary>
        /// Present a dialog with message, title and exception text.
        /// </summary>
        /// <param name="pText">Text to prefix exception message</param>
        /// <param name="pTitle">Title of dialog</param>
        /// <param name="pException">Thrown exception from a catch</param>
        public static void ExceptionDialog(string pText, string pTitle, Exception pException)
        {
            string message = $"{pText}{Environment.NewLine} {pException.Message}";
            System.Windows.MessageBox.Show(message, pTitle, MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// This extension method is for quick and dirty usage when debugging, not for production.
        /// </summary>
        /// <param name="pException"></param>
        public static void ExceptionDeveloperDialog(this Exception pException)
        {           
            System.Windows.MessageBox.Show($"{Environment.NewLine}{pException.Message}{pException.Message}", "Oh snap", MessageBoxButton.OK, MessageBoxImage.None);
        }
    }
}
