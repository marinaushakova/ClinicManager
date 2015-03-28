using System;
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
    /// Data access for test
    /// </summary>
    public static class TestDAL
    {
        /// <summary>
        /// Adds the passed in test object to the DB
        /// </summary>
        /// <param name="test">The test object to add to the DB</param>
        /// <returns>The id generated for the created test</returns>
        public static int AddTest(Test test)
        {
            string insertStatement =
                "INSERT INTO test (name, description) VALUES (@name, @description)";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, con))
                    {
                        insertCommand.Parameters.AddWithValue("@name", test.Name);
                        insertCommand.Parameters.AddWithValue("@description", test.Description);

                        insertCommand.ExecuteNonQuery();

                        SqlCommand identCom = new SqlCommand();
                        identCom.Connection = con;
                        identCom.CommandText = "SELECT IDENT_CURRENT('test') FROM test";
                        int testID = Convert.ToInt32(identCom.ExecuteScalar());
                        return testID;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get tests that match given name
        /// </summary>
        /// <param name="name">Name of test to search for</param>
        /// <returns>List of tests</returns>
        public static List<Test> GetTests(string name)
        {
            List<Test> retval = new List<Test>();
            string selectStatement =
                "SELECT * FROM test WHERE name LIKE @name ORDER BY name";
            try
            {
                using (SqlConnection connection = ClinicManagerDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@name", "%" + name + "%");
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Test test = new Test();
                                test.Name = reader["name"].ToString();
                                test.Description = reader["description"].ToString();
                                test.TestID = (int)reader["id"];
                                test.Timestamp = Convert.ToBase64String(reader["timestamp"] as byte[]);
                                retval.Add(test);
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
            return retval;
        }

        /// <summary>
        /// Updates a test in the DB
        /// </summary>
        /// <param name="test">The test object with the altered data and the original test ID</param>
        /// <returns>True if update successful, false otherwise</returns>
        public static bool UpdateTest(Test test)
        {
            string updateStatement =
                "UPDATE test SET name = @name, description = @description WHERE id = @id AND timestamp = @timestamp";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, con))
                    {
                        updateCommand.Parameters.AddWithValue("@id", test.TestID);
                        updateCommand.Parameters.AddWithValue("@name", test.Name);
                        updateCommand.Parameters.AddWithValue("@description", test.Description);
                        updateCommand.Parameters.AddWithValue("@timestamp", Convert.FromBase64String(test.Timestamp));

                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0) return true;
                        else return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
