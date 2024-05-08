using Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface
{
    public class DI_Autor
    {
        private AutorService autorService;
        public DI_Autor()
        {
            autorService = new AutorService();
        }

        public void InsertOrUpdate(int idAutor, string nombre, string apellido)
        {
            try
            {
                autorService.InsertOrUpdate(idAutor, nombre, apellido);
            }
            catch (Exception)
            {

            }
        }

        public IList Get()
        {
            return autorService.Get();
        }

        public bool Delete(int idLibro)
        {
            return autorService.Delete(idLibro);
        }
    }
}
