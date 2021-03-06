﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManager.View
{
    /// <summary>
    /// Verifies the proper value/format/presence of various form controls
    /// </summary>
    class Validator
    {
        private const string TITLE = "Invalid Input";

        /// <summary>
        /// Checks that the control passed in has a value
        /// </summary>
        /// <param name="control">The control to be checked</param>
        /// <returns>true if the control has a value, false otherwise</returns>
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                textBox.Text = textBox.Text.Trim();
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", TITLE);
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", TITLE);
                    comboBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.DateTimePicker")
            {
                DateTimePicker dateTimePicker = (DateTimePicker)control;
                if (dateTimePicker.Text == "")
                {
                    MessageBox.Show(dateTimePicker.Tag.ToString() + " is a required field.", TITLE);
                    dateTimePicker.Focus();
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks a DateTimePicker control to see if its date is before the given time
        /// </summary>
        /// <param name="dateTimeControl">The control to check</param>
        /// <param name="limit">The value to check if the control is set less than or equal to</param>
        /// <returns>True if the value of the control is before the isBefore DateTime param</returns>
        public static bool DateIsBefore(DateTimePicker dateTimeControl, DateTime limit)
        {
            if (dateTimeControl.Value > limit)
            {
                MessageBox.Show(dateTimeControl.Tag.ToString() + " must be set to a date before now.", TITLE);
                dateTimeControl.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks whether the given phone number is in the correct format
        /// </summary>
        /// <param name="textBox">The text box containing the format to check</param>
        /// <returns>True if the format is acceptable, false otherwise</returns>
        public static bool IsPhoneNumber(TextBox textBox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "^\\d{3}-?\\d{3}-?\\d{4}$"))
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be in one of the following formats:\n\n" +
                    "111-222-3333\n1112223333", TITLE);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks whether the given temperature reading is in the correct format
        /// </summary>
        /// <param name="textBox">The text box containing the format to check</param>
        /// <returns>True if the format is acceptable, false otherwise</returns>
        public static bool IsTemp(TextBox textBox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "^1?\\d{2}.\\d$"))
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be in one of the following format:\n\n" +
                    "xx.x or xxx.x", TITLE);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Verifies that the SSN input is in the correct format
        /// </summary>
        /// <param name="textBox">The text box containing the format to check</param>
        /// <returns>True if the format is acceptable, false otherwise</returns>
        public static bool IsSSN(TextBox textBox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "^\\d{3}-?\\d{2}-?\\d{4}$"))
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be in the following format: xxx-xx-xxxx or xxxxxxxxx", TITLE);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Verifies that the zip input is in the correct format
        /// </summary>
        /// <param name="textBox">The text box containing the format to check</param>
        /// <returns>True if the format is acceptable, false otherwise</returns>
        public static bool IsZip(TextBox textBox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "^\\d{5}(-\\d{4})?$"))
            {
                MessageBox.Show(textBox.Tag.ToString() + " must be in one of the following formats:\n\nxxxxx\nxxxxx-xxxx", TITLE);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks whether the passing in string can be converted to an integer
        /// </summary>
        /// <param name="number">The string to check</param>
        /// <returns>True if the string can be converted, false otherwise</returns>
        public static bool IsInt(string number)
        {
            try
            {
                foreach (char current in number)
                {
                    Convert.ToInt64(current);
                }
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks whether the passing in string can be converted to an double
        /// </summary>
        /// <param name="number">The string to check</param>
        /// <returns>True if the string can be converted, false otherwise</returns>
        public static bool IsDouble(string number)
        {
            try
            {
                Double.Parse(number);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("One oe more fields must be valid numbers", TITLE);
                return false;
            }
        }


        /// <summary>
        /// Checks that the given username and password are at least 4 characters each
        /// </summary>
        /// <returns>true if valid false otherwise</returns>
        public static bool IsValidUserPsswd(TextBox userBox, TextBox psswdBox)
        {
            if (userBox.Text.Length < 4)
            {
                MessageBox.Show(userBox.Tag + " must be at least 4 characters", TITLE);
                userBox.Focus();
                return false;
            }
            if (psswdBox.Text.Length < 4)
            {
                MessageBox.Show(psswdBox.Tag + " must be at least 4 characters", TITLE);
                psswdBox.Focus();
                return false;
            }
            return true;
        }
    }
}
