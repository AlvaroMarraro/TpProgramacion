
namespace FerremaniaFront
{
    partial class FrmAltaCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAccion = new System.Windows.Forms.Label();
            this.rdbAlta = new System.Windows.Forms.RadioButton();
            this.rdbModificar = new System.Windows.Forms.RadioButton();
            this.rdbEliminar = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAceptar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.lblAccion.Location = new System.Drawing.Point(41, 46);
            this.lblAccion.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(365, 51);
            this.lblAccion.TabIndex = 0;
            this.lblAccion.Text = "Seleccionar Acción:";
            // 
            // rdbAlta
            // 
            this.rdbAlta.AutoSize = true;
            this.rdbAlta.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbAlta.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdbAlta.Location = new System.Drawing.Point(410, 46);
            this.rdbAlta.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rdbAlta.Name = "rdbAlta";
            this.rdbAlta.Size = new System.Drawing.Size(117, 49);
            this.rdbAlta.TabIndex = 1;
            this.rdbAlta.TabStop = true;
            this.rdbAlta.Text = "Alta";
            this.rdbAlta.UseVisualStyleBackColor = true;
            this.rdbAlta.Click += new System.EventHandler(this.rdbAlta_Click);
            // 
            // rdbModificar
            // 
            this.rdbModificar.AutoSize = true;
            this.rdbModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbModificar.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdbModificar.Location = new System.Drawing.Point(566, 46);
            this.rdbModificar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rdbModificar.Name = "rdbModificar";
            this.rdbModificar.Size = new System.Drawing.Size(202, 49);
            this.rdbModificar.TabIndex = 2;
            this.rdbModificar.TabStop = true;
            this.rdbModificar.Text = "Modificar";
            this.rdbModificar.UseVisualStyleBackColor = true;
            this.rdbModificar.Click += new System.EventHandler(this.rdbModificar_Click);
            // 
            // rdbEliminar
            // 
            this.rdbEliminar.AutoSize = true;
            this.rdbEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbEliminar.ForeColor = System.Drawing.Color.DarkBlue;
            this.rdbEliminar.Location = new System.Drawing.Point(794, 46);
            this.rdbEliminar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rdbEliminar.Name = "rdbEliminar";
            this.rdbEliminar.Size = new System.Drawing.Size(178, 49);
            this.rdbEliminar.TabIndex = 3;
            this.rdbEliminar.TabStop = true;
            this.rdbEliminar.Text = "Eliminar";
            this.rdbEliminar.UseVisualStyleBackColor = true;
            this.rdbEliminar.Click += new System.EventHandler(this.rdbEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.panel1.Location = new System.Drawing.Point(542, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 55);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.panel2.Location = new System.Drawing.Point(775, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 55);
            this.panel2.TabIndex = 5;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(1239, 38);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(485, 49);
            this.cboCliente.TabIndex = 4;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(94)))), ((int)(((byte)(138)))));
            this.panel3.Location = new System.Drawing.Point(27, 131);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1943, 11);
            this.panel3.TabIndex = 5;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDocumento.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDocumento.Location = new System.Drawing.Point(158, 333);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(261, 51);
            this.lblDocumento.TabIndex = 7;
            this.lblDocumento.Text = "DOCUMENTO";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombre.Location = new System.Drawing.Point(988, 470);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(182, 51);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblApellido.Location = new System.Drawing.Point(223, 470);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(195, 51);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCalle.Location = new System.Drawing.Point(287, 612);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(130, 51);
            this.lblCalle.TabIndex = 10;
            this.lblCalle.Text = "CALLE";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAltura.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAltura.Location = new System.Drawing.Point(255, 741);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(163, 51);
            this.lblAltura.TabIndex = 11;
            this.lblAltura.Text = "ALTURA";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTelefono.Location = new System.Drawing.Point(209, 880);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(208, 51);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblEmail.Location = new System.Drawing.Point(282, 1017);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(133, 51);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "EMAIL";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(423, 325);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(305, 47);
            this.txtDocumento.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(423, 467);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(546, 47);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(1178, 467);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(546, 47);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(423, 610);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(854, 47);
            this.txtCalle.TabIndex = 7;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(423, 738);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(223, 47);
            this.txtAltura.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(423, 877);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(393, 47);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(423, 1014);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(735, 47);
            this.txtEmail.TabIndex = 10;
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
            this.btnAceptar.Location = new System.Drawing.Point(680, 1246);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(231, 68);
            this.btnAceptar.TabIndex = 11;
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
            this.btnCancelar.Location = new System.Drawing.Point(1052, 1246);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(231, 68);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 20;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(1493, 1246);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(231, 68);
            this.btnSalir.TabIndex = 80;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1991, 1421);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdbEliminar);
            this.Controls.Add(this.rdbModificar);
            this.Controls.Add(this.rdbAlta);
            this.Controls.Add(this.lblAccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FrmAltaCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.RadioButton rdbAlta;
        private System.Windows.Forms.RadioButton rdbModificar;
        private System.Windows.Forms.RadioButton rdbEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private FontAwesome.Sharp.IconButton btnAceptar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}

