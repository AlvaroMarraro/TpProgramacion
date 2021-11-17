
namespace ReporteDeFacturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dSFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSFacturas = new ReporteDeFacturas.DSFacturas();
            this.DataReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvFacturas
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dSFacturasBindingSource;
            this.rvFacturas.LocalReport.DataSources.Add(reportDataSource3);
            this.rvFacturas.LocalReport.ReportEmbeddedResource = "ReporteDeFacturas.rptFaturasXdia.rdlc";
            this.rvFacturas.Location = new System.Drawing.Point(2, 41);
            this.rvFacturas.Name = "rvFacturas";
            this.rvFacturas.ServerReport.BearerToken = null;
            this.rvFacturas.Size = new System.Drawing.Size(797, 408);
            this.rvFacturas.TabIndex = 0;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(236, 15);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "Mes";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(269, 12);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 3;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(375, 10);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Generar";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
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
            // DataReporteBindingSource
            // 
            this.DataReporteBindingSource.DataMember = "DataReporte";
            this.DataReporteBindingSource.DataSource = this.DSFacturas;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(163)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.rvFacturas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReporteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFacturas;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.BindingSource DataReporteBindingSource;
        private DSFacturas DSFacturas;
        private System.Windows.Forms.BindingSource dSFacturasBindingSource;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

