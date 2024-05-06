using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMusica
{
    public partial class AgregarCancion : Form
    {
        List<Cancion> canciones;
        string titulo;
        string genero;
        Album album;
        Artista artista;
        int anyo;
        double duracion;

        public AgregarCancion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             titulo = Convert.ToString(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             genero = Convert.ToString(textBox3.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             artista = new Artista(textBox4.Text);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 4;
            anyo = Convert.ToInt32(textBox5.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             album = new Album(textBox2.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.MaxLength = 4;
            duracion = Convert.ToDouble(textBox6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            canciones = new List<Cancion>(); 
           
            titulo = textBox1.Text;
            genero = textBox3.Text;
            album = new Album(textBox2.Text);
            artista = new Artista();
            anyo.Equals(textBox5);
            duracion.Equals(textBox6.Text);

            canciones.Add(new Cancion(titulo, genero, artista, anyo,
                    new Album(textBox5.Text), duracion));
        
            MessageBox.Show("Los datos se han guardado correctamente ");
        }
    }
}
