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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FERREMANIA4;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("SP_REPORTE_FORMAS_PAGO", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Load(cmd2.ExecuteReader());
            rvFPagos.LocalReport.DataSources.Clear();
            rvFPagos.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table));
            rvFPagos.RefreshReport();
            cnn.Close();
        }
    }
}
