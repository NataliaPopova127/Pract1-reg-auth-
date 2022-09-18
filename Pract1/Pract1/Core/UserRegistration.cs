using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace Pract1.Core
{
    internal class UserRegistration
    {
        private SqlConnection sqlConnection = null;
        public bool Registration(string login, string password, string name)
        {
            if(PasswordLengthCheck(password))
            {
                MessageBox.Show("Длина пароля не может быть меньше 6 символов!");
                return false;
            }
            else if(LoginAndPasswordRepeatCheck(login, password))
            {
                MessageBox.Show("Этот логин уже используется");
                return false;
            }
            else
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
                sqlConnection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO [UsersLoginsAndPasswords] (Login, Password, Name) VALUES" +
                    " (@Login, @Password, @Name)", sqlConnection);

                command.Parameters.AddWithValue("Login", login);
                command.Parameters.AddWithValue("Password", password);
                command.Parameters.AddWithValue("Name", name);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация прошла успешно!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Ошибка");
                    return false;
                }
            }
            
        }
        public bool LoginAndPasswordRepeatCheck(string login, string password)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT Login, Password FROM UsersLoginsAndPasswords", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            int k = 0;
            while (reader.Read())
            {
                if (login == reader[0].ToString())
                {
                    k++;
                    break;
                }
            }
            if (k != 0)
                return true;
            else return false;
        }
        public bool PasswordLengthCheck(string password)
        {
            if (password.Length < 6)
            {
                return true;
            }
            else return false;
        }
    }
}
