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
    }
}
