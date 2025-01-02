namespace VBS
{
    partial class CreditResponse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditResponse));
            this.approve = new Guna.UI.WinForms.GunaAdvenceButton();
            this.deny = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.Label();
            this.employ = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.bankID = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // approve
            // 
            this.approve.AnimationHoverSpeed = 0.07F;
            this.approve.AnimationSpeed = 0.03F;
            this.approve.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.approve.BorderColor = System.Drawing.Color.Black;
            this.approve.CheckedBaseColor = System.Drawing.Color.Gray;
            this.approve.CheckedBorderColor = System.Drawing.Color.Black;
            this.approve.CheckedForeColor = System.Drawing.Color.White;
            this.approve.CheckedImage = ((System.Drawing.Image)(resources.GetObject("approve.CheckedImage")));
            this.approve.CheckedLineColor = System.Drawing.Color.DimGray;
            this.approve.DialogResult = System.Windows.Forms.DialogResult.None;
            this.approve.FocusedColor = System.Drawing.Color.Empty;
            this.approve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.approve.ForeColor = System.Drawing.Color.White;
            this.approve.Image = ((System.Drawing.Image)(resources.GetObject("approve.Image")));
            this.approve.ImageSize = new System.Drawing.Size(20, 20);
            this.approve.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.approve.Location = new System.Drawing.Point(12, 359);
            this.approve.Name = "approve";
            this.approve.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.approve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.approve.OnHoverForeColor = System.Drawing.Color.White;
            this.approve.OnHoverImage = null;
            this.approve.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.approve.OnPressedColor = System.Drawing.Color.Black;
            this.approve.Size = new System.Drawing.Size(180, 42);
            this.approve.TabIndex = 0;
            this.approve.Text = "Approve";
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // deny
            // 
            this.deny.AnimationHoverSpeed = 0.07F;
            this.deny.AnimationSpeed = 0.03F;
            this.deny.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.deny.BorderColor = System.Drawing.Color.Black;
            this.deny.CheckedBaseColor = System.Drawing.Color.Gray;
            this.deny.CheckedBorderColor = System.Drawing.Color.Black;
            this.deny.CheckedForeColor = System.Drawing.Color.White;
            this.deny.CheckedImage = ((System.Drawing.Image)(resources.GetObject("deny.CheckedImage")));
            this.deny.CheckedLineColor = System.Drawing.Color.DimGray;
            this.deny.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deny.FocusedColor = System.Drawing.Color.Empty;
            this.deny.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deny.ForeColor = System.Drawing.Color.White;
            this.deny.Image = ((System.Drawing.Image)(resources.GetObject("deny.Image")));
            this.deny.ImageSize = new System.Drawing.Size(20, 20);
            this.deny.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deny.Location = new System.Drawing.Point(269, 359);
            this.deny.Name = "deny";
            this.deny.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.deny.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deny.OnHoverForeColor = System.Drawing.Color.White;
            this.deny.OnHoverImage = null;
            this.deny.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.deny.OnPressedColor = System.Drawing.Color.Black;
            this.deny.Size = new System.Drawing.Size(180, 42);
            this.deny.TabIndex = 1;
            this.deny.Text = "Decline";
            this.deny.Click += new System.EventHandler(this.deny_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Additional Info:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "BankID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "UserName";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(109, 33);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(0, 13);
            this.amount.TabIndex = 9;
            // 
            // reason
            // 
            this.reason.AutoSize = true;
            this.reason.Location = new System.Drawing.Point(109, 106);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(0, 13);
            this.reason.TabIndex = 10;
            // 
            // employ
            // 
            this.employ.AutoSize = true;
            this.employ.Location = new System.Drawing.Point(109, 172);
            this.employ.Name = "employ";
            this.employ.Size = new System.Drawing.Size(0, 13);
            this.employ.TabIndex = 11;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(103, 237);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(0, 13);
            this.balance.TabIndex = 12;
            // 
            // bankID
            // 
            this.bankID.AutoSize = true;
            this.bankID.Location = new System.Drawing.Point(336, 33);
            this.bankID.Name = "bankID";
            this.bankID.Size = new System.Drawing.Size(0, 13);
            this.bankID.TabIndex = 14;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(336, 99);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 13);
            this.userName.TabIndex = 15;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(249, 208);
            this.info.MaximumSize = new System.Drawing.Size(160, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 13);
            this.info.TabIndex = 16;
            // 
            // CreditResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 413);
            this.Controls.Add(this.info);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.bankID);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.employ);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deny);
            this.Controls.Add(this.approve);
            this.Name = "CreditResponse";
            this.Text = "CreditResponse";
            this.Load += new System.EventHandler(this.CreditResponse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton approve;
        private Guna.UI.WinForms.GunaAdvenceButton deny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label reason;
        private System.Windows.Forms.Label employ;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label bankID;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label info;
    }
}