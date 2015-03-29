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

        /// <summary>
        /// Get summary of visits containing
        /// </summary>
        /// <returns>List of visits</returns>
        public static List<VisitSummary> GetVisitSummary(string firstName, string lastName, DateTime? dateOfBirth)
        {
            List<VisitSummary> retval = new List<VisitSummary>();
            string selectStatement =
                "SELECT v.id as 'id', v.date as 'date', v.final_diagnosis as 'diagnosis', " +
                       "p.lname as 'patientLName', " +
                       "p.minit as 'patientMInit', " +
                       "p.fname as 'patientFName', " +
                       "p.birth_date as 'patientDOB', " +
                       "n.lname as 'nurseLName', " +
                       "n.minit as 'nurseMInit', " +
                       "n.fname as 'nurseFName', " +
                       "d.lname as 'doctorLName', " +
                       "d.minit as 'doctorMInit', " +
                       "d.fname as 'doctorFName' " +
	                "FROM visit v JOIN person p ON v.patient_id = p.id " +
	                             "JOIN person n ON v.nurse_id = n.id " +
	                             "JOIN person d ON v.doctor_id = d.id " +
                    "WHERE p.is_patient = 1";
            List<string> whereClauses = new List<string>();
            if (!String.IsNullOrEmpty(firstName))
            {
                whereClauses.Add("p.fname = @FirstName");
            }
            if (!String.IsNullOrEmpty(lastName))
            {
                whereClauses.Add("p.lname = @LastName");
            }
            if (dateOfBirth != null)
            {
                whereClauses.Add("p.birth_date = @DateOfBirth");
            }
            foreach (string val in whereClauses)
            {
                selectStatement += " AND ";
                selectStatement += val;
            }
            selectStatement += " ORDER BY 'date'";

            try
            {
                using (SqlConnection connection = ClinicManagerDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        if (!String.IsNullOrEmpty(firstName))
                        {
                            selectCommand.Parameters.AddWithValue("@FirstName", firstName);
                        }
                        if (!String.IsNullOrEmpty(lastName))
                        {
                            selectCommand.Parameters.AddWithValue("@LastName", lastName);
                        }
                        if (dateOfBirth != null)
                        {
                            selectCommand.Parameters.AddWithValue("@DateOfBirth", ((DateTime)dateOfBirth).Date);
                        }
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                VisitSummary visit = new VisitSummary();
                                visit.VisitID = (int)reader["id"];
                                visit.FinalDiagnosis = reader["diagnosis"].ToString();
                                visit.Date = (DateTime)reader["date"];
                                visit.PatientFName = reader["patientFname"].ToString();
                                visit.PatientLName = reader["patientLname"].ToString();
                                visit.PatientMInit = reader["patientMInit"].ToString();
                                visit.NurseFName = reader["nurseFname"].ToString();
                                visit.NurseLName = reader["nurseLname"].ToString();
                                visit.NurseMInit = reader["nurseMInit"].ToString();
                                visit.DoctorFName = reader["doctorFname"].ToString();
                                visit.DoctorLName = reader["doctorLname"].ToString();
                                visit.DoctorMInit = reader["doctorMInit"].ToString();
                                visit.DateOfBirth = (DateTime)reader["patientDOB"];
                                retval.Add(visit);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retval;
        }
    }
}
