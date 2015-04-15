using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagerData.Model;
using System.Data.SqlClient;
using ClinicManagerData.DB;
using System.Data;

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
                "INSERT INTO orderedtest (visit_id, test_id, order_date, result_date, result) " 
                + "VALUES (@visitID, @testID, @orderDate, @resultDate, @result)";
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
                        if (orderedTest.PerformDate.HasValue)
                        {
                            insertCommand.Parameters.AddWithValue("@resultDate", orderedTest.PerformDate);
                        }
                        else
                        {
                            insertCommand.Parameters.AddWithValue("@resultDate", DBNull.Value);
                        }
                        if (orderedTest.Result.HasValue)
                        {
                            insertCommand.Parameters.AddWithValue("@result", orderedTest.Result);
                        }
                        else
                        {
                            insertCommand.Parameters.AddWithValue("@result", DBNull.Value);
                        }

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
                                if (reader["result_date"] != System.DBNull.Value)
                                {
                                    orderedTestSummary.PerformDate = (DateTime)reader["result_date"];
                                }
                                else
                                {
                                    orderedTestSummary.PerformDate = null;
                                }
                                
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

        /// <summary>
        /// Records results of an ordered test in the DB
        /// </summary>
        /// <param name="test">The orderedtest object with the altered data and the original test ID</param>
        /// <returns>True if update successful, false otherwise</returns>
        public static bool RecordTestResults(OrderedTest orderedTest)
        {
            if (orderedTest.PerformDate == null || orderedTest.Result == null)
            {
                return false;
            }
            string updateStatement =
                "UPDATE orderedtest SET result_date = @result_date, result = @result " +
                "WHERE id = @id AND timestamp = @timestamp";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, con))
                    {
                        updateCommand.Parameters.AddWithValue("@id", orderedTest.OrderedTestID);
                        updateCommand.Parameters.AddWithValue("@result_date", orderedTest.PerformDate);
                        updateCommand.Parameters.AddWithValue("@result", orderedTest.Result);
                        updateCommand.Parameters.AddWithValue("@timestamp", Convert.FromBase64String(orderedTest.Timestamp));

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

        /// <summary>
        /// Deletes a test
        /// </summary>
        /// <param name="id">The orderedtest object id to delete</param>
        /// <returns>True if delete successful, false otherwise</returns>
        public static bool DeleteTest(int id)
        {
            string statement =
                "DELETE orderedtest " +
                "WHERE id = @id";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand updateCommand = new SqlCommand(statement, con))
                    {
                        updateCommand.Parameters.AddWithValue("@id", id);

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

        public static OrderedTest GetTestById(int id)
        {
            OrderedTest ordTest = new OrderedTest();
            string selectStatment =
                "SELECT id, test_id, visit_id, order_date, result_date, result, timestamp " +
                "FROM orderedtest WHERE id = @id";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatment, con))
                    {
                        selectCommand.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                ordTest.OrderedTestID = (int)reader["id"];
                                ordTest.TestID = (int)reader["test_id"];
                                ordTest.VisitID = (int)reader["visit_id"];
                                ordTest.OrderDate = (DateTime)reader["order_date"];
                                if (reader["result_date"] != System.DBNull.Value)
                                {
                                    ordTest.PerformDate = (DateTime)reader["result_date"];
                                }
                                else
                                {
                                    ordTest.PerformDate = null;
                                }
                                if (reader["result"] != System.DBNull.Value)
                                {
                                    ordTest.Result = (bool)reader["result"];
                                }
                                else
                                {
                                    ordTest.Result = null;
                                }
                                ordTest.Timestamp = Convert.ToBase64String(reader["timestamp"] as byte[]);
                            }
                            else
                            {
                                ordTest = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ordTest;
        }
    }

}
