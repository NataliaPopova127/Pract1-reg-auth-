using Pract1.Core;
using System.Windows;


namespace Pract1.View
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            UserValidator userValidator = new UserValidator();
            if (userValidator.Validation(tbLogin.Text, tbPassword.Password))
            {
                new DashboardWindow().Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                tbLogin.Text = "";
                tbPassword.Password = "";
            }
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            new RegistrationWindow().Show();
            Close();
        }
    }
}
