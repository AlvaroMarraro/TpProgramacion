
namespace FerremaniaFront
{
    partial class FrmAltaFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblFacturaNro = new System.Windows.Forms.Label();
            this.btnModCliente = new FontAwesome.Sharp.IconButton();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboArticulos = new System.Windows.Forms.ComboBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAceptar.IconColor = System.Drawing.Color.White;
            this.btnAceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAceptar.IconSize = 20;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(417, 1293);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(231, 68);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancelar.IconColor = System.Drawing.Color.White;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 20;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(734, 1293);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(231, 68);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(236, 77);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(261, 47);
            this.dtpFecha.TabIndex = 25;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFecha.Location = new System.Drawing.Point(63, 79);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(135, 50);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "FECHA";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregar.IconColor = System.Drawing.Color.White;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 35;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(1526, 604);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(192, 63);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(1314, 612);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(182, 47);
            this.nudCantidad.TabIndex = 32;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblArticulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblArticulo.Location = new System.Drawing.Point(87, 612);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(194, 50);
            this.lblArticulo.TabIndex = 30;
            this.lblArticulo.Text = "ARTICULO";
            // 
            // lblFacturaNro
            // 
            this.lblFacturaNro.AutoSize = true;
            this.lblFacturaNro.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFacturaNro.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblFacturaNro.Location = new System.Drawing.Point(1421, 66);
            this.lblFacturaNro.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblFacturaNro.Name = "lblFacturaNro";
            this.lblFacturaNro.Size = new System.Drawing.Size(339, 50);
            this.lblFacturaNro.TabIndex = 35;
            this.lblFacturaNro.Text = "FACTURA NRO   |   ";
            // 
            // btnModCliente
            // 
            this.btnModCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.btnModCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.btnModCliente.FlatAppearance.BorderSize = 0;
            this.btnModCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModCliente.ForeColor = System.Drawing.Color.White;
            this.btnModCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModCliente.IconColor = System.Drawing.Color.White;
            this.btnModCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModCliente.IconSize = 35;
            this.btnModCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModCliente.Location = new System.Drawing.Point(1049, 140);
            this.btnModCliente.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.btnModCliente.Name = "btnModCliente";
            this.btnModCliente.Size = new System.Drawing.Size(305, 63);
            this.btnModCliente.TabIndex = 58;
            this.btnModCliente.Text = "Modificar Cliente";
            this.btnModCliente.UseVisualStyleBackColor = false;
            this.btnModCliente.Click += new System.EventHandler(this.btnModCliente_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(869, 75);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(485, 49);
            this.cboCliente.TabIndex = 57;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(582, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 50);
            this.label2.TabIndex = 56;
            this.label2.Text = "Buscar Cliente";
            // 
            // cboArticulos
            // 
            this.cboArticulos.FormattingEnabled = true;
            this.cboArticulos.Location = new System.Drawing.Point(272, 612);
            this.cboArticulos.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.cboArticulos.Name = "cboArticulos";
            this.cboArticulos.Size = new System.Drawing.Size(1022, 49);
            this.cboArticulos.TabIndex = 60;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(419, 439);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(551, 47);
            this.txtCalle.TabIndex = 66;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(419, 369);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(546, 47);
            this.txtNombre.TabIndex = 64;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(419, 298);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(546, 47);
            this.txtApellido.TabIndex = 65;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(419, 224);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(305, 47);
            this.txtDocumento.TabIndex = 63;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCalle.Location = new System.Drawing.Point(272, 435);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(130, 51);
            this.lblCalle.TabIndex = 70;
            this.lblCalle.Text = "CALLE";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblApellido.Location = new System.Drawing.Point(207, 298);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(195, 51);
            this.lblApellido.TabIndex = 69;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombre.Location = new System.Drawing.Point(220, 365);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(182, 51);
            this.lblNombre.TabIndex = 68;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDocumento.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDocumento.Location = new System.Drawing.Point(141, 224);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(261, 51);
            this.lblDocumento.TabIndex = 67;
            this.lblDocumento.Text = "DOCUMENTO";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(419, 529);
            this.cboFormaPago.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(546, 49);
            this.cboFormaPago.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(87, 529);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 50);
            this.label3.TabIndex = 61;
            this.label3.Text = "FORMA DE PAGO";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(1261, 369);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 47);
            this.txtEmail.TabIndex = 73;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(1261, 298);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(393, 47);
            this.txtTelefono.TabIndex = 72;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(1261, 432);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(393, 47);
            this.txtAltura.TabIndex = 71;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEmail.Location = new System.Drawing.Point(1114, 369);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(133, 51);
            this.lblEmail.TabIndex = 76;
            this.lblEmail.Text = "EMAIL";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTelefono.Location = new System.Drawing.Point(1049, 298);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(208, 51);
            this.lblTelefono.TabIndex = 75;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAltura.Location = new System.Drawing.Point(1084, 431);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(163, 51);
            this.lblAltura.TabIndex = 74;
            this.lblAltura.Text = "ALTURA";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detalle,
            this.Articulo,
            this.precio,
            this.Cantidad,
            this.colSubTotal,
            this.acciones});
            this.dgvDetalles.Location = new System.Drawing.Point(76, 677);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(1655, 571);
            this.dgvDetalles.TabIndex = 77;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Column1";
            this.detalle.MinimumWidth = 6;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Visible = false;
            this.detalle.Width = 125;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.MinimumWidth = 6;
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 400;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 200;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "Subtotal";
            this.colSubTotal.MinimumWidth = 6;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.Width = 200;
            // 
            // acciones
            // 
            this.acciones.HeaderText = "Acciones";
            this.acciones.MinimumWidth = 6;
            this.acciones.Name = "acciones";
            this.acciones.ReadOnly = true;
            this.acciones.Text = "Quitar";
            this.acciones.UseColumnTextForButtonValue = true;
            this.acciones.Width = 200;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotal.Location = new System.Drawing.Point(1126, 1282);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(131, 51);
            this.lblTotal.TabIndex = 78;
            this.lblTotal.Text = "TOTAL";
            // 
            // FrmAltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1991, 1421);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboArticulos);
            this.Controls.Add(this.btnModCliente);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFacturaNro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmAltaFactura";
            this.Text = "FrmAltaFactura";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblFacturaNro;
        private FontAwesome.Sharp.IconButton btnModCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboArticulos;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn acciones;
        private System.Windows.Forms.Label lblTotal;
    }
}