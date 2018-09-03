using System;
using System.Windows.Forms;
using Microsoft.SqlServer.MessageBox;

namespace WindowsFormsDialogsSamples.Classes
{
    public static class CommonDialogs
    {
        public static bool Question(string pText)
        {
            return (MessageBox.Show(pText, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
        public static bool Question(string pText, string pTitle)
        {
            return (MessageBox.Show(pText, pTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
        public static bool Question(string pText, string pTitle, DialogResult pDefaultButton)
        {
            MessageBoxDefaultButton db = 0;
            if (pDefaultButton == DialogResult.No)
            {
                db = MessageBoxDefaultButton.Button2;
            }
            return (MessageBox.Show(pText, pTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, db) == DialogResult.Yes);
        }
        public static void InformationDialog(string pText)
        {
            MessageBox.Show(pText, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void InformationDialog(string pText, string pTitle)
        {
            MessageBox.Show(pText, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ExceptionDialog(string pText)
        {
            MessageBox.Show(pText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ExceptionDialog(string pText, string pTitle)
        {
            MessageBox.Show(pText, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ExceptionDialog(string pText, string pTitle, Exception pException)
        {
            string message = $"{pText}{Environment.NewLine} {pException.Message}";
            MessageBox.Show(message, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ExceptionDialog(Exception pException, string pText, string pTitle)
        {
            MessageBox.Show($"{pText}{Environment.NewLine}{pException.Message}{pException.Message}", pTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// Used to create a custom app exception dialog.
        /// </summary>
        /// <param name="sender"><see cref="Form1.cmdApplicationExceptionDialog_Click"/>Calling form</param>
        /// <param name="ex">ApplicationException instance</param>
        /// <param name="title">Title for dialog</param>
        /// <returns>ExceptionMessageBoxDialogResult</returns>
        /// <remarks>
        /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.sqlserver.messagebox.exceptionmessagebox?view=sqlserver-2016
        /// </remarks>
        public static ExceptionMessageBoxDialogResult AppExceptionDialog(Form sender, ApplicationException ex, string title = "Action failed. What do you want to do?")
        {
            var applicationException = new ApplicationException(title, ex) {Source = "Source"};

            // Show the exception message box with three custom buttons.
            var box = new ExceptionMessageBox(applicationException) {Caption = "Karen's great application"};

            // set the window caption/title

            // Set the names of the three custom buttons.
            box.SetButtonText("Skip", "Retry", "Stop Processing");

            // Set the Retry button as the default.
            box.DefaultButton = ExceptionMessageBoxDefaultButton.Button2;
            box.Symbol = ExceptionMessageBoxSymbol.Question;
            box.Buttons = ExceptionMessageBoxButtons.Custom;

            box.Show(sender);
            return box.CustomDialogResult;
        }

        public static void ExceptionDeveloperDialog(this Exception pException)
        {
            MessageBox.Show($"{Environment.NewLine}{pException.Message}{pException.Message}", "Oh snap", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Alert(string pMessage, string pTitle = "Alert")
        {
            MessageBox.Show(pMessage, pTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
