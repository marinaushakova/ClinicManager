using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ClinicManagerData.DB
{
    /// <summary>
    /// Database connection for clinic manager database
    /// </summary>
    public static class ClinicManagerDBConnection
    {
        /// <summary>
        /// Get sql connection
        /// </summary>
        /// <returns>SQL connection</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=blah;Initial Catalog=cs6232-g1;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
