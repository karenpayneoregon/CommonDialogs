using System;
using System.Windows.Forms;
using static WindowsFormsDialogsSamples.Classes.CommonDialogs;

namespace WindowsFormsDialogsSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Example for asking a question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStandardQuestionDialog_Click(object sender, EventArgs e)
        {
            if (Question("Do you like coffee?"))
            {
                Alert("Let's go to Starbucks!!");
            }
            else
            {
                Alert("Tea drinker");
            }
        }
        /// <summary>
        /// Example to catch user's attention (with a beep) information dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdInformationDialog_Click(object sender, EventArgs e)
        {
            InformationDialog("Thanks for your order!", "Confirmation");
        }
        /// <summary>
        /// Example for to display informaton to the user, no information
        /// icon, no beep as the beep is triggered by the selected icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMessageDialog_Click(object sender, EventArgs e)
        {
            Alert("Thanks for your order!", "Confirmation");
        }
        /// <summary>
        /// Two examples to display error/exception information. The
        /// first for users and the second for a developer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdExceptionDialog_Click(object sender, EventArgs e)
        {
            try
            {
                var ooops = (bool)sender;
            }
            catch (Exception exception)
            {
                ExceptionDialog("Something went wrong", "Ooops", exception);
                // alternate to call dialog on the exception object, quick and dirty
                exception.ExceptionDeveloperDialog();
            }
        }
        /// <summary>
        /// For completeness yet best to avoid as it has no true value over using
        /// the base Exception class or custom exceptions classes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Framework Design Guidelines:  Do not throw or derive from System.ApplicationException.
        /// </remarks>
        private void cmdApplicationExceptionDialog_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ApplicationException("");
            }
            catch (ApplicationException exception)
            {
                AppExceptionDialog(this, exception);
            }
        }
    }
}
