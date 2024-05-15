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
        private GestorCanciones gestorCanciones;

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
            string tituloAlbum;
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
           
            MessageBox.Show("Los datos se han guardado correctamente ");

            for (int i = 0; i < gestorCanciones.Canciones.Count; i++)
            {
                MessageBox.Show("Las canciones : son " + gestorCanciones.Canciones[i]);
            }
        }
    }
}
