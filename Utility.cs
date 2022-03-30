using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MovieSYS
{
    class Utility
    {
        /*Code taken/modified from : https://www.codeproject.com/questions/813344/clear-all-textboxes-in-form-with-one-function*/
        //add more - combo boxes and dates
        
        public static void ClearText(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearText(ctrl.Controls);
                }
                if (ctrl is ComboBox)
                {
                    ComboBox cbo = (ComboBox)ctrl;
                    cbo.SelectedIndex = -1;
                }
                else
                {
                    ClearText(ctrl.Controls);
                }
                //etc
            }
        }

        public static String setGenre(String genre)
        {
            if (!genre.Substring(0).Equals('G'))
                return genre.Substring(0, 2);
            else
                return genre.Substring(0, 1) + " ";
        }

        //TRY CATCH
        public static DataSet getMembershipCodes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Memberships ORDER BY Membership_Id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "membership");

            conn.Close();

            return ds;
        }

        //TRY CATCH
        public static DataSet getCountryCodes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Countries ORDER BY Country_Id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "country");

            conn.Close();

            return ds;
        }

        //TRY CATCH
        public static DataSet getCategoryCodes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Categories ORDER BY Category_Id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "category");

            conn.Close();

            return ds;
        }

        //TRY CATCH
        public static DataSet getGenreCodes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Genres ORDER BY Genre_Id";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "genre");

            conn.Close();

            return ds;
        }

        //TRY CATCH
        public static DataSet getAgeCodes()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Age_Ratings";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "age");

            conn.Close();

            return ds;
        }
    }
}
