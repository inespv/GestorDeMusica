using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMusica
{
    public partial class AgregarCancion : Form
    {
        Cancion cancion ;
        List<Cancion> canciones;
        string titulo;
        string tituloAlbum;
        string genero;
        string album;
        string artista;
        int anyo;
        double duracion;
        string nombreArtistico;
        bool esVinilo;

        public AgregarCancion()
        {
            InitializeComponent();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 4;   
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 4;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            canciones = new List<Cancion>();

            titulo = textBox1.Text;
            genero = textBox3.Text;
            album = textBox2.Text;
            artista = textBox4.Text;
            anyo.Equals(textBox5);
            duracion.Equals(textBox6.Text);

            artista.Equals(new Artista(nombreArtistico));
            album.Equals(new Album(tituloAlbum, esVinilo));

            canciones.Add(new Cancion(titulo, genero, artista, anyo, album, duracion));

            MessageBox.Show("Los datos se han guardado correctamente ");

            for (int i = 0; i < canciones.Count; i++)
            {
                MessageBox.Show("Las canciones : son " + canciones[i]);
            }
            StreamWriter fichero = new StreamWriter("canciones.txt");

            fichero.WriteLine(canciones);

            fichero.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
