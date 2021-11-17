using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;

namespace ReporteDeFacturas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
               
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FERREMANIA4;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd2 = new SqlCommand("SP_REPORTE_TRAER_CLIENTES", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Load(cmd2.ExecuteReader());
            rvClientes.LocalReport.DataSources.Clear();
            rvClientes.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", table));
            rvClientes.RefreshReport();
            cnn.Close();
        }
    }
}
