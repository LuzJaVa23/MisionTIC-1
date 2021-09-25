using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> estaciones;
 
    public RepositorioEstaciones()
        {
            estaciones= new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Norte",direccion= "Avenida Norte calle 100",coord_x= 1,coord_y= 2,Tipo= "A"},
                new Estaciones{id=2,nombre="Caracas",direccion= "Avenida Caracas calle 72",coord_x= 1,coord_y= 2,Tipo= "A"},
                new Estaciones{id=3,nombre="Cll 80",direccion= "Portal de la 80",coord_x= 1,coord_y= 2,Tipo= "A"}
             };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return estaciones;
        }
 
        public Estaciones GetEstacionWithId(int id){
            return estaciones.SingleOrDefault(b => b.id == id);
        }
    }
}
