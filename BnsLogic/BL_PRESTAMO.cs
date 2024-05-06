using DataInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnsLogic
{
    public class BL_PRESTAMO
    {
        private static DI_PRESTAMO dataInterfaceAutor = new DI_PRESTAMO();

        public static List<DI_PRESTAMO> Get()
        {
            List<DI_PRESTAMO> prestamos = new List<DI_PRESTAMO>();

            IList informacionDB = dataInterfaceAutor.Get();

            if (informacionDB != null)
            {
                foreach (var item in informacionDB)
                {
                    DI_PRESTAMO prestamo = new DI_PRESTAMO();

                    Type type = item.GetType();



                    prestamos.Add(prestamo);
                }
            }

            return prestamos;
        }

        public static void InsertLibro(string nombre, int poblacion, int no_municipios)
        {
            dataInterfaceAutor.InsertLibro(nombre, poblacion, no_municipios);
        }
    }
}
