using FerremaniaBack.Dominio;
using FerremaniaBack.Servicios;
using FerremaniaBack.Servicios.Implementaciones;
using FerremaniaBack.Servicios.Interfaces;
using FerremaniaFront.ClienteSingleton;
using Newtonsoft.Json;
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
    public partial class FrmAltaCliente : Form
    {
        ClienteServicios clienteService = new ClienteServicios();
        Cliente oCliente = new Cliente();
        int codCliente = 0;
        private IClienteServicios servicio;
        public FrmAltaCliente()
        {
            InitializeComponent();
            servicio = new ServiceFactoryImp().CrearService();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            rdbAlta.Checked = true;
            cboCliente.Enabled = false;
        }
        private bool ValidarCampos()
        {

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Nombre de Cliente",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un Apellido de Cliente",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDocumento.Text)
                || !int.TryParse(txtDocumento.Text, out _)
                || Convert.ToInt32(txtDocumento.Text) <= 0
                || txtDocumento.Text.Length < 8)
            {
                MessageBox.Show("Debe Ingresar un DNI válido",
                    "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumento.Focus();
                return false;
            }
            if (txtCalle.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la calle",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un telefono",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            if (txtAltura.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la altura",
                    "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           try {  
            if (ValidarCampos())
            {
                oCliente.CodCliente = Convert.ToInt32(this.codCliente);
                oCliente.DocCliente = Convert.ToInt32(txtDocumento.Text);
                oCliente.NombreCliente = txtNombre.Text;
                oCliente.ApellidoCliente = txtApellido.Text;
                oCliente.Calle = txtCalle.Text;
                oCliente.Altura = Convert.ToInt32(txtAltura.Text);
                oCliente.NroTel = Convert.ToInt32(txtTelefono.Text);
                oCliente.Email = txtEmail.Text;
                if (rdbAlta.Checked)
                {
                    altaCliente();
                }
                else if (rdbModificar.Checked)
                {
                    modificarCliente();
                }
                else
                {
                    eliminarCliente();
                }
             }

            }
            catch (Exception ex)
            {
                string error = ex.Message; 
            }
        }
        private void eliminarCliente()
        {
            if (clienteService.EliminarCliente(oCliente.CodCliente))
            {
                MessageBox.Show("El Cliente se ha dado de baja con éxito",
                    "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LimpiarCampos(); crear la funcion
            }
            else
            {
                MessageBox.Show("El Cliente no pudo ser dado de baja,\n consulte al Administrador",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modificarCliente()
        {
            if (clienteService.modificarCliente(oCliente))
            {
                MessageBox.Show("El Cliente se ha Modificado con éxito",
                    "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LimpiarCampos(); crear la funcion
            }
            else
            {
                MessageBox.Show("El Cliente no pudo Modificarse, consulte al Administrador",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void altaCliente()
        {
            if (clienteService.RegistrarCliente(oCliente))
            {
                MessageBox.Show("El Cliente se ha Registrado con éxito",
                    "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LimpiarCampos(); crear la funcion
            }
            else
            {
                MessageBox.Show("El Cliente no pudo Registrarse, consulte al Administrador",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarComboClientes()
        {
            List<Cliente> clientes = clienteService.getClientes();
            BindingSource conector = new BindingSource();
            conector.DataSource = clientes;
            cboCliente.DataSource = conector;
            cboCliente.ValueMember = "CodCliente";
            cboCliente.DisplayMember = "DocCliente";
        }

        private async void traerDatosClientes()
        {
            List<Cliente> lst = clienteService.getClientes();
            string filtrosJSON = JsonConvert.SerializeObject(lst);
            string url = "https://localhost:44304/api/Cliente/consultar";

            var resultado = await ClienteSingle.GetInstance().PostAsync(url, filtrosJSON);

            lst = JsonConvert.DeserializeObject<List<Cliente>>(resultado);

            foreach (var item in lst)
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

        private void rdbAlta_Click(object sender, EventArgs e)
        {
            cboCliente.Enabled = false;
        }

        private void rdbModificar_Click(object sender, EventArgs e)
        {
            cboCliente.Enabled = true;
            cargarComboClientes();
            traerDatosClientes();
        }

        private void rdbEliminar_Click(object sender, EventArgs e)
        {
            cboCliente.Enabled = true;
            cargarComboClientes();
            traerDatosClientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtAltura.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            rdbAlta.Checked = true;
            cboCliente.Enabled = false;
            rdbAlta.Focus();
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            traerDatosClientes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Salir?", "", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }
}
