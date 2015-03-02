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
        public static int IsValidUser(string username, string password)
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
                                return (int)reader["id"];
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
        /// Returns true if user with given userID has priveleges of administrator,
        /// returns false if otherwise.
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <returns>True if user with given userID is administrator, false if not.</returns>
        public static bool IsUserAdmin(int userID)
        {
            string selectStatement = "SELECT * FROM [user] WHERE id = @userID AND admin_privelege = 1";

            try
            {
                using (SqlConnection connection = ClinicManagerDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@userID", userID);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }
                            else
                            {
                                return false;
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
