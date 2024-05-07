using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class AutorService
    {
       public IList Get()
{
    try
    {
        using (var connection = new BibliotecaEntities())
        {
            var list = (from a in connection.Autor
                        select a).ToList();
            return list;
        }
    }
    catch (Exception) 
    {
        return null;
    }
}
public int InsertE(string nombre, string apellido)
{
    try
    {
        using (var connection = new BibliotecaEntities())
        {
            Autor nuevoautor = new Autor();
            nuevoautor.Nombre = nombre;
            nuevoautor.Apellido = apellido;

            connection.Autor.Add(nuevoautor);

            connection.SaveChanges();

            return nuevoautor.IDAutor;

        }
    }
    catch (Exception)
    {
        return 0;
    }
} 
    }
}
