using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagerData.DAL;
using ClinicManagerData.Model;

namespace ClinicManager.Controller
{
    /// <summary>
    /// Controller for tech support program
    /// </summary>
    class ClinicManagerController
    {
        /// <summary>
        /// Get all customers
        /// </summary>
        /// <returns>List of customers</returns>
        public List<Person> GetPersonSummary(string firstName, string lastName, DateTime? dateOfBirth)
        {
            return PersonDAL.GetPersonSummary(firstName, lastName, dateOfBirth);
        }
    }
}
