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

        Menu menu;
        public AgregarCancion()
        {
            InitializeComponent();
            menu = new Menu();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (textBox1.Text == " " )
                {
                    MessageBox.Show("Ese título no es válido");
                }

            }catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == " ")
                {
                    MessageBox.Show("Ese género no es válido");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == " ")
                {
                    MessageBox.Show("Ese nombre de artista no es válido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.Text == " ")
                {
                    MessageBox.Show("Ese álbum no es válido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.ShowDialog();
            Gestor gestor = new Gestor();
            gestor.AgregarCancion();
            Cancion cancion = new Cancion();
            textBox1.Equals(cancion.GetTitulo());
            textBox2.Equals(cancion.GetGenero());
            textBox3.Equals(cancion.GetAlbum());
            textBox4.Equals(cancion.GetArtista());
            textBox5.Equals(cancion.GetAnyo());
            textBox6.Equals(cancion.GetDuracion());
         

            if (button1.Capture)
            {
                MessageBox.Show("Los datos se han guardado en la lista");
            }
        }

        private void AgregarCancion_Load(object sender, EventArgs e)
        {
            Gestor gestor = new Gestor();
            gestor.AgregarCancion();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
