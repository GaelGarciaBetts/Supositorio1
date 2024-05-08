using DataInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsnLogic
{
    public class BL_Prestamo
    {
        private static DI_Prestamo dataInterfaceLibro = new DI_Prestamo();
        public static List<DO_Prestamo> Get()
        {
            List<DO_Prestamo> libros = new List<DO_Prestamo>();

            IList informacionDB = dataInterfaceLibro.Get();

            if (informacionDB != null)
            {
                foreach (var item in informacionDB)
                {
                    DO_Prestamo libro = new DO_Prestamo();

                    Type type = item.GetType();

                    libro.idPrestamo = Convert.ToInt32(type.GetProperty("IDPrestamo").GetValue(item, null));
                    libro.nombrepersona = type.GetProperty("NombrePersona").GetValue(item, null).ToString();
                    libro.idLibro = Convert.ToInt32(type.GetProperty("IDLibro").GetValue(item, null));
                    libro.fechaPrestamoInicio = type.GetProperty("FechaPrestamoInicio").GetValue(item, null).ToString();
                    libro.fechaPrestamoFin = type.GetProperty("FechaPrestamoFin").GetValue(item, null).ToString();

                    libros.Add(libro);
                }
            }

            return libros;
        }

        public static void InsertOrUpdate(int idPrestamo, string nombrepersona, int idLibro, DateTime fechaprestamoinicio, DateTime fechaprestamofin)
        {
            dataInterfaceLibro.InsertOrUpdate(idPrestamo, nombrepersona, idLibro, fechaprestamoinicio, fechaprestamofin);
        }

        public static bool Delete(int idLibro)
        {
            return dataInterfaceLibro.Delete(idLibro);
        }
    }
}
