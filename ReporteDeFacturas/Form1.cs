using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteDeFacturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.rvFacturas.RefreshReport();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(txtMes.Text);
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FERREMANIA4;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("SP_FACTURAS_POR_DIA", cnn);
            cmd2.Parameters.AddWithValue("@mes", mes);
            cmd2.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Load(cmd2.ExecuteReader());
            rvFacturas.LocalReport.DataSources.Clear();
            rvFacturas.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table));
            rvFacturas.RefreshReport();
            cnn.Close();
        }
    }
}
