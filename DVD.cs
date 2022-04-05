using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;

namespace MovieSYS
{
    class DVD
    {
        private int dvdID;
        private String title;
        private String categoryCode;
        private String genreCode;
        private String countryCode;
        private String releaseYear;
        private int duration;
        private String dateAdded;
        private String ageCode;
        private String status;

        public DVD()
        {
            dvdID = 0;
            title = "";
            categoryCode = "";
            genreCode = "";
            countryCode = "";
            releaseYear = "";
            duration = 0;
            dateAdded = "";
            ageCode = "";
            status = "";
        }

        public DVD(int dvdID, string title, string categoryCode, string genreCode, string countryCode, string releaseYear, int duration, string dateAdded, string ageCode, string status)
        {
            this.dvdID = dvdID;
            this.title = title;
            this.categoryCode = categoryCode;
            this.genreCode = genreCode;
            this.countryCode = countryCode;
            this.releaseYear = releaseYear;
            this.duration = duration;
            this.dateAdded = dateAdded;
            this.ageCode = ageCode;
            this.status = status;
        }

        public int DvdID { get => dvdID; set => dvdID = value; }
        public string Title { get => title; set => title = value; }
        public string ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public int Duration { get => duration; set => duration = value; }
        public String DateAdded { get => dateAdded; set => dateAdded = value; }
        public string Status { get => status; set => status = value; }
        public string CategoryCode { get => categoryCode; set => categoryCode = value; }
        public string GenreCode { get => genreCode; set => genreCode = value; }
        public string CountryCode { get => countryCode; set => countryCode = value; }
        public string AgeCode { get => ageCode; set => ageCode = value; }

        public static int GetNextDVDID()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT MAX(DVD_Id) FROM DVDs";

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
            catch(Exception e)
            {
                Debug.WriteLine("Error updating Database\n" + e.ToString());
                throw new Exception("Failure retrieving data\n" + e.ToString());
            }
        }

        public void AddDVD()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO DVDs VALUES (" +
                    this.dvdID + ",'" +
                    this.title + "','" +
                    this.categoryCode + "','" +
                    this.genreCode + "','" +
                    this.countryCode + "','" +
                    this.releaseYear + "'," +
                    this.duration + ",'" +
                    this.dateAdded + "','" +
                    this.ageCode + "','" +
                    this.status + "')";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch(Exception e)
            {
                Debug.WriteLine("Error updating Database\n" + e.ToString());
                throw new Exception("Error updating Database");
            }
        }
        
        public static DataSet SearchDVD(String title)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT DVD_Id, DVD_Title, Category_Id " +
                                  "FROM DVDs " +
                                  "WHERE upper(DVD_Title) LIKE '%" + title + "%' AND Status = 'A' ORDER BY DVD_Id";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "search");

                conn.Close();

                return ds;
            }
            catch(Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
                throw new Exception("Data Set Result Error");
            }
        }

        //code very similar - resolve
        public void GetAllDvdDetails(int id)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT * FROM DVDs" +
                                   " WHERE DVD_Id = " + id + "";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                this.dvdID = dr.GetInt32(0);
                this.title = dr.GetString(1);
                this.categoryCode = dr.GetString(2);
                this.genreCode = dr.GetString(3);
                this.countryCode = dr.GetString(4);
                this.releaseYear = dr.GetString(5);
                this.duration = dr.GetInt32(6);
                this.dateAdded = dr.GetString(7);
                this.ageCode = dr.GetString(8);
                this.status = dr.GetString(9);

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

        public void GetPartialDvdDetails(String name)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT * FROM DVDs" +
                                   " WHERE upper(DVD_title) = '" + name + "'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                this.title = dr.GetString(1);
                this.categoryCode = dr.GetString(2);
                this.genreCode = dr.GetString(3);
                this.countryCode = dr.GetString(4);
                this.releaseYear = dr.GetString(5);
                this.duration = dr.GetInt32(6);
                this.ageCode = dr.GetString(8);

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

        public static void RemoveDVD(int id)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "UPDATE DVDs SET Status = 'D' " +
                                  "WHERE DVD_Id = '" + id + "'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

        public static int GetDvdCount(String name)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "SELECT COUNT(Dvd_title) " +
                                  "FROM DVDs " +
                                  "WHERE upper(DVD_Title) = '" + name + "' AND NOT Status = 'D'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                OracleDataReader dr = cmd.ExecuteReader();

                int count;

                dr.Read();

                if (dr.GetInt32(0) > 0)
                    count = dr.GetInt32(0);
                else
                    count = 0;
                
                conn.Close();

                return count;
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
                throw new Exception("Error retrieving data");
            }
        }

        public static void UpdateStatus(int id, string status)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "UPDATE DVDs SET Status = '" + status + "' " +
                                  "WHERE DVD_Id = '" + id + "'";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("An error has occured\n" + e.ToString());
            }
        }

    }
}
