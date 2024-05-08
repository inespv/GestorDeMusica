using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    internal class GestorArtistas
    {
        Artista artista;
        List<Artista> artistas;

        public GestorArtistas()
        {
            artistas = new List<Artista>();
        }
        public List<Artista> GetArtista()
        {
            return artistas;
        }
        public void SetArtista(Artista artista)
        {
            this.artista = artista;
        }
        public void AddArtist()
        {
            artistas.Add(artista);
        }
    }
}
