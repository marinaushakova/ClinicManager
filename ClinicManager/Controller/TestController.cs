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
    class TestController
    {
        /// <summary>
        /// Adds the passed in test to the DB
        /// </summary>
        /// <param name="test">The test to add to the DB</param>
        /// <returns>The id of the created test</returns>
        public int AddTest(Test test)
        {
            return TestDAL.AddTest(test);
        }

        /// <summary>
        /// Updates the passed in test to the DB
        /// </summary>
        /// <param name="test">The test to update in the DB</param>
        /// <returns>The test to update</returns>
        public bool UpdateTest(Test test)
        {
            return TestDAL.UpdateTest(test);
        }

        /// <summary>
        /// Deletes the passed in test to the DB
        /// </summary>
        /// <param name="test">The test to delete to the DB</param>
        /// <returns>The test to delete</returns>
        public bool DeleteTest(Test test)
        {
            return TestDAL.DeleteTest(test);
        }

        /// <summary>
        /// Gets tests that match name
        /// </summary>
        /// <param name="name">The test name to search for</param>
        /// <returns>List of matching tests</returns>
        public List<Test> GetTests(String name)
        {
            return TestDAL.GetTests(name);
        }

        /// <summary>
        /// Gets all tests saved in DB
        /// </summary>
        /// <returns>List of tests</returns>
        public List<Test> GetAllTests()
        {
            return TestDAL.GetAllTests();
        }
    }
}
