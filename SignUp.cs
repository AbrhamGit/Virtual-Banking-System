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
    public partial class SignUp : Form
    {
        private SQLiteConnection connection;
        private bool isChanged = false;

        public SignUp()
        {
            InitializeComponent();
            string path = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(path);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void signUpbtn_Click(object sender, EventArgs e)
        {
            //string checkFirstName = "";
            //string checkMiddleName = "";
            //string checkLastName = "";
            //string checkPhoneNumber = "";
            //string checkAccountNumber = "";
            if (signUpbtn.Text == "Next")
            {
                if (!string.IsNullOrEmpty(fNBox.Texts) && !string.IsNullOrEmpty(mNBox.Texts) && !string.IsNullOrEmpty(lNBox.Texts) && !string.IsNullOrEmpty(accNumBox.Texts) && !string.IsNullOrEmpty(IDBox.Texts) && !string.IsNullOrEmpty(phNumBox.Texts) && !string.IsNullOrEmpty(pswBox.Texts) && !string.IsNullOrEmpty(psw2Box.Texts))
                {

                    try
                    {
                        connection.Open();
                        string selectQuery = "SELECT * FROM clients WHERE clientID=@clientID";
                        using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                        {
                            command.Parameters.AddWithValue("@clientID", IDBox.Texts);
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    if (reader["clientFirstName"].ToString() != fNBox.Texts.Trim())
                                    {
                                        customeMessageBox errorBox = new customeMessageBox("The First name and the ID are not of the same client. Please check again");
                                        errorBox.Show();

                                    }
                                    else if (reader["clientMiddleName"].ToString() != mNBox.Texts)
                                    {
                                        customeMessageBox errorBox = new customeMessageBox("The Middle name and the ID are not of the same client. Please check again");
                                        errorBox.Show();
                                    }
                                    else if (reader["clientLastName"].ToString() != lNBox.Texts)
                                    {
                                        customeMessageBox errorBox = new customeMessageBox("The Last name and the ID are not of the same client. Please check again");
                                        errorBox.Show();
                                    }
                                    else if (reader["clientPhoneNumber"].ToString() != phNumBox.Texts)
                                    {
                                        customeMessageBox errorBox = new customeMessageBox("The Phone number and the ID are not of the same client. Please check again");
                                        errorBox.Show();
                                    }
                                    else if (reader["accountNumber"].ToString() != accNumBox.Texts)
                                    {
                                        customeMessageBox errorBox = new customeMessageBox("The accountNumber and the ID are not of the same client. Please check again");
                                        errorBox.Show();
                                    }
                                    else
                                    {
                                        signUpbtn.Text = "Sign Up";
                                        profilePan.Visible = true;

                                    }
                                }
                                else
                                {
                                    customeMessageBox noData = new customeMessageBox("No such ID is available. Please try another ID");
                                    noData.Show();
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
                else
                {
                    if (string.IsNullOrEmpty(fNBox.Texts)) { fnLab.Visible = true; }
                    else { fnLab.Visible = false; }

                    if (string.IsNullOrEmpty(mNBox.Texts)) { mNLab.Visible = true; }
                    else { mNLab.Visible = false; }

                    if (string.IsNullOrEmpty(lNBox.Texts)) { lNLab.Visible = true; }
                    else { lNLab.Visible = false; }

                    if (string.IsNullOrEmpty(userBox.Texts)) { userLab.Visible = true; }
                    else { userLab.Visible = false; }

                    if (string.IsNullOrEmpty(IDBox.Texts)) { IDLab.Visible = true; }
                    else { IDLab.Visible = false; }

                    if (string.IsNullOrWhiteSpace(phNumBox.Texts)) { phoneLab.Visible = true; }
                    else { phoneLab.Visible = false; }

                    if (string.IsNullOrWhiteSpace(pswBox.Texts)) { pswLab.Visible = true; }
                    else { pswLab.Visible = false; }

                    if (string.IsNullOrWhiteSpace(psw2Box.Texts)) { psw2Lab.Visible = true; }
                    else { psw2Lab.Visible = false; }
                }
            }

            else
            {
                if (string.IsNullOrWhiteSpace(userBox.Texts))
                {
                    userLab.Text = "UserName can not be empty!";
                    userLab.Visible = true;
                }
                else
                {
                    try
                    {
                        connection.Open();
                        string selectQuery = "SELECT * FROM VBSUsers WHERE UserName=@userName;";
                        using (SQLiteCommand checkCommand = new SQLiteCommand(selectQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@userName", userBox.Texts);
                            using (SQLiteDataReader checkUser = checkCommand.ExecuteReader())
                            {
                                if (checkUser.Read())
                                {
                                    userLab.Text = "UserName already taken";
                                    userLab.Visible = true;
                                }
                                else
                                {
                                    checkUser.Close();
                                    string cash = extractCash(IDBox.Texts);
                                    string insertQuery = "INSERT INTO VBSUsers (FirstName, MiddleName, LastName, UserName, BankAccount, BankID, PhoneNumber, Password, Profile) VALUES(@firstName, @middleName, @lastName, @userName, @bankAccount, @bankID, @phoneNumber, @password,@profile)";
                                    string insert2Query = "INSERT INTO AccountStatus (UserName, Account) VALUES(@name, @acc);";
                                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                                    {
                                        insertCommand.Parameters.AddWithValue("@firstName", fNBox.Texts);
                                        insertCommand.Parameters.AddWithValue("@middleName", mNBox.Texts);
                                        insertCommand.Parameters.AddWithValue("@lastName", lNBox.Texts);
                                        insertCommand.Parameters.AddWithValue("@userName", userBox.Texts);
                                        insertCommand.Parameters.AddWithValue("@bankAccount", accNumBox.Texts);
                                        insertCommand.Parameters.AddWithValue("@bankID", IDBox.Texts);
                                        insertCommand.Parameters.AddWithValue("@phoneNumber", phNumBox.Texts);
                                        insertCommand.Parameters.AddWithValue("@password", pswBox.Texts);
                                        if (!skip.Checked)
                                        {
                                            if (isChanged)
                                            {
                                                insertCommand.Parameters.AddWithValue("@profile", openFileDialog1.FileName);
                                                insertCommand.ExecuteNonQuery();

                                                this.Hide();
                                                Home home = new Home(fNBox.Texts, mNBox.Texts, lNBox.Texts, userBox.Texts, IDBox.Texts, phNumBox.Texts, pswBox.Texts, cash, openFileDialog1.FileName);
                                                home.Show();

                                            }
                                            else
                                            {
                                                insertCommand.Parameters.AddWithValue("@profile", "none");
                                                insertCommand.ExecuteNonQuery();
                                                this.Hide();
                                                Home home = new Home(fNBox.Texts, mNBox.Texts, lNBox.Texts, userBox.Texts, IDBox.Texts, phNumBox.Texts, pswBox.Texts, cash);
                                                home.Show();
                                            }
                                        }
                                        else
                                        {
                                            insertCommand.Parameters.AddWithValue("@profile", "none");

                                            insertCommand.ExecuteNonQuery();
                                            this.Hide();
                                            Home home = new Home(fNBox.Texts, mNBox.Texts, lNBox.Texts, userBox.Texts, IDBox.Texts, phNumBox.Texts, pswBox.Texts, cash);
                                            home.Show();
                                        }
                                        using (SQLiteCommand command = new SQLiteCommand(insert2Query, connection))
                                        {
                                            command.Parameters.AddWithValue("@name", userBox.Texts);
                                            command.Parameters.AddWithValue("@acc", "Unblocked");
                                            command.ExecuteNonQuery();
                                        }

                                        string insertHistory = "INSERT INTO TransactionHistory (BankID, Date, TransactionType, Amount) VALUES(@bankID, @date, @transactionType, @amount);";
                                        using(SQLiteCommand histCommand = new SQLiteCommand(insertHistory,connection))
                                        {
                                            histCommand.Parameters.AddWithValue("@bankID", IDBox.Texts);
                                            histCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                                            histCommand.Parameters.AddWithValue("@transactionType", "Account Creation");
                                            histCommand.Parameters.AddWithValue("@amount","none");
                                            histCommand.ExecuteNonQuery();
                                        }


                                    }
                                }
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        customeMessageBox exception = new customeMessageBox(ex.Message);
                        exception.Show();
                    }
                    finally
                    {
                        connection.Close();

                    }
                }
            }
             
        }

        private string extractCash(string ID)
        {
            string selectCash = "SELECT * FROM clients WHERE clientID=@id";
            using (SQLiteCommand command = new SQLiteCommand(selectCash, connection))
            {
                command.Parameters.AddWithValue("@id", ID);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["clientCash"].ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void custome_PictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files(*.*)|*.*| jpg files(*.jpg|*.jpg| PNG files(*.png)|*.png)";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            profilePic.ImageLocation = openFileDialog1.FileName;
            isChanged = true;

        }
             

    }
}
