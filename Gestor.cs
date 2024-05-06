using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    public class Gestor
    {
        Cancion cancion;
        private List<Cancion> canciones;
        AgregarCancion agregar;

        public Gestor()
        {
             canciones = new List<Cancion>();
        }
        public void AgregarCancion()
        {
            cancion = new Cancion();
            canciones.Add(cancion);
        }
    }
}
