using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ConexionsqlN
    {
        Conexionsql con = new Conexionsql();

        public int conSQL(string usuario, string contraseña)
        {
            return con.consultalogin(usuario, contraseña);
        }

        public int Registrarpaciente(string NumIdentificación, string Nombres, string TipoIdentificación, string Género, string FechaNacimiento, string Edad, string EstadoCivil, string Dirección, string Barrio, string Teléfono, string Ocupación, string Escolaridad, string EPS, string Régimen, string Email, string Antecedentes, string TelefonoEmergencia)
        {
            return con.Registrarpaciente(NumIdentificación, Nombres, TipoIdentificación, Género, FechaNacimiento, Edad, EstadoCivil, Dirección, Barrio, Teléfono, Ocupación, Escolaridad, EPS, Régimen, Email, Antecedentes, TelefonoEmergencia);
        }

        public int ModificarInfo(string NumIdentificación, string Nombres, string TipoIdentificación, string Género, string FechaNacimiento, string Edad, string EstadoCivil, string Dirección, string Barrio, string Teléfono, string Ocupación, string Escolaridad, string EPS, string Régimen, string Email, string Antecedentes, string TelefonoEmergencia)
        {
            return con.ModificarInfo(NumIdentificación, Nombres, TipoIdentificación, Género, FechaNacimiento, Edad, EstadoCivil, Dirección, Barrio, Teléfono, Ocupación, Escolaridad, EPS, Régimen, Email, Antecedentes, TelefonoEmergencia);
        }
        public Tuple<string, string, string, string, string, string, string> registros(string NumIdentificación)
        {
            return con.registros(NumIdentificación);
        }

        public Tuple<string, string, string, string, string, string, string> registros1(string NumIdentificación)
        {
            return con.registros1(NumIdentificación);
        }

        public Tuple<string, string> registros2(string NumIdentificación)
        {
            return con.registros2(NumIdentificación);
        }

        public int Eliminar(string NumIdentificación)
        {
            return con.Eliminar(NumIdentificación);
        }

        public Tuple<string, string, string> registros3(string NumIdentificación)
        {
            return con.registros3(NumIdentificación);
        }

        public Tuple<string> Costo(string TipoExamen)
        {
            return con.Costo(TipoExamen);
        }

        public int Registraexamen(string IdPaciente, string Examen1, string Costo_Ex1, string Examen2, string Costo_Ex2, string Descuento, string CostoFinal)
        {
            return con.Registraexamen(IdPaciente, Examen1, Costo_Ex1, Examen2, Costo_Ex2, Descuento, CostoFinal);
        }

        public DataTable Datosexamen(string IdPaciente)
        {
            return con.Datosexamen(IdPaciente);
        }

        public Tuple<string, string, string, string> infoSucursal(string Sucursal)
        {
            return con.infoSucursal(Sucursal);
        }

        public DataTable EResultados(string IdSucursal)
        {
            return con.EResultados(IdSucursal);
        }

        public DataTable TMuestra(string IdSucursal)
        {
            return con.TMuestra(IdSucursal);
        }
    }
}
