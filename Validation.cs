using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MovieSYS
{
    class Validation
    {
        public static bool IsTableEmpty(DataSet ds)
        {
            foreach (DataTable table in ds.Tables)
                if (table.Rows.Count != 0)
                    return false;

            return true;
        }

        public static bool HasChars(String name)
        {
            if (name.All(char.IsLetter))

                return true;

            return false;
        }

        //not working
        public static bool IsValidPhone(String number)
        {
            /*https://rextester.com/NCOI74295*/

            Regex pattern = new Regex(@"^([0]{1}[0-9]{0,2}\s)?(0?[1-9]\d{0,4})(\s[1-9][\d]{5,12})(\sx\d{0,4})?$");

            if (pattern.IsMatch(number))
                return true;

            return false;
        }

        public static bool IsNumber(String number)
        {
            int count = 0;

            foreach (char ch in number)
            {
                if (ch == '.')
                    count++;
            }

            if (count == 1)
                number = number.Replace(".", "");

            if (number.All(char.IsDigit))
                return true;

            return false;
        }

        public static bool IsValidEmail(String email)
        {
            Regex pattern = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

            if (pattern.IsMatch(email))
                return true;

            return false;
        }

        public static bool IsValidEircode(String eircode)
        {
            /*https://www.tutorialguruji.com/javascript/validation-for-irish-eircode/*/
            Regex pattern = new Regex(@"^[ACDEFHKNPRTVWXY]{1}[0-9]{1}[0-9W]{1}[\ \-]?[0-9ACDEFHKNPRTVWXY]{4}$");

            if (pattern.IsMatch(eircode))
                return true;

            return false;
        }

        public static bool EmailExists(String email)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT COUNT(Email) FROM Members WHERE Email = '" + email + "'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();

                if (dr.GetInt32(0) == 0)
                {
                    conn.Close();
                    return false;
                }

                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }
    }
}
