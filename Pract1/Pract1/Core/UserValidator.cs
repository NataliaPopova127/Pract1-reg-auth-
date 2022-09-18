using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace Pract1.Core
{
    internal class UserValidator
    {
        private SqlConnection sqlConnection = null;
        public bool Validation(string login, string password)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Users"].ConnectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("SELECT Login, Password FROM UsersLoginsAndPasswords", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();
            int k = 0;
            while (reader.Read())
            {
                if (login == reader[0].ToString() && password == reader[1].ToString())
                {
                    k++;
                    break;
                }
            }
            if (k != 0)
                return true;
            else return false;
        }
    }
    
}
