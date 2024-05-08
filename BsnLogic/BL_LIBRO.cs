using DataInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsnLogic
{
    public class BL_LIBRO
    {
        private static DI_Libro dataInterfaceLibro = new DI_Libro();
        public static List<DO_Libro> GetAll()
        {
            List<DO_Libro> libros = new List<DO_Libro>();

            IList informacionDB = dataInterfaceLibro.Get();

            if (informacionDB != null)
            {
                foreach (var item in informacionDB)
                {
                    DO_Libro libro = new DO_Libro();

                    Type type = item.GetType();

                    libro.idLibro = Convert.ToInt32(type.GetProperty("IDLibro").GetValue(item, null));
                    libro.nombre = type.GetProperty("Nombre").GetValue(item, null).ToString();
                    libro.disponibilidad = Convert.ToInt32(type.GetProperty("Disponibilidad").GetValue(item, null));
                    libro.idAutor = Convert.ToInt32(type.GetProperty("IDAutor").GetValue(item, null));
                    libro.editorial = type.GetProperty("Editorial").GetValue(item, null).ToString();

                    libros.Add(libro);
                }
            }

            return libros;
        }

        public static void InsertOrUpdate(int idLibro, string nombre, int disponibilidad, int idAutor, string editorial)
        {
            dataInterfaceLibro.InsertOrUpdate(idLibro, nombre, disponibilidad, idAutor, editorial);
        }

        public static bool Delete(int idLibro)
        {
            return dataInterfaceLibro.Delete(idLibro);
        }
    }
}
