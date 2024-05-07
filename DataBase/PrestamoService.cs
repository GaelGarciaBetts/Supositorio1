using System;
using System.Collectios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class PrestamoService
    {
        public IList Get(int idLibro)
{
    try
    {
        using (var connection = new BibliotecaEntities())
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
public int InsertP(string nombrepersona, int idLibro, date fechaprestamoinicio, date fechaprestamofin)
{
    try
    {
        using (var connection = new BibliotecaEntities())
        {
            Prestamos nuevoprestamo = new Prestamo();
            nuevoprestamo.NombrePersona = nombrepersona;
            nuevoprestamo.IDLibro = idLibro;
            nuevoprestamo.FechaPrestamoInicio = fechaprestamoinicio;
            nuevoprestamo.FechaPrestamoFin = fechaprestamofin;

            connection.Prestamos.Add(nuevoprestamo);

            connection.SaveChanges();

            return nuevoprestamo.IDPrestamo;

        }
    }
    catch (Exception)
    {
        return 0;
    }
}
    }
}
