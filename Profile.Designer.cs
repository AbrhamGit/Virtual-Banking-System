namespace VBS
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new VBS.Custome_Controls.Custome_button();
            this.label1 = new System.Windows.Forms.Label();
            this.profPanel = new System.Windows.Forms.Panel();
            this.darkLightbtn = new VBS.Custome_Controls.Custome_PictureBox();
            this.accNum = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userPic = new VBS.Custome_Controls.Custome_PictureBox();
            this.changePanel = new System.Windows.Forms.Panel();
            this.delPic = new VBS.Custome_Controls.Custome_PictureBox();
            this.feedPic = new VBS.Custome_Controls.Custome_PictureBox();
            this.contPic = new VBS.Custome_Controls.Custome_PictureBox();
            this.faqPic = new VBS.Custome_Controls.Custome_PictureBox();
            this.pinPic = new VBS.Custome_Controls.Custome_PictureBox();
            this.profPic = new VBS.Custome_Controls.Custome_PictureBox();
            this.delBtn = new VBS.Custome_Controls.Custome_button();
            this.feedBtn = new VBS.Custome_Controls.Custome_button();
            this.contBtn = new VBS.Custome_Controls.Custome_button();
            this.faqBtn = new VBS.Custome_Controls.Custome_button();
            this.pinBtn = new VBS.Custome_Controls.Custome_button();
            this.profBtn = new VBS.Custome_Controls.Custome_button();
            this.changeProfile = new System.Windows.Forms.Panel();
            this.searchProfile = new VBS.Custome_Controls.Custome_PictureBox();
            this.saveProfile = new VBS.Custome_Controls.Custome_button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.logOutbtn = new VBS.Custome_Controls.Custome_button();
            this.panel1.SuspendLayout();
            this.profPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkLightbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).BeginInit();
            this.changePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faqPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profPic)).BeginInit();
            this.changeProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 68);
            this.panel1.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.BorderBtnColor = System.Drawing.Color.Violet;
            this.backBtn.BorderRaius = 20;
            this.backBtn.BorderSize = 0;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.Violet;
            this.backBtn.Location = new System.Drawing.Point(16, 14);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(37, 37);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // profPanel
            // 
            this.profPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profPanel.BackgroundImage")));
            this.profPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profPanel.Controls.Add(this.darkLightbtn);
            this.profPanel.Controls.Add(this.accNum);
            this.profPanel.Controls.Add(this.userName);
            this.profPanel.Controls.Add(this.userPic);
            this.profPanel.Location = new System.Drawing.Point(-1, 67);
            this.profPanel.Name = "profPanel";
            this.profPanel.Size = new System.Drawing.Size(496, 85);
            this.profPanel.TabIndex = 1;
            // 
            // darkLightbtn
            // 
            this.darkLightbtn.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.darkLightbtn.BorderColor = System.Drawing.Color.RoyalBlue;
            this.darkLightbtn.BorderColor2 = System.Drawing.Color.HotPink;
            this.darkLightbtn.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.darkLightbtn.BorderSize = 0;
            this.darkLightbtn.GradientAngle = 50F;
            this.darkLightbtn.Image = ((System.Drawing.Image)(resources.GetObject("darkLightbtn.Image")));
            this.darkLightbtn.Location = new System.Drawing.Point(465, 51);
            this.darkLightbtn.Name = "darkLightbtn";
            this.darkLightbtn.Size = new System.Drawing.Size(21, 21);
            this.darkLightbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.darkLightbtn.TabIndex = 3;
            this.darkLightbtn.TabStop = false;
            this.darkLightbtn.Click += new System.EventHandler(this.darkLightbtn_Click);
            // 
            // accNum
            // 
            this.accNum.AutoSize = true;
            this.accNum.BackColor = System.Drawing.Color.Transparent;
            this.accNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.accNum.Location = new System.Drawing.Point(87, 40);
            this.accNum.Name = "accNum";
            this.accNum.Size = new System.Drawing.Size(113, 19);
            this.accNum.TabIndex = 2;
            this.accNum.Text = "Account Number";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.Color.Transparent;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.userName.Location = new System.Drawing.Point(87, 12);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(71, 19);
            this.userName.TabIndex = 1;
            this.userName.Text = "Username";
            // 
            // userPic
            // 
            this.userPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPic.BackgroundImage")));
            this.userPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.userPic.BorderColor = System.Drawing.Color.Orange;
            this.userPic.BorderColor2 = System.Drawing.Color.Indigo;
            this.userPic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.userPic.BorderSize = 2;
            this.userPic.GradientAngle = 50F;
            this.userPic.Image = ((System.Drawing.Image)(resources.GetObject("userPic.Image")));
            this.userPic.Location = new System.Drawing.Point(13, 7);
            this.userPic.Name = "userPic";
            this.userPic.Size = new System.Drawing.Size(65, 65);
            this.userPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPic.TabIndex = 0;
            this.userPic.TabStop = false;
            // 
            // changePanel
            // 
            this.changePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePanel.BackgroundImage")));
            this.changePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePanel.Controls.Add(this.delPic);
            this.changePanel.Controls.Add(this.feedPic);
            this.changePanel.Controls.Add(this.contPic);
            this.changePanel.Controls.Add(this.faqPic);
            this.changePanel.Controls.Add(this.pinPic);
            this.changePanel.Controls.Add(this.profPic);
            this.changePanel.Controls.Add(this.delBtn);
            this.changePanel.Controls.Add(this.feedBtn);
            this.changePanel.Controls.Add(this.contBtn);
            this.changePanel.Controls.Add(this.faqBtn);
            this.changePanel.Controls.Add(this.pinBtn);
            this.changePanel.Controls.Add(this.profBtn);
            this.changePanel.Location = new System.Drawing.Point(-1, 145);
            this.changePanel.Name = "changePanel";
            this.changePanel.Size = new System.Drawing.Size(493, 298);
            this.changePanel.TabIndex = 2;
            // 
            // delPic
            // 
            this.delPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.delPic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.delPic.BorderColor2 = System.Drawing.Color.HotPink;
            this.delPic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.delPic.BorderSize = 0;
            this.delPic.GradientAngle = 50F;
            this.delPic.Image = ((System.Drawing.Image)(resources.GetObject("delPic.Image")));
            this.delPic.Location = new System.Drawing.Point(22, 245);
            this.delPic.Name = "delPic";
            this.delPic.Size = new System.Drawing.Size(31, 31);
            this.delPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delPic.TabIndex = 11;
            this.delPic.TabStop = false;
            // 
            // feedPic
            // 
            this.feedPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.feedPic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.feedPic.BorderColor2 = System.Drawing.Color.HotPink;
            this.feedPic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.feedPic.BorderSize = 0;
            this.feedPic.GradientAngle = 50F;
            this.feedPic.Image = ((System.Drawing.Image)(resources.GetObject("feedPic.Image")));
            this.feedPic.Location = new System.Drawing.Point(22, 197);
            this.feedPic.Name = "feedPic";
            this.feedPic.Size = new System.Drawing.Size(31, 31);
            this.feedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.feedPic.TabIndex = 10;
            this.feedPic.TabStop = false;
            // 
            // contPic
            // 
            this.contPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.contPic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.contPic.BorderColor2 = System.Drawing.Color.HotPink;
            this.contPic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.contPic.BorderSize = 0;
            this.contPic.GradientAngle = 50F;
            this.contPic.Image = ((System.Drawing.Image)(resources.GetObject("contPic.Image")));
            this.contPic.Location = new System.Drawing.Point(22, 151);
            this.contPic.Name = "contPic";
            this.contPic.Size = new System.Drawing.Size(31, 31);
            this.contPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contPic.TabIndex = 9;
            this.contPic.TabStop = false;
            // 
            // faqPic
            // 
            this.faqPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.faqPic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.faqPic.BorderColor2 = System.Drawing.Color.HotPink;
            this.faqPic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.faqPic.BorderSize = 0;
            this.faqPic.GradientAngle = 50F;
            this.faqPic.Image = ((System.Drawing.Image)(resources.GetObject("faqPic.Image")));
            this.faqPic.Location = new System.Drawing.Point(22, 105);
            this.faqPic.Name = "faqPic";
            this.faqPic.Size = new System.Drawing.Size(31, 31);
            this.faqPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.faqPic.TabIndex = 8;
            this.faqPic.TabStop = false;
            // 
            // pinPic
            // 
            this.pinPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pinPic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pinPic.BorderColor2 = System.Drawing.Color.HotPink;
            this.pinPic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pinPic.BorderSize = 0;
            this.pinPic.GradientAngle = 50F;
            this.pinPic.Image = ((System.Drawing.Image)(resources.GetObject("pinPic.Image")));
            this.pinPic.Location = new System.Drawing.Point(22, 59);
            this.pinPic.Name = "pinPic";
            this.pinPic.Size = new System.Drawing.Size(31, 31);
            this.pinPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinPic.TabIndex = 7;
            this.pinPic.TabStop = false;
            // 
            // profPic
            // 
            this.profPic.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.profPic.BorderColor = System.Drawing.Color.RoyalBlue;
            this.profPic.BorderColor2 = System.Drawing.Color.HotPink;
            this.profPic.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profPic.BorderSize = 0;
            this.profPic.GradientAngle = 50F;
            this.profPic.Image = ((System.Drawing.Image)(resources.GetObject("profPic.Image")));
            this.profPic.Location = new System.Drawing.Point(22, 13);
            this.profPic.Name = "profPic";
            this.profPic.Size = new System.Drawing.Size(31, 31);
            this.profPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profPic.TabIndex = 6;
            this.profPic.TabStop = false;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.White;
            this.delBtn.BorderBtnColor = System.Drawing.Color.Violet;
            this.delBtn.BorderRaius = 20;
            this.delBtn.BorderSize = 0;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.delBtn.Location = new System.Drawing.Point(13, 245);
            this.delBtn.Name = "delBtn";
            this.delBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.delBtn.Size = new System.Drawing.Size(470, 40);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "Delete account";
            this.delBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // feedBtn
            // 
            this.feedBtn.BackColor = System.Drawing.Color.White;
            this.feedBtn.BorderBtnColor = System.Drawing.Color.Violet;
            this.feedBtn.BorderRaius = 20;
            this.feedBtn.BorderSize = 0;
            this.feedBtn.FlatAppearance.BorderSize = 0;
            this.feedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.feedBtn.Location = new System.Drawing.Point(13, 197);
            this.feedBtn.Name = "feedBtn";
            this.feedBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.feedBtn.Size = new System.Drawing.Size(470, 40);
            this.feedBtn.TabIndex = 4;
            this.feedBtn.Text = "Feedback";
            this.feedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.feedBtn.UseVisualStyleBackColor = false;
            // 
            // contBtn
            // 
            this.contBtn.BackColor = System.Drawing.Color.White;
            this.contBtn.BorderBtnColor = System.Drawing.Color.Violet;
            this.contBtn.BorderRaius = 20;
            this.contBtn.BorderSize = 0;
            this.contBtn.FlatAppearance.BorderSize = 0;
            this.contBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.contBtn.Location = new System.Drawing.Point(16, 151);
            this.contBtn.Name = "contBtn";
            this.contBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.contBtn.Size = new System.Drawing.Size(467, 40);
            this.contBtn.TabIndex = 3;
            this.contBtn.Text = "Contact us";
            this.contBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contBtn.UseVisualStyleBackColor = false;
            // 
            // faqBtn
            // 
            this.faqBtn.BackColor = System.Drawing.Color.White;
            this.faqBtn.BorderBtnColor = System.Drawing.Color.Violet;
            this.faqBtn.BorderRaius = 20;
            this.faqBtn.BorderSize = 0;
            this.faqBtn.FlatAppearance.BorderSize = 0;
            this.faqBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faqBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faqBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.faqBtn.Location = new System.Drawing.Point(16, 105);
            this.faqBtn.Name = "faqBtn";
            this.faqBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.faqBtn.Size = new System.Drawing.Size(467, 40);
            this.faqBtn.TabIndex = 2;
            this.faqBtn.Text = "FAQ";
            this.faqBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.faqBtn.UseVisualStyleBackColor = false;
            // 
            // pinBtn
            // 
            this.pinBtn.BackColor = System.Drawing.Color.White;
            this.pinBtn.BorderBtnColor = System.Drawing.Color.Violet;
            this.pinBtn.BorderRaius = 20;
            this.pinBtn.BorderSize = 0;
            this.pinBtn.FlatAppearance.BorderSize = 0;
            this.pinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.pinBtn.Location = new System.Drawing.Point(13, 59);
            this.pinBtn.Name = "pinBtn";
            this.pinBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.pinBtn.Size = new System.Drawing.Size(470, 40);
            this.pinBtn.TabIndex = 1;
            this.pinBtn.Text = "Change pin";
            this.pinBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pinBtn.UseVisualStyleBackColor = false;
            // 
            // profBtn
            // 
            this.profBtn.BackColor = System.Drawing.Color.White;
            this.profBtn.BorderBtnColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.profBtn.BorderRaius = 20;
            this.profBtn.BorderSize = 0;
            this.profBtn.FlatAppearance.BorderSize = 0;
            this.profBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.profBtn.Location = new System.Drawing.Point(13, 13);
            this.profBtn.Name = "profBtn";
            this.profBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.profBtn.Size = new System.Drawing.Size(470, 40);
            this.profBtn.TabIndex = 0;
            this.profBtn.Text = "Change profile";
            this.profBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profBtn.UseVisualStyleBackColor = false;
            this.profBtn.Click += new System.EventHandler(this.profBtn_Click);
            // 
            // changeProfile
            // 
            this.changeProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeProfile.Controls.Add(this.searchProfile);
            this.changeProfile.Controls.Add(this.saveProfile);
            this.changeProfile.Location = new System.Drawing.Point(2, 159);
            this.changeProfile.Name = "changeProfile";
            this.changeProfile.Size = new System.Drawing.Size(487, 149);
            this.changeProfile.TabIndex = 12;
            this.changeProfile.Visible = false;
            // 
            // searchProfile
            // 
            this.searchProfile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.searchProfile.BorderColor = System.Drawing.Color.RoyalBlue;
            this.searchProfile.BorderColor2 = System.Drawing.Color.HotPink;
            this.searchProfile.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.searchProfile.BorderSize = 2;
            this.searchProfile.GradientAngle = 50F;
            this.searchProfile.Image = ((System.Drawing.Image)(resources.GetObject("searchProfile.Image")));
            this.searchProfile.Location = new System.Drawing.Point(205, 16);
            this.searchProfile.Name = "searchProfile";
            this.searchProfile.Size = new System.Drawing.Size(71, 71);
            this.searchProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchProfile.TabIndex = 0;
            this.searchProfile.TabStop = false;
            this.searchProfile.Click += new System.EventHandler(this.searchProfile_Click);
            // 
            // saveProfile
            // 
            this.saveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.saveProfile.BorderBtnColor = System.Drawing.Color.Violet;
            this.saveProfile.BorderRaius = 20;
            this.saveProfile.BorderSize = 0;
            this.saveProfile.FlatAppearance.BorderSize = 0;
            this.saveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveProfile.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.saveProfile.ForeColor = System.Drawing.Color.White;
            this.saveProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveProfile.Location = new System.Drawing.Point(144, 93);
            this.saveProfile.Name = "saveProfile";
            this.saveProfile.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.saveProfile.Size = new System.Drawing.Size(194, 40);
            this.saveProfile.TabIndex = 7;
            this.saveProfile.Text = "Save Changes";
            this.saveProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveProfile.UseVisualStyleBackColor = false;
            this.saveProfile.Click += new System.EventHandler(this.saveProfile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // logOutbtn
            // 
            this.logOutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.logOutbtn.BorderBtnColor = System.Drawing.Color.Violet;
            this.logOutbtn.BorderRaius = 20;
            this.logOutbtn.BorderSize = 0;
            this.logOutbtn.FlatAppearance.BorderSize = 0;
            this.logOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutbtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutbtn.ForeColor = System.Drawing.Color.White;
            this.logOutbtn.Location = new System.Drawing.Point(53, 449);
            this.logOutbtn.Name = "logOutbtn";
            this.logOutbtn.Size = new System.Drawing.Size(369, 40);
            this.logOutbtn.TabIndex = 6;
            this.logOutbtn.Text = "Log out";
            this.logOutbtn.UseVisualStyleBackColor = false;
            this.logOutbtn.Click += new System.EventHandler(this.custome_button7_Click);
            this.logOutbtn.MouseLeave += new System.EventHandler(this.custome_button7_MouseLeave);
            this.logOutbtn.MouseHover += new System.EventHandler(this.custome_button7_MouseHover);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 519);
            this.Controls.Add(this.changeProfile);
            this.Controls.Add(this.changePanel);
            this.Controls.Add(this.logOutbtn);
            this.Controls.Add(this.profPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.profPanel.ResumeLayout(false);
            this.profPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkLightbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPic)).EndInit();
            this.changePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faqPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profPic)).EndInit();
            this.changeProfile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Custome_Controls.Custome_PictureBox userPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel profPanel;
        private System.Windows.Forms.Label accNum;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Panel changePanel;
        private Custome_Controls.Custome_button logOutbtn;
        private Custome_Controls.Custome_button delBtn;
        private Custome_Controls.Custome_button feedBtn;
        private Custome_Controls.Custome_button contBtn;
        private Custome_Controls.Custome_button faqBtn;
        private Custome_Controls.Custome_button pinBtn;
        private Custome_Controls.Custome_button profBtn;
        private Custome_Controls.Custome_PictureBox delPic;
        private Custome_Controls.Custome_PictureBox feedPic;
        private Custome_Controls.Custome_PictureBox contPic;
        private Custome_Controls.Custome_PictureBox faqPic;
        private Custome_Controls.Custome_PictureBox pinPic;
        private Custome_Controls.Custome_PictureBox profPic;
        private Custome_Controls.Custome_PictureBox darkLightbtn;
        private System.Windows.Forms.Panel changeProfile;
        private Custome_Controls.Custome_button saveProfile;
        private Custome_Controls.Custome_PictureBox searchProfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Custome_Controls.Custome_button backBtn;
    }
}