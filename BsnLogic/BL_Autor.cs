using DataInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsnLogic
{
    public class BL_Autor
    {
        private static DI_Autor dataInterfaceLibro = new DI_Autor();
        public static List<DO_Autor> Get()
        {
            List<DO_Autor> libros = new List<DO_Autor>();

            IList informacionDB = dataInterfaceLibro.Get();

            if (informacionDB != null)
            {
                foreach (var item in informacionDB)
                {
                    DO_Autor libro = new DO_Autor();

                    Type type = item.GetType();

                    libro.idAutor = Convert.ToInt32(type.GetProperty("IDAutor").GetValue(item, null));
                    libro.nombre = type.GetProperty("Nombre").GetValue(item, null).ToString();
                    libro.apellidos = type.GetProperty("Apellidos").GetValue(item, null).ToString();

                    libros.Add(libro);
                }
            }

            return libros;
        }

        public static void InsertOrUpdate(int idAutor, string nombre, string apellido)
        {
            dataInterfaceLibro.InsertOrUpdate(idAutor, nombre, apellido);
        }

        public static bool Delete(int idLibro)
        {
            return dataInterfaceLibro.Delete(idLibro);
        }
    }
}
