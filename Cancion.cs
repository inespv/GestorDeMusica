using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    public class Cancion
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
            return Titulo;
        }
        public void SetTitulo(string titulo)
        {
            this.Titulo = titulo;
        }
        public string GetGenero()
        {
            return Genero;
        }
        public void SetGenero(string genero)
        {
            this.Genero = genero;
        }
        public Artista GetArtista()
        {
            return Artista;
        }
        public void SetArtista(Artista artista)
        {
            this.Artista = artista;
        }
        public int GetAnyo()
        {
            return Anyo;
        }

        public void SetAnyo(int anyo)
        {
            this.Anyo = anyo;
        }

        public Album GetAlbum()
        {
            return Album;
        }
        public void SetAlbum(Album album)
        {
            this.Album = album;
        }
        public double GetDuracion()
        {
            return Duracion;
        }
        public void SetDuracion(double duracion)
        {
            this.Duracion = duracion;
        }
        public override string ToString()
        {
            return "Título :" + Titulo + " género :" + Genero + "álbum :" + Album
                + "artista :" + Artista +
                  " duración :" + Duracion + " año :" + Anyo;
        }
    }
}
