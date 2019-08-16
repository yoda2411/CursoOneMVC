using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules
{
   public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static List<Alumno> ListaAlumno()
        {
            List<Alumno> lista = new List<Alumno>();
            for (int i = 1; i <=10; i++)
            {
                lista.Add(
                    new Alumno
                    {
                        Id=i,
                        Nombre=string.Format("Nombre_{0}",i)
                    }
                    );
            }
            return lista;
        }
        public static Alumno GetAlumno()
        {
            var alum = new Alumno
            {
                Id = 1,
                Nombre = string.Format("Nombre_{0}", 1)
            };
            return alum;
        }
    }
}
