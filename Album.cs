using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    public class Album
    {
        private string nombreAlbum;
        private string genero;
        private Artista artista;
        private int anyo;
        private double duracion;
        private List<Cancion> canciones;
        private bool esVinilo;

        protected string NombreAlbum { get => nombreAlbum; set => nombreAlbum = value; }
        protected string Genero { get => genero; set => genero = value; }
        protected Artista Artista { get => artista; set => artista = value; }
        protected int Anyo { get => anyo; set => anyo = value; }
        protected double Duracion { get => duracion; set => duracion = value; }
        protected List<Cancion> Canciones { get => canciones; set => canciones = value; }
        protected bool EsVinilo { get => esVinilo; set => esVinilo = value; }

        public Album()
        {
            NombreAlbum = " ";
            Genero = " ";
            Artista = new Artista();
            Anyo = 0;
            Duracion = 0;
            EsVinilo = false;
        }

        public Album(string nombreAlbum, string genero, Artista artista,
            int anyo, double duracion,bool esVinilo)
        {
            this.nombreAlbum = nombreAlbum;
            this.genero = genero;
            this.artista = artista;
            this.anyo = anyo;
            this.duracion = duracion;
            this.esVinilo = esVinilo;
        }
        public Album(string nombreAlbum,bool esVinilo)
        {
            this.nombreAlbum = nombreAlbum; 
            this.esVinilo = esVinilo;
        }
        public string GetNombreAlbum()
        {
            return NombreAlbum;
        }
        public void SetNombreAlbum(string nombreAlbum)
        {
            this.NombreAlbum = nombreAlbum;
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
        public double GetDuracion()
        {
            return Duracion;
        }
        public void SetDuracion(double duracion)
        {
            this.Duracion = duracion;
        }
        public List<Cancion> GetCanciones()
        {
            return Canciones;
        }
        public void SetCanciones(List<Cancion> canciones)
        {
            this.Canciones = canciones;
        }
        public bool GetEsVinilo()
        {
            return EsVinilo;
        }
        public void SetVinilo(bool esVinilo)
        {
            this.EsVinilo = esVinilo;
        }
        public new virtual string ToString()
        {
            return "Título :" + NombreAlbum + " género :" + Genero +
                 "artista :" + Artista +
                  " duración :" + Duracion + " año :" + Anyo;
        }
    }
}
