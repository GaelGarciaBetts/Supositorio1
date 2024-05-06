using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace DataInterface
{
    public class DI_LIBRO
    {
        private LibroService libroService;
        public DI_LIBRO()
        {
            libroService = new LibroService();
        }

        public void InsertEstado(string nombre, int poblacion, int no_municipios)
        {
            try
            {
                libroService.Insert(nombre, poblacion, no_municipios);
            }
            catch (Exception)
            {

            }
        }

        public IList Get()
        {
            return libroService.Get();
        }
    }
}
