namespace VBS
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.userBox = new VBS.Custome_Controls.Custome_TextBox();
            this.pswBox = new VBS.Custome_Controls.Custome_TextBox();
            this.logBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.SystemColors.Window;
            this.userBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.userBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.userBox.BorderRadius = 0;
            this.userBox.BorderSize = 1;
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox.ForeColor = System.Drawing.Color.DimGray;
            this.userBox.IsPlaceHolder = true;
            this.userBox.Location = new System.Drawing.Point(23, 139);
            this.userBox.Multiline = false;
            this.userBox.Name = "userBox";
            this.userBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userBox.PasswordChar = false;
            this.userBox.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.userBox.PlaceHolderText = "User Name . . .";
            this.userBox.Size = new System.Drawing.Size(250, 31);
            this.userBox.TabIndex = 0;
            this.userBox.Texts = "";
            this.userBox.UnderlinedStyle = false;
            // 
            // pswBox
            // 
            this.pswBox.BackColor = System.Drawing.SystemColors.Window;
            this.pswBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.pswBox.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.pswBox.BorderRadius = 0;
            this.pswBox.BorderSize = 1;
            this.pswBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswBox.ForeColor = System.Drawing.Color.DimGray;
            this.pswBox.IsPlaceHolder = true;
            this.pswBox.Location = new System.Drawing.Point(23, 214);
            this.pswBox.Multiline = false;
            this.pswBox.Name = "pswBox";
            this.pswBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.pswBox.PasswordChar = false;
            this.pswBox.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.pswBox.PlaceHolderText = "Password . . .";
            this.pswBox.Size = new System.Drawing.Size(250, 31);
            this.pswBox.TabIndex = 1;
            this.pswBox.Texts = "";
            this.pswBox.UnderlinedStyle = false;
            // 
            // logBtn
            // 
            this.logBtn.AnimationHoverSpeed = 0.07F;
            this.logBtn.AnimationSpeed = 0.03F;
            this.logBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.logBtn.BorderColor = System.Drawing.Color.Black;
            this.logBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.logBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.logBtn.CheckedForeColor = System.Drawing.Color.White;
            this.logBtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("logBtn.CheckedImage")));
            this.logBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.logBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logBtn.FocusedColor = System.Drawing.Color.Empty;
            this.logBtn.Font = new System.Drawing.Font("High Tower Text", 13F);
            this.logBtn.ForeColor = System.Drawing.Color.White;
            this.logBtn.Image = ((System.Drawing.Image)(resources.GetObject("logBtn.Image")));
            this.logBtn.ImageSize = new System.Drawing.Size(35, 35);
            this.logBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.logBtn.Location = new System.Drawing.Point(62, 296);
            this.logBtn.Name = "logBtn";
            this.logBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.logBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.logBtn.OnHoverImage = null;
            this.logBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.logBtn.OnPressedColor = System.Drawing.Color.Black;
            this.logBtn.Size = new System.Drawing.Size(180, 42);
            this.logBtn.TabIndex = 2;
            this.logBtn.Text = "Log In";
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(87, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 88);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.pswBox);
            this.Controls.Add(this.userBox);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custome_Controls.Custome_TextBox userBox;
        private Custome_Controls.Custome_TextBox pswBox;
        private Guna.UI.WinForms.GunaAdvenceButton logBtn;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}