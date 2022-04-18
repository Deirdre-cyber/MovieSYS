using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
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

        //edit - replace with if txtBox.All(char.IsLetter)
        public static bool HasChars(String name)
        {
            Regex check = new Regex(@"^[a-zA-Z]+$");

            if (check.IsMatch(name))
                return true;
            else
                return false;
        }

        //edit - replace with if txtBox.All(char.IsDigit)
        public static bool HasDigits(String number)
        {
            Regex pattern = new Regex(@"^[0-9]+$");

            if (pattern.IsMatch(number))
                return true;
            else
                return false;
        }

        //makes sure number starts with 08...
        public static bool IsNumber(String number)
        {
            if (Int32.TryParse(number, out int num))
                return true;
            else
                return false;
        }

        public static bool IsValidEmail(String email)
        {
            Regex pattern = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z");

            if (pattern.IsMatch(email))
                return true;
            else
                return false;
        }

        public static bool IsValidEircode(String eircode)
        {
            Regex pattern = new Regex(@"^[ACDEFHKNPRTVWXY]{1}[0-9]{1}[0-9W]{1}[\ \-]?[0-9ACDEFHKNPRTVWXY]{4}$");

            if (pattern.IsMatch(eircode))
                return true;
            else
                return false;
        }

        public static bool EmailExists(String email)
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
            else
            {
                conn.Close();
                return true;
            }
        }
    }
}
