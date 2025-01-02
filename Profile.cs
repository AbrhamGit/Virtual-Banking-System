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
    public partial class Profile : Form
    {

        private string iconPath = "C:/Users/Nathnael/Desktop/My stuff/School Stuff/Projects/C#/FinalProject/Icons/";
        private bool DarkMode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        private Home home;
        private bool profileChanged=false;
        private SQLiteConnection connection;

        public Profile(Home home, string userName, string password)
        {
            InitializeComponent();
            this.home = home;
            UserName = userName;
            Password = password;
            string connectionPath = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(connectionPath);
        }

        private void custome_button7_Click(object sender, EventArgs e)
        {

        }

        private void custome_button7_MouseHover(object sender, EventArgs e)
        {
            logOutbtn.BackColor = Color.White;
            logOutbtn.ForeColor = Color.FromArgb(40, 0, 20);
            logOutbtn.BorderBtnColor = Color.FromArgb(40, 0, 20);
            logOutbtn.BorderSize = 2;
        }

        private void custome_button7_MouseLeave(object sender, EventArgs e)
        {
            logOutbtn.BackColor = Color.FromArgb(40, 0, 20);
            logOutbtn.ForeColor = Color.White;
            logOutbtn.BorderBtnColor = Color.White;
            logOutbtn.BorderSize = 2;
        }

        private void darkLightbtn_Click(object sender, EventArgs e)
        {
            if (!DarkMode)
            {
                darkLightbtn.ImageLocation = iconPath + "sun.png";
                DarkMode = true;
            }
            else
            {
                darkLightbtn.ImageLocation = iconPath + "moon.png";
                DarkMode = false;
            }
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void profBtn_Click(object sender, EventArgs e)
        {
            changeProfile.Visible = true;
            changePanel.Visible = false;
            logOutbtn.Visible = false;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void saveProfile_Click(object sender, EventArgs e)
        {
            if (profileChanged)
            {
                changeProfile.Visible = false;
                changePanel.Visible = true;
                userPic.ImageLocation = openFileDialog1.FileName;
                string updateImageQuery = "UPDATE VBSUsers SET Profile=@profile WHERE Password=@password;";
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(updateImageQuery, connection))
                {
                    command.Parameters.AddWithValue("@profile", userPic.ImageLocation);
                    command.Parameters.AddWithValue("@password", Password);
                    command.ExecuteNonQuery();
                }

                profileChanged = false;
            }
        }

        private void searchProfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files(*.*)|*.*| jpg files(*.jpg|*.jpg| PNG files(*.png)|*.png)";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            searchProfile.ImageLocation = openFileDialog1.FileName;
            profileChanged = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            home.Show();
            home.saveChanges(openFileDialog1.FileName);
            this.Close();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
           
            if( MessageBox.Show("Are You sure you want to delete your account. All you histories and transactions will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                try
                {
                    connection.Open();
                    string query="DELETE FROM VBSUsers WHERE UserName=@name;";
                    using(SQLiteCommand command= new SQLiteCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@name",UserName);
                        command.ExecuteNonQuery();
                    }
                    string query2 = "DELETE FROM AccountStatus WHERE UserName=@name;";
                    using (SQLiteCommand command = new SQLiteCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@name", UserName);
                        command.ExecuteNonQuery();
                    }
                    home.Close();
                    this.Close();
                    Application.Exit();
                }
                catch(Exception ex)
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
