using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagerData.Model
{
    /// <summary>
    /// Contains username and admin privelege status of currently logged in user
    /// </summary>
    public class CurrentUserInfo
    {
        private static string currentLoggedInUsername = null;
        private static bool isUserCurrentAdmin;

        /// <summary>
        /// Get/set CurrentLoggedInUserName
        /// </summary>
        public static string CurrentLoggedInUsername
        {
            get;
            set;
        }

        /// <summary>
        /// Get/set IsCurrentUserAdmin
        /// </summary>
        public static bool IsCurrentUserAdmin
        {
            get;
            set;
        }


    }
}
