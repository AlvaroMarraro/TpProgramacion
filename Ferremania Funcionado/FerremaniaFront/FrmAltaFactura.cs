using FerremaniaBack.Dominio;
using FerremaniaBack.Servicios.Implementaciones;
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
    public partial class FrmAltaFactura : Form
    {

        FacturaService facturaServicio = new FacturaService();
        Factura oFactura = new Factura();
        FormaPago oFormaPago = new FormaPago();
        ClienteServicios clienteService = new ClienteServicios();
        Cliente oCliente = new Cliente();
        int codCliente = 0;
        public FrmAltaFactura()
        {
            InitializeComponent();
            cargarClientes();
            CargarComboArticulos();
            CargarFormaPago();
            ConsultarUltimaFactura();
            txtAltura.Enabled = false;
            txtApellido.Enabled = false;
            txtCalle.Enabled = false;
            txtDocumento.Enabled = false;
            txtEmail.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            dtpFecha.Enabled = false;
        }

        private void cargarClientes()
        {
            List<Cliente> clientes = clienteService.getClientes();
            BindingSource conector = new BindingSource();
            conector.DataSource = clientes;
            cboCliente.DataSource = conector;
            cboCliente.ValueMember = "CodCliente";
            cboCliente.DisplayMember = "DocCliente";
        }

        private void traerDatosClientes()
        {
            List<Cliente> clientes = clienteService.getClientes();

            foreach (var item in clientes)
            {
                if (cboCliente.SelectedItem.ToString().Contains(item.DocCliente.ToString()))
                {
                    codCliente = item.CodCliente;
                    txtDocumento.Text = item.DocCliente.ToString();
                    txtApellido.Text = item.ApellidoCliente;
                    txtNombre.Text = item.NombreCliente;
                    txtCalle.Text = item.Calle;
                    txtAltura.Text = item.Altura.ToString();
                    txtEmail.Text = item.Email;
                    txtTelefono.Text = item.NroTel.ToString();
                    break;
                }
            }
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            traerDatosClientes();
        }

        private void CargarComboArticulos()
        {
            List<Articulo> oArticulo = facturaServicio.ConsultarArticulos();
            BindingSource conector = new BindingSource();
            conector.DataSource = oArticulo;
            cboArticulos.DataSource = conector;
            cboArticulos.ValueMember = "Cod_articulo";
            cboArticulos.DisplayMember = "Descripcion";

        }
        private void CargarFormaPago()
        {
            List<FormaPago> oFormaPago = facturaServicio.ConsultarFormaPago();
            BindingSource conector = new BindingSource();
            conector.DataSource = oFormaPago;
            cboFormaPago.DataSource = conector;
            cboFormaPago.ValueMember = "CodFormaPago";
            cboFormaPago.DisplayMember = "Nombre";
        }

        private bool ExisteProductoEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["Articulo"].Value.Equals(text))
                    return true;
            }
            return false;
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente mod = new FrmAltaCliente();
            mod.Show();
        }

        private void ConsultarUltimaFactura()
        {
            lblFacturaNro.Text = "Factura Nro: " + facturaServicio.ObtenerProximaFacturaID();
        }
        private void CalcularTotales()
        {
            double Total = oFactura.CalcularTotal();
            lblTotal.Text = "Total: " + Total.ToString();

            //pasar total al objeto
            oFactura.Total = Total;
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 5)
            {
                oFactura.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                CalcularTotales();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar el registro?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ExisteProductoEnGrilla(cboArticulos.Text))
            {
                MessageBox.Show("Articulo ya agregado como detalle", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleFactura item = new DetalleFactura();

            Articulo oArticulo = (Articulo)cboArticulos.SelectedItem;
            item.Articulo = oArticulo;
            item.Cantidad = (int)nudCantidad.Value;

            oFactura.AgregarDetalle(item);

            dgvDetalles.Rows.Add(new object[] { "", oArticulo.Descripcion, oArticulo.Pre_unitario, item.Cantidad, item.CalcularSubTotal() }); ;

            CalcularTotales();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto como detalle", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboArticulos.Focus();
                return;
            }
           //tambien con formas de pago que esta en facturas o no 
           // sisi todo lo que n esté asignado y te haga falta para registrar la factura
            oFactura.CodCliente = cboCliente.SelectedIndex;
            oFactura.CodFormaPago = cboFormaPago.SelectedIndex;
            oFactura.Fecha = dtpFecha.Value;
            if (facturaServicio.GrabarFactura(oFactura))
            {
                MessageBox.Show("Factura generada con éxito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al intentar generar la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
