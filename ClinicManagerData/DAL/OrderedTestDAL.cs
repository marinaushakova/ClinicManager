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

        /// <summary>
        /// Get summary of tests ordered for specified visit
        /// </summary>
        /// <returns>List of ordered tests</returns>
        public static List<OrderedTestSummary> GetOrderedTestsSummaryByVisit(int visitID)
        {
            List<OrderedTestSummary> testList = new List<OrderedTestSummary>();
            string selectStatement =
                "SELECT ot.id AS ord_test_id, ot.visit_id, ot.order_date, ot.result_date, ot.result, t.Name " +
                    "FROM orderedtest ot JOIN test t ON ot.test_id = t.id " +
                    "WHERE visit_id = @visitID " +
                    "ORDER BY ot.order_date, ot.result_date";
            try
            {
                using (SqlConnection connection = ClinicManagerDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@VisitID", visitID);
                        
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                OrderedTestSummary orderedTestSummary = new OrderedTestSummary();
                                orderedTestSummary.OrderedTestID = (int)reader["ord_test_id"];
                                orderedTestSummary.VisitID = (int)reader["visit_id"];
                                orderedTestSummary.OrderDate = (DateTime)reader["order_date"];
                                orderedTestSummary.PerformDate = (DateTime)reader["result_date"];
                                if (reader["result"] != System.DBNull.Value) {
                                    orderedTestSummary.Result = (bool)reader["result"];
                                } else {
                                    orderedTestSummary.Result = null;
                                }
                                
                                orderedTestSummary.Name = reader["Name"].ToString();
                                testList.Add(orderedTestSummary);
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
            return testList;
        }
    }
}
