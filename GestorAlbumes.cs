using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    internal class GestorAlbumes
    {
        Album album;
        List<Album> albums;

        public GestorAlbumes()
        {
            albums = new List<Album>();
        }
        public void AddArtist()
        {
            albums.Add(album);
        }
    }
}
