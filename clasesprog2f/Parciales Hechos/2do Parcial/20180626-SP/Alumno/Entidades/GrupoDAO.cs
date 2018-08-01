using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class GrupoDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static GrupoDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            GrupoDAO.conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS1;Initial Catalog=mundial-sp-2018;Integrated Security=True");//CadenaConexionMDE);//                                                                                                                        // CREO UN OBJETO SQLCOMMAND
            // CREO UN OBJETO SQLCOMMAND
            GrupoDAO.comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            GrupoDAO.comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            GrupoDAO.comando.Connection = GrupoDAO.conexion;
        }

        /// <summary>
        /// Guarda los datos de la votacion en la base de datos
        /// </summary>
        /// <param name="v">Votacion a guardar en la base de datos</param>
        /// <returns></returns>
        public static bool Leer(Grupo v)
        {
            bool TodoOk = false;
            Grupo grupo = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                GrupoDAO.comando.CommandText = "SELECT * FROM Equipos";

                // ABRO LA CONEXION A LA BD
                GrupoDAO.conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = GrupoDAO.comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE
                    Letras letra;
                    if (!Enum.TryParse<Letras>(oDr["grupo"].ToString(), out letra))
                    {
                        letra = Letras.D;
                    }
                    grupo = new Grupo(letra, Torneo.MAX_EQUIPOS_GRUPO);
                }

                //CIERRO EL DATAREADER
                oDr.Close();

                TodoOk = true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (TodoOk)
                    GrupoDAO.conexion.Close();
            }
            return TodoOk;
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
                GrupoDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                GrupoDAO.conexion.Open();

                // EJECUTO EL COMMAND
                GrupoDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    GrupoDAO.conexion.Close();
            }
            return todoOk;
        }
    }
}
