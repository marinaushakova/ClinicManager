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
        DateTime date;
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
            get { return doctorID; }
            set { doctorID = value; }
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

    /// <summary>
    /// Visit summary model
    /// </summary>
    public class VisitSummary
    {
        private int visitID = 0;
        DateTime date;
        DateTime dateOfBirth;
        private string patientFName;
        private string patientMInit;
        private string patientLName;
        private string doctorFName;
        private string doctorMInit;
        private string doctorLName;
        private string nurseFName;
        private string nurseMInit;
        private string nurseLName;
        private string finalDiagnosis;

        public int VisitID
        {
          get { return visitID; }
          set { visitID = value; }
        }

        public DateTime Date
        {
          get { return date; }
          set { date = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string PatientFName
        {
          get { return patientFName; }
          set { patientFName = value; }
        }


        public string PatientMInit
        {
            get { return patientMInit; }
            set { patientMInit = value; }
        }

        public string PatientLName
        {
            get { return patientLName; }
            set { patientLName = value; }
        }

        public string DoctorFName
        {
            get { return doctorFName; }
            set { doctorFName = value; }
        }

        public string DoctorMInit
        {
            get { return doctorMInit; }
            set { doctorMInit = value; }
        }

        public string DoctorLName
        {
            get { return doctorLName; }
            set { doctorLName = value; }
        }

        public string NurseFName
        {
            get { return nurseFName; }
            set { nurseFName = value; }
        }

        public string NurseMInit
        {
            get { return nurseMInit; }
            set { nurseMInit = value; }
        }

        public string NurseLName
        {
            get { return nurseLName; }
            set { nurseLName = value; }
        }

        public string FinalDiagnosis
        {
          get { return finalDiagnosis; }
          set { finalDiagnosis = value; }
        }

        /// <summary>
        /// Gets the full patient name
        /// </summary>
        /// <returns>String containing full persons name</returns>
        public string GetPatientName()
        {
            string fullName = "";
            fullName = patientLName + ", " + patientFName;
            if (!String.IsNullOrEmpty(patientMInit))
            {
                fullName += " " + patientMInit + ".";
            }
            return fullName;
        }

        /// <summary>
        /// Gets the full nurse name
        /// </summary>
        /// <returns>String containing full persons name</returns>
        public string GetNurseName()
        {
            string fullName = "";
            fullName = nurseLName + ", " + nurseFName;
            if (!String.IsNullOrEmpty(nurseMInit))
            {
                fullName += " " + nurseMInit + ".";
            }
            return fullName;
        }

        /// <summary>
        /// Gets the full doctor name
        /// </summary>
        /// <returns>String containing full persons name</returns>
        public string GetDoctorName()
        {
            string fullName = "";
            fullName = doctorLName + ", " + doctorFName;
            if (!String.IsNullOrEmpty(doctorMInit))
            {
                fullName += " " + doctorMInit + ".";
            }
            return fullName;
        }
    }
}
