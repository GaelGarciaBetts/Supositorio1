using DataInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BnsLogic
{
    public class BL_AUTOR
    {
        private static DI_AUTOR dataInterfaceAutor = new DI_AUTOR();

        public static List<DI_AUTOR> Get()
        {
            List<DI_AUTOR> autores = new List<DI_AUTOR>();

            IList informacionDB = dataInterfaceAutor.Get();

            if (informacionDB != null)
            {
                foreach (var item in informacionDB)
                {
                    DI_AUTOR autor = new DI_AUTOR();

                    Type type = item.GetType();



                    autores.Add(autor);
                }
            }

            return autores;
        }

        public static void InsertLibro(string nombre, int poblacion, int no_municipios)
        {
            dataInterfaceAutor.InsertLibro(nombre, poblacion, no_municipios);
        }
    }
}
