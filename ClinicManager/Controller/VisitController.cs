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

        /// <summary>
        /// Get all visits specified by patient
        /// </summary>
        /// <param name="firstName">The first name of the sought person(s)</param>
        /// <param name="lastName">The last name of the sought person(s)</param>
        /// <param name="dateOfBirth">The DOB of the sought person(s)</param>
        /// <returns>The list of visits matching the params</returns>
        public List<VisitSummary> GetVisitSummary(string firstName, string lastName, DateTime? dateOfBirth)
        {
            return VisitDAL.GetVisitSummary(firstName, lastName, dateOfBirth);
        }

        /// <summary>
        /// Gets the visit with the passed in ID
        /// </summary>
        /// <param name="id">The ID of the visit being retrieved from the DB</param>
        /// <returns>The visit object with the given ID else null</returns>
        public Visit GetVisitById(int id)
        {
            return VisitDAL.GetVisitById(id);
        }
    }
}
