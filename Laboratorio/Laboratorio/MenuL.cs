using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class MenuL : Form
    {
        public MenuL()
        {
            InitializeComponent();
        }

        private void btnRegistroPaci_Click(object sender, EventArgs e)
        {
            var Menu = new Registro_paciente();
            Menu.Show();
            this.Hide();
        }

        private void btnAtencionNacio_Click(object sender, EventArgs e)
        {
            var Menu = new Atencion_Nacional();
            Menu.Show();
            this.Hide();
        }

        private void btnRegistroExam_Click(object sender, EventArgs e)
        {
            var Menu = new Registro_examen();
            Menu.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuL_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MenuL = new Login();
            MenuL.Show();
            this.Hide();
        }
    }
}
