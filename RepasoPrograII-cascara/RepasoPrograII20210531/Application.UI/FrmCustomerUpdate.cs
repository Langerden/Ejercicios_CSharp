using Application.Models;
using Application.Repositories;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCustomerUpdate : FrmCustomer
    {
        Customer auxCustomer;

        public FrmCustomerUpdate(CustomerRepository customerRepository, Customer customer) : base(customerRepository)
        {
            this.auxCustomer = customer;

            this.txtAge.Text = customer.Age.ToString();
            this.txtLastName.Text = customer.LastName;
            this.txtName.Text = customer.Name;
            this.btnAdd.Enabled = false;
            InitializeComponent();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer()
            {
                Name = this.txtName.Text,
                LastName = this.txtLastName.Text,
                Id = auxCustomer.Id,
                Age = Convert.ToInt32(this.txtAge.Text)
            };

            this.customerRepository.Update(newCustomer);
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void FrmCustomerUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
