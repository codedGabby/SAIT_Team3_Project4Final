using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpert_Application
{

    //Author: Yasin Habib and Suaid
    public class Validation
    {
        //whole number
        public static bool ValidWhole(TextBox tbInput)
        {
            bool valid = true;
            int textValue;
            if (!Int32.TryParse(tbInput.Text, out textValue)) //Validating whole number
            {
                valid = false;
                MessageBox.Show("Need to be a whole number", "Input Error");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            return valid;
        }//end of whole number

        //Non Negative
        public static bool ValidNeg(TextBox tbInput)
        {
            bool valid = true;
            decimal tbData;
            if (tbInput.Text != "")
            {
                tbData = Convert.ToDecimal(tbInput.Text);
                if (tbData < 0)      //Validating a negative value
                {
                    valid = false;
                    MessageBox.Show("Please enter a positive value", "Input Error");
                    tbInput.SelectAll();
                    tbInput.Focus();
                }
            }
            return valid;
        }//end of negative

        //No null
        public static bool ValidNull(TextBox tbInput)
        {
            bool valid = true;
            if (tbInput.Text == "") //Validating empty textbox
            {
                valid = false;
                MessageBox.Show("Description and Name can not be empty", "Input Error");
                tbInput.Focus();
            }
            return valid;
        }//End of null

        //No number(Only alphabets)
        public static bool ValidLetters(TextBox tbInput)
        {
            bool valid = true;
            if (!tbInput.Text.All(Char.IsLetter)) //Validating for letters
            {
                valid = false;
                MessageBox.Show("This field accepts letters ", "Input Error");
                tbInput.SelectAll();
                tbInput.Focus();
            }
            return valid;
        }//End of letters only

        //Compare two datetime (DateTimePicker)
        public static bool ValidDateTime(DateTimePicker startDate, DateTimePicker endDate)
        {

            bool valid = true;
            DateTime start = startDate.Value.Date;
            DateTime end = endDate.Value.Date;
            if (start > end)
            {
                MessageBox.Show("Start date has to be before end date", "Input Error");
                valid = false;
            }
            return valid;
        }
        // Author Muhammad Suaid
        public static bool ProductNotNull(TextBox tbInput)
        {
            bool valid = true;
            if (tbInput.Text == "") //Validating empty textbox
            {
                valid = false;
                MessageBox.Show("Product Name cannot be empty", "Input Error");
                tbInput.Focus();
            }
            return valid;
        }

    }//End of validation
}//End of Namespace

