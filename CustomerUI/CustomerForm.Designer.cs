namespace CustomerUI
{
    partial class CustomerForm
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
            this.lvCustomer = new System.Windows.Forms.ListView();
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ZipCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvCustomer
            // 
            this.lvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerID,
            this.Name,
            this.Address,
            this.City,
            this.State,
            this.ZipCode,
            this.Phone,
            this.Email});
            this.lvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCustomer.Location = new System.Drawing.Point(0, 0);
            this.lvCustomer.Name = "lvCustomer";
            this.lvCustomer.Size = new System.Drawing.Size(608, 262);
            this.lvCustomer.TabIndex = 0;
            this.lvCustomer.UseCompatibleStateImageBehavior = false;
            this.lvCustomer.View = System.Windows.Forms.View.List;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 262);
            this.Controls.Add(this.lvCustomer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "CustomerForm";
            this.Text = "Customers List Form";
            this.Load += new System.EventHandler(this.CustomerForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCustomer;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader ZipCode;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
    }
}

