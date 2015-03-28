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
    }
}
