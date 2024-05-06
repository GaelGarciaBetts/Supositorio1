using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;

namespace DataInterface
{
    public class DI_AUTOR
    {
        private AutorService autorService;
        public DI_AUTOR()
        {
            autorService = new AutorService();
        }

        public void InsertAutor(string nombre, int poblacion, int no_municipios)
        {
            try
            {
                autorService.Insert(nombre, poblacion, no_municipios);
            }
            catch (Exception)
            {

            }
        }

        public IList Get()
        {
            return autorService.Get();
        }
    }
}
