using System;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Diagnostics;

namespace MovieSYS
{
    class Member
    {
        private int memId;
        private String firstName;
        private String lastName;
        private String DOB;
        private String contactNo;
        private String email;
        private String eircode;
        private String startDate;
        private String membershipID;
        private String status;
        private float total_fines;

        public int MemId { get => memId; set => memId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string Email { get => email; set => email = value; }
        public string Eircode { get => eircode; set => eircode = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string MembershipID { get => membershipID; set => membershipID = value; }
        public string Status { get => status; set => status = value; }
        public float Total_fines { get => total_fines; set => total_fines = value; }

        public Member()
        {
            memId = 0;
            firstName = "";
            lastName = "";
            DOB = "";
            contactNo = "";
            email = "";
            eircode = "";
            startDate = "";
            membershipID = "";
            status = "";
            total_fines = 0.0f;
        }

        public Member(int memId, string firstName, string lastName, String DOB, string contactNo, string email, string eircode, String startDate, string membershipID, string status)
        {
            //initialise with setters
            this.memId = memId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
            this.contactNo = contactNo;
            this.email = email;
            this.eircode = eircode;
            this.startDate = startDate;
            this.membershipID = membershipID;
            this.status = status;
        }

        public static int GetNextMemberID()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT MAX(Member_Id) FROM Members";

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

        public void AddMember()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO Members VALUES (" +
                    this.memId + ",'" +
                    this.membershipID + "','" +
                    this.firstName + "','" +
                    this.lastName + "','" +
                    this.DOB + "','" +
                    this.contactNo + "','" +
                    this.email + "','" +
                    this.eircode + "','" +
                    this.startDate + "','" +
                    this.status + "'," +
                    this.total_fines + ")";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error updating Database\n" + e.ToString());
                throw new Exception("Error updating Database");
            }
        }

        public static void UpdateMember(int id, String membership, String fName, String sName, String DOB, String phoneNo, 
            String email, String eircode, String status)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "UPDATE Members " +
                                  "SET Membership_Id = '" + membership + "', First_Name = '" + fName + "', " +
                                  "Last_Name = '" + sName + "', DOB = '" + DOB + "', " +
                                  "Contact_No = '" + phoneNo + "', Email = '" + email + "', Eircode = '" + eircode + "', " +
                                  "Status = '" + status + "' " +
                                  "WHERE Member_Id = " + id;

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

        public static DataSet SearchMember(String fName)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT * " +
                                  "FROM Members " +
                                  "WHERE UPPER(First_Name) LIKE '" + fName + "%' AND Status = 'A' ORDER BY First_Name";


                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "search");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }

        }

        public void GetMemberDetails(int id)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT * FROM Members" +
                                   " WHERE Member_Id = " + id + " AND Status = 'A'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                this.memId = dr.GetInt32(0);
                this.membershipID = dr.GetString(1);
                this.firstName = dr.GetString(2);
                this.lastName = dr.GetString(3);
                this.DOB = dr.GetString(4);
                this.contactNo = dr.GetString(5);
                this.email = dr.GetString(6);
                this.eircode = dr.GetString(7);
                this.startDate = dr.GetString(8);
                this.status = dr.GetString(9);

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
            }
        }

        public bool HasFine(int memId)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlGetFine = "SELECT Fines_Total " +
                                    "FROM Members " +
                                    "WHERE Member_Id = " + memId + "";


                OracleCommand cmd = new OracleCommand(sqlGetFine, conn);
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
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }

        }

        public bool HasOverdue(int memId)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlFindOverdue = "SELECT COUNT(*) FROM Rental_Items " +
                                        "WHERE Return_Date IS null AND Rent_Id IN " +
                                            "(SELECT Rent_Id " +
                                            "FROM Rentals " +
                                            "WHERE Due_Date < TRUNC(SYSDATE) AND Member_Id = " + memId + ")";

                OracleCommand cmd = new OracleCommand(sqlFindOverdue, conn);
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
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }

        public static float GetFinesOwed(int memId)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlGetFine = "SELECT Fines_Total " +
                                    "FROM Members " +
                                    "WHERE Member_Id = " + memId + "";

                OracleCommand cmd = new OracleCommand(sqlGetFine, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                float fineAmt;

                dr.Read();

                if (dr.IsDBNull(0))
                    fineAmt = 0;
                else
                {
                    fineAmt = dr.GetFloat(0);
                }

                conn.Close();

                return fineAmt;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }

        public static void UpdateFine(int id, float fine)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "UPDATE Members " +
                                  "SET Fines_Total = " + fine + "" +
                                  "WHERE Member_Id = " + id;

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

        public float GetFinesForPeriod(int memId, String start, String end)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlGetFine = "SELECT SUM(Fine_Amount) FROM Rental_Items " +
                                    "WHERE Rent_Id IN " +
                                        "(SELECT Rent_Id " +
                                        "FROM Rentals " +
                                        "WHERE Member_Id = " + memId + " AND " +
                                        "Rent_Date BETWEEN '" + start + "' AND '" + end + "')";


                OracleCommand cmd = new OracleCommand(sqlGetFine, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                float total;

                dr.Read();

                if (dr.IsDBNull(0))
                    total = 0;
                else
                {
                    total = dr.GetFloat(0);
                }

                conn.Close();

                return total;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }

        }

        public float GetTotalForPeriod(int memId, String start, String end)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlGetFine = "SELECT SUM(Rental_Price) FROM Rentals " +
                                    "WHERE Member_Id = " + memId + " AND " +
                                    "Rent_Date BETWEEN '" + start + "' AND '" + end + "'";


                OracleCommand cmd = new OracleCommand(sqlGetFine, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                float total;

                dr.Read();

                if (dr.IsDBNull(0))
                    total = 0;
                else
                {
                    total = dr.GetFloat(0);
                }

                conn.Close();

                return total;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }

        }

        public DataSet GetReturnedDVDsForPeriod(int memId, String start, String end)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT RI.DVD_Id, DVD_Title, Category_Id, TO_DATE(Return_Date) " +
                                  "FROM DVDs D JOIN Rental_Items RI ON D.DVD_Id = RI.DVD_Id " +
                                  "JOIN Rentals R ON R.Rent_Id = RI.Rent_Id " +
                                  "JOIN Members M ON M.Member_Id = R.Member_Id " +
                                  "WHERE R.Member_Id = " + memId + " " +
                                  "AND Rent_Date BETWEEN '" + start + "' AND '" + end + "' " +
                                  "AND Return_Date IS NOT NULL " +
                                  "ORDER BY DVD_Title";


                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "returned");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error retrieving data\n" + e.ToString());
                throw new Exception("Error connecting to database");
            }
        }

        public DataSet GetRentedDVDsForPeriod(int memId, String start, String end)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                String sqlQuery = "SELECT RI.DVD_Id, DVD_Title, Category_Id, Due_Date " +
                                  "FROM DVDs D JOIN Rental_Items RI ON D.DVD_Id = RI.DVD_Id " +
                                  "JOIN Rentals R ON R.Rent_Id = RI.Rent_Id " +
                                  "JOIN Members M ON M.Member_Id = R.Member_Id " +
                                  "WHERE R.Member_Id = " + memId + " " +
                                  "AND Rent_Date BETWEEN '" + start + "' AND '" + end + "' " +
                                  "AND Return_Date IS NULL " +
                                  "ORDER BY DVD_Title";


                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

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
    }
}
