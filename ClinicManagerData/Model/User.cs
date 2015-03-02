using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagerData.Model
{
    /// <summary>
    /// User model
    /// </summary>
    public class User
    {
        private int userID;
        private int personID = 0;
        private string username;
        private string password;
        private Boolean admin_privelege;
        private string timestamp;

        /// <summary>
        /// Get/set user ID
        /// </summary>
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// Get/set person ID
        /// </summary>
        public int PersonID
        {
            get { return PersonID; }
            set { PersonID = value; }
        }

        /// <summary>
        /// Get/set user name
        /// </summary>
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// Get/set password
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// Get/set admin privelege
        /// </summary>
        public Boolean Admin_privelege
        {
            get { return admin_privelege; }
            set { admin_privelege = value; }
        }

        /// <summary>
        /// Get/set timestamp
        /// </summary>
        public string Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
    }
}
