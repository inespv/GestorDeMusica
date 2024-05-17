using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMusica
{
    public class GestorCanciones
    {
        private List<Cancion> canciones;

        public GestorCanciones()
        {
            Canciones = new List<Cancion>();
        }
        public List<Cancion> Canciones { get => canciones; set => canciones = value; }

        public void AgregarCancion(Cancion cancion)
        {
            Canciones.Add(cancion);
        }
        public void LeerArchivo()
        {
            Artista artista = new Artista();
            Album album = new Album();
            StreamReader fichero =null;
            string linea = " ";

            try
            {
                fichero = new StreamReader("canciones.txt");
                while(linea != null)
                {
                    linea = fichero.ReadLine();
                    if(fichero.ReadLine() != null)
                    {
                        string[] strings = linea.Split(':');
                        string[] trozos = strings;

                        /*Canciones.Add(new Cancion(trozos[0], trozos[1],
                           new Artista(artista.NombreArtistico), Convert.ToInt32(trozos[3]),
                           new Album(album.NombreAlbum,album.Genero,
                           album.Artista,album.Anyo,album.Duracion,album.EsVinilo),
                           Convert.ToDouble(trozos[5])));*/
                    }
                } 
            }catch (FileNotFoundException)
            {
                MessageBox.Show("El fichero no se encontró","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }catch (IOException) 
            {
                MessageBox.Show("Hubo un error con el fichero", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(fichero != null)
                {
                    fichero.Close();
                }
            }
        }
    }
}
