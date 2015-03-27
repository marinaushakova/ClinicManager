using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagerData.Model;
using System.Data.SqlClient;
using ClinicManagerData.DB;

namespace ClinicManagerData.DAL
{
    /// <summary>
    /// Data access for user
    /// </summary>
    public class UserDAL
    {
        /// <summary>
        /// Returns 0 if username and password match a record in database and user is not admin,
        /// returns 1 if user is admin,
        /// returns -1 if user doesn't exits
        /// </summary>
        /// <param name="username">user's username</param>
        /// <param name="password">user's password</param>
        /// <returns>1 if user is admin, 0 if user is not admin, -1 if user doesn't exist</returns>
        public static int getUserType(string username, string password)
        {
            string hashedPassword = HashLogin(username, password);

            string selectStatement = "SELECT * FROM [user] WHERE username = @username AND password = @password";

            try
            {
                using (SqlConnection connection = ClinicManagerDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", username);
                        selectCommand.Parameters.AddWithValue("@password", hashedPassword);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if ((bool)reader["admin_privelege"])
                                {
                                    return 1;
                                }
                                else
                                {
                                    return 0;
                                }
                                
                            }
                            else
                            {
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Hashes the given data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string HashData(string data)
        {
            SHA256 hasher = SHA256Managed.Create();
            byte[] hashedData = hasher.ComputeHash(Encoding.Unicode.GetBytes(data));

            StringBuilder sb = new StringBuilder(hashedData.Length * 2);
            foreach (byte b in hashedData)
            {
                sb.AppendFormat("{0:x2}", b);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Hashes the user login credentials
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string HashLogin(string userName, string password)
        {
            return HashData(String.Format("{0}{1}", userName.Substring(0, 4), password));
        }
    }
}
