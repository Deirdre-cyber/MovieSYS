using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace MovieSYS
{
    class Rental
    {
        private int rentId;
        private String rentDate;
        private String dueDate;
        private float rentalPrice;
        private int memberId;
        public Rental()
        {
            this.rentId = 0;
            this.rentDate = "";
            this.dueDate = "";
            this.rentalPrice = 0.00f;
            this.memberId = 0;
        }

        public Rental(int rentId, string rentDate, string dueDate, float rentalPrice, int memberId)
        {
            this.rentId = rentId;
            this.rentDate = rentDate;
            this.dueDate = dueDate;
            this.rentalPrice = rentalPrice;
            this.memberId = memberId;
        }

        public int RentId { get => rentId; set => rentId = value; }
        public string RentDate { get => rentDate; set => rentDate = value; }
        public string DueDate { get => dueDate; set => dueDate = value; }
        public float RentalPrice { get => rentalPrice; set => rentalPrice = value; }
        public int MemberId { get => memberId; set => memberId = value; }

        public static int GetNextRentalId()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT MAX(Rent_Id) FROM Rentals";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                int nextId;

                dr.Read();

                if (dr.IsDBNull(0))
                    nextId = 1;
                else
                {
                    nextId = dr.GetInt32(0) + 1;
                }

                conn.Close();

                return nextId;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }

        public void AddRental()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO Rentals VALUES (" +
                    this.rentId + ",'" +
                    this.rentDate + "','" +
                    this.dueDate + "'," +
                    this.rentalPrice + "," +
                    this.memberId + ")";

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

        public static DataSet GetOverdueDvds()
        {
            try { 
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT Member_Id, RI.Rent_Id, RI.DVD_Id, DVD_Title, Rent_Date, Due_Date, Fine_Amount " +
                                  "FROM Rental_Items RI JOIN DVDs D ON RI.DVD_ID = D.DVD_ID " +
                                        "JOIN Rentals R ON R.Rent_Id = RI.Rent_Id " +
                                  "WHERE Return_Date IS NULL AND Due_Date < SYSDATE " +
                                        "ORDER BY DVD_Id";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "overdue");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }

        public static DataSet GetRevenueAnalysis(String year)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String SQLquery = "SELECT EXTRACT(MONTH FROM Rent_Date), SUM(Rental_Price) " +
                                  "FROM Rentals " +
                                  "WHERE Rent_Date LIKE '%" + year + "' " +
                                  "GROUP BY EXTRACT(MONTH FROM Rent_Date)";

                OracleCommand cmd = new OracleCommand(SQLquery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds, "RA");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }
    }
}
