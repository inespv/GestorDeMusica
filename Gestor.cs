using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    internal class Gestor
    {
        public void AgregarCancion()
        {
            Cancion cancion;
            List<Cancion> canciones = new List<Cancion>();

            Console.WriteLine("Introduce los datos de la nueva canción");
            Console.WriteLine("Título :");
            string titulo = Console.ReadLine();

            Console.WriteLine("Género :");
            string genero = Console.ReadLine();

            Console.WriteLine("Álbum al que pertenece :");
            Album album = new Album();

            Console.WriteLine("Artista :");
            Artista artista = new Artista();

            Console.WriteLine("Año de publicación:");
            int anyo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Duración :");
            double duracion = Convert.ToDouble(Console.ReadLine());

            canciones.Add(new Cancion(titulo, genero, artista, anyo, album, duracion));
        }
    }
}
