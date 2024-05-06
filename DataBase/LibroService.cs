using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class LibroService
    {
         public IList Get(int idAutor)
 {
     try
     {
         using (var connection = new BibliotecaEntities())
         {
             var list = (from a in connection.Libros
                         where a.IDAutor == idAutor
                         select a).ToList();
             return list;
         }
     }
     catch (Exception)
     {
         return null;
     }
 }
 public int Insert(int idAutor, string nombre, int disponibilidad,string editorial,date anopubli)
 {
     try
     {
         using (var connection = new BibliotecaEntities())
         {
             Libros nuevolibro = new Libros();
             nuevolibro.IDAutor = idAutor;
             nuevolibro.Nombre = nombre;
             nuevolibro.Disponibilidad = disponibilidad;
             nuevolibro.Editorial = editorial;
             nuevolibro.Anopubli = anopubli;

             connection.Libros.Add(nuevolibro);

             connection.SaveChanges();

             return nuevolibro.IDLibro;

         }
     }
     catch (Exception)
     {
         return 0;
     }
 }
    }
}
