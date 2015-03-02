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

        /// <summary>
        /// Gets the person with the passed in ID
        /// </summary>
        /// <param name="id">The ID of the person being retrieved from the DB</param>
        /// <returns>The person object with the given ID else null</returns>
        public Person GetPersonById(int id)
        {
            return PersonDAL.GetPersonById(id);
        }

        /// <summary>
        /// Adds the passed in person to the DB
        /// </summary>
        /// <param name="person">The person to add to the DB</param>
        /// <returns>The id of the created person</returns>
        public int AddPerson(Person person)
        {
            return PersonDAL.AddPerson(person);
        }
    }
}
