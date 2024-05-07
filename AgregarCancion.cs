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
        string album;
        string artista;
        int anyo;
        double duracion;

        public AgregarCancion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender)
        {
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.MaxLength = 4;
           
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

            canciones.Add(new Cancion(titulo, genero, new Artista(),anyo,
                     new Album(), duracion));
        
            MessageBox.Show("Los datos se han guardado correctamente ");
        }
    }
}
