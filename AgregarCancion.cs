using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMusica
{
    public partial class AgregarCancion : Form
    {
        private GestorCanciones gestorCanciones;
        private Cancion cancion;

        public AgregarCancion(GestorCanciones gestorCanciones)
        {
            InitializeComponent();
            this.gestorCanciones = gestorCanciones;
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
            string titulo;
            string nombreAlbum;
            string genero;
            string album;
            string artista;
            int anyo = 0;
            double duracion = 0;
            string nombreArtistico;
            bool esVinilo;
      
            titulo = textBox1.Text;
            genero = textBox3.Text;
            album = textBox2.Text;
            artista = textBox4.Text;
            anyo.Equals(textBox5);
            duracion.Equals(textBox6.Text);

            gestorCanciones = new GestorCanciones();
            try
            {
                StreamWriter ficheroCanciones =
                new StreamWriter("canciones2.txt");
                ficheroCanciones.WriteLine(gestorCanciones.Canciones.Count);
                foreach (Cancion c in gestorCanciones.Canciones)
                {
                    ficheroCanciones.WriteLine(c.Titulo);
                    ficheroCanciones.WriteLine(c.Genero);
                    ficheroCanciones.WriteLine(c.Artista);
                    ficheroCanciones.WriteLine(c.Anyo);
                    ficheroCanciones.WriteLine(c.Album);
                    ficheroCanciones.WriteLine(c.Duracion);
                    ficheroCanciones.WriteLine();
                }
                ficheroCanciones.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error, no se ha encontrador el fichero");
            }
            catch (IOException)
            {
                MessageBox.Show("Error");
            }         
            MessageBox.Show("Los datos se han guardado correctamente ");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
