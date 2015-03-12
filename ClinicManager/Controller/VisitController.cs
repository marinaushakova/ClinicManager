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
    /// Provides the interface for the view classes to interact with Visit data
    /// </summary>
    class VisitController
    {

        /// <summary>
        /// Adds the passed in visit to the DB
        /// </summary>
        /// <param name="person">The visit to add to the DB</param>
        /// <returns>The id of the created visit</returns>
        public int AddVisitRecord(Visit theVisit)
        {
            return VisitDAL.AddVisitRecord(theVisit);
        }
    }
}
