using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public static class AlumnoExtension
    {
        public static bool Guardar(this Alumno al)
        {
                string sql = "INSERT INTO Persona (id, nombre) VALUES(";
                sql = sql +  al.id + ",'" + al.Nombre + "')";

               return AlumnoDAO.EjecutarNonQuery(sql);
        }
    }
}