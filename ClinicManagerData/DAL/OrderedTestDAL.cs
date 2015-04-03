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
    /// Data access for OrderedTest
    /// </summary>
    public class OrderedTestDAL
    {
        /// <summary>
        /// Adds the passed in OrderedTest object to the DB
        /// </summary>
        /// <param name="test">The OrderedTest object to add to the DB</param>
        /// <returns>The id generated for the created OrderedTest</returns>
        public static int OrderTest(OrderedTest orderedTest)
        {
            string insertStatement =
                "INSERT INTO orderedtest (visit_id, test_id, order_date, result_date) " 
                + "VALUES (@visitID, @testID, @orderDate, @resultDate)";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, con))
                    {
                        insertCommand.Parameters.AddWithValue("@visitID", orderedTest.VisitID);
                        insertCommand.Parameters.AddWithValue("@testID", orderedTest.TestID);
                        insertCommand.Parameters.AddWithValue("@orderDate", orderedTest.OrderDate);
                        insertCommand.Parameters.AddWithValue("@resultDate", orderedTest.PerformDate);

                        insertCommand.ExecuteNonQuery();

                        SqlCommand identCom = new SqlCommand();
                        identCom.Connection = con;
                        identCom.CommandText = "SELECT IDENT_CURRENT('orderedtest') FROM orderedtest";
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
