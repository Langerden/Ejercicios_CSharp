using System;
using System.Windows.Forms;
using Application.Repositories;
using Application.Models;

namespace WindowsFormsApp1
{
    public partial class FrmCustomerVisualizer : Form
    {
        CustomerRepository customerRepository;
        public FrmCustomerVisualizer(CustomerRepository customerRepository)
        {
            InitializeComponent();
            this.customerRepository = customerRepository;
        }


        private void FrmCostumerVisualizer_Load(object sender, EventArgs e)
        {
            this.RefreshDataGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCustomer frm = new FrmCustomer(this.customerRepository);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.RefreshDataGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmCustomerUpdate frm = new FrmCustomerUpdate(this.customerRepository, (Customer)dtgCustomer.CurrentRow.DataBoundItem);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                this.RefreshDataGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (DialogResult.Yes == MessageBox.Show("Seguro que desea Eliminar el cliente?", "Atencion", MessageBoxButtons.YesNo))
            {
                this.customerRepository.Remove((Customer)dtgCustomer.CurrentRow.DataBoundItem);
                this.RefreshDataGrid();
            }
          
        }

        private void RefreshDataGrid()
        {
            dtgCustomer.DataSource = null;
            dtgCustomer.DataSource = this.customerRepository.GetAll();
        }

        private void FrmCustomerVisualizer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
