//Jeffery Hill
//January 11, 2018
//TLA Lab 1.4 (UI)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CustomerDB;
using Customers;
using TechSupportDB;

namespace CustomerUI
{
    public partial class frmCustomer : Form
    {
        Customer customer;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load_1(object sender, EventArgs e)
        {
            List<Customer> customerList;
            try
            {
                customerList = CustomerDBDAL.GetCustomers();
                if (customerList.Count > 0)
                {
                    Customer customer;
                    for (int i = 0; i < customerList.Count; i++)
                    {
                        customer = customerList[i];
                        txtCustID.Text = customer.CustomID.ToString();
                        txtName.Text = customer.Name;
                        txtAddress.Text = customer.Address;
                        txtCity.Text = customer.City;
                        txtState.Text = customer.State;
                        txtZip.Text = customer.ZipCode.ToString();
                        txtPhone.Text = customer.Phone;
                        txtEmail.Text = customer.Email;

                    }
                }
                else
                {
                    MessageBox.Show("No Customer fitting that ID can be found.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
        private void GetCustomer(int customID)
        {
            try
            {
                customer = CustomerDBDAL.GetCustomer(customID);
                    if (customer == null)
                    MessageBox.Show("No customer found with this ID." +
                        "Please try again.", "Customer Not Found");
                else
                    this.DisplayCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer addAddCustomerForm = new frmAddCustomer();
            addAddCustomerForm.addCustomer = true;
            DialogResult result = addAddCustomerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                customer = addAddCustomerForm.customer;
                txtCustID.Text = customer.CustomID.ToString();
                this.DisplayCustomer();
            }
        }
        private void DisplayCustomer()
        {
            txtCustID.Text = customer.CustomID.ToString();
            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtState.Text = customer.State;
            txtPhone.Text = customer.Phone;
            txtZip.Text = customer.ZipCode;
            txtEmail.Text = customer.Email;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            addCustomerForm.addCustomer = false;
            addCustomerForm.customer = customer;
            DialogResult result = addCustomerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                customer = addCustomerForm.customer;
                this.DisplayCustomer();
            }
            else if (result == DialogResult.Retry)
            {
                this.ClearControls();
                this.GetCustomer(customer.CustomID);
            }
        }
        private void ClearControls()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            btnModify.Enabled = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.bindingSource1.Position + 1 < this.bindingSource1.Count)
            {
                this.bindingSource1.MoveNext();

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.bindingSource1.MoveLast();
        }

    }
}