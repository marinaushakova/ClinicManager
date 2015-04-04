using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagerData.Model
{
    public class TestIntegrityException : Exception { };

    /// <summary>
    /// Test model
    /// </summary>
    public class Test
    {
        private int testID = 0;
        private string name;
        private string description;
        private bool is_active;
        private string timestamp;

        public string Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public bool IsActive
        {
            get { return is_active; }
            set { is_active = value; }
        }

        public int TestID
        {
            get { return testID; }
            set { testID = value; }
        }
    }
}
