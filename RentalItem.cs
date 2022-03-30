using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using Oracle.ManagedDataAccess.Client;

namespace MovieSYS
{
    class RentalItem
    {
        private int itemID;
        private int dvdID;
        private float fineAmount;

        public RentalItem()
        {
            itemID = 0;
            dvdID = 0;
            fineAmount = 0.00f;
        }

        public RentalItem(int itemID, int dvdID,float fineAmount)
        {
            this.itemID = itemID;
            this.dvdID = dvdID;
            this.fineAmount = fineAmount;
        }

        //Getters & Setters
        public int ItemID { get => itemID; set => itemID = value; }
        public int DvdID { get => dvdID; set => dvdID = value; }
        public float FineAmount { get => fineAmount; set => fineAmount = value; }

        public void AddRentalItem()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO Rental_Items(Rent_Id, DVD_Id, Fine_Amount) VALUES (" +
                    this.itemID + "," +
                    this.dvdID + "," +
                    this.fineAmount + ")";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error updating Database\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }

        public static DataSet GetRentalItems(int memId)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT RI.Rent_Id, RI.DVD_Id, DVD_Title, Due_Date " +
                                  "FROM Rental_Items RI JOIN DVDs D ON RI.DVD_ID = D.DVD_ID " +
                                        "JOIN Rentals R ON R.Rent_Id = RI.Rent_Id " +
                                        "JOIN Members M ON R.Member_Id = M.Member_ID " +
                                  "WHERE M.Member_Id = " + memId + " AND " +
                                        "Return_Date IS NULL " +
                                        "ORDER BY Due_Date";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "rented");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }

        public static int GetDaysOverdue(int memId, int rentId)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT to_date(Due_date)- to_date(TRUNC(SYSDATE)) " +
                                  "FROM Rentals " +
                                  "WHERE Due_Date < TRUNC(SYSDATE) AND Member_Id = " + memId + " AND Rent_Id = " + rentId + "";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                int overdueDays;

                dr.Read();

                if (dr.IsDBNull(0))
                    overdueDays = 0;
                else
                {
                    overdueDays = dr.GetInt32(0) * -1;
                }

                conn.Close();

                return overdueDays;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }

        public static void UpdateRentalItem(int rentId, int dvdId)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "UPDATE Rental_Items " +
                                  "SET Return_Date = SYSDATE " +
                                  "WHERE Rent_Id = " + rentId + " AND DVD_Id = " + dvdId + "";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error updating Database\n" + e.ToString());
            }
        }

        public static void UpdateFineAmount(int dvdId, float amount)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "UPDATE Rental_Items " +
                                  "SET Fine_Amount = " + amount + " " +
                                  "WHERE DVD_Id = " + dvdId + "";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error updating Database\n" + e.ToString());
            }
        }
        //public void SendReminder()
    }
}
