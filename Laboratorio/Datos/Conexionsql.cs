using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexionsql
    {
        static string conexionstring = "Data Source=localhost;Initial Catalog=Laboratorio;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection(conexionstring);

        public int consultalogin(string Usuario, string Contraseña)
        {
            int count;
            conexion.Open();
            string Query = "Select Count(*) From Login where Usuario ='" + Usuario + "'and contraseña ='" + Contraseña + "'";
            SqlCommand cmd = new SqlCommand(Query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();
            return count;
        }

        public int Registrarpaciente(string NumIdentificación, string Nombres, string TipoIdentificación, string Género, string FechaNacimiento, string Edad, string EstadoCivil, string Dirección, string Barrio, string Teléfono, string Ocupación, string Escolaridad, string EPS, string Régimen, string Email, string Antecedentes, string TelefonoEmergencia)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Registro_paciente values ('" + NumIdentificación + "', '" + Nombres + "', '" + TipoIdentificación + "', '" + Género + "', '" + FechaNacimiento + "', '" + Edad + "', '" + EstadoCivil + "', '" + Dirección + "', '" + Barrio + "', '" + Teléfono + "', '" + Ocupación + "', '" + Escolaridad + "', '" + EPS + "', '" + Régimen + "', '" + Email + "', '" + Antecedentes + "', '" + TelefonoEmergencia + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);

            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public int ModificarInfo(string NumIdentificación, string Nombres, string TipoIdentificación, string Género, string FechaNacimiento, string Edad, string EstadoCivil, string Dirección, string Barrio, string Teléfono, string Ocupación, string Escolaridad, string EPS, string Régimen, string Email, string Antecedentes, string TelefonoEmergencia)
        {
            int flag = 0;
            conexion.Open();
            string query = "update Registro_paciente set nombres = '" + Nombres + "', tipoIdentificación = '" + TipoIdentificación + "', género = '" + Género + "', fechaNacimiento = '" + FechaNacimiento + "', edad = '" + Edad + "', estadocivil = '" + EstadoCivil + "', dirección = '" + Dirección + "', barrio = '" + Barrio + "', teléfono = '" + Teléfono + "', ocupación = '" + Ocupación + "', escolaridad = '" + Escolaridad + "', EPS = '" + EPS + "', régimen = '" + Régimen + "', email = '" + Email + "', antecedentes = '" + Antecedentes + "', telefonoEmergencia = '" + TelefonoEmergencia + "' where numIdentificación = '" + NumIdentificación + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();

            return flag;
        }

        public Tuple<string, string, string, string, string, string, string> registros(string NumIdentificación)
        {
            conexion.Open();

            string nombres = "NULL";
            string tipoId = "NULL";
            string género = "NULL";
            string fechaNac = "NULL";
            string edad = "NULL";
            string estadoCiv = "NULL";
            string dirección = "NULL";


            string query = "select * from Registro_paciente where NumIdentificación = '" + NumIdentificación + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader info = cmd.ExecuteReader();

            if (info.Read())
            {
                nombres = info["Nombres"].ToString();
                tipoId = info["TipoIdentificación"].ToString();
                género = info["Género"].ToString();
                fechaNac = info["FechaNacimiento"].ToString();
                edad = info["Edad"].ToString();
                estadoCiv = info["EstadoCivil"].ToString();
                dirección = info["Dirección"].ToString();
            }

            conexion.Close();
            return Tuple.Create(nombres, tipoId, género, fechaNac, edad, estadoCiv, dirección);
        }

        public Tuple<string, string, string, string, string, string, string> registros1(string NumIdentificación)
        {
            conexion.Open();

            string barrio = "NULL";
            string teléfono = "NULL";
            string ocupación = "NULL";
            string escolaridad = "NULL";
            string EPS = "NULL";
            string régimen = "NULL";
            string email = "NULL";


            string query = "select * from Registro_paciente where NumIdentificación = '" + NumIdentificación + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader info = cmd.ExecuteReader();

            if (info.Read())
            {
                barrio = info["Barrio"].ToString();
                teléfono = info["Teléfono"].ToString();
                ocupación = info["Ocupación"].ToString();
                escolaridad = info["Escolaridad"].ToString();
                EPS = info["EPS"].ToString();
                régimen = info["Régimen"].ToString();
                email = info["Email"].ToString();
            }

            conexion.Close();
            return Tuple.Create(barrio, teléfono, ocupación, escolaridad, EPS, régimen, email);
        }

        public Tuple<string, string> registros2(string NumIdentificación)
        {
            conexion.Open();

            string antecedentes = "NULL";
            string telefonoEmergencia = "NULL";


            string query = "select * from Registro_paciente where NumIdentificación = '" + NumIdentificación + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader info = cmd.ExecuteReader();

            if (info.Read())
            {
                antecedentes = info["Antecedentes"].ToString();
                telefonoEmergencia = info["TelefonoEmergencia"].ToString();
            }

            conexion.Close();
            return Tuple.Create(antecedentes, telefonoEmergencia);
        }

        public int Eliminar(string NumIdentificación)
        {
            int flag = 0;
            conexion.Open();
            string query = "Delete from Registro_paciente where numIdentificación = '" + NumIdentificación + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public Tuple<string, string, string> registros3(string NumIdentificación)
        {
            conexion.Open();

            string nombres = "NULL";
            string edad = "NULL";
            string género = "NULL";


            string query = "select * from Registro_paciente where NumIdentificación = '" + NumIdentificación + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader info = cmd.ExecuteReader();

            if (info.Read())
            {
                nombres = info["Nombres"].ToString();
                edad = info["Edad"].ToString();
                género = info["Género"].ToString();
            }

            conexion.Close();
            return Tuple.Create(nombres, edad, género);
        }

        public Tuple<string> Costo(string TipoExamen)
        {
            conexion.Open();

            string costo = "0";

            string query = "select * from Examen where tipoExamen = '" + TipoExamen + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader info = cmd.ExecuteReader();

            if (info.Read())
            {
                costo = info["Costo"].ToString();                
            }

            conexion.Close();
            return Tuple.Create(costo);
        }

        public int Registraexamen(string IdPaciente, string Examen1, string Costo_Ex1, string Examen2, string Costo_Ex2, string Descuento, string CostoFinal)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Registro_examen values ('" + IdPaciente + "', '" + Examen1 + "', '" + Costo_Ex1 + "', '" + Examen2 + "', '" + Costo_Ex2 + "', '" + Descuento + "', '" + CostoFinal + "')";
            SqlCommand cmd = new SqlCommand(query, conexion);

            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;
        }

        public DataTable Datosexamen(string IdPaciente)
        {
            string query = "select * from Registro_examen where idPaciente = '" + IdPaciente + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable datos = new DataTable();
            data.Fill(datos);

            return datos;
        }

        public Tuple<string, string, string, string> infoSucursal(string Sucursal)
        {
            conexion.Open();

            string id = "NULL";
            string dirección = "NULL";
            string teléfono = "NULL";
            string email = "NULL";

            string query = "select * from Atención_Nacional where sucursal = '" + Sucursal + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataReader info = cmd.ExecuteReader();

            if (info.Read())
            {
                id = info["Id"].ToString();
                dirección = info["Dirección"].ToString();
                teléfono = info["Teléfono"].ToString();
                email = info["Email"].ToString();
            }

            conexion.Close();
            return Tuple.Create(id, dirección, teléfono, email);
        }

        public DataTable EResultados(string IdSucursal)
        {
            string query = "select Semana, FinDeSemana from Entrega_Resultados where idSucursal = '" + IdSucursal + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable datos = new DataTable();
            data.Fill(datos);

            return datos;
        }

        public DataTable TMuestra(string IdSucursal)
        {
            string query = "select Semana, FinDeSemana from Toma_de_muestras where idSucursal = '" + IdSucursal + "'";
            SqlCommand cmd = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable datos = new DataTable();
            data.Fill(datos);

            return datos;
        }
    }
}
