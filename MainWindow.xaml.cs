using System.Windows;
using System.Windows.Controls;

namespace RoomRentalAppilcationForm
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Foreground == Brushes.Gray)
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                // Restore placeholder text based on which textbox it is
                if (textBox == txtFirstName) textBox.Text = "First";
                else if (textBox == txtLastName) textBox.Text = "Last";
                else if (textBox == txtPhoneNumber) textBox.Text = "Phone number";
                else if (textBox == txtAddress) textBox.Text = "Address";
                else if (textBox == txtServerAddress) textBox.Text = "Server Address";
                else if (textBox == txtCity) textBox.Text = "City";
                
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Add validation logic here
            MessageBox.Show("Application submitted!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
