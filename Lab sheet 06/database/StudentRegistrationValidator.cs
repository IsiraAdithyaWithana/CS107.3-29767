using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database
{
    class StudentRegistrationValidator
    {
        public static string ValidateRegistration(string name, string dob, string password, string confirmPassword)
        {
            string errors = "";

            // Validate name (alphanumeric only)
            if (!name.All(char.IsLetterOrDigit))
            {
                errors += "Name must contain only alphanumeric characters (A-Z, a-z, 0-9).\n";
            }

            // Validate date of birth (format and age)
            try
            {
                DateTime dobDateTime = DateTime.ParseExact(dob, "yyyy-MM-dd", null);
                DateTime today = DateTime.Today;
                int age = today.Year - dobDateTime.Year;
                if (age < 16)
                {
                    errors += "You must be 16 years or older to register.\n";
                }
            }
            catch (FormatException)
            {
                errors += "Invalid date of birth format. Please use YYYY-MM-DD.\n";
            }

            // Validate password (match and alphanumeric only)
            /*if (password != confirmPassword)
            {
                errors += "Passwords do not match.\n";
            }
            if (!password.All(char.IsLetterOrDigit))
            {
                errors += "Password must contain only alphanumeric characters (A-Z, a-z, 0-9).\n";
            }*/

            return errors.Trim();
        }
    }
}
