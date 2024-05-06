using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace DataInterface
{
    public class DI_PRESTAMO
    {
        private PrestamoService prestamoService;
        public DI_PRESTAMO()
        {
            prestamoService = new PrestamoService();
        }

        public void InsertPrestamo(string nombre, int poblacion, int no_municipios)
        {
            try
            {
                prestamoService.Insert(nombre, poblacion, no_municipios);
            }
            catch (Exception)
            {

            }
        }

        public IList Get()
        {
            return prestamoService.Get();
        }
    }
}
