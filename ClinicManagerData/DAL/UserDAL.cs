using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClinicManagerData.DB;
using ClinicManagerData.Model;

namespace ClinicManagerData.DAL
{
    /// <summary>
    /// Data access for user
    /// </summary>
    public class UserDAL
    {
        /// <summary>
        /// Gets the user object for the given personID
        /// </summary>
        /// <param name="personID">The person ID of the sought user</param>
        /// <returns>The found user, else null</returns>
        public static User getUser(int personID)
        {
            User user = new User();
            string selectStatement = "SELECT * FROM [user] WHERE person_id = @personID";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand selectCom = new SqlCommand(selectStatement, con))
                    {
                        selectCom.Parameters.AddWithValue("@personID", personID);
                        using (SqlDataReader reader = selectCom.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                user.UserID = (int)reader["id"];
                                user.PersonID = (int)reader["person_id"];
                                user.Username = reader["username"].ToString();
                                user.Timestamp = Convert.ToBase64String(reader["timestamp"] as byte[]);
                            }
                            else user = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return user;
        }

        /// <summary>
        /// Returns 0 if username and password match a record in database and user is not admin,
        /// returns 1 if user is admin,
        /// returns -1 if user doesn't exits or is neither nurese nor admin
        /// </summary>
        /// <param name="username">user's username</param>
        /// <param name="password">user's password</param>
        /// <returns>1 if user is admin, 0 if user is not admin, -1 if user doesn't exist</returns>
        public static int getUserType(string username, string password)
        {
            string hashedPassword = HashLogin(username, password);

            string selectStatement = "SELECT p.is_admin as is_admin, p.is_nurse as is_nurse " +
                                        "FROM [user] u JOIN [person] p ON u.person_id = p.id WHERE username = @username AND password = @password";

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
                                if ((bool)reader["is_admin"])
                                {
                                    return 1;
                                }
                                else if ((bool)reader["is_nurse"])
                                {
                                    return 0;
                                }
                                else
                                {
                                    return -1;
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
