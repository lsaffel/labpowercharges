using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1PowerCharges
{
    /// <summary>
    /// A repository of validation methods
    /// </summary>
    public static class Validator
    {
        public static bool IsProvided(TextBox inputBox, string name)
        {
            bool isValid = true; // good until or unless not good
            if (inputBox.Text == "") // input cannot be empty
            {
                isValid = false;
                MessageBox.Show(name + " must be provided");
                inputBox.Focus();
            }
            return isValid;
        }

        public static bool IsNonNegativeInt(TextBox inputBox, string name)
        {
            bool isValid = true;
            int value; // parsed value
            if (!Int32.TryParse(inputBox.Text, out value)) // not an int
            {
                isValid = false;
                MessageBox.Show(name + " has to be a whole number");
                inputBox.SelectAll(); // select all content for replacement
                inputBox.Focus();
            }
            else if (value < 0) // negative is bad
            {
                isValid = false;
                MessageBox.Show(name + " has to be non-negative");
                inputBox.SelectAll(); // select all content for replacement
                inputBox.Focus();
            }
            return isValid;
        }

        public static bool IsNonNegativeDouble(TextBox inputBox, string name)
        {
            bool isValid = true;
            double value; // parsed value
            if (!Double.TryParse(inputBox.Text, out value)) // not an double
            {
                isValid = false;
                MessageBox.Show(name + " has to be a number");
                inputBox.SelectAll(); // select all content for replacement
                inputBox.Focus();
            }
            else if (value < 0) // negative is bad
            {
                isValid = false;
                MessageBox.Show(name + " has to be non-negative");
                inputBox.SelectAll(); // select all content for replacement
                inputBox.Focus();
            }
            return isValid;
        }

    }
}
