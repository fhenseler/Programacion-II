using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class VotacionDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static VotacionDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            VotacionDAO.conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=votacion-sp-2018;Integrated Security=True");//CadenaConexionMDE);//                                                                                                                        // CREO UN OBJETO SQLCOMMAND
            // CREO UN OBJETO SQLCOMMAND
            VotacionDAO.comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            VotacionDAO.comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            VotacionDAO.comando.Connection = VotacionDAO.conexion;
        }

        /// <summary>
        /// Lee los datos de la votacion desde la base de datos
        /// </summary>
        /// <returns></returns>
        public static void Leer()
        {
            Votacion votacion = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                VotacionDAO.comando.CommandText = "SELECT * FROM Votaciones";

                // ABRO LA CONEXION A LA BD
                VotacionDAO.conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = VotacionDAO.comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE
                    string nombreLey;
                    nombreLey = oDr["nombreLey"].ToString();

                    votacion = new Votacion(nombreLey, votacion.Senadores);
                }

                //CIERRO EL DATAREADER
                oDr.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                VotacionDAO.conexion.Close();
            }
        }

        /// <summary>
        /// Guarda los datos de la votacion en la base de datos
        /// </summary>
        /// <param name="v">Votacion a guardar en la base de datos</param>
        /// <returns></returns>
        public static bool Guardar(Votacion v)
        {
            string sql = "INSERT INTO Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES(";
            sql = sql + "'" + v.NombreLey + "'," + v.ContadorAfirmativo + "," + v.ContadorNegativo + "," + v.ContadorAbstencion + "," + "'FedericoHenseler2D'" + ")";

            try
            {
                return EjecutarNonQuery(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Conecta a la database y ejecuta el nonquery
        /// </summary>
        /// <param name="sql">Instruccion SQL a ejecutar</param>
        /// <returns></returns>
        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                VotacionDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                VotacionDAO.conexion.Open();

                // EJECUTO EL COMMAND
                VotacionDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    VotacionDAO.conexion.Close();
            }
            return todoOk;
        }
    }
}