using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMusica
{
    public class Cancion : IEnumerable<Cancion>
    {
        private string titulo;
        private string genero;
        private Album album;
        private Artista artista;
        private int anyo;
        private double duracion;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Genero { get => genero; set => genero = value; }
        internal Album Album { get => album; set => album = value; }
        internal Artista Artista { get => artista; set => artista = value; }
        public int Anyo { get => anyo; set => anyo = value; }
        public double Duracion { get => duracion; set => duracion = value; }

        public Cancion(string titulo, string genero, Artista artista,
            int anyo, Album album, double duracion)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Artista = artista;
            this.Anyo = anyo;
            this.Album = album;
            this.Duracion = duracion;
        }
        public Cancion()
        {
            Titulo = " ";
            Genero = " ";
            Album = new Album();
            Artista = new Artista();
            Anyo = 0;
            Duracion = 0;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetGenero()
        {
            return genero;
        }
        public void SetGenero(string genero)
        {
            this.genero = genero;
        }
        public Artista GetArtista()
        {
            return artista;
        }
        public void SetArtista(Artista artista)
        {
            this.artista = artista;
        }
        public int GetAnyo()
        {
            return Anyo;
        }

        public void SetAnyo(int anyo)
        {
            this.anyo = anyo;
        }
        public Album GetAlbum()
        {
            return album;
        }
        public void SetAlbum(Album album)
        {
            this.album = album;
        }
        public double GetDuracion()
        {
            return duracion;
        }
        public void SetDuracion(double duracion)
        {
            this.duracion = duracion;
        }
        public override bool Equals(object obj)
        {
            return obj is Cancion cancion &&
                   titulo == cancion.titulo &&
                   genero == cancion.genero &&
                   EqualityComparer<Album>.Default.Equals(album, cancion.album) &&
                   EqualityComparer<Artista>.Default.Equals(artista, cancion.artista) &&
                   anyo == cancion.anyo &&
                   duracion == cancion.duracion;
        }
        public IEnumerator<Cancion> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
