using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class LibroService
    {
        public IList Get()
        {
            try
            {
                using (var connection = new BibliotecaEntities1())
                {
                    var list = (from a in connection.Libros
                                select a).ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int InsertOrUpdate(int idLibro, string nombre, int disponibilidad, int idAutor, string editorial)
        {
            try
            {
                using (var conexion = new BibliotecaEntities1())
                {
                    var existingLibro = conexion.Libros.FirstOrDefault(m => m.IDLibro == idLibro);
                    if (existingLibro == null)
                    {
                        // Si no existe, creamos uno nuevo
                        Libros newLibro = new Libros();
                        newLibro.Nombre = nombre;
                        newLibro.Disponibilidad = 1;
                        newLibro.IDAutor = idAutor;
                        newLibro.Editorial = editorial;
                        conexion.Libros.Add(newLibro);
                    }
                    else
                    {
                        // Si existe, actualizamos sus propiedades
                        existingLibro.Nombre = nombre;
                        existingLibro.Disponibilidad = disponibilidad;
                        existingLibro.IDAutor = idAutor;
                        existingLibro.Editorial = editorial;
                    }
                    conexion.SaveChanges();
                    return idLibro;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool Delete(int idLibro)
        {
            try
            {
                using (var conexion = new BibliotecaEntities1())
                {
                    var libroToDelete = conexion.Libros.FirstOrDefault(m => m.IDLibro == idLibro);
                    if (libroToDelete != null)
                    {
                        conexion.Libros.Remove(libroToDelete);
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
