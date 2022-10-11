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
    public partial class Registro_examen : Form
    {
        ConexionsqlN con = new ConexionsqlN();
        public Registro_examen()
        {            
            InitializeComponent();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Mostrar información
            ElimError2();
            if (validating2())
            {
                var datos = con.registros3(txtNumId.Text);

                txtNombres.Text = datos.Item1;
                txtEdad.Text = datos.Item2;
                txtGénero.Text = datos.Item3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElimError1();
            if (validating1())
            {
                try
                {
                    var datos1 = con.Costo(cmbExamen1.Text);

                    txtCosto1.Text = datos1.Item1;

                    var datos2 = con.Costo(cmbExamen2.Text);

                    txtCosto2.Text = datos2.Item1;

                    //Cálculo del precio con descuento (Precio final)
                    //Suma del valor de los examenes 
                    int valor1 = Convert.ToInt32(txtCosto1.Text);
                    int valor2 = Convert.ToInt32(txtCosto2.Text);

                    int Total = valor1 + valor2;
                    txtTotal.Text = Total.ToString();

                    // Cálculo del descuento según grupo de edad
                    int Descuento = 0;
                    int Edad = Convert.ToInt32(txtEdad.Text);

                    if (Edad <= 15 || Edad >= 60)
                    {
                        Descuento = 20;
                    }
                    else if (Edad >= 16 && Edad <= 30)
                    {
                        Descuento = 15;
                    }
                    else
                    {
                        Descuento = 10;
                    }

                    txtDCTo.Text = Descuento.ToString();

                    //Precio final con descuento

                    Double precio = 0;

                    int Dct = Convert.ToInt32(txtDCTo.Text);

                    if (Dct == 20)
                    {
                        precio = Total - (Total * 0.20);
                    }
                    else if (Dct == 15)
                    {
                        precio = Total - (Total * 0.15);
                    }
                    else
                    {
                        precio = Total - (Total * 0.10);
                    }

                    txtPFinal.Text = precio.ToString();
                }
                catch
                {
                    MessageBox.Show("Verifique que los datos sean correctos");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElimError();
            if (validating())
            {
                con.Registraexamen(txtNumId.Text, cmbExamen1.Text, txtCosto1.Text, cmbExamen2.Text, txtCosto2.Text, txtDCTo.Text, txtPFinal.Text);

            }
        }

        private bool validating()
        {
            bool ok = true;

            if (txtNumId.Text == "")
            {
                ok = false;
                eV.SetError(txtNumId, "Ingrese el número de cédula");
            }

            if (txtNombres.Text == "")
            {
                ok = false;
                eV.SetError(txtNombres, "Ingrese el nombre");
            }
           
            if (txtEdad.Text == "")
            {
                ok = false;
                eV.SetError(txtEdad, "Ingrese la edad");
            }

            if (txtGénero.Text == "")
            {
                ok = false;
                eV.SetError(txtGénero, "Ingrese el género");
            }

            if (cmbExamen1.Text == "")
            {
                ok = false;
                eV.SetError(cmbExamen1, "Ingrese el examen");
            }

            if (txtPFinal.Text == "")
            {
                ok = false;
                eV.SetError(txtPFinal, "Ingrese el precio final del examen");
            }

            return ok;
        }
        private void ElimError()
        {
            eV.SetError(txtNumId, "");
            eV.SetError(txtNombres, "");
            eV.SetError(txtEdad, "");
            eV.SetError(txtGénero, "");
            eV.SetError(cmbExamen1, "");
            eV.SetError(txtPFinal, "");
        }

        private bool validating1()
        {
            bool ok = true;

            if (cmbExamen1.Text == "")
            {
                ok = false;
                eV.SetError(cmbExamen1, "Ingrese el examen");
            }

            if (txtEdad.Text == "")
            {
                ok = false;
                eV.SetError(txtEdad, "Ingrese la información del paciente");
            }

            return ok;
        }
        private void ElimError1()
        {
            eV.SetError(cmbExamen1, "");
            eV.SetError(txtEdad, "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElimError2();
            if (validating2())
            {
                var datos = con.Datosexamen(txtNumId.Text);
                dtRegistros.DataSource = datos;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Examen = new MenuL();
            Examen.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNumId.Text = "";
            txtNombres.Text = "";
            txtEdad.Text = "";
            txtGénero.Text = "";
            cmbExamen1.Text = "";
            cmbExamen2.Text = "";
            txtCosto1.Text = "";
            txtCosto2.Text = "";
            txtTotal.Text = "";
            txtDCTo.Text = "";
            txtPFinal.Text = "";
        }

        private bool validating2()
        {
            bool ok = true;

            if (txtNumId.Text == "")
            {
                ok = false;
                eV.SetError(txtNumId, "Ingrese numero de cédula");
            }

            return ok;
        }
        private void ElimError2()
        {
            eV.SetError(txtNumId, "");
        }
    }
}
