using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class ProductoDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static ProductoDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            ProductoDAO.conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=final-20180712;Integrated Security=True");//CadenaConexionMDE);//                                                                                                                        // CREO UN OBJETO SQLCOMMAND
            // CREO UN OBJETO SQLCOMMAND
            ProductoDAO.comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            ProductoDAO.comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            ProductoDAO.comando.Connection = ProductoDAO.conexion;
        }

        /// <summary>
        /// Lee los productos desde la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            Producto productoA = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                ProductoDAO.comando.CommandText = "SELECT * FROM Productos";

                // ABRO LA CONEXION A LA BD
                ProductoDAO.conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = ProductoDAO.comando.ExecuteReader();

                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    Material material;

                    if (!Enum.TryParse<Material>(oDr["material"].ToString(), out material))
                    {
                        material = Material.Aluminio;
                    }
                    productoA = new ProductoA(oDr["descripcion"].ToString(), short.Parse(oDr["diametro"].ToString()), material);
                    productos.Add(productoA);             
                }

                //CIERRO EL DATAREADER
                oDr.Close();
                return productos;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return productos;
            }
            finally
            {
                ProductoDAO.conexion.Close();               
            }
        }

        /// <summary>
        /// Guarda los productos en la base de datos
        /// </summary>
        /// <param name="v">Votacion a guardar en la base de datos</param>
        /// <returns></returns>
        public static bool GuardarProducto(Producto p)
        {
            bool retorno = false;
            string sql;
            if (p is ProductoA)
            {
                ProductoA a = (ProductoA)p;
                sql = "INSERT INTO Productos (descripcion, tipo, diametro, material, largo, alto, ancho) VALUES(";
                sql = sql + "'" + a.Descripcion + "','" + 'A' + "'," + a.Diametro + ",'" + a.Material.ToString() + "'," + DBNull.Value + "," + DBNull.Value + "," + DBNull.Value + ")";
                retorno = EjecutarNonQuery(sql);

                //cmd.CommandText = "INSERT INTO dbo.Person(birthdate) VALUES(@Birthdate);";
                //cmd.Parameters.Add("@Birthdate", SqlDbType.Date).Value = dateTimePicker.Value.Date;
            }
            if (p is ProductoB)
            {
                ProductoB b = (ProductoB)p;
                sql = "INSERT INTO Productos (descripcion, tipo, diametro, material, largo, alto, ancho) VALUES(";
                sql = sql + "'" + b.Descripcion + "','" + 'B' + "'," + DBNull.Value + "," + DBNull.Value + "," + b.Largo + "," + b.Alto + "," + b.Ancho + ")";
                retorno = EjecutarNonQuery(sql);
            }
            return retorno;
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
                ProductoDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                ProductoDAO.conexion.Open();

                // EJECUTO EL COMMAND
                ProductoDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    ProductoDAO.conexion.Close();
            }
            return todoOk;
        }
    }
}
