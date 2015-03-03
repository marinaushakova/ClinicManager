using System;
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
        private const string MESSAGE = "Invalid Input";

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
                    MessageBox.Show(textBox.Tag.ToString() + " is a required field.", MESSAGE);
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox)control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", MESSAGE);
                    comboBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.DateTimePicker")
            {
                DateTimePicker dateTimePicker = (DateTimePicker)control;
                if (dateTimePicker.Text == "")
                {
                    MessageBox.Show(dateTimePicker.Tag.ToString() + " is a required field.", MESSAGE);
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
                MessageBox.Show(dateTimeControl.Tag.ToString() + " must be set to a date before now.", MESSAGE);
                dateTimeControl.Focus();
                return false;
            }
            return true;
        }
    }
}
