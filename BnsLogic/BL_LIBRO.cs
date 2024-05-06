using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataInterface;

namespace BnsLogic
{
    public static class BL_LIBRO
    {
        private static DI_LIBRO dataInterfaceLibro = new DI_LIBRO();

        public static List<DO_LIBRO> Get()
        {
            List<DO_LIBRO> libros = new List<DO_LIBRO>();

            IList informacionDB = dataInterfaceLibro.Get();

            if (informacionDB != null)
            {
                foreach (var item in informacionDB)
                {
                    DO_LIBRO libro = new DO_LIBRO();

                    Type type = item.GetType();

                    

                    libros.Add(libro);
                }
            }

            return libros;
        }

        public static void InsertLibro(string nombre, int poblacion, int no_municipios)
        {
            dataInterfaceLibro.InsertLibro(nombre, poblacion, no_municipios);
        }
    }
}
