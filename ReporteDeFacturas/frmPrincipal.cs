using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteDeFacturas
{
    public partial class frmPrincipal : Form
    {
        private Form currentChildForm;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ChildForm);
            panelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFPagos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());

        }
    }
}
