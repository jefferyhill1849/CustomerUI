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
            this.SuspendLayout();
            // 
            // lvCustomer
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCustomer;
    }
}

