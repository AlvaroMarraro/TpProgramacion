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

namespace FerremaniaFront
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ALVARONOTE\SQLEXPRESS;Initial Catalog=FERREMANIA3;Integrated Security=True");

        public void Login(string TxtUser, string TxtPass)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Usuario from Usuarios where Usuario = @Usuario And Pass = @pass", con);
                cmd.Parameters.AddWithValue("Usuario", TxtUser);
                cmd.Parameters.AddWithValue("Pass", TxtPass);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    this.Hide();
                    new FrmBienvenida();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña Incorrecta");
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login(this.TxtUser.Text, this.TxtPass.Text);
        }
    }
}
