using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Laboratorio
{
    public partial class Login : Form
    {
        ConexionsqlN con = new ConexionsqlN();
        public Login()
        {
            InitializeComponent();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (con.conSQL(txtUsuario.Text, txtContraseña.Text) == 1)
            {
                var login = new MenuL();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
