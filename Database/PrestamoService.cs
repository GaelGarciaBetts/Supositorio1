using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class PrestamoService
    {
        public IList Get()
        {
            try
            {
                using (var connection = new BibliotecaEntities1())
                {
                    var list = (from a in connection.Prestamos
                                select a).ToList();
                    return list;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int InsertOrUpdate(int idPrestamo, string nombrepersona, int idLibro, DateTime fechaprestamoinicio, DateTime fechaprestamofin)
        {
            try
            {
                using (var conexion = new BibliotecaEntities1())
                {
                    var existingPrestamo = conexion.Prestamos.FirstOrDefault(m => m.IDPrestamo == idPrestamo);
                    if (existingPrestamo == null)
                    {
                        // Si no existe, creamos uno nuevo
                        Prestamos nuevoprestamo = new Prestamos();
                        nuevoprestamo.NombrePersona = nombrepersona;
                        nuevoprestamo.IDLibro = idLibro;
                        nuevoprestamo.FechaPrestamoInicio = fechaprestamoinicio;
                        nuevoprestamo.FechaPrestamoFin = fechaprestamofin;
                    }
                    else
                    {
                        // Si existe, actualizamos sus propiedades
                        existingPrestamo.NombrePersona = nombrepersona;
                        existingPrestamo.IDLibro = idLibro;
                        existingPrestamo.FechaPrestamoInicio = fechaprestamoinicio;
                        existingPrestamo.FechaPrestamoFin = fechaprestamofin;
                    }
                    conexion.SaveChanges();
                    return idPrestamo;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool Delete(int idPrestamo)
        {
            try
            {
                using (var conexion = new BibliotecaEntities1())
                {
                    var prestamoToDelete = conexion.Prestamos.FirstOrDefault(m => m.IDPrestamo == idPrestamo);
                    if (prestamoToDelete != null)
                    {
                        conexion.Prestamos.Remove(prestamoToDelete);
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
