using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace VBS
{
    public partial class Home : Form
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BankAccount { get; set; }
        public string BankID { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Balance { get; set; }

        public string RecieverID;

        Point oldDstv;
        Point oldCanal;

        private string iconPath = "C:/Users/Nathnael/Desktop/My stuff/School Stuff/Projects/C#/FinalProject/Icons/";
        private bool alreadyOpen = false;
        public bool DarkMode { get; set; }
        private bool swipedOut = true;

        SQLiteConnection connection;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));

        System.Windows.Forms.Panel hist = new System.Windows.Forms.Panel();
        System.Windows.Forms.Label histTitle = new System.Windows.Forms.Label();
        System.Windows.Forms.Label histMoney = new System.Windows.Forms.Label();
        System.Windows.Forms.Label histDate = new System.Windows.Forms.Label();
        System.Windows.Forms.Label histTime = new System.Windows.Forms.Label();
        System.Windows.Forms.Label hist1Line = new System.Windows.Forms.Label();
        System.Windows.Forms.Label hist2Line = new System.Windows.Forms.Label();

        public Home()
        {
            InitializeComponent();
            string connectionPath = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(connectionPath);
            oldDstv = dstPan.Location;
            oldCanal = canPan.Location;
        }

        public Home(string firstName, string middleName, string lastName, string bankAccount, string bankID, string phoneNumber, string password, string balance)
        {
            InitializeComponent();
            string connectionPath = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(connectionPath);
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.BankAccount = bankAccount;
            this.BankID = bankID;
            this.PhoneNumber = phoneNumber;
            this.Password = password;
            this.Balance = balance;
            userName.Text = FirstName;
            accountNum.Text = BankAccount;
            balanceLabel.Text = Balance;
            userPanel.Visible = true;
            navigationBar.Visible = true;
            signPanel.Visible = false;

        }

        public Home(string firstName, string middleName, string lastName, string bankAccount, string bankID, string phoneNumber, string password, string balance, string profile)
        {
            InitializeComponent();
            string connectionPath = @"Data Source=C:\Users\Nathnael\Desktop\My Stuff\School Stuff\Projects\C#\FinalProject\database\bankclients.db; version=3;";
            connection = new SQLiteConnection(connectionPath);
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.BankAccount = bankAccount;
            this.BankID = bankID;
            this.PhoneNumber = phoneNumber;
            this.Password = password;
            this.Balance = balance;
            userProfile.ImageLocation = profile;
            userName.Text = FirstName;
            accountNum.Text = BankAccount;
            balanceLabel.Text = Balance;
            userPanel.Visible = true;
            navigationBar.Visible = true;
            signPanel.Visible = false;

        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(accBox.Texts) && !string.IsNullOrWhiteSpace(pswBox.Texts))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM VBSUsers WHERE BankAccount=@bankAccount;";
                    using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bankAccount", accBox.Texts);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                if (reader["Password"].ToString() != pswBox.Texts)
                                {
                                    pswLab.Text = "Incorrect Password";
                                    pswLab.Visible = true;
                                }
                                else
                                {
                                    string query = "SELECT * FROM AccountStatus WHERE UserName=@name ;";
                                    using (SQLiteCommand bCommand = new SQLiteCommand(query, connection))
                                    {
                                        bCommand.Parameters.AddWithValue("@name", reader["UserName"].ToString());
                                        using (SQLiteDataReader blockReader = bCommand.ExecuteReader())
                                        {
                                            if (blockReader.Read())
                                            {
                                                if (blockReader["Account"].ToString() == "Blocked")
                                                {
                                                    customeMessageBox blocked = new customeMessageBox("Your account has been blocked");
                                                    blocked.Show();
                                                }
                                                else
                                                {
                                                    Password = reader["Password"].ToString();
                                                    userName.Text = reader["UserName"].ToString();
                                                    FirstName = reader["FirstName"].ToString();
                                                    MiddleName = reader["MiddleName"].ToString();
                                                    LastName = reader["LastName"].ToString();
                                                    BankAccount = reader["BankAccount"].ToString();
                                                    BankID = reader["BankID"].ToString();
                                                    balanceLabel.Text = extractCash(BankID);

                                                    userProfile.ImageLocation = reader["Profile"].ToString();
                                                    accountNum.Text = BankAccount;
                                                    signPanel.Visible = false;
                                                    navigationBar.Visible = true;
                                                    userPanel.Visible = true;
                                                    homePanel.Visible = true;
                                                }
                                            }
                                        }
                                    }
                                    
                                }
                            }
                            else
                            {
                                customeMessageBox noData = new customeMessageBox("There is no such bank account sign up!");
                                noData.Show();
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
            else
            {

                if (string.IsNullOrWhiteSpace(accBox.Texts)) { acNumLab.Text = "Account Number is required to proceed"; acNumLab.Visible = true; }
                else { acNumLab.Visible = false; }

                if (string.IsNullOrWhiteSpace(pswBox.Texts)) { pswLab.Text = "Password is required to proceed"; pswLab.Visible = true; }
                else { pswLab.Visible = false; }
            }

            //int value1 = histTitle1.Location.Y-hist1.Location.Y;
            //int value2 = hist1Line1.Location.Y - hist1.Location.Y;
            //int value3 = histMoney1.Location.Y - hist1.Location.Y;
            //int value4 = hist2Line1.Location.Y - hist1.Location.Y;
            //int value5 = histDate1.Location.Y - hist1.Location.Y;

            //MessageBox.Show(value1.ToString() + " " + value2.ToString() + " " + value3.ToString() + " " + value4.ToString() + " " + value5.ToString(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //MessageBox.Show(histPanel.Controls.Count.ToString(), "", MessageBoxButtons.OK);
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

        private string extractAccount(string ID)
        {
            string selectCash = "SELECT * FROM clients WHERE clientID=@id";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SQLiteCommand command = new SQLiteCommand(selectCash, connection))
            {

                command.Parameters.AddWithValue("@id", ID);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {

                        return reader["accountNumber"].ToString();

                    }
                    else
                    {
                        return "";
                    }
                }
            }

        }

        private void allNormal()
        {
            homePic.ImageLocation = iconPath + "home.jpg";
            checkPic.ImageLocation = iconPath + "dollar.jpg";
            moneyPic.ImageLocation = iconPath + "handDollar.jpg";
            billPic.ImageLocation = iconPath + "moneyBill.jpg";
            creditPic.ImageLocation = iconPath + "listCheck2.jpg";
            histPic.ImageLocation = iconPath + "clockLeft.jpg";
            homeBtn.BackColor = Color.FromArgb(0, 0, 30);
            checkBtn.BackColor = Color.FromArgb(0, 0, 30);
            moneyBtn.BackColor = Color.FromArgb(0, 0, 30);
            billBtn.BackColor = Color.FromArgb(0, 0, 30);
            creditBtn.BackColor = Color.FromArgb(0, 0, 30);
            histBtn.BackColor = Color.FromArgb(0, 0, 30);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            userPanel.Visible = false;
            navigationBar.Visible = false;
            histPanel.Visible = false;
            homePanel.Visible = false;
            creditPanel.Visible = false;
            billPanel.Visible = false;
            accBox.Texts = "";
            pswBox.Texts = "";
            signPanel.Visible = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!alreadyOpen)
            {
                Profile profile = new Profile(this,userName.Text,Password);
                profile.Show();
                this.Hide(); 
                alreadyOpen = true;
            }
            else
            {
                MessageBox.Show("Profile page is already open", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            allNormal();
            checkBtn.BackColor = Color.FromArgb(40, 0, 20);
            checkPic.ImageLocation = iconPath + "focusDollar.jpg";
            histPanel.Visible = false;
            billPanel.Visible = false;
            balanceLabel.Visible = true;
            moneyPanel.Visible = false;
            creditPanel.Visible = false;
        }

        private void moneyBtn_Click(object sender, EventArgs e)
        {
            allNormal();
            moneyBtn.BackColor = Color.FromArgb(40, 0, 20);
            moneyPic.ImageLocation = iconPath + "focusHandDollar.jpg";
            creditPanel.Visible = false;
            histPanel.Visible = false;
            billPanel.Visible = false;
            balanceLabel.Visible = false;
            homePanel.Visible = false;
            moneyPanel.Visible = true;
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            allNormal();
            billBtn.BackColor = Color.FromArgb(40, 0, 20);
            billPic.ImageLocation = iconPath + "focusMoneyBill.jpg";
            histPanel.Visible = false;
            billPanel.Visible = true;
            balanceLabel.Visible = false;
            homePanel.Visible = false;
            moneyPanel.Visible = false;
            creditPanel.Visible = false;
        }

        private void creditBtn_Click(object sender, EventArgs e)
        {
            allNormal();
            creditBtn.BackColor = Color.FromArgb(40, 0, 20);
            creditPic.ImageLocation = iconPath + "focusListCheck.jpg";
            histPanel.Visible = false;
            billPanel.Visible = false;
            creditPanel.Visible = true;
            balanceLabel.Visible = false;
            homePanel.Visible = false;
            moneyPanel.Visible = false;
        }

        private void histBtn_Click(object sender, EventArgs e)
        {
            allNormal();
            histBtn.BackColor = Color.FromArgb(40, 0, 20);
            histPic.ImageLocation = iconPath + "focusClockLeft.jpg";
            histPanel.Visible = true;
            billPanel.Visible = false;
            balanceLabel.Visible = false;
            homePanel.Visible = false;
            moneyPanel.Visible = false;
            creditPanel.Visible = false;
            MessageBox.Show(histPanel.Controls.Count.ToString());
            for (int i = 0; i < histPanel.Controls.Count; i++)
            {
                histPanel.Controls.RemoveAt(i);
            }
            createHistory(1);
        }

        public void createHistory(int type)
        {
            
            string query1 = "SELECT * FROM Transactions WHERE FromID = '"+BankID+ "' OR "+ " ToID= '"+BankID+"';";
            string query2 = "SELECT * FROM TransactionHistory WHERE BankID = '"+BankID+"';";
            string query4 = "SELECT * FROM CreditHistory WHERE BankID = '" + BankID + "';";
            string query3 = "SELECT * FROM BillTransactions WHERE BankID = '"+BankID+"';";
            string query = "";
            if (type == 1)
            {
                query = query1;
            }
            else if (type == 3)
            {
                query = query3;
            }
            else
            {
                query=query4;
            }

            
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
            {
                DataTable histories = new DataTable();
                adapter.Fill(histories);
                for (int i = 0; i < histories.Rows.Count; i++)
                {
                    System.Windows.Forms.Panel hist2 = new System.Windows.Forms.Panel();
                    System.Windows.Forms.Label histTitle2 = new System.Windows.Forms.Label();
                    System.Windows.Forms.Label histMoney2 = new System.Windows.Forms.Label();
                    System.Windows.Forms.Label histDate2 = new System.Windows.Forms.Label();
                    System.Windows.Forms.Label histTime2 = new System.Windows.Forms.Label();
                    System.Windows.Forms.Label hist1Line2 = new System.Windows.Forms.Label();
                    System.Windows.Forms.Label hist2Line2 = new System.Windows.Forms.Label();

                    histTitle2.AutoSize = true;
                    histTitle2.Location = new System.Drawing.Point(histTitle1.Location.X, hist2.Location.Y + 8);
                    histTitle2.Size = histTitle1.Size;
                    histTitle2.Font = histTitle1.Font;
                    histTitle2.Text = "qwsdas";
                    histTitle2.TabIndex = 0;
                    histTitle2.Name = "histTitle" + (histPanel.Controls.Count - 1).ToString();


                    hist1Line2.AutoSize = true;
                    hist1Line2.Size = hist1Line1.Size;
                    hist1Line2.ForeColor = hist1Line1.ForeColor;
                    hist1Line2.Text = hist1Line1.Text;
                    hist1Line2.Location = new System.Drawing.Point(hist1Line1.Location.X, hist2.Location.Y + 11);
                    hist1Line2.TabIndex = 1;
                    hist1Line2.Name = "hist1Line" + (histPanel.Controls.Count - 1).ToString();

                    histMoney2.AutoSize = true;
                    histMoney2.Size = histMoney1.Size;
                    histMoney2.Font = histMoney1.Font;
                    histMoney2.Text = histMoney1.Text;
                    histMoney2.Location = new System.Drawing.Point(histMoney1.Location.X, hist2.Location.Y + 30);
                    histMoney2.TabIndex = 2;
                    histMoney2.Name = "histMoney" + (histPanel.Controls.Count - 1).ToString();

                    hist2Line2.AutoSize = true;
                    hist2Line2.Size = hist2Line1.Size;
                    hist2Line2.ForeColor = hist2Line1.ForeColor;
                    hist2Line2.Text = hist2Line1.Text;
                    hist2Line2.Location = new System.Drawing.Point(hist2Line1.Location.X, hist2.Location.Y + 50);
                    hist2Line2.TabIndex = 3;
                    hist2Line2.Name = "hist2Line" + (histPanel.Controls.Count - 1).ToString();

                    histDate2.AutoSize = true;
                    histDate2.Size = histDate1.Size;
                    histDate2.Font = histDate1.Font;
                    histDate2.Text = histDate1.Text;
                    histDate2.Location = new System.Drawing.Point(histDate1.Location.X, hist2.Location.Y + 68);
                    histDate2.TabIndex = 4;
                    histDate2.Name = "histDate" + (histPanel.Controls.Count - 1).ToString();

                    histTime2.AutoSize = true;
                    histTime2.Size = histTime1.Size;
                    histTime2.Font = histTime1.Font;
                    histTime2.Text = histTime1.Text;
                    histTime2.Location = new System.Drawing.Point(histTime1.Location.X, hist2.Location.Y + 68);
                    histTime2.TabIndex = 5;
                    histTime2.Name = "histTime" + (histPanel.Controls.Count - 1).ToString();

                    histPanel.Controls.Add(hist2);
                    hist2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hist1.BackgroundImage")));
                    hist2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    hist2.Controls.Add(histTitle2);
                    hist2.Controls.Add(hist1Line2);
                    hist2.Controls.Add(histMoney2);
                    hist2.Controls.Add(hist2Line2);
                    hist2.Controls.Add(histDate2);
                    hist2.Controls.Add(histTime2);
                    Control current = hist1;

                    foreach (Control c in histPanel.Controls)
                    {
                        if (c.Name == "hist" + (histPanel.Controls.Count - 2).ToString())
                        {
                            current = c;
                            break;
                        }
                    }

                    // MessageBox.Show(current.Name, "er", MessageBoxButtons.OK);

                    hist2.Location = new System.Drawing.Point(hist1.Location.X, current.Location.Y + hist1.Height + 1);
                    hist2.Size = hist1.Size;
                    hist2.TabIndex = 0;
                    hist2.Name = "hist" + (histPanel.Controls.Count - 1).ToString();
                    if (type == 1)
                    {
                        if (histories.Rows[i].ItemArray[1].ToString() == BankID)
                        {
                            if (histories.Rows[i].ItemArray[4].ToString() == "Sent")
                            {
                                histTitle2.Text = "Sent";
                                histTime2.Text = "To: " + extractAccount(histories.Rows[i].ItemArray[2].ToString());
                                histDate2.Text = histories.Rows[i].ItemArray[5].ToString();
                                histMoney2.Text = histories.Rows[i].ItemArray[3].ToString();

                            }
                            else
                            {
                                histPanel.Controls.Remove(hist2);
                            }


                        }
                        else
                        {
                            if (histories.Rows[i].ItemArray[4].ToString() == "recieved")
                            {
                                histTitle2.Text = "Recieve";
                                histTime2.Text = "From: " + histories.Rows[i].ItemArray[1].ToString();
                                histDate2.Text = histories.Rows[i].ItemArray[5].ToString();
                                histMoney2.Text = histories.Rows[i].ItemArray[3].ToString();
                            }
                            else
                            {
                                histPanel.Controls.Remove(hist2);
                            }
                        }

                    }
                    else if (type == 3)
                    {
                        histTitle2.Text = "Bill Payment";
                        histTime2.Text = "To: " + extractAccount(histories.Rows[i].ItemArray[2].ToString());
                        histDate2.Text = histories.Rows[i].ItemArray[4].ToString();
                        histMoney2.Text = histories.Rows[i].ItemArray[3].ToString();
                    }
                    else
                    {
                        histTitle2.Text = "Credit";
                        histTime2.Text = histories.Rows[i].ItemArray[3].ToString();
                        histDate2.Text=histories.Rows[i].ItemArray[2].ToString();
                        histMoney2.Text = histories.Rows[i].ItemArray[1].ToString();
                    }
                }
            }
            
        }



        private int transactionNum()
        {
            string query = "Select * from Transactions;";
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table.Rows.Count;
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            allNormal();
            homeBtn.BackColor = Color.FromArgb(40, 0, 20);
            homePic.ImageLocation = iconPath + "focusHome.jpg";
            histPanel.Visible = false;
            billPanel.Visible = false;
            balanceLabel.Visible = false;
            homePanel.Visible = true;
            moneyPanel.Visible = false;
            creditPanel.Visible = false;
        }

        private void custome_Panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        public void saveChanges(string path)
        {
            if (path != "")
            {
                userProfile.ImageLocation = path;
            }

            alreadyOpen = false;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //183, 402
        //57,402
        private void swipBtn_Click(object sender, EventArgs e)
        {
            if (swipedOut)
            {
                swipBtn.Location = new Point(14, 336);
                logOutBtn.Location = new Point(14, 365);
                navigationBar.Size = new Size(57, 402);
                swipedOut = false;
            }

            else
            {
                logOutBtn.Location = new Point(0, 365);
                for (int i = 57; i < 184; i+=10)
                {
                    navigationBar.Size = new Size(i, 402);
                    if ((i - 57) >= swipBtn.Width)
                    {
                        swipBtn.Location = new Point(i-34, 365);
                    }
                    checkBtn.Refresh();
                    homeBtn.Refresh();
                    creditBtn.Refresh();
                    histBtn.Refresh();
                    billBtn.Refresh();
                    moneyBtn.Refresh();
                    navigationBar.Refresh();
                }
                //swipBtn.Location = new Point(150, 365);
                swipedOut = true;
            }
        }

        private void electricProvider_Click(object sender, EventArgs e)
        {
            EEUPan.Visible = true;
            canPan.Visible = false;
            dstPan.Visible = false;
            payBillBtn.Visible = true;
            smartCardBox.Visible = true;
            moneyBox.Visible = true;
            backBtn.Visible = true;
            payBillBtn.BringToFront();
            smartCardBox.BringToFront();
            moneyBox.BringToFront();
            backBtn.BringToFront();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            companies.Visible = true;
            canPan.Location = oldCanal;
            dstPan.Location = oldDstv;
            EEUPan.Visible = true;
            canPan.Visible = true;
            dstPan.Visible = true;
            payBillBtn.Visible = false;
            smartCardBox.Visible = false;
            moneyBox.Visible = false;
            backBtn.Visible = false;
        }
        


        private void DSTV_Click(object sender, EventArgs e)
        {
            EEUPan.Visible = false;
            canPan.Visible = false;
            dstPan.Visible = true;
            payBillBtn.Visible = true;
            smartCardBox.Visible = true;
            moneyBox.Visible = true;
            backBtn.Visible = true;
            canPan.Location = oldCanal;
            dstPan.Location = EEUPan.Location;
            payBillBtn.BringToFront();
            smartCardBox.BringToFront();
            moneyBox.BringToFront();
            backBtn.BringToFront();
        }

        private void canalP_Click(object sender, EventArgs e)
        {
            EEUPan.Visible = false;
            canPan.Visible = true;
            dstPan.Visible = false;
            payBillBtn.Visible = true;
            smartCardBox.Visible = true;
            moneyBox.Visible = true;
            backBtn.Visible = true;
            canPan.Location = EEUPan.Location;
            payBillBtn.BringToFront();
            smartCardBox.BringToFront();
            moneyBox.BringToFront();
            backBtn.BringToFront();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string account = searchBox.Texts;
            try
            {
                connection.Open();
                string selectAccount = "SELECT * FROM clients WHERE accountNumber=@account;";
                using (SQLiteCommand command = new SQLiteCommand(selectAccount, connection))
                {
                    command.Parameters.AddWithValue("@account", account);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            toLab.Visible = true;
                            recieveLab.Text = account;
                            recieveLab.Visible = true;
                            RecieverID = reader["clientID"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                customeMessageBox exc = new customeMessageBox(ex.Message);
                exc.Show();
            }

            finally
            {
                connection.Close();
            }

        }

        private string rID()
        {
            string query = "SELECT * FROM CreditRequest; ";
            
                using (SQLiteDataAdapter reader =new SQLiteDataAdapter(query,connection))
                {
                    DataTable t = new DataTable();
                    reader.Fill(t);
                    return (t.Rows.Count+1).ToString();
                }
            
        }

        private void moneyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(amountBox.Texts))
            {
                amountErr.Visible = true;
            }
            else
            {
                if (!string.IsNullOrEmpty(searchBox.Texts))
                {
                    if (string.IsNullOrEmpty(recieveLab.Text))
                    {
                        searchBtn_Click(sender, e);
                        MessageBox.Show(recieveLab.Text);
                    }
                    //recieveLab.Text = searchBox.Texts;
                    //RecieverID = recieveLab.Text;
                    double transferedCash;
                    if (double.TryParse(amountBox.Texts, out transferedCash))
                    {
                        transferedCash = double.Parse(amountBox.Texts);
                        double senderMoney = double.Parse(extractCash(BankID));
                        double recieverMoney = double.Parse(extractCash(RecieverID));
                        if (transferedCash > senderMoney)
                        {
                            customeMessageBox over = new customeMessageBox("Sorry! You have insufficient balance for this service.");
                            over.Show();
                        }
                        else
                        {
                            senderMoney -= transferedCash;
                            recieverMoney += transferedCash;
                            string senderQuery = "UPDATE clients SET clientCash=@senderCash WHERE clientID=@id;";
                            string recieverQuery = "UPDATE clients SET clientCash=@recvCash WHERE clientID=@rID;";
                            string senHis = "INSERT INTO Transactions (TransactionID, FromID, ToID, Amount, TransactionType,Date) VALUES(@TrID,@sendID,@toID,@cash,@type,@date);";
                            string recHis = "INSERT INTO Transactions (TransactionID, FromID, ToID, Amount, TransactionType,Date) VALUES(@TrID,@sendID,@toID,@cash,@type,@date);";

                            try
                            {
                                if (connection.State == ConnectionState.Closed)
                                {
                                    connection.Open();
                                }

                                using (SQLiteCommand sendCommand = new SQLiteCommand(senderQuery, connection))
                                {
                                    //
                                    sendCommand.Parameters.AddWithValue("@senderCash", senderMoney.ToString());
                                    sendCommand.Parameters.AddWithValue("@id", BankID);
                                    int row = sendCommand.ExecuteNonQuery();

                                }

                                using (SQLiteCommand recCommand = new SQLiteCommand(recieverQuery, connection))
                                {
                                    //
                                    recCommand.Parameters.AddWithValue("@recvCash", recieverMoney.ToString());
                                    recCommand.Parameters.AddWithValue("@rID", RecieverID);
                                    int row = recCommand.ExecuteNonQuery();
                                }

                                using (SQLiteCommand histCommand = new SQLiteCommand(recHis, connection))
                                {
                                    //
                                    histCommand.Parameters.AddWithValue("@TrID", "TR" + (transactionNum() + 1).ToString());
                                    histCommand.Parameters.AddWithValue("@sendID", BankID);
                                    histCommand.Parameters.AddWithValue("@toID", RecieverID);
                                    histCommand.Parameters.AddWithValue("@cash", transferedCash.ToString());
                                    histCommand.Parameters.AddWithValue("@type", "recieved");
                                    histCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                                    histCommand.ExecuteNonQuery();
                                }

                                using (SQLiteCommand senderCommand = new SQLiteCommand(senHis, connection))
                                {
                                    //
                                    senderCommand.Parameters.AddWithValue("@TrID", "TS" + (transactionNum() + 1).ToString());
                                    senderCommand.Parameters.AddWithValue("@sendID", BankID);
                                    senderCommand.Parameters.AddWithValue("@toID", RecieverID);
                                    senderCommand.Parameters.AddWithValue("@cash", transferedCash.ToString());
                                    senderCommand.Parameters.AddWithValue("@type", "Sent");
                                    senderCommand.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                                    senderCommand.ExecuteNonQuery();

                                }

                                MessageBox.Show("The transaction was successful","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                
                                balanceLabel.Text = senderMoney.ToString();

                            }
                            catch (Exception ex)
                            {
                                customeMessageBox exc = new customeMessageBox(ex.Message);
                                exc.Show();
                            }
                            finally
                            {
                                connection.Close();
                            }

                        }

                        }
                        else
                        {
                            customeMessageBox Error = new customeMessageBox("Please enter a valid amount");
                        }

                    
                }
                

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void creditRe_Click(object sender, EventArgs e)
        {
            CreditRequest request = new CreditRequest(this, BankID);
            request.Show();
        }

        private void tHis_Click(object sender, EventArgs e)
        {
            int m = histPanel.Controls.Count;
            for (int i = m-1; i >=0; i--)
            {
                histPanel.Controls.RemoveAt(i);
            }
            histPanel.Controls.Add(histNavBar);
            createHistory(1);
        }

        private void bHis_Click(object sender, EventArgs e)
        {
            int m=histPanel.Controls.Count;
            for (int i = m-1; i >=0; i--)
            {
                histPanel.Controls.RemoveAt(i);
            }
            histPanel.Controls.Add(histNavBar);
            createHistory(3);
        }

        private void cHis_Click(object sender, EventArgs e)
        {
            int m = histPanel.Controls.Count;
            for (int i = m - 1; i >= 0; i--)
            {
                histPanel.Controls.RemoveAt(i);
            }
            histPanel.Controls.Add(histNavBar);
            createHistory(2);
        }

        private void payBillBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(moneyBox.Texts))
            {
                customeMessageBox empty = new customeMessageBox("Please enter the amount.");
                empty.Show();
            }
            else
            {
                if (string.IsNullOrEmpty(smartCardBox.Texts))
                {
                    customeMessageBox empty2 = new customeMessageBox("Please enter your ID.");
                    empty2.Show();
                }
                else
                {
                    string checkQuery = "SELECT * FROM BillClients WHERE CustomerIDNumber=@id;";
                    string checkMoney = "SELECT * FROM Billing WHERE CustomerIDNumber=@id;";
                    string billHistory = "INSERT INTO BillTransactions (BankID, BillerID, CompanyAcc, Amount, Date) VALUES (@id,@bID,@cAcc,@money,@date);";
                    string updateComp = "UPDATE billCompanies SET companyCash=@cash WHERE companyAccountNumber=@acc;";
                    string updateUser = "UPDATE clients SET clientCash=@cash WHERE clientID=@id;";
                    try
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(checkQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", smartCardBox.Texts);
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    
                                    using (SQLiteCommand command2 = new SQLiteCommand(checkMoney, connection))
                                    {

                                        command2.Parameters.AddWithValue("@id", smartCardBox.Texts);

                                        
                                        using (SQLiteDataReader reader2 = command2.ExecuteReader())
                                        {

                                            
                                            if (reader2.Read())
                                            {
                                                string compNum = reader2["companyAccountNumber"].ToString();
                                                string amount = reader2["AmountOwed"].ToString();

                                                
                                                double money = 0;
                                                if (amount == "any")
                                                {
                                                    money = double.Parse(moneyBox.Texts);
                                                }
                                                else
                                                {
                                                    money = double.Parse(amount);
                                                }

                                                if (money > double.Parse(extractCash(BankID)))
                                                {
                                                    customeMessageBox over = new customeMessageBox("Insufficient balance for the service!");
                                                    over.Show();
                                                }
                                                else
                                                {

                                                    
                                                    double cash = double.Parse(extractCash(BankID));
                                                    double cashComp = double.Parse(compCash(reader2["companyAccountNumber"].ToString()));
                                                    cash -= money;
                                                    cashComp += money;

                                                    
                                                    using (SQLiteCommand command3 = new SQLiteCommand(updateComp, connection))
                                                    {

                                                        
                                                        command3.Parameters.AddWithValue("@acc", reader2["companyAccountNumber"].ToString());
                                                        command3.Parameters.AddWithValue("@cash", cashComp.ToString());
                                                        command3.ExecuteNonQuery();
                                                    }

                                                    using (SQLiteCommand command4 = new SQLiteCommand(updateUser, connection))
                                                    {

                                                       
                                                        command4.Parameters.AddWithValue("@cash", cash);
                                                        command4.Parameters.AddWithValue("@id", BankID);
                                                        command4.ExecuteNonQuery();

                                                        
                                                    }

                                                    using (SQLiteCommand commandHis = new SQLiteCommand(billHistory, connection))
                                                    {
                                                        commandHis.Parameters.AddWithValue("@id", BankID);
                                                        commandHis.Parameters.AddWithValue("@bID", reader["CustomerIDNumber"].ToString());
                                                        commandHis.Parameters.AddWithValue("@cAcc", reader2["companyAccountNumber"].ToString());
                                                        commandHis.Parameters.AddWithValue("@money", money.ToString());
                                                        commandHis.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                                                        commandHis.ExecuteNonQuery();
                                                    }
                                                    MessageBox.Show("Bill Paid Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                                   
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Nothing");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    customeMessageBox box = new customeMessageBox("No such ID is found!");
                                    box.Show();
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
            }
        }

        private string compCash(string ID)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            string query = "SELECT * FROM billCompanies WHERE companyAccountNumber=@acc;";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@acc", ID);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["companyCash"].ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.Show();
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            creditRepay.Visible = true;

        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            creditRepay.Visible = false;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM DebtStatus WHERE BankID=@id;";
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", BankID);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader["Debt"].ToString() == "Free")
                            {
                                customeMessageBox box = new customeMessageBox("You are not in debt");
                                box.Show();
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(repayAmount.Texts))
                                {
                                    if (Regex.IsMatch(repayAmount.Texts, @"[0-9]+"))
                                    {
                                        double cash = double.Parse(repayAmount.Texts);
                                        double money = double.Parse(extractCash(BankID));
                                        if (money < cash)
                                        {
                                            customeMessageBox box = new customeMessageBox("Insufficient Amount for the service");
                                            box.Show();
                                        }
                                        else
                                        {
                                            string query2 = "SELECT * FROM Credits WHERE BankID=@id;";
                                            using (SQLiteCommand commandCredit = new SQLiteCommand(query2, connection))
                                            {
                                                commandCredit.Parameters.AddWithValue("@id", BankID);
                                                using (SQLiteDataReader readDebt = commandCredit.ExecuteReader())
                                                {
                                                    if (readDebt.Read())
                                                    {
                                                        double debtLeft = double.Parse(readDebt["MoneyLeft"].ToString());
                                                        if (debtLeft < cash)
                                                        {
                                                            debtLeft = 0;
                                                            money -= cash;
                                                        }
                                                        else
                                                        {
                                                            debtLeft -= cash;
                                                            money -= cash;
                                                        }
                                                        string newQ = "UPDATE Credits SET MoneyLeft=@cash WHERE BankID=@id;";
                                                        string newQ2 = "UPDATE clients SET clientCash=@money WHERE clientID=@id;";
                                                        using (SQLiteCommand update = new SQLiteCommand(newQ, connection))
                                                        {
                                                            update.Parameters.AddWithValue("@cash", debtLeft.ToString());
                                                            update.Parameters.AddWithValue("@id", BankID);
                                                            update.ExecuteNonQuery();
                                                        }
                                                        using (SQLiteCommand update = new SQLiteCommand(newQ2, connection))
                                                        {
                                                            update.Parameters.AddWithValue("@id", BankID);
                                                            update.Parameters.AddWithValue("@money", money.ToString());
                                                            update.ExecuteNonQuery();
                                                        }
                                                        if (debtLeft == 0)
                                                        {
                                                            string del = "DELETE FROM Credits WHERE BankID=@id;";
                                                            using (SQLiteCommand dele = new SQLiteCommand(del, connection))
                                                            {
                                                                dele.Parameters.AddWithValue("@id", BankID);
                                                                dele.ExecuteNonQuery();
                                                            }
                                                            string up2 = "UPDATE DebtStatus SET Debt=@debt WHERE BankID=@id; ";
                                                            using (SQLiteCommand update = new SQLiteCommand(up2, connection))
                                                            {
                                                                update.Parameters.AddWithValue("@id", BankID);
                                                                update.Parameters.AddWithValue("@debt", "Free");
                                                                update.ExecuteNonQuery();
                                                            }
                                                            customeMessageBox box = new customeMessageBox("You are free of debt");
                                                            box.Show();
                                                        }
                                                        balanceLabel.Text = money.ToString();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
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

        private void Home_Load(object sender, EventArgs e)
        {
            pswBox.PasswordChar = true;
            pswBox.Enabled = true;
        }


    }
}
