using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class AutorService
    {
        public IList Get()
        {
            try
            {
                using (var connection = new BibliotecaEntities1())
                {
                    var list = (from a in connection.Autores select a).ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int InsertOrUpdate(int idAutor, string nombre, string apellido)
        {
            try
            {
                using (var conexion = new BibliotecaEntities1())
                {
                    var existingLibro = conexion.Autores.FirstOrDefault(m => m.IDAutor == idAutor);
                    if (existingLibro == null)
                    {
                        // Si no existe, creamos uno nuevo
                        Autores nuevoautor = new Autores(); 
                        nuevoautor.Nombre = nombre;
                        nuevoautor.Apellidos = apellido;
                        conexion.Autores.Add(nuevoautor);
                    }
                    else
                    {
                        // Si existe, actualizamos sus propiedades
                        existingLibro.Nombre = nombre;
                        existingLibro.Apellidos = apellido;
                    }
                    conexion.SaveChanges();
                    return idAutor;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool Delete(int idAutor)
        {
            try
            {
                using (var conexion = new BibliotecaEntities1())
                {
                    var autorToDelete = conexion.Autores.FirstOrDefault(m => m.IDAutor == idAutor);
                    if (autorToDelete != null)
                    {
                        conexion.Autores.Remove(autorToDelete);
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        // El municipio no existe, puedes manejar este caso según tu lógica de negocio
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                // Manejo de excepciones
                return false;
            }
        }
    }
}
