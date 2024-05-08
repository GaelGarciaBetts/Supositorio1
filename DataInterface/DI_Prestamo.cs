using Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface
{
    public class DI_Prestamo
    {
        private PrestamoService prestamoService;
        public DI_Prestamo()
        {
            prestamoService = new PrestamoService();
        }

        public void InsertOrUpdate(int idPrestamo, string nombrepersona, int idLibro, DateTime fechaprestamoinicio, DateTime fechaprestamofin)
        {
            try
            {
                prestamoService.InsertOrUpdate(idPrestamo, nombrepersona, idLibro, fechaprestamoinicio, fechaprestamofin);
            }
            catch (Exception)
            {

            }
        }

        public IList Get()
        {
            return prestamoService.Get();
        }

        public bool Delete(int idPrestamo)
        {
            return prestamoService.Delete(idPrestamo);
        }
    }
}
