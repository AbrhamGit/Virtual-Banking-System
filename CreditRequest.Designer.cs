namespace VBS
{
    partial class CreditRequest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLab = new System.Windows.Forms.Label();
            this.reasonLab = new System.Windows.Forms.Label();
            this.employmentLab = new System.Windows.Forms.Label();
            this.GMILab = new System.Windows.Forms.Label();
            this.submitBtn = new VBS.Custome_Controls.Custome_button();
            this.any = new VBS.Custome_Controls.Custome_TextBox();
            this.GMI = new VBS.Custome_Controls.Custome_TextBox();
            this.employment = new VBS.Custome_Controls.Custome_TextBox();
            this.reason = new VBS.Custome_Controls.Custome_TextBox();
            this.amount = new VBS.Custome_Controls.Custome_TextBox();
            this.empTime = new VBS.Custome_Controls.Custome_TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit request";
            // 
            // amountLab
            // 
            this.amountLab.AutoSize = true;
            this.amountLab.Font = new System.Drawing.Font("High Tower Text", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLab.ForeColor = System.Drawing.Color.Red;
            this.amountLab.Location = new System.Drawing.Point(9, 173);
            this.amountLab.Name = "amountLab";
            this.amountLab.Size = new System.Drawing.Size(283, 16);
            this.amountLab.TabIndex = 12;
            this.amountLab.Text = "Please Type in The Amount You Want (Integer)";
            this.amountLab.Visible = false;
            // 
            // reasonLab
            // 
            this.reasonLab.AutoSize = true;
            this.reasonLab.Font = new System.Drawing.Font("High Tower Text", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonLab.ForeColor = System.Drawing.Color.Red;
            this.reasonLab.Location = new System.Drawing.Point(12, 241);
            this.reasonLab.Name = "reasonLab";
            this.reasonLab.Size = new System.Drawing.Size(260, 16);
            this.reasonLab.TabIndex = 13;
            this.reasonLab.Text = "Please type in the reason for asking for credit";
            this.reasonLab.Visible = false;
            // 
            // employmentLab
            // 
            this.employmentLab.AutoSize = true;
            this.employmentLab.Font = new System.Drawing.Font("High Tower Text", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employmentLab.ForeColor = System.Drawing.Color.Red;
            this.employmentLab.Location = new System.Drawing.Point(12, 313);
            this.employmentLab.Name = "employmentLab";
            this.employmentLab.Size = new System.Drawing.Size(431, 16);
            this.employmentLab.TabIndex = 14;
            this.employmentLab.Text = "Registering your job is mandatory. If you don\'t have any, type \'unemployed\'";
            this.employmentLab.Visible = false;
            // 
            // GMILab
            // 
            this.GMILab.AutoSize = true;
            this.GMILab.Font = new System.Drawing.Font("High Tower Text", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GMILab.ForeColor = System.Drawing.Color.Red;
            this.GMILab.Location = new System.Drawing.Point(12, 384);
            this.GMILab.Name = "GMILab";
            this.GMILab.Size = new System.Drawing.Size(356, 16);
            this.GMILab.TabIndex = 15;
            this.GMILab.Text = "Register Your income. If you don\'t have a job, you can leave it.";
            this.GMILab.Visible = false;
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.submitBtn.BorderBtnColor = System.Drawing.Color.White;
            this.submitBtn.BorderRaius = 10;
            this.submitBtn.BorderSize = 1;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("High Tower Text", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(323, 408);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(222, 53);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit Request";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // any
            // 
            this.any.BackColor = System.Drawing.SystemColors.Window;
            this.any.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.any.BorderFocusColor = System.Drawing.Color.HotPink;
            this.any.BorderRadius = 0;
            this.any.BorderSize = 2;
            this.any.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.any.ForeColor = System.Drawing.Color.DimGray;
            this.any.IsPlaceHolder = true;
            this.any.Location = new System.Drawing.Point(298, 128);
            this.any.Multiline = true;
            this.any.Name = "any";
            this.any.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.any.PasswordChar = false;
            this.any.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.any.PlaceHolderText = "Type in anything you want to add or anything you think it\'s missing. . .";
            this.any.Size = new System.Drawing.Size(286, 129);
            this.any.TabIndex = 10;
            this.any.Texts = "";
            this.any.UnderlinedStyle = false;
            // 
            // GMI
            // 
            this.GMI.BackColor = System.Drawing.SystemColors.Window;
            this.GMI.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.GMI.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.GMI.BorderRadius = 0;
            this.GMI.BorderSize = 2;
            this.GMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GMI.ForeColor = System.Drawing.Color.DimGray;
            this.GMI.IsPlaceHolder = true;
            this.GMI.Location = new System.Drawing.Point(12, 342);
            this.GMI.Multiline = false;
            this.GMI.Name = "GMI";
            this.GMI.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.GMI.PasswordChar = false;
            this.GMI.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.GMI.PlaceHolderText = "Gross Monthly Income...(ETB)";
            this.GMI.Size = new System.Drawing.Size(250, 31);
            this.GMI.TabIndex = 4;
            this.GMI.Texts = "";
            this.GMI.UnderlinedStyle = false;
            // 
            // employment
            // 
            this.employment.BackColor = System.Drawing.SystemColors.Window;
            this.employment.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.employment.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.employment.BorderRadius = 0;
            this.employment.BorderSize = 2;
            this.employment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employment.ForeColor = System.Drawing.Color.DimGray;
            this.employment.IsPlaceHolder = true;
            this.employment.Location = new System.Drawing.Point(13, 270);
            this.employment.Multiline = false;
            this.employment.Name = "employment";
            this.employment.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.employment.PasswordChar = false;
            this.employment.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.employment.PlaceHolderText = "Job position...";
            this.employment.Size = new System.Drawing.Size(250, 31);
            this.employment.TabIndex = 3;
            this.employment.Texts = "";
            this.employment.UnderlinedStyle = false;
            // 
            // reason
            // 
            this.reason.BackColor = System.Drawing.SystemColors.Window;
            this.reason.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.reason.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.reason.BorderRadius = 0;
            this.reason.BorderSize = 2;
            this.reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason.ForeColor = System.Drawing.Color.DimGray;
            this.reason.IsPlaceHolder = true;
            this.reason.Location = new System.Drawing.Point(12, 197);
            this.reason.Multiline = false;
            this.reason.Name = "reason";
            this.reason.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.reason.PasswordChar = false;
            this.reason.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.reason.PlaceHolderText = "Purpose of loan...";
            this.reason.Size = new System.Drawing.Size(250, 31);
            this.reason.TabIndex = 2;
            this.reason.Texts = "";
            this.reason.UnderlinedStyle = false;
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.SystemColors.Window;
            this.amount.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.amount.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.amount.BorderRadius = 0;
            this.amount.BorderSize = 2;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.DimGray;
            this.amount.IsPlaceHolder = true;
            this.amount.Location = new System.Drawing.Point(13, 128);
            this.amount.Multiline = false;
            this.amount.Name = "amount";
            this.amount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.amount.PasswordChar = false;
            this.amount.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.amount.PlaceHolderText = "Amount....(ETB)";
            this.amount.Size = new System.Drawing.Size(250, 31);
            this.amount.TabIndex = 1;
            this.amount.Texts = "";
            this.amount.UnderlinedStyle = false;
            // 
            // empTime
            // 
            this.empTime.BackColor = System.Drawing.SystemColors.Window;
            this.empTime.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.empTime.BorderFocusColor = System.Drawing.SystemColors.HotTrack;
            this.empTime.BorderRadius = 0;
            this.empTime.BorderSize = 2;
            this.empTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empTime.ForeColor = System.Drawing.Color.DimGray;
            this.empTime.IsPlaceHolder = true;
            this.empTime.Location = new System.Drawing.Point(15, 417);
            this.empTime.Multiline = false;
            this.empTime.Name = "empTime";
            this.empTime.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.empTime.PasswordChar = false;
            this.empTime.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.empTime.PlaceHolderText = "Years of employment. . .";
            this.empTime.Size = new System.Drawing.Size(250, 31);
            this.empTime.TabIndex = 17;
            this.empTime.Texts = "";
            this.empTime.UnderlinedStyle = false;
            // 
            // CreditRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(591, 465);
            this.Controls.Add(this.empTime);
            this.Controls.Add(this.GMILab);
            this.Controls.Add(this.employmentLab);
            this.Controls.Add(this.reasonLab);
            this.Controls.Add(this.amountLab);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.any);
            this.Controls.Add(this.GMI);
            this.Controls.Add(this.employment);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.panel1);
            this.Name = "CreditRequest";
            this.Text = "CreditRequest";
            this.Load += new System.EventHandler(this.CreditRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Custome_Controls.Custome_TextBox amount;
        private Custome_Controls.Custome_TextBox reason;
        private Custome_Controls.Custome_TextBox employment;
        private Custome_Controls.Custome_TextBox GMI;
        private Custome_Controls.Custome_TextBox any;
        private Custome_Controls.Custome_button submitBtn;
        private System.Windows.Forms.Label amountLab;
        private System.Windows.Forms.Label reasonLab;
        private System.Windows.Forms.Label employmentLab;
        private System.Windows.Forms.Label GMILab;
        private Custome_Controls.Custome_TextBox empTime;
    }
}