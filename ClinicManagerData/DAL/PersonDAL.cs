﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
