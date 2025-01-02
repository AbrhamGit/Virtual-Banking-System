namespace VBS
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.navBar = new System.Windows.Forms.Panel();
            this.type = new Guna.UI.WinForms.GunaLabel();
            this.name = new Guna.UI.WinForms.GunaLabel();
            this.profile = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.credit = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.user = new Guna.UI.WinForms.GunaShadowPanel();
            this.unblock = new Guna.UI.WinForms.GunaAdvenceButton();
            this.block = new Guna.UI.WinForms.GunaAdvenceButton();
            this.nameBox = new VBS.Custome_Controls.Custome_TextBox();
            this.navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.credit.SuspendLayout();
            this.user.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.navBar.Controls.Add(this.type);
            this.navBar.Controls.Add(this.name);
            this.navBar.Controls.Add(this.profile);
            this.navBar.Controls.Add(this.gunaAdvenceButton4);
            this.navBar.Controls.Add(this.gunaAdvenceButton2);
            this.navBar.Location = new System.Drawing.Point(-1, 0);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(230, 394);
            this.navBar.TabIndex = 0;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.type.ForeColor = System.Drawing.Color.White;
            this.type.Location = new System.Drawing.Point(115, 53);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(70, 15);
            this.type.TabIndex = 7;
            this.type.Text = "Admin Type";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(115, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(65, 15);
            this.name.TabIndex = 6;
            this.name.Text = "User Name";
            // 
            // profile
            // 
            this.profile.BaseColor = System.Drawing.Color.White;
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.Location = new System.Drawing.Point(3, 12);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(84, 73);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 5;
            this.profile.TabStop = false;
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.CheckedImage")));
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton4.Image")));
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(0, 246);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(230, 42);
            this.gunaAdvenceButton4.TabIndex = 3;
            this.gunaAdvenceButton4.Text = "User Account Managment";
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(15, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(0, 195);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(230, 42);
            this.gunaAdvenceButton2.TabIndex = 1;
            this.gunaAdvenceButton2.Text = "Credit Regulations";
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gunaShadowPanel1.Location = new System.Drawing.Point(235, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowDepth = 200;
            this.gunaShadowPanel1.ShadowShift = 6;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(517, 109);
            this.gunaShadowPanel1.TabIndex = 3;
            // 
            // credit
            // 
            this.credit.Controls.Add(this.listBox1);
            this.credit.Location = new System.Drawing.Point(246, 125);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(469, 258);
            this.credit.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.BaseColor = System.Drawing.Color.White;
            this.user.Controls.Add(this.unblock);
            this.user.Controls.Add(this.block);
            this.user.Controls.Add(this.nameBox);
            this.user.Location = new System.Drawing.Point(249, 125);
            this.user.Name = "user";
            this.user.ShadowColor = System.Drawing.Color.Black;
            this.user.Size = new System.Drawing.Size(466, 258);
            this.user.TabIndex = 7;
            // 
            // unblock
            // 
            this.unblock.AnimationHoverSpeed = 0.07F;
            this.unblock.AnimationSpeed = 0.03F;
            this.unblock.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.unblock.BorderColor = System.Drawing.Color.Black;
            this.unblock.CheckedBaseColor = System.Drawing.Color.Gray;
            this.unblock.CheckedBorderColor = System.Drawing.Color.Black;
            this.unblock.CheckedForeColor = System.Drawing.Color.White;
            this.unblock.CheckedImage = ((System.Drawing.Image)(resources.GetObject("unblock.CheckedImage")));
            this.unblock.CheckedLineColor = System.Drawing.Color.DimGray;
            this.unblock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.unblock.FocusedColor = System.Drawing.Color.Empty;
            this.unblock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unblock.ForeColor = System.Drawing.Color.White;
            this.unblock.Image = ((System.Drawing.Image)(resources.GetObject("unblock.Image")));
            this.unblock.ImageSize = new System.Drawing.Size(20, 20);
            this.unblock.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.unblock.Location = new System.Drawing.Point(280, 96);
            this.unblock.Name = "unblock";
            this.unblock.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.unblock.OnHoverBorderColor = System.Drawing.Color.Black;
            this.unblock.OnHoverForeColor = System.Drawing.Color.White;
            this.unblock.OnHoverImage = null;
            this.unblock.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.unblock.OnPressedColor = System.Drawing.Color.Black;
            this.unblock.Size = new System.Drawing.Size(166, 42);
            this.unblock.TabIndex = 2;
            this.unblock.Text = "Unblock User";
            this.unblock.Click += new System.EventHandler(this.unblock_Click);
            // 
            // block
            // 
            this.block.AnimationHoverSpeed = 0.07F;
            this.block.AnimationSpeed = 0.03F;
            this.block.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.block.BorderColor = System.Drawing.Color.Black;
            this.block.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.block.CheckedBorderColor = System.Drawing.Color.Black;
            this.block.CheckedForeColor = System.Drawing.Color.White;
            this.block.CheckedImage = ((System.Drawing.Image)(resources.GetObject("block.CheckedImage")));
            this.block.CheckedLineColor = System.Drawing.Color.DimGray;
            this.block.DialogResult = System.Windows.Forms.DialogResult.None;
            this.block.FocusedColor = System.Drawing.Color.Empty;
            this.block.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.block.ForeColor = System.Drawing.Color.White;
            this.block.Image = ((System.Drawing.Image)(resources.GetObject("block.Image")));
            this.block.ImageSize = new System.Drawing.Size(20, 20);
            this.block.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.block.Location = new System.Drawing.Point(14, 96);
            this.block.Name = "block";
            this.block.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.block.OnHoverBorderColor = System.Drawing.Color.Black;
            this.block.OnHoverForeColor = System.Drawing.Color.White;
            this.block.OnHoverImage = null;
            this.block.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.block.OnPressedColor = System.Drawing.Color.Black;
            this.block.Size = new System.Drawing.Size(166, 42);
            this.block.TabIndex = 1;
            this.block.Text = "Block User";
            this.block.Click += new System.EventHandler(this.block_Click);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.nameBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.nameBox.BorderRadius = 0;
            this.nameBox.BorderSize = 1;
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.DimGray;
            this.nameBox.IsPlaceHolder = true;
            this.nameBox.Location = new System.Drawing.Point(145, 37);
            this.nameBox.Multiline = false;
            this.nameBox.Name = "nameBox";
            this.nameBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nameBox.PasswordChar = false;
            this.nameBox.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.nameBox.PlaceHolderText = "User Name";
            this.nameBox.Size = new System.Drawing.Size(191, 31);
            this.nameBox.TabIndex = 0;
            this.nameBox.Texts = "";
            this.nameBox.UnderlinedStyle = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(764, 393);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.user);
            this.Controls.Add(this.credit);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.credit.ResumeLayout(false);
            this.user.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navBar;
        private Guna.UI.WinForms.GunaLabel type;
        private Guna.UI.WinForms.GunaLabel name;
        private Guna.UI.WinForms.GunaPictureBox profile;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel credit;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI.WinForms.GunaShadowPanel user;
        private Guna.UI.WinForms.GunaAdvenceButton unblock;
        private Guna.UI.WinForms.GunaAdvenceButton block;
        private Custome_Controls.Custome_TextBox nameBox;
    }
}