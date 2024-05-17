using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    internal class GestorAlbumes
    {
        Album album ;
        List<Album> albums;

        public GestorAlbumes()
        {
            Albums = new List<Album>();
        }

        public Album Album { get => album; set => album = value; }
        public List<Album> Albums { get => albums; set => albums = value; }

        public void AddAlbum()
        {
            Albums.Add(Album);
        }
    }
}
