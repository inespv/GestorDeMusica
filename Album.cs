using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    internal class Album
    {
        protected string titulo;
        protected string genero;
        protected Artista artista;
        protected int anyo;
        protected double duracion;
        protected List<Cancion> canciones;
        protected bool esVinilo;

        public Album()
        {
            titulo = " ";
            genero = " ";
            artista = new Artista();
            anyo = 0;
            duracion = 0;
            esVinilo = false;
        }

        public Album(string titulo, string genero, Artista artista,
            int anyo, double duracion,bool esVinilo)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.artista = artista;
            this.anyo = anyo;
            this.duracion = duracion;
            this.esVinilo = esVinilo;
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
        public double GetDuracion()
        {
            return duracion;
        }
        public void SetDuracion(double duracion)
        {
            this.duracion = duracion;
        }
        public List<Cancion> GetCanciones()
        {
            return canciones;
        }
        public void SetCanciones(List<Cancion> canciones)
        {
            this.canciones = canciones;
        }
        public bool GetEsVinilo()
        {
            return esVinilo;
        }
        public void SetVinilo(bool esVinilo)
        {
            this.esVinilo = esVinilo;
        }
        public new virtual string ToString()
        {
            return "Título :" + titulo + " género :" + genero +
                 "artista :" + artista +
                  " duración :" + duracion + " año :" + anyo;
        }
    }
}
