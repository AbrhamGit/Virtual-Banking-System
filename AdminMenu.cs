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
    public partial class AdminMenu : Form
    {
        private SQLiteDataReader reader;
        SQLiteConnection connection;
        public AdminMenu(SQLiteDataReader reader)
        {
            InitializeComponent();
            string connectionPath = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(connectionPath);
            this.reader = reader;
            name.Text = reader["AdminUserName"].ToString();
            type.Text = reader["AdminType"].ToString();
            if (reader["AdminProfile"].ToString() != "none")
            {
                profile.ImageLocation = reader["AdminProfile"].ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CreditRequests WHERE RequestID=@id";
            try
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", (listBox1.SelectedIndex + 1).ToString());
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CreditResponse response = new CreditResponse(reader);
                            response.Show();
                        }
                    }
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

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            user.Visible = false;
            credit.Visible = true;
            string query = "SELECT * FROM CreditRequests;";
            try
            {
                connection.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        listBox1.Items.Add(data.Rows[i].ItemArray[1].ToString() + ": " + data.Rows[i].ItemArray[3].ToString());
                    }
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

        private void block_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Texts))
            {
                customeMessageBox box = new customeMessageBox("user name is empty!");
                box.Show();
            }
            else
            {
                string query = "UPDATE AccountStatus SET Account=@acc WHERE UserName=@name;";
                try
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@acc", "Blocked");
                        command.Parameters.AddWithValue("@name", nameBox.Texts);

                        int row = command.ExecuteNonQuery();
                        if (row > 0)
                        {
                        }
                        else
                        {
                            customeMessageBox message = new customeMessageBox("No such user name available");
                            message.Show();
                        }
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

        private void unblock_Click(object sender, EventArgs e)
        {
               if (string.IsNullOrEmpty(nameBox.Texts))
            {
                customeMessageBox box = new customeMessageBox("user name is empty!");
                box.Show();
            }
            else
            {
                string query = "UPDATE AccountStatus SET Account=@acc WHERE UserName=@name;";
                try
                {
                    connection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@acc", "Unblocked");
                        command.Parameters.AddWithValue("@name", nameBox.Texts);

                        int row = command.ExecuteNonQuery();
                        if (row > 0)
                        {
                        }
                        else
                        {
                            customeMessageBox message = new customeMessageBox("No such user name available");
                            message.Show();
                        }
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
}
