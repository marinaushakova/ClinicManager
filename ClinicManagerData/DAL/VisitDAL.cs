using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClinicManagerData.Model;
using ClinicManagerData.DB;

namespace ClinicManagerData.DAL
{
    /// <summary>
    /// Data access for visit
    /// </summary>
    public static class VisitDAL
    {
        /// <summary>
        /// Adds the passed in visit object to the DB
        /// </summary>
        /// <param name="person">The visit object to add to the DB</param>
        /// <returns>The id generated for the created visit</returns>
        public static int AddVisitRecord(Visit visit)
        {
            string insertStatement =
                "INSERT INTO visit (date, patient_id, nurse_id, doctor_id, blood_pressure, " +
                "temperature, pulse_rate, symptoms, initial_diagnosis, final_diagnosis) " +
                "VALUES (@date, @patient_id, @nurse_id, @doctor_id, @blood_pressure, " +
                "@temperature, @pulse_rate, @symptoms, @initial_diagnosis, @final_diagnosis)";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, con))
                    {
                        insertCommand.Parameters.AddWithValue("@date", visit.Date);
                        insertCommand.Parameters.AddWithValue("@patient_id", visit.PatientID);
                        insertCommand.Parameters.AddWithValue("@nurse_id", visit.NurseID);
                        insertCommand.Parameters.AddWithValue("@doctor_id", visit.DoctorID);
                        insertCommand.Parameters.AddWithValue("@blood_pressure", visit.BloodPressure);
                        insertCommand.Parameters.AddWithValue("@temperature", visit.Temperature);
                        insertCommand.Parameters.AddWithValue("@pulse_rate", visit.PulseRate);
                        insertCommand.Parameters.AddWithValue("@symptoms", visit.Symptoms);
                        insertCommand.Parameters.AddWithValue("@initial_diagnosis", visit.InitialDiagnosis);
                        insertCommand.Parameters.AddWithValue("@final_diagnosis", visit.FinalDiagnosis);

                        insertCommand.ExecuteNonQuery();

                        SqlCommand identCom = new SqlCommand();
                        identCom.Connection = con;
                        identCom.CommandText = "SELECT IDENT_CURRENT('visit') FROM visit";
                        int visitID = Convert.ToInt32(identCom.ExecuteScalar());
                        return visitID;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
