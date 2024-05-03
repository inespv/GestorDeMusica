using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    public class Gestor
    {
        List<Cancion> canciones;

        public Gestor()
        {
             canciones = new List<Cancion>();
        }
        public void AgregarCancion()
        {
            Cancion cancion = new Cancion();
            canciones.Add(new Cancion(cancion.GetTitulo(), cancion.GetGenero(), cancion.GetArtista(), 
                cancion.GetAnyo(), cancion.GetAlbum(), cancion.GetDuracion()));
        }
    }
}
