using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagerData.Model
{
    /// <summary>
    /// Person model
    /// </summary>
    public class Person
    {
        private int personID = 0;
        private string lastName;
        private string firstName;
        private string middleInit;
        private string social;
        private DateTime dateOfBirth;
        bool is_male = true;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phone;
        private bool is_nurse = false;
        private bool is_doctor = false;
        private string timestamp;

        /// <summary>
        /// Get/set last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /// <summary>
        /// Get/set first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        /// <summary>
        /// Get/set middle initial
        /// </summary>
        public string MiddleInit
        {
            get { return middleInit; }
            set { middleInit = value; }
        }

        /// <summary>
        /// Get/set social security number
        /// </summary>
        public string Social
        {
            get { return social; }
            set { social = value; }
        }

        /// <summary>
        /// Get/set date of birth
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        /// <summary>
        /// Get/set gender
        /// </summary>
        public bool IsMale
        {
            get { return is_male; }
            set { is_male = value; }
        }

        /// <summary>
        /// Get/set street address
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Get/set city
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Get/set state
        /// </summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// Get/set zip code
        /// </summary>
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        /// <summary>
        /// Get/set phone
        /// </summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        /// <summary>
        /// Get/set nurse status
        /// </summary>
        public bool IsNurse
        {
            get { return is_nurse; }
            set { is_nurse = value; }
        }

        /// <summary>
        /// Get/set doctor status
        /// </summary>
        public bool IsDoctor
        {
            get { return is_doctor; }
            set { is_doctor = value; }
        }

        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public string Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        /// <summary>
        /// Gets the full persons name
        /// </summary>
        /// <returns>String containing full persons name</returns>
        public string GetFullName()
        {
            string fullName = "";
            fullName = lastName + ", " + firstName;
            if (!String.IsNullOrEmpty(middleInit)) {
                fullName += " " + middleInit + ".";
            }
            return fullName;
        }
    }
}