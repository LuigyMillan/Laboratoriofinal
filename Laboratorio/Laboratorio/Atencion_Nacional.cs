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
    public partial class Atencion_Nacional : Form
    {
        ConexionsqlN con = new ConexionsqlN();
        public Atencion_Nacional()
        {
            InitializeComponent();
        }

        private void cmbSucursal_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var datos = con.infoSucursal(cmbSucursal.Text);

                txtId.Text = datos.Item1;
                txtDirección.Text = datos.Item2;
                txtTeléfono.Text = datos.Item3;
                txtEmail.Text = datos.Item4;

                var horarios = con.EResultados(txtId.Text);
                dtResultados.DataSource = horarios;

                var horarios2 = con.TMuestra(txtId.Text);
                dtMuestras.DataSource = horarios2;
            }
            catch
            {
                MessageBox.Show("Verifique que el nombre de la sucursal sea correcto ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Atención = new MenuL();
            Atención.Show();
            this.Hide();
        }
    }
}
