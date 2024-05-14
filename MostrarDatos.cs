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
    public partial class MostrarDatos : Form
    {
        Menu menu;
        MostrarCanciones mostrarCanciones;
        MostrarAlbumes mostrarAlbumes;
        public MostrarDatos()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            menu.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarCanciones = new MostrarCanciones();
            mostrarCanciones.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarAlbumes = new MostrarAlbumes();
            mostrarAlbumes.ShowDialog();

        }
    }
}
