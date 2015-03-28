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
    /// Provides the interface for the view classes to interact with Person data
    /// </summary>
    class PersonController
    {
        /// <summary>
        /// Get all persons specified by the query
        /// </summary>
        /// <param name="isPatient">Signals whether the sought persons are patients</param>
        /// <param name="firstName">The first name of the sought person(s)</param>
        /// <param name="lastName">The last name of the sought person(s)</param>
        /// <param name="dateOfBirth">The DOB of the sought person(s)</param>
        /// <returns>The list of persons matching the params</returns>
        public List<Person> GetPersonSummary(bool isPatient, string firstName, string lastName, DateTime? dateOfBirth)
        {
            return PersonDAL.GetPersonSummary(isPatient, firstName, lastName, dateOfBirth);
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

        /// <summary>
        /// Adds the passed in person to the db and creates user credentials for them from the given user object
        /// </summary>
        /// <param name="person">The person to add to the DB</param>
        /// <param name="user">The user credential to create for the new person</param>
        /// <returns></returns>
        public int AddUserStaffMember(Person person, User user)
        {
            return PersonDAL.AddUserStaffMember(person, user);
        }

        /// <summary>
        /// Updates the DB person row with the id matching the id given in the person param to the other values
        /// given in the person param. 
        /// </summary>
        /// <param name="person">The person object containing the id and changed data of the person to update</param>
        /// <returns>True if successful, false otherwise</returns>
        public bool UpdatePerson(Person person)
        {
            return PersonDAL.UpdatePerson(person);
        }

        /// <summary>
        /// Gets all nurses from the DB
        /// </summary>
        /// <returns>List of nurses</returns>
        public List<Person> GetAllNurses()
        {
            return PersonDAL.GetAllStaffMembers(false);
        }

        /// <summary>
        /// Gets all doctors from the DB
        /// </summary>
        /// <returns>List of doctors</returns>
        public List<Person> GetAllDoctors()
        {
            return PersonDAL.GetAllStaffMembers(true);
        }

        /// <summary>
        /// Deletes a staff member from the DB
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>True if deletion was sucessful, false otherwise</returns>
        public bool DeleteStaffMember(int ID)
        {
            return PersonDAL.DeleteStaffMember(ID);
        }
    }
}
