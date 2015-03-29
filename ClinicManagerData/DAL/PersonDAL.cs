using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClinicManagerData.DB;
using ClinicManagerData.Model;

namespace ClinicManagerData.DAL
{
    /// <summary>
    /// Data access for person
    /// </summary>
    public static class PersonDAL
    {
        /// <summary>
        /// Get summary of persons containing only name, ssn, street address, city and phone
        /// </summary>
        /// <returns>List of persons</returns>
        public static List<Person> GetPersonSummary(bool isPatient, string firstName, string lastName, DateTime? dateOfBirth)
        {
            List<Person> retval = new List<Person>();
            string selectStatement =
                "SELECT id, ssn, fname, minit, lname, birth_date, is_male, street_address, phone, timestamp " +
                "FROM person WHERE is_patient = @IsPatient";
            List<string> whereClauses = new List<string>();
            if (!String.IsNullOrEmpty(firstName))
            {
                whereClauses.Add("fname = @FirstName");
            }
            if (!String.IsNullOrEmpty(lastName))
            {
                whereClauses.Add("lname = @LastName");
            }
            if (dateOfBirth != null)
            {
                whereClauses.Add("birth_date = @DateOfBirth");
            }
            foreach (string val in whereClauses)
            {
                selectStatement += " AND ";
                selectStatement += val;
            }
            selectStatement += " ORDER BY lname ";

            try
            {
                using (SqlConnection connection = ClinicManagerDBConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@IsPatient", isPatient);
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
                                Person person = new Person();
                                person.PersonID = (int)reader["id"];
                                person.Timestamp = Convert.ToBase64String(reader["timestamp"] as byte[]);
                                person.FirstName = reader["fname"].ToString();
                                person.LastName = reader["lname"].ToString();
                                person.MiddleInit = reader["minit"].ToString();
                                person.IsMale = (bool)reader["is_male"];
                                person.Social = reader["ssn"].ToString();
                                person.DateOfBirth = (DateTime)reader["birth_date"];
                                person.Address = reader["street_address"].ToString();
                                person.Phone = reader["phone"].ToString();
                                retval.Add(person);
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

        /// <summary>
        /// Adds the passed in person object to the DB
        /// </summary>
        /// <param name="person">The person object to add to the DB</param>
        /// <returns>The id generated for the created person</returns>
        public static int AddPerson(Person person)
        {
            string insertStatement =
                "INSERT INTO person (ssn, fname, minit, lname, birth_date, is_male, " +
                "street_address, city, state, zip, phone, is_patient, is_nurse, is_doctor, is_admin) " +
                "VALUES (@ssn, @fname, @minit, @lname, @birth_date, @is_male, " +
                "@street_address, @city, @state, @zip, @phone, @is_patient, @is_nurse, @is_doctor, @is_admin)";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertStatement, con))
                    {
                        insertCommand.Parameters.AddWithValue("@ssn", person.Social);
                        insertCommand.Parameters.AddWithValue("@fname", person.FirstName);
                        insertCommand.Parameters.AddWithValue("@minit", person.MiddleInit);
                        insertCommand.Parameters.AddWithValue("@lname", person.LastName);
                        insertCommand.Parameters.AddWithValue("@birth_date", person.DateOfBirth);
                        insertCommand.Parameters.AddWithValue("@is_male", person.IsMale);
                        insertCommand.Parameters.AddWithValue("@street_address", person.Address);
                        insertCommand.Parameters.AddWithValue("@city", person.City);
                        insertCommand.Parameters.AddWithValue("@state", person.State);
                        insertCommand.Parameters.AddWithValue("@zip", person.Zip);
                        insertCommand.Parameters.AddWithValue("@phone", person.Phone);
                        insertCommand.Parameters.AddWithValue("@is_patient", person.IsPatient);
                        insertCommand.Parameters.AddWithValue("@is_nurse", person.IsNurse);
                        insertCommand.Parameters.AddWithValue("@is_doctor", person.IsDoctor);
                        insertCommand.Parameters.AddWithValue("@is_admin", person.IsAdmin);

                        insertCommand.ExecuteNonQuery();

                        SqlCommand identCom = new SqlCommand();
                        identCom.Connection = con;
                        identCom.CommandText = "SELECT IDENT_CURRENT('person') FROM person";
                        int personID = Convert.ToInt32(identCom.ExecuteScalar());
                        return personID;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Adds a staff member who also has user credentials
        /// </summary>
        /// <param name="person">The person object to add to the person table</param>
        /// <param name="user">The user object to add to the user table for this staff member</param>
        /// <returns>The id of the newly created person entry</returns>
        public static int AddUserStaffMember(Person person, User user)
        {
            string personInsertStatement =
                "INSERT INTO person (ssn, fname, minit, lname, birth_date, is_male, " +
                "street_address, city, state, zip, phone, is_patient, is_nurse, is_doctor, is_admin) " +
                "VALUES (@ssn, @fname, @minit, @lname, @birth_date, @is_male, " +
                "@street_address, @city, @state, @zip, @phone, @is_patient, @is_nurse, @is_doctor, @is_admin)";
            string userInsertStatment =
                "INSERT INTO [user] (person_id, username, password)" +
                "VALUES (@person_id, @username, @password)";

            SqlConnection con;
            try
            {
                con = ClinicManagerDBConnection.GetConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            SqlTransaction createStaffUserTran = null;

            SqlCommand insPersonCom = new SqlCommand();
            insPersonCom.Connection = con;
            insPersonCom.CommandText = personInsertStatement;
            insPersonCom.Parameters.AddWithValue("@ssn", person.Social);
            insPersonCom.Parameters.AddWithValue("@fname", person.FirstName);
            insPersonCom.Parameters.AddWithValue("@minit", person.MiddleInit);
            insPersonCom.Parameters.AddWithValue("@lname", person.LastName);
            insPersonCom.Parameters.AddWithValue("@birth_date", person.DateOfBirth);
            insPersonCom.Parameters.AddWithValue("@is_male", person.IsMale);
            insPersonCom.Parameters.AddWithValue("@street_address", person.Address);
            insPersonCom.Parameters.AddWithValue("@city", person.City);
            insPersonCom.Parameters.AddWithValue("@state", person.State);
            insPersonCom.Parameters.AddWithValue("@zip", person.Zip);
            insPersonCom.Parameters.AddWithValue("@phone", person.Phone);
            insPersonCom.Parameters.AddWithValue("@is_patient", person.IsPatient);
            insPersonCom.Parameters.AddWithValue("@is_nurse", person.IsNurse);
            insPersonCom.Parameters.AddWithValue("@is_doctor", person.IsDoctor);
            insPersonCom.Parameters.AddWithValue("@is_admin", person.IsAdmin);

            SqlCommand insUserCom = new SqlCommand();
            insUserCom.Connection = con;
            insUserCom.CommandText = userInsertStatment;
            string hashedPassword = UserDAL.HashLogin(user.Username, user.Password);

            SqlCommand identCom = new SqlCommand();
            identCom.Connection = con;
            identCom.CommandText = "SELECT IDENT_CURRENT('person') FROM person";

            int personID;
            try
            {
                con.Open();
                createStaffUserTran = con.BeginTransaction();
                insPersonCom.Transaction = createStaffUserTran;
                insUserCom.Transaction = createStaffUserTran;
                identCom.Transaction = createStaffUserTran;

                int count = insPersonCom.ExecuteNonQuery();
                    
                    personID = Convert.ToInt32(identCom.ExecuteScalar());

                        insUserCom.Parameters.AddWithValue("@person_id", personID);
                        insUserCom.Parameters.AddWithValue("@username", user.Username);
                        insUserCom.Parameters.AddWithValue("@password", hashedPassword);
                        count = insUserCom.ExecuteNonQuery();
                        createStaffUserTran.Commit();
                        return personID;
            }
            catch (Exception ex)
            {
                if (createStaffUserTran != null) createStaffUserTran.Rollback();
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// Updates a person in the DB
        /// </summary>
        /// <param name="person">The person object with the altered data and the original person ID</param>
        /// <returns>True if update successful, false otherwise</returns>
        public static bool UpdatePerson(Person person)
        {
            string updateStatement =
                "UPDATE person SET ssn = @ssn, fname = @fname, minit = @minit, lname = @lname, " +
                "birth_date = @birth_date, is_male = @is_male, street_address = @street_address, " +
                "city = @city, state = @state, zip = @zip, phone = @phone, is_patient = @is_patient, " +
                "is_nurse = @is_nurse, is_doctor = @is_doctor, is_admin = @is_admin " +
                "WHERE id = @id AND timestamp = @timestamp";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, con))
                    {
                        updateCommand.Parameters.AddWithValue("@id", person.PersonID);
                        updateCommand.Parameters.AddWithValue("@ssn", person.Social);
                        updateCommand.Parameters.AddWithValue("@fname", person.FirstName);
                        updateCommand.Parameters.AddWithValue("@minit", person.MiddleInit);
                        updateCommand.Parameters.AddWithValue("@lname", person.LastName);
                        updateCommand.Parameters.AddWithValue("@birth_date", person.DateOfBirth);
                        updateCommand.Parameters.AddWithValue("@is_male", person.IsMale);
                        updateCommand.Parameters.AddWithValue("@street_address", person.Address);
                        updateCommand.Parameters.AddWithValue("@city", person.City);
                        updateCommand.Parameters.AddWithValue("@state", person.State);
                        updateCommand.Parameters.AddWithValue("@zip", person.Zip);
                        updateCommand.Parameters.AddWithValue("@phone", person.Phone);
                        updateCommand.Parameters.AddWithValue("@is_patient", person.IsPatient);
                        updateCommand.Parameters.AddWithValue("@is_nurse", person.IsNurse);
                        updateCommand.Parameters.AddWithValue("@is_doctor", person.IsDoctor);
                        updateCommand.Parameters.AddWithValue("@is_admin", person.IsAdmin);
                        updateCommand.Parameters.AddWithValue("@timestamp", Convert.FromBase64String(person.Timestamp));

                        int count = updateCommand.ExecuteNonQuery();
                        if (count > 0) return true;
                        else return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Updates the person and user entry for a given staff member or just one if one is null
        /// </summary>
        /// <param name="person">The person object holding the data to update the person entry of the person with</param>
        /// <param name="user">The user object holding the data to update the user entry of the user with</param>
        /// <returns>True if successful, false otherwise</returns>
        public static bool UpdateStaffMember(Person person, User user)
        {
            return false;
        }

        /// <summary>
        /// Gets a person from the db by their id
        /// </summary>
        /// <param name="id">The id of the person to be retrieved</param>
        /// <returns>The person with the passed in id, null otherwise</returns>
        public static Person GetPersonById(int id)
        {
            Person person = new Person();
            string selectStatment = 
                "SELECT id, ssn, fname, minit, lname, birth_date, is_male, street_address, " + 
                "city, state, zip, phone, is_patient, is_nurse, is_doctor, is_admin, timestamp " + 
                "FROM person WHERE id = @id";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatment, con))
                    {
                        selectCommand.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow))
                        {
                            if (reader.Read())
                            {
                                person.PersonID = (int)reader["id"];
                                person.Social = reader["ssn"].ToString();
                                person.FirstName = reader["fname"].ToString();
                                person.MiddleInit = reader["minit"].ToString();
                                person.LastName = reader["lname"].ToString();
                                person.DateOfBirth = (DateTime)reader["birth_date"];
                                person.IsMale = (bool)reader["is_male"];
                                person.Address = reader["street_address"].ToString();
                                person.City = reader["city"].ToString();
                                person.State = reader["state"].ToString();
                                person.Zip = reader["zip"].ToString();
                                person.IsPatient = (bool)reader["is_patient"];
                                person.IsNurse = (bool)reader["is_nurse"];
                                person.IsDoctor = (bool)reader["is_doctor"];
                                person.IsAdmin = (bool)reader["is_admin"];
                                person.Phone = reader["phone"].ToString();
                                person.Timestamp = Convert.ToBase64String(reader["timestamp"] as byte[]);
                            }
                            else
                            {
                                person = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        /// <summary>
        /// Get the list of nurses or doctors depending on
        /// passed in parameter
        /// </summary>
        /// <param name="is_doctor">
        ///     true if returning the list of doctors, 
        ///     false if returning the list of nurses
        /// </param>
        /// <returns>the list of doctors of parameter is true, the list of nurses if parameter is false</returns>
        public static List<Person> GetAllStaffMembers(bool is_doctor)
        {
            List<Person> nurseList = new List<Person>();
            string selectStatment =
                "SELECT id, ssn, fname, minit, lname, birth_date, is_male, street_address, " +
                "city, state, zip, phone, is_patient, is_nurse, is_doctor, is_admin, timestamp " +
                "FROM person WHERE ";
            if (is_doctor)
            {
                selectStatment += "is_doctor = 1";
            }
            else
            {
                selectStatment += "is_nurse = 1";
            }
            selectStatment += " ORDER BY lname";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatment, con))
                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                Person person = new Person();
                                person.PersonID = (int)reader["id"];
                                person.Social = reader["ssn"].ToString();
                                person.FirstName = reader["fname"].ToString();
                                person.MiddleInit = reader["minit"].ToString();
                                person.LastName = reader["lname"].ToString();
                                person.DateOfBirth = (DateTime)reader["birth_date"];
                                person.IsMale = (bool)reader["is_male"];
                                person.Address = reader["street_address"].ToString();
                                person.City = reader["city"].ToString();
                                person.State = reader["state"].ToString();
                                person.Zip = reader["zip"].ToString();
                                person.IsPatient = (bool)reader["is_patient"];
                                person.IsNurse = (bool)reader["is_nurse"];
                                person.IsDoctor = (bool)reader["is_doctor"];
                                person.IsAdmin = (bool)reader["is_admin"];
                                person.Phone = reader["phone"].ToString();
                                person.Timestamp = Convert.ToBase64String(reader["timestamp"] as byte[]);
                                nurseList.Add(person);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nurseList;
        }

        /// <summary>
        /// Deletes the staff member with the specified ID from the database
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>True if deletion was sucessful, false otherwise</returns>
        public static bool DeleteStaffMember(int ID)
        {
            string deleteStatment = "DELETE FROM person WHERE id = @id";
            try
            {
                using (SqlConnection con = ClinicManagerDBConnection.GetConnection())
                {
                    con.Open();
                    using (SqlCommand deleteCommand = new SqlCommand(deleteStatment, con))
                    {
                        deleteCommand.Parameters.AddWithValue("@id", ID);
                        int count = deleteCommand.ExecuteNonQuery();
                        if (count > 0) return true;
                        else return false;
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
