using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagerData.Model;
using ClinicManagerData.DAL;

namespace ClinicManager.Controller
{
    /// <summary>
    /// Provides the interface for the view classes to interact with Test data
    /// </summary>
    public class OrderedTestController
    {
        /// <summary>
        /// Adds the passed in test to the DB
        /// </summary>
        /// <param name="test">The test to add to the DB</param>
        /// <returns>The id of the created test</returns>
        public int OrderTest(OrderedTest test)
        {
            return OrderedTestDAL.OrderTest(test);
        }

        /// <summary>
        /// Gets all ordered tests for one visit specified by visitID
        /// </summary>
        /// <param name="visitID">Visit ID</param>
        /// <returns>List of all ordered tests for specified visit</returns>
        public List<OrderedTestSummary> GetOrderedTestsSummaryByVisit(int visitID)
        {
            return OrderedTestDAL.GetOrderedTestsSummaryByVisit(visitID);
        }

        /// <summary>
        /// Saves test results to the database
        /// </summary>
        /// <param name="ordTest">Ordered Test object that contains test results</param>
        /// <returns>True if update successful, false otherwise</returns>
        public bool RecordTestResult(OrderedTest ordTest)
        {
            return OrderedTestDAL.RecordTestResults(ordTest);
        }

        /// <summary>
        /// Deletes an ordered test
        /// </summary>
        /// <param name="id">Ordered Test object id</param>
        /// <returns>True if delete successful, false otherwise</returns>
        public bool DeleteTest(int id)
        {
            return OrderedTestDAL.DeleteTest(id);
        }

        public OrderedTest GetTestById(int id)
        {
            return OrderedTestDAL.GetTestById(id);
        }
    }
}
