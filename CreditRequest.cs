using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;


namespace VBS
{
    public partial class CreditRequest : Form
    {
        Home home;
        private string BankID { get; set; }
        SQLiteConnection connection;

        public CreditRequest(Home home, string BankID)
        {
            InitializeComponent();
            this.home = home;
            this.BankID = BankID;
            string connectionPath = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(connectionPath);
        }

        private void CreditRequest_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(employment.Texts) && !string.IsNullOrEmpty(GMI.Texts) && !string.IsNullOrEmpty(reason.Texts) && !string.IsNullOrEmpty(amount.Texts) && !string.IsNullOrEmpty(employment.Texts) && !string.IsNullOrEmpty(empTime.Texts))
            {
                int num;
                if (!Regex.IsMatch(amount.Texts, @"[0-9]+"))
                {
                    customeMessageBox message = new customeMessageBox("Please Type in a number");
                    message.Show();
                }
                else
                {
                    if (!Regex.IsMatch(GMI.Texts, @"[0-9]+"))
                    {
                        customeMessageBox message = new customeMessageBox("Please Type in a number");
                        message.Show();
                    }
                    else
                    {
                        if (!Regex.IsMatch(empTime.Texts, @"[0-9]+"))
                        {
                            customeMessageBox message = new customeMessageBox("Please Type in a number");
                            message.Show();
                        }
                        else
                        {
                            string creditQuery = "INSERT INTO CreditRequests (RequestID,BankID,Reason,Amount,AnythingElse,Salary,Employment,JobYear) VALUES(@RId,@ID,@reason,@amount,@aElse,@salary,@job,@year);";
                            try
                            {
                                connection.Open();
                                using (SQLiteCommand command = new SQLiteCommand(creditQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@RId", rID());
                                    command.Parameters.AddWithValue("ID", BankID);
                                    command.Parameters.AddWithValue("@reason", reason.Texts);
                                    command.Parameters.AddWithValue("@amount", amount.Texts);
                                    command.Parameters.AddWithValue("@aElse", any.Texts);
                                    command.Parameters.AddWithValue("@salary", GMI.Texts);
                                    command.Parameters.AddWithValue("@job", employment.Texts);
                                    command.Parameters.AddWithValue("@year", empTime.Texts);
                                    command.ExecuteNonQuery();
                                    customeMessageBox success = new customeMessageBox("Request has been submitted. Response will be submitted once the decision has been made.");
                                    success.Show();
                                }
                            }
                            catch (Exception ex)
                            {
                                customeMessageBox error = new customeMessageBox(ex.Message);
                                error.Show();
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty(amount.Texts))
                {
                    amountLab.Visible = true;
                }
                else
                {
                    amountLab.Visible = false;
                }
                if (string.IsNullOrEmpty(reason.Texts))
                {
                    reasonLab.Visible = true;
                }
                else
                {
                    reasonLab.Visible = false;
                }
                if (string.IsNullOrEmpty(GMI.Texts))
                {
                    GMILab.Visible = true;
                }
                else
                {
                    GMILab.Visible = false;
                }
                if (string.IsNullOrEmpty(employment.Texts))
                {
                    employmentLab.Visible = true;
                }
                else
                {
                    employmentLab.Visible = false;
                }
            }
        }

        private string rID()
        {
            string query = "SELECT * FROM CreditRequests; ";

            using (SQLiteDataAdapter reader = new SQLiteDataAdapter(query, connection))
            {
                DataTable t = new DataTable();
                reader.Fill(t);
                return (t.Rows.Count + 1).ToString();
            }

        }
    }
}
