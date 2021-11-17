using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerremaniaFront
{
    public partial class FrmBienvenida : Form
    {
        private Form currentChildForm;
        public FrmBienvenida()
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

        private void btnAltaFactura_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAltaFactura());
        }

        private void btnConsultaFacturas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmConsultarFactura());
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAltaCliente());
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAcercaDe());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está a punto de salir del programa \n esta seguro?", "Advertencia", MessageBoxButtons.YesNo);
            if(respuesta == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}
