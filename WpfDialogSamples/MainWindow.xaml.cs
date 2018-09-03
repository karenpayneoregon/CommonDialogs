using System;
using System.Windows;
using static WpfDialogSamples.Classes.CommonDialogs;

namespace WpfDialogSamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Demo the Question method.
        /// First invoke can not perform a logic action while the second does
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStandardQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (chkCompact.IsChecked != null && (bool)chkCompact.IsChecked)
            {
                // show sring value
                MessageBox(Question("Do you like coffee? (compact 1)") ? "Let's go to Starbucks!!" : "Tea drinker");
                // get string value
                var result = Question("Do you like coffee? (compact 2)") ? "Let's go to Starbucks!!" : "Tea drinker";
                Console.WriteLine(result);
            }
            else
            {
                if (Question("Do you like coffee?"))
                {
                    MessageBox("Let's go to Starbucks!!");
                }
                else
                {
                    MessageBox("Tea drinker");
                }
            }
        }

        private void cmdInformation_Click(object sender, RoutedEventArgs e)
        {
            InformationDialog("Thanks for your order!", "Confirmation");
        }

        private void cmdMessageBoxNoBell_Click(object sender, RoutedEventArgs e)
        {
            MessageBox("Thanks for your order!", "Confirmation");
        }
        /// <summary>
        /// Demo exception dialog via an invalid cast
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdExceptionDialog_Click(object sender, RoutedEventArgs e)
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

        private void test()
        {



        }
    }

}
