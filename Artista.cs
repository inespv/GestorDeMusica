using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    public class Artista
    {
        string nombreArtistico;

        public string NombreArtistico { get => nombreArtistico; set => nombreArtistico = value; }

        public Artista(string nombreArtistico)
        {
            this.nombreArtistico = nombreArtistico;
        }
        public Artista()
        {
            NombreArtistico = " ";
        }
        public string GetNombreArtistico()
        {
            return NombreArtistico;
        }
        public void SetNombreArtistico(string nombreArtistico)
        {
            this.nombreArtistico = nombreArtistico;
        }
        public override bool Equals(object obj)
        {
            return obj is Artista artista &&
                   NombreArtistico == artista.NombreArtistico;
        }
    }
}
