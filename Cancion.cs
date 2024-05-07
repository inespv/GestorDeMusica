using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    internal class Cancion
    {
        private string titulo;
        private string genero;
        private Album album;
        private Artista artista;
        private int anyo;
        private double duracion;

        public Cancion(string titulo, string genero, Artista artista,
            int anyo, Album album, double duracion)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.artista = artista;
            this.anyo = anyo;
            this.album = album;
            this.duracion = duracion;
        }
        public Cancion()
        {
            titulo = " ";
            genero = " ";
            album = new Album();
            artista = new Artista();
            anyo = 0;
            duracion = 0;
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
            return anyo;
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
        public override string ToString()
        {
            return "Título :" + titulo + " género :" + genero + "álbum :" + album
                + "artista :" + artista +
                  " duración :" + duracion + " año :" + anyo;
        }
    }
}
