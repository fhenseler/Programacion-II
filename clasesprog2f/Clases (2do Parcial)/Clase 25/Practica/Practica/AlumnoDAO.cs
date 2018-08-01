using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Practica
{
    public class AlumnoDAO
    {
        #region Attributes
        private static SqlConnection conexion;
        private static SqlCommand comando;
        #endregion

        #region Constructors
        static AlumnoDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            AlumnoDAO.conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=miBase;Integrated Security=True");//CadenaConexionMDE);//
            // CREO UN OBJETO SQLCOMMAND
            AlumnoDAO.comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            AlumnoDAO.comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            AlumnoDAO.comando.Connection = AlumnoDAO.conexion;
        }
        #endregion

        #region Methods
        //public static bool Insertar(Alumno p)
        //{
        //    string sql = "INSERT INTO Persona (id, nombre) VALUES(";
        //    sql = sql +  p.Id + ",'" + p.Nombre + "')";

        //    return EjecutarNonQuery(sql);
        //}

        public static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                AlumnoDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                AlumnoDAO.conexion.Open();

                // EJECUTO EL COMMAND
                AlumnoDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                AlumnoDAO.conexion.Close();
            }
            return todoOk;
        }
        #endregion
    }
}