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
        Album album;

        public Artista(string nombreArtistico, Album album)
        {
            this.nombreArtistico = nombreArtistico;
            this.album = album;
        }
        public Artista()
        {
            nombreArtistico = " ";
            album = new Album();
        }

        public Artista(string text)
        {
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
            return "Nombre artístico :" + nombreArtistico
                + "Álbum :" + album;
        }
    }
}
