using Pract1.Core;
using System.Windows;

namespace Pract1.View
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration();
            if(userRegistration.Registration(tbLogin.Text, tbPassword.Password, tbName.Text))
            {
                new AuthorizationWindow().Show();
                Close();
            }
            else
            {
                tbLogin.Text = "";
                tbPassword.Password = "";
                tbName.Text = "";
            }
        }
    }
}
