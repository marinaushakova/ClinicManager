using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagerData.Model
{
    /// <summary>
    /// Visit model
    /// </summary>
    public class Visit
    {
        private int visitID = 0;
        private DateTime date;
        private int patientID;
        private int doctorID;
        private int nurseID;
        private string bloodPressure;
        private double temperature;
        private int pulseRate;
        private string symptoms;
        private string initialDiagnosis;
        private string finalDiagnosis;
        private string timestamp;

        /// <summary>
        /// Get/set visit ID
        /// </summary>
        public int VisitID
        {
            get { return visitID; }
            set { visitID = value; }
        }

        /// <summary>
        /// Get/set date
        /// </summary>
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// Get/set patient ID
        /// </summary>
        public int PatientID
        {
            get { return patientID; }
            set { patientID = value; }
        }

        /// <summary>
        /// Get/set doctor ID
        /// </summary>
        public int DoctorID
        {
            get { return DoctorID; }
            set { DoctorID = value; }
        }

        /// <summary>
        /// Get/set nurse ID
        /// </summary>
        public int NurseID
        {
            get { return nurseID; }
            set { nurseID = value; }
        }

        /// <summary>
        /// Get/set bloodPressure
        /// </summary>
        public string BloodPressure
        {
            get { return bloodPressure; }
            set { bloodPressure = value; }
        }

        /// <summary>
        /// Get/set temperature
        /// </summary>
        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        /// <summary>
        /// Get/set pulse rate
        /// </summary>
        public int PulseRate
        {
            get { return pulseRate; }
            set { pulseRate = value; }
        }

        /// <summary>
        /// Get/set symptoms
        /// </summary>
        public string Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }

        /// <summary>
        /// Get/set initialDiagnosis
        /// </summary>
        public string InitialDiagnosis
        {
            get { return initialDiagnosis; }
            set { initialDiagnosis = value; }
        }

        /// <summary>
        /// Get/set finalDiagnosis
        /// </summary>
        public string FinalDiagnosis
        {
            get { return finalDiagnosis; }
            set { finalDiagnosis = value; }
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
