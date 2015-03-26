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
        public static List<Person> GetPersonSummary(string firstName, string lastName, DateTime? dateOfBirth)
        {
            List<Person> retval = new List<Person>();
            string selectStatement =
                "SELECT id, ssn, fname, minit, lname, birth_date, is_male, street_address, phone, timestamp " +
                "FROM person ";
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
            int count = 0;
            foreach (string val in whereClauses)
            {
                if (count == 0)
                {
                    selectStatement += "WHERE ";
                }
                selectStatement += val;
                if (++count != whereClauses.Count)
                {
                    selectStatement += " AND ";
                }
            }
            selectStatement += " ORDER BY lname ";

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
                "street_address, city, state, zip, phone, is_nurse, is_doctor) " +
                "VALUES (@ssn, @fname, @minit, @lname, @birth_date, @is_male, " +
                "@street_address, @city, @state, @zip, @phone, @is_nurse, @is_doctor)";
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
                        insertCommand.Parameters.AddWithValue("@is_nurse", person.IsNurse);
                        insertCommand.Parameters.AddWithValue("@is_doctor", person.IsDoctor);

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
        /// Updates a person in the DB
        /// </summary>
        /// <param name="person">The person object with the altered data and the original person ID</param>
        /// <returns>True if update successful, false otherwise</returns>
        public static bool UpdatePerson(Person person)
        {
            string updateStatement =
                "UPDATE person SET ssn = @ssn, fname = @fname, minit = @minit, lname = @lname, " +
                "birth_date = @birth_date, is_male = @is_male, street_address = @street_address, " +
                "city = @city, state = @state, zip = @zip, phone = @phone, is_nurse = @is_nurse, is_doctor = @is_doctor " +
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
                        updateCommand.Parameters.AddWithValue("@is_nurse", person.IsNurse);
                        updateCommand.Parameters.AddWithValue("@is_doctor", person.IsDoctor);
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
        /// Gets a person from the db by their id
        /// </summary>
        /// <param name="id">The id of the person to be retrieved</param>
        /// <returns>The person with the passed in id, null otherwise</returns>
        public static Person GetPersonById(int id)
        {
            Person person = new Person();
            string selectStatment = 
                "SELECT id, ssn, fname, minit, lname, birth_date, is_male, street_address, " + 
                "city, state, zip, phone, is_nurse, is_doctor, timestamp " + 
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
                                person.IsNurse = (bool)reader["is_nurse"];
                                person.IsDoctor = (bool)reader["is_doctor"];
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
                "city, state, zip, phone, is_nurse, is_doctor, timestamp " +
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
                                person.IsNurse = (bool)reader["is_nurse"];
                                person.IsDoctor = (bool)reader["is_doctor"];
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
        /// <returns></returns>
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
