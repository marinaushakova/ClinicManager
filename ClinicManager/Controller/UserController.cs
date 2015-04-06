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
    /// Provides the interface for the view classes to interact with the User data
    /// </summary>
    class UserController
    {
        /// <summary>
        /// Calls UserDAL method to determine user type
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="password">Password of the user</param>
        /// <returns>1 if user is admin, 0 if user is not admin, -1 if yous doesn't exist</returns>
        public int GetUserType(string username, string password)
        {
            return UserDAL.getUserType(username, password);
        }

        /// <summary>
        /// Gets the user with the given person ID
        /// </summary>
        /// <param name="personID">The person ID of the sought user</param>
        /// <returns>The User object if it exists, null otherwise</returns>
        public User GetUser(int personID)
        {
            return UserDAL.getUser(personID);
        }

        /// <summary>
        /// Gets the user object with the admin privilege flag set to true or false depending on the users role. 
        /// Returns null if no user exists as a nurse or admin
        /// </summary>
        /// <param name="username">user's username</param>
        /// <param name="password">user's password</param>
        /// <returns>The populated user object if the use exists, else null</returns>
        public User GetUserByCredentials(string username, string password)
        {
            return UserDAL.getUserByCredentials(username, password);
        }
    }
}
