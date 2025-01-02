using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace VBS
{
    public partial class CreditResponse : Form
    {
        SQLiteConnection connection;
        SQLiteDataReader reader;
        string requestID;
        public CreditResponse(SQLiteDataReader reader)
        {
            InitializeComponent();
            string connectionPath = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(connectionPath);
            this.reader = reader;
            amount.Text = reader["Amount"].ToString();
            reason.Text = reader["Reason"].ToString();
            employ.Text = reader["Employment"].ToString();
            info.Text = reader["AnythingElse"].ToString();
            balance.Text = extractCash(reader["BankID"].ToString());
            userName.Text = extractName(reader["BankID"].ToString());
            bankID.Text = reader["BankID"].ToString();
            requestID = reader["RequestID"].ToString();
        }

        private string extractCash(string ID)
        {
            string selectCash = "SELECT * FROM clients WHERE clientID=@id";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand(selectCash, connection))
            {

                command.Parameters.AddWithValue("@id", ID);
                using (SQLiteDataReader reader2 = command.ExecuteReader())
                {

                    if (reader2.Read())
                    {

                        return reader2["clientCash"].ToString();

                    }
                    else
                    {
                        return "";
                    }
                }
            }

        }

        private string extractName(string ID)
        {
            string selectCash = "SELECT * FROM VBSUsers WHERE BankID=@id";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand(selectCash, connection))
            {

                command.Parameters.AddWithValue("@id", ID);
                using (SQLiteDataReader reader2 = command.ExecuteReader())
                {

                    if (reader2.Read())
                    {

                        return reader2["UserName"].ToString();

                    }
                    else
                    {
                        return "";
                    }
                }
            }

        }

        private void CreditResponse_Load(object sender, EventArgs e)
        {

        }

        private void approve_Click(object sender, EventArgs e)
        {
            double cash = double.Parse(amount.Text);
            double balanceD = double.Parse(balance.Text);
            balanceD += cash;
            double newCash = (cash) + (cash * 0.07);
            double time= newCash/15000;
            string query = "UPDATE clients SET clientCash=@cash WHERE clientID=@id;";
            string his = "INSERT INTO CreditHistory (BankID, Amount, Date, Response) VALUES(@id, @money, @date, @response);";
            string del = "DELETE FROM CreditRequests WHERE RequestID=@id;";
            string newCredit = "INSERT INTO Credits (BankID, MoneyLeft, Time) VALUES(@id, @money, @time);";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cash", balanceD.ToString());
                    command.Parameters.AddWithValue("@id", bankID.Text);
                    command.ExecuteNonQuery();
                }
                using (SQLiteCommand command = new SQLiteCommand(his, connection))
                {
                    command.Parameters.AddWithValue("@money", cash.ToString());
                    command.Parameters.AddWithValue("@id", bankID.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@response", "Approved");
                    command.ExecuteNonQuery();

                  
                }

                
                using (SQLiteCommand command3 = new SQLiteCommand(del, connection))
                {
                    command3.Parameters.AddWithValue("@id", requestID);
                    command3.ExecuteNonQuery();
                }

                using (SQLiteCommand command = new SQLiteCommand(newCredit, connection))
                {
                    command.Parameters.AddWithValue("@id", bankID.Text);
                    command.Parameters.AddWithValue("@time", time.ToString());
                    command.Parameters.AddWithValue("@money", newCash.ToString());
                    command.ExecuteNonQuery();
                }
                string debting = "UPDATE DebtStatus SET Debt=@debt WHERE BankID=@id;";
                using (SQLiteCommand command = new SQLiteCommand(debting, connection))
                {
                    command.Parameters.AddWithValue("@debt", "OnDebt");
                    command.Parameters.AddWithValue("@id", bankID.Text);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void deny_Click(object sender, EventArgs e)
        {
            string his = "INSERT INTO CreditHistory (BankID, Amount, Date, Response) VALUES(@id, @money, @date, @response);";
            string del = "DELETE FROM CreditRequests WHERE RequestID=@id;";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SQLiteCommand command = new SQLiteCommand(his, connection))
                {
                    command.Parameters.AddWithValue("@money", amount.Text);
                    command.Parameters.AddWithValue("@id", bankID.Text);
                    command.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    command.Parameters.AddWithValue("@response", "Declined");
                    command.ExecuteNonQuery();
                }
                using (SQLiteCommand command = new SQLiteCommand(del, connection))
                {
                    command.Parameters.AddWithValue("@id", reader["RequestID"].ToString());
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
