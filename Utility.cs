using IronPdf;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;

namespace MovieSYS
{
    class Utility
    {
        public static string SetGenre(string genre)
        {
            if (!genre.Substring(0).Equals('G'))
                return genre.Substring(0, 2);
            else
                return genre.Substring(0, 1) + " ";
        }

        public static DataSet GetMembershipCodes()
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                string sqlQuery = "SELECT * FROM Memberships ORDER BY Membership_Id";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);

                OracleDataAdapter da = new OracleDataAdapter(cmd);

                DataSet ds = new DataSet();

                da.Fill(ds, "membership");

                conn.Close();

                return ds;
            }
            catch (Exception e)
            {
                Debug.WriteLine("There was an error saving file :" + e.ToString());
                throw new Exception("Failure saving file\n" + e.ToString());
            }
        }

        public static DataSet GetCountryCodes()
        {
            try
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
            catch (Exception e)
            {
                Debug.WriteLine("There was an error saving file :" + e.ToString());
                throw new Exception("Failure saving file\n" + e.ToString());
            }
        }

        public static DataSet GetCategoryCodes()
        {
            try
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
            catch (Exception e)
            {
                Debug.WriteLine("There was an error saving file :" + e.ToString());
                throw new Exception("Failure saving file\n" + e.ToString());
            }
        }

        public static DataSet GetGenreCodes()
        {
            try
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
            catch (Exception e)
            {
                Debug.WriteLine("There was an error saving file :" + e.ToString());
                throw new Exception("Failure saving file\n" + e.ToString());
            }
        }

        public static DataSet GetAgeCodes()
        {
            try
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
            catch (Exception e)
            {
                Debug.WriteLine("There was an error saving file :" + e.ToString());
                throw new Exception("Failure saving file\n" + e.ToString());
            }
        }

        public static void SavePdf(String msg)
        {
            /*https://www.c-sharpcorner.com/article/how-to-create-pdf-file-in-c-sharp-using-ironpdf/*/

            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"D:\";
                saveFileDialog1.Title = "Save Pdf File";
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog1.FileName;

                    var HtmlLine = new HtmlToPdf();
                    HtmlLine.RenderHtmlAsPdf(msg).SaveAs(filename);

                    MessageBox.Show("File Saved Successfully!");
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("There was an error saving file :" + e.ToString());
            }
        }

        public static void EmailReceipt(String msg)
        {
            /*https://stackoverflow.com/questions/71652020/system-net-mail-smtpexception-the-smtp-server-requires-a-secure-connection-or*/

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("movierentals2020@gmail.com");
                mail.To.Add("Deirdre.Lee@students.ittralee.ie"); //member email would go here
                mail.Subject = "Welcome to Movie Rental!";
                mail.Body = msg;

                SmtpClient smtp = new SmtpClient
                {
                    UseDefaultCredentials = false
                };
                NetworkCredential credentials = new NetworkCredential("movierentals2020@gmail.com", "netflixandchill");
                smtp.Credentials = credentials;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.Send(mail);
            }
            catch (Exception e)
            {
                Debug.WriteLine("There was an error sending email : " + e.ToString());
            }
        }

        public static void PrintPDFWithAcrobat()
        {
            /*https://ourcodeworld.com/articles/read/502/how-to-print-a-pdf-from-your-winforms-application-in-c-sharp*/
            /*https://stackoverflow.com/questions/11624298/how-do-i-use-openfiledialog-to-select-a-folder*/

            try
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                folderBrowser.FileName = "Folder Selection.";

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(folderBrowser.FileName);

                    using PrintDialog Dialog = new PrintDialog();
                    Dialog.ShowDialog();

                    ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                    {
                        Verb = "print",
                        CreateNoWindow = true,
                        FileName = folderPath,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process printProcess = new Process
                    {
                        StartInfo = printProcessInfo
                    };
                    try
                    {
                        printProcess.Start();
                        MessageBox.Show("File Sent to Printer!");

                        printProcess.WaitForInputIdle();

                        Thread.Sleep(3000);

                        if (false == printProcess.CloseMainWindow())
                        {
                            printProcess.Kill();
                        }
                    }
                    catch (Exception e) {
                        Debug.WriteLine("There was an error printing" + e.ToString());
                    }
                }

                
            }
            catch(IOException ioe)
            {
                Debug.WriteLine("There was an error saving file :" + ioe.ToString());
            }
        }
    }
}
