namespace CustomerUI
{
    partial class frmAddCustomer
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtNewCity = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtNewZip = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.txtNewState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(67, 34);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(181, 20);
            this.txtNewName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 72);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(67, 65);
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(248, 20);
            this.txtNewAddress.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(12, 103);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // txtNewCity
            // 
            this.txtNewCity.Location = new System.Drawing.Point(67, 96);
            this.txtNewCity.Name = "txtNewCity";
            this.txtNewCity.Size = new System.Drawing.Size(156, 20);
            this.txtNewCity.TabIndex = 5;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(12, 134);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(12, 163);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(50, 13);
            this.lblZip.TabIndex = 8;
            this.lblZip.Text = "Zip Code";
            // 
            // txtNewZip
            // 
            this.txtNewZip.Location = new System.Drawing.Point(67, 156);
            this.txtNewZip.Name = "txtNewZip";
            this.txtNewZip.Size = new System.Drawing.Size(117, 20);
            this.txtNewZip.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 190);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone";
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Location = new System.Drawing.Point(67, 183);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(129, 20);
            this.txtNewPhone.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 219);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(67, 212);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(248, 20);
            this.txtNewEmail.TabIndex = 13;
            // 
            // txtNewState
            // 
            this.txtNewState.Location = new System.Drawing.Point(67, 127);
            this.txtNewState.Name = "txtNewState";
            this.txtNewState.Size = new System.Drawing.Size(156, 20);
            this.txtNewState.TabIndex = 14;
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 262);
            this.Controls.Add(this.txtNewState);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNewPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtNewZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtNewCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtNewAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddCustomer";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtNewCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtNewZip;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtNewPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.TextBox txtNewState;
    }
}