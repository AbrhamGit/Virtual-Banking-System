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
    public partial class Admin : Form
    {
        SQLiteConnection connection;
        public Admin()
        {
            InitializeComponent(); 
            string connectionPath = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(connectionPath);
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userBox.Texts) && !string.IsNullOrEmpty(pswBox.Texts))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT * FROM VbsAmins WHERE AdminUserName=@name";
                    using (SQLiteCommand command = new SQLiteCommand(checkQuery, connection))
                    {
                        command.Parameters.AddWithValue("@name", userBox.Texts);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["AdminPasscode"].ToString() == pswBox.Texts)
                                {
                                    AdminMenu admin = new AdminMenu(reader);
                                    this.Hide();
                                    admin.Show();
                                }
                                else
                                {
                                    customeMessageBox notFound = new customeMessageBox("Incorrect Password!");
                                    notFound.Show();
                                }
                            }
                            else
                            {
                                customeMessageBox notFound = new customeMessageBox("Incorrect UserName!");
                                notFound.Show();
                            }
                        }
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
