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
        private string artista;
        private int anyo;
        private double duracion;
        private List<Cancion> canciones;
        private bool esVinilo;

        public string NombreAlbum { get => nombreAlbum; set => nombreAlbum = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Anyo { get => anyo; set => anyo = value; }
        public double Duracion { get => duracion; set => duracion = value; }
        public List<Cancion> Canciones { get => canciones; set => canciones = value; }
        public bool EsVinilo { get => esVinilo; set => esVinilo = value; }
        public string Artista { get => artista; set => artista = value; }

        public Album()
        {
            NombreAlbum = " ";
            Genero = " ";
            artista = " ";
            Anyo = 0;
            Duracion = 0;
            EsVinilo = false;
        }
        public Album(string nombreAlbum, bool esVinilo)
        {
            this.NombreAlbum = nombreAlbum;
            this.EsVinilo = esVinilo;
        }
        public Album(string nombreAlbum, string genero, string artista,
            int anyo, double duracion,bool esVinilo)
        {
            this.NombreAlbum = nombreAlbum;
            this.genero = genero;
            this.Artista = artista;
            this.anyo = anyo;
            this.duracion = duracion;
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
            this.genero = genero;
        }
        public string GetArtista()
        {
            return Artista;
        }
        public void SetArtista(string artista)
        {
            this.Artista = artista;
        }
        public int GetAnyo()
        {
            return Anyo;
        }
        public void SetAnyo(int anyo)
        {
            this.anyo = anyo;
        }
        public double GetDuracion()
        {
            return Duracion;
        }
        public void SetDuracion(double duracion)
        {
            this.duracion = duracion;
        }
        public List<Cancion> GetCanciones()
        {
            return Canciones;
        }
        public void SetCanciones(List<Cancion> canciones)
        {
            this.canciones = canciones;
        }
        public bool GetEsVinilo()
        {
            return EsVinilo;
        }
        public void SetVinilo(bool esVinilo)
        {
            this.esVinilo = esVinilo;
        }      
    }
}
