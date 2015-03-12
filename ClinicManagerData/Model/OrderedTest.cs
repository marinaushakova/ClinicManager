using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagerData.Model
{
    /// <summary>
    /// Ordered Test model
    /// </summary>
    public class OrderedTest
    {
        private int orderedTestID = 0;
        private int visitID;
        private int testID;
        private DateTime orderDate;
        private DateTime resultDate;
        private bool result;
        private string timestamp;

        /// <summary>
        /// Get/set ordered test ID
        /// </summary>
        public int OrderedTestID
        {
            get { return orderedTestID; }
            set { orderedTestID = value; }
        }
        
        /// <summary>
        /// Get/set visitID
        /// </summary>
        public int VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        /// <summary>
        /// Get/set test ID
        /// </summary>
        public int TestID
        {
            get { return testID; }
            set { testID = value; }
        }

        /// <summary>
        /// Get/set orderDate
        /// </summary>
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        /// <summary>
        /// Get/set resultDate
        /// </summary>
        public DateTime ResultDate
        {
            get { return resultDate; }
            set { resultDate = value; }
        }

        /// <summary>
        /// Get/set result
        /// </summary>
        public bool Result
        {
            get { return result; }
            set { result = value; }
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
