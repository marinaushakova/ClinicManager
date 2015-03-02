using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagerData.Model
{
    public class CurrentUserInfo
    {
        private static string currentLoggedInUsername = null;
        private static bool isUserCurrentAdmin;

        public static string CurrentLoggedInUsername
        {
            get;
            set;
        }

        public static bool IsCurrentUserAdmin
        {
            get;
            set;
        }


    }
}
