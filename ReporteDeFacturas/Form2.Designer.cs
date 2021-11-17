
namespace ReporteDeFacturas
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnCargar = new System.Windows.Forms.Button();
            this.rvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSFacturas = new ReporteDeFacturas.DSFacturas();
            this.DataClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(607, 415);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // rvClientes
            // 
            this.rvClientes.LocalReport.ReportEmbeddedResource = "ReporteDeFacturas.rptClientes.rdlc";
            this.rvClientes.Location = new System.Drawing.Point(3, -26);
            this.rvClientes.Name = "rvClientes";
            this.rvClientes.ServerReport.BearerToken = null;
            this.rvClientes.Size = new System.Drawing.Size(794, 444);
            this.rvClientes.TabIndex = 3;
            // 
            // dSFacturasBindingSource
            // 
            this.dSFacturasBindingSource.DataSource = this.DSFacturas;
            this.dSFacturasBindingSource.Position = 0;
            // 
            // DSFacturas
            // 
            this.DSFacturas.DataSetName = "DSFacturas";
            this.DSFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataClientesBindingSource
            // 
            this.DataClientesBindingSource.DataMember = "DataClientes";
            this.DataClientesBindingSource.DataSource = this.DSFacturas;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvClientes);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private Microsoft.Reporting.WinForms.ReportViewer rvClientes;
        private System.Windows.Forms.BindingSource DataClientesBindingSource;
        private DSFacturas DSFacturas;
        private System.Windows.Forms.BindingSource dSFacturasBindingSource;
    }
}