
namespace ReporteDeFacturas
{
    partial class Form3
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
            this.DataReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSFacturas = new ReporteDeFacturas.DSFacturas();
            this.rvFPagos = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataReporteBindingSource
            // 
            this.DataReporteBindingSource.DataMember = "DataReporte";
            this.DataReporteBindingSource.DataSource = this.DSFacturas;
            // 
            // DSFacturas
            // 
            this.DSFacturas.DataSetName = "DSFacturas";
            this.DSFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvFPagos
            // 
            this.rvFPagos.LocalReport.ReportEmbeddedResource = "ReporteDeFacturas.rpfFPagos.rdlc";
            this.rvFPagos.Location = new System.Drawing.Point(0, 1);
            this.rvFPagos.Name = "rvFPagos";
            this.rvFPagos.ServerReport.BearerToken = null;
            this.rvFPagos.Size = new System.Drawing.Size(801, 447);
            this.rvFPagos.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvFPagos);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFPagos;
        private System.Windows.Forms.BindingSource DataReporteBindingSource;
        private DSFacturas DSFacturas;
    }
}