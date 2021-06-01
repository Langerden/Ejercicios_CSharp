using System;
using System.Windows.Forms;
using Application.Repositories;
using Application.Helpers;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        CustomerRepository customerRepository;
        public FrmPrincipal()
        {
            InitializeComponent();
            this.customerRepository = new CustomerRepository();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)//SE VA
        {

        }

        private void visualizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomerVisualizer frm = new FrmCustomerVisualizer(this.customerRepository);

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.Show();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using(OpenFileDialog openFile = new OpenFileDialog())
                {
                    openFile.ShowDialog();
                    string fileName = openFile.FileName;
                    customerRepository.LoadFromFile(fileName);
                }
                //TODO completar
                //throw new NotImplementedException();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se puede abrir: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger.LogException(ex.Message);
            }
        }
            private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                try
                {

                    if (this.customerRepository.SaveToFile(customerRepository.GetAll()))
                    {
                        MessageBox.Show("Clientes serializados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No se puede Guardar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se puede Guardar: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Logger.LogException(ex.Message);
                }
            }

        private void FrmPrincipal_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
