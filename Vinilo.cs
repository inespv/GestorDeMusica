using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    internal class Vinilo : Album
    {
        public Vinilo (bool esVinilo, string titulo, string genero, Artista artista,
            int anyo, double duracion, List<Cancion> canciones) 
            : base(titulo,genero,artista,anyo,duracion, esVinilo)
        {
            this.EsVinilo = esVinilo;
        }
    }
}
