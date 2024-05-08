using Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataInterface
{
    public class DI_Libro
    {
        private LibroService libroService;
        public DI_Libro()
        {
            libroService = new LibroService();
        }

        public void InsertOrUpdate(int idLibro, string nombre, int disponibilidad, int idAutor, string editorial)
        {
            try
            {
                libroService.InsertOrUpdate(idLibro, nombre, disponibilidad, idAutor, editorial);
            }
            catch (Exception)
            {

            }
        }

        public IList Get()
        {
            return libroService.Get();
        }

        public bool Delete(int idLibro)
        {
            return libroService.Delete(idLibro);
        }
    }
}
