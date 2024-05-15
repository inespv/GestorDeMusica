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
    public partial class Menu : Form
    {
        Buscar buscar;
        Agregar anyadir;
        Form1 form;
        MostrarDatos mostrarDatos;
       

        public Menu()
        {
            InitializeComponent();
        }
        private void Button6_Click(object sender, EventArgs e)
        {

            anyadir = new Agregar();
            anyadir.ShowDialog();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            mostrarDatos = new MostrarDatos();
            mostrarDatos.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buscar = new Buscar();
            buscar.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form = new Form1();

            form.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
