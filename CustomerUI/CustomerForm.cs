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
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            List<Customer> customerList;
            try
            {
                customerList = CustomerDB.GetCustomers();
                if (customerList.Count > 0)
                {
                    Customer customer;
                    for (int i = 0; i < customerList.Count; i++)
                    {
                        customer = customerList[i];
                        lvCustomer.Items.Add(customer.CustomID);
                        lvCustomer.Items[i].Subitems.Add(customer.Name.ToString());

                    }
                }
            }
        }
    }
}
