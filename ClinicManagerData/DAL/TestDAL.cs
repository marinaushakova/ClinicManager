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
    }
}
