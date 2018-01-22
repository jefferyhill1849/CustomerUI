//Jeffery Hill
//January 17, 2018 
//TLA Lab 1.4 UI

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
using TechSupportDB;
using CustomerDB;
using Customers;
using State;
using StateDB;
using VendorMaintenance;

namespace CustomerUI
{
    
    public partial class frmAddCustomer : Form
    {
        public bool addCustomer;
        public Customer customer;

        public frmAddCustomer()
        {
            InitializeComponent();
        }
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            if (addCustomer)
            {
                this.Text = "Add Customer";

            }
            else
            {
                this.Text = "Modify Customer";
                this.DisplayCustomer();
            }
        }
        private void DisplayCustomer()
        {
            txtNewName.Text = customer.Name;
            txtNewAddress.Text = customer.Address;
            txtNewCity.Text = customer.City;
            cboStates.Text = customer.State;
            txtNewPhone.Text = customer.Phone;
            txtNewZip.Text = customer.ZipCode;
            txtNewEmail.Text = customer.Email;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addCustomer)
                {
                    customer = new Customer();
                    this.PutCustomerData(customer);
                    try
                    {
                        customer.CustomID = CustomerDBDAL.AddCustomer(customer);
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Customer newCustomer = new Customer();
                    newCustomer.CustomID = customer.CustomID;
                    this.PutCustomerData(newCustomer);
                    try
                    {
                        if (!CustomerDBDAL.UpdateCustomer(customer, newCustomer))
                        {
                            MessageBox.Show("Another user has updated or " +
                                "deleted that customer.", "Database Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                        else
                        {
                            customer = newCustomer;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }
        private bool IsValidData()
        {
            if (Validator.IsPresent(txtNewName) &&
                Validator.IsPresent(txtNewAddress) &&
                Validator.IsPresent(txtNewCity) &&
                Validator.IsPresent(cboStates) &&
                Validator.IsInt32(txtNewZip) &&
                Validator.IsPresent(txtNewPhone) &&
                Validator.IsPresent(txtNewEmail))
            {
                int firstZip = stateList[cboStates.SelectedIndex].FirstZipCode;
                int lastZip = stateList[cboStates.SelectedIndex].LastZipCode;
                if (Validator.IsStateZipCode(txtNewZip, firstZip, lastZip))
                {
                    if (txtNewPhone.Text != "")
                    {
                        if (Validator.IsPhoneNumber(txtNewPhone))
                            return true;
                        else
                            return false;
                    }
                    else
                        return true;
                }
                else
                    return false;
                }
            else
                return false;
        }

        private void PutCustomerData(Customer customer)
        {
            customer.Name = txtNewName.Text;
            customer.Address = txtNewAddress.Text;
            customer.City = txtNewCity.Text;
            customer.ZipCode = txtNewZip.Text;
            customer.State = cboStates.Text;
            customer.Phone = txtNewPhone.Text;
            customer.Email = txtNewEmail.Text;
        }
    }
}
