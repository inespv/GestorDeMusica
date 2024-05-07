using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    internal class Artista
    {
        string nombreArtistico;

        public Artista(string nombreArtistico)
        {
            this.nombreArtistico = nombreArtistico;
        }
        public Artista()
        {
            nombreArtistico = " ";
        }
        public string GetNombreArtistico()
        {
            return nombreArtistico;
        }
        public void SetNombreArtistico(string nombreArtistico)
        {
            this.nombreArtistico = nombreArtistico;
        }
        public override string ToString()
        {
            return "Nombre artístico :" + nombreArtistico;
        }
        public override bool Equals(object obj)
        {
            return obj is Artista artista &&
                   nombreArtistico == artista.nombreArtistico;
        }
    }
}
