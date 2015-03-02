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
        /// <param name="oldPerson"></param>
        /// <param name="newPerson"></param>
        /// <returns></returns>
        public static bool UpdatePerson(Person oldPerson, Person newPerson)
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
    }
}
