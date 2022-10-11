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
    public partial class Registro_paciente : Form
    {
        ConexionsqlN con = new ConexionsqlN();
        public Registro_paciente()
        {
            InitializeComponent();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ElimError();
            if (validating())
            {
                try
                {

                    con.Registrarpaciente(txtNumId.Text, txtNombres.Text, cmbTipoId.Text, cmbGénero.Text, dtTmFecha.Text, txtEdad.Text, cmbEstadoCiv.Text, txtDirección.Text, txtBarrio.Text, txtTeléfono.Text, txtOcupación.Text, cmbEscolaridad.Text, txtEPS.Text, cmbRégimen.Text, txtEmail.Text, txtAntecedentes.Text, txtContactoE.Text);

                    MessageBox.Show("El registro se ha realizado con éxito");

                    txtNombres.Text = "";
                    cmbTipoId.Text = "";
                    txtNumId.Text = "";
                    cmbGénero.Text = "";
                    dtTmFecha.Text = "";
                    txtEdad.Text = "";
                    cmbEstadoCiv.Text = "";
                    txtDirección.Text = "";
                    txtBarrio.Text = "";
                    txtTeléfono.Text = "";
                    txtOcupación.Text = "";
                    cmbEscolaridad.Text = "";
                    txtEPS.Text = "";
                    cmbRégimen.Text = "";
                    txtEmail.Text = "";
                    txtAntecedentes.Text = "";
                    txtContactoE.Text = "";
                }
                catch
                {
                    MessageBox.Show("Error: Verifique que los datos sean correctos ");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Registro = new MenuL();
            Registro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ElimError1();
            if (validating1())
            {
                try
                {
                    con.ModificarInfo(txtNumId.Text, txtNombres.Text, cmbTipoId.Text, cmbGénero.Text, dtTmFecha.Text, txtEdad.Text, cmbEstadoCiv.Text, txtDirección.Text, txtBarrio.Text, txtTeléfono.Text, txtOcupación.Text, cmbEscolaridad.Text, txtEPS.Text, cmbRégimen.Text, txtEmail.Text, txtAntecedentes.Text, txtContactoE.Text);

                    MessageBox.Show("La información se actualizó con éxito");
                }
                catch
                {
                    MessageBox.Show("Error: Verifique que la cedula ingresada sea correcta");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ElimError1();
            if (validating1())
            {
                try
                {
                    var datos = con.registros(txtNumId.Text);

                    txtNombres.Text = datos.Item1;
                    cmbTipoId.Text = datos.Item2;
                    cmbGénero.Text = datos.Item3;
                    dtTmFecha.Text = datos.Item4;
                    txtEdad.Text = datos.Item5;
                    cmbEstadoCiv.Text = datos.Item6;
                    txtDirección.Text = datos.Item7;

                    var datos1 = con.registros1(txtNumId.Text);

                    txtBarrio.Text = datos1.Item1;
                    txtTeléfono.Text = datos1.Item2;
                    txtOcupación.Text = datos1.Item3;
                    cmbEscolaridad.Text = datos1.Item4;
                    txtEPS.Text = datos1.Item5;
                    cmbRégimen.Text = datos1.Item6;
                    txtEmail.Text = datos1.Item7;

                    var datos2 = con.registros2(txtNumId.Text);

                    txtAntecedentes.Text = datos2.Item1;
                    txtContactoE.Text = datos2.Item2;
                }
                catch
                {
                    MessageBox.Show("Error: Verifique que la cedula ingresada sea correcta");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ElimError1();
            if (validating1())
            {
                con.Eliminar(txtNumId.Text);

                txtNombres.Text = "";
                cmbTipoId.Text = "";
                txtNumId.Text = "";
                cmbGénero.Text = "";
                dtTmFecha.Text = "";
                txtEdad.Text = "";
                cmbEstadoCiv.Text = "";
                txtDirección.Text = "";
                txtBarrio.Text = "";
                txtTeléfono.Text = "";
                txtOcupación.Text = "";
                cmbEscolaridad.Text = "";
                txtEPS.Text = "";
                cmbRégimen.Text = "";
                txtEmail.Text = "";
                txtAntecedentes.Text = "";
                txtContactoE.Text = "";

                MessageBox.Show("Registro eliminado con éxito");
            }
        }

        // Validación de que los campos solicitados para el registro de pacientes no estén vacíos 
        private bool validating()
        {
            bool ok = true;

            if (txtNumId.Text == "")
            {
                ok = false;
                eVR.SetError(txtNumId, "Ingrese numero de cédula");
            }

            if (cmbTipoId.Text == "")
            {
                ok = false;
                eVR.SetError(cmbTipoId, "Ingrese el tipo de identificación");
            }

            if (txtNombres.Text == "")
            {
                ok = false;
                eVR.SetError(txtNombres, "Ingrese el nombre completo");
            }

            if (cmbGénero.Text == "")
            {
                ok = false;
                eVR.SetError(cmbGénero, "Ingrese el género");
            }

            if (dtTmFecha.Text == "")
            {
                ok = false;
                eVR.SetError(dtTmFecha, "Ingrese la fecha de nacimiento");
            }

            if (dtTmFecha.Text == "")
            {
                ok = false;
                eVR.SetError(dtTmFecha, "Ingrese la fecha de nacimiento");
            }

            if (txtEdad.Text == "")
            {
                ok = false;
                eVR.SetError(txtEdad, "Ingrese la edad");
            }

            if (cmbEstadoCiv.Text == "")
            {
                ok = false;
                eVR.SetError(cmbEstadoCiv, "Ingrese el estado civil");
            }

            if (txtDirección.Text == "")
            {
                ok = false;
                eVR.SetError(txtDirección, "Ingrese la dirección de residencia");
            }

            if (txtBarrio.Text == "")
            {
                ok = false;
                eVR.SetError(txtBarrio, "Ingrese el barrio de residencia");
            }

            if (txtTeléfono.Text == "")
            {
                ok = false;
                eVR.SetError(txtTeléfono, "Ingrese el teléfono");
            }

            if (txtOcupación.Text == "")
            {
                ok = false;
                eVR.SetError(txtOcupación, "Ingrese la ocupación");
            }

            if (cmbEscolaridad.Text == "")
            {
                ok = false;
                eVR.SetError(cmbEscolaridad, "Ingrese el nivel de escolaridad");
            }

            if (txtEPS.Text == "")
            {
                ok = false;
                eVR.SetError(txtEPS, "Ingrese la EPS");
            }

            if (cmbRégimen.Text == "")
            {
                ok = false;
                eVR.SetError(cmbRégimen, "Ingrese el régimen");
            }

            if (txtEmail.Text == "")
            {
                ok = false;
                eVR.SetError(txtEmail, "Ingrese el Email");
            }

            if (txtContactoE.Text == "")
            {
                ok = false;
                eVR.SetError(txtContactoE, "Ingrese un contacto de emergencia");
            }

            return ok;
        }

        //Quitar el errorprovider una vez se llene el campo solicitado 
        private void ElimError()
        {
            eVR.SetError(txtNumId, "");
            eVR.SetError(cmbTipoId, "");
            eVR.SetError(txtNombres, "");
            eVR.SetError(cmbGénero, "");
            eVR.SetError(dtTmFecha, "");
            eVR.SetError(txtEdad, "");
            eVR.SetError(cmbEstadoCiv, "");
            eVR.SetError(txtDirección, "");
            eVR.SetError(txtBarrio, "");
            eVR.SetError(txtTeléfono, "");
            eVR.SetError(txtOcupación, "");
            eVR.SetError(cmbEscolaridad, "");
            eVR.SetError(txtEPS, "");
            eVR.SetError(cmbRégimen, "");
            eVR.SetError(txtEmail, "");
            eVR.SetError(txtContactoE, "");
        }

        private bool validating1()
        {
            bool ok = true;

            if (txtNumId.Text == "")
            {
                ok = false;
                eVR.SetError(txtNumId, "Ingrese numero de cédula");
            }

            return ok;
        }

        private void ElimError1()
        {
            eVR.SetError(txtNumId, "");
        }
    }
}
