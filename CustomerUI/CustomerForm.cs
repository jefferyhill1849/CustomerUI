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
    public partial class CustomerForm : Form
    {

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
                        lvCustomer.Items.Add(customer.CustomID.ToString());
                        lvCustomer.Items[i].SubItems.Add(customer.Name.ToString());
                        lvCustomer.Items[i].SubItems.Add(customer.Address.ToString());
                        lvCustomer.Items[i].SubItems.Add(customer.City.ToString());
                        lvCustomer.Items[i].SubItems.Add(customer.State.ToString());
                        lvCustomer.Items[i].SubItems.Add(customer.ZipCode.ToString());
                        lvCustomer.Items[i].SubItems.Add(customer.Phone.ToString());
                        lvCustomer.Items[i].SubItems.Add(customer.Email.ToString());
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
    }
}