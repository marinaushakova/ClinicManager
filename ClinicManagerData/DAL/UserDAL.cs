using System;
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
        /// Returns userID if username and password match a record in database,
        /// returns -1 otherwise
        /// </summary>
        /// <param name="username">user's username</param>
        /// <param name="password">user's password</param>
        /// <returns>UserID if user with given username and password exists in database, -1 otherwise</returns>
        public static void IsValidUser(string username, string password)
        {
            string selectStatement = "SELECT * FROM [user] WHERE username = @username AND password = @password";

            try
            {
                using (SqlConnection connection = ClinicManagerDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", username);
                        selectCommand.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CurrentUserInfo.CurrentLoggedInUsername = (string)reader["username"];
                                
                            }
                            else
                            {
                                CurrentUserInfo.CurrentLoggedInUsername = null;
                                
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
        /// Returns true if user with given userID has priveleges of administrator,
        /// returns false if otherwise.
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <returns>True if user with given userID is administrator, false if not.</returns>
        public static void IsUserAdmin()
        {
            string selectStatement = "SELECT * FROM [user] WHERE username = @username AND admin_privelege = 1";

            try
            {
                using (SqlConnection connection = ClinicManagerDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@username", CurrentUserInfo.CurrentLoggedInUsername);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                CurrentUserInfo.IsCurrentUserAdmin = true;
                                
                            }
                            else
                            {
                                CurrentUserInfo.IsCurrentUserAdmin = false;
                         
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
    }
}
