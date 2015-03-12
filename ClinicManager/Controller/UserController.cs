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
    }
}
