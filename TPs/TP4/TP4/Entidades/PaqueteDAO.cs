using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    static class PaqueteDAO
    {
        #region Attributes
        private static SqlConnection conexion;
        private static SqlCommand comando;
        #endregion

        #region Constructors
        static PaqueteDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            PaqueteDAO.conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=correo-sp-2017;Integrated Security=True");//CadenaConexionMDE);//
            // CREO UN OBJETO SQLCOMMAND
            PaqueteDAO.comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            PaqueteDAO.comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Guarda los datos de un paquete en la base de datos
        /// </summary>
        /// <param name="p">Paquete a guardar en la base de datos</param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            string sql = "INSERT INTO Paquetes (direccionEntrega, trackingID, alumno) VALUES(";
            sql = sql + "'" + p.DireccionEntrega + "','" + p.TrackingID + "'," + "'FedericoHenseler2D'" + ")";

            try
            {
                return EjecutarNonQuery(sql);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PaqueteDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PaqueteDAO.conexion.Open();

                // EJECUTO EL COMMAND
                PaqueteDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    PaqueteDAO.conexion.Close();
            }
            return todoOk;
        }
        #endregion
    }
}
