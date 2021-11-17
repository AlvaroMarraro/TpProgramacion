
namespace ReporteDeFacturas
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFPagos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnFPagos);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 456);
            this.panel1.TabIndex = 0;
            // 
            // btnFPagos
            // 
            this.btnFPagos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFPagos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFPagos.ForeColor = System.Drawing.Color.White;
            this.btnFPagos.Location = new System.Drawing.Point(0, 44);
            this.btnFPagos.Name = "btnFPagos";
            this.btnFPagos.Size = new System.Drawing.Size(185, 52);
            this.btnFPagos.TabIndex = 1;
            this.btnFPagos.Text = "Reporte Formas de pago";
            this.btnFPagos.UseVisualStyleBackColor = false;
            this.btnFPagos.Click += new System.EventHandler(this.btnFPagos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(0, 102);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(185, 52);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Reporte Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 160);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(185, 52);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Reporte clientes activos";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Location = new System.Drawing.Point(182, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(615, 450);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnFPagos;
        private System.Windows.Forms.Panel panelDesktop;
    }
}