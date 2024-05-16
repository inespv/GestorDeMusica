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
        Modificar modificar;

        public Menu()
        {
            InitializeComponent();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            anyadir = new Agregar();
            DialogResult dialogResult;
            dialogResult = anyadir.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mostrarDatos = new MostrarDatos();
            DialogResult dialogResult;
            dialogResult = mostrarDatos.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buscar = new Buscar();
            DialogResult dialogResult;
            dialogResult = buscar.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form = new Form1();
            DialogResult dialogoResult
                = form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            modificar = new Modificar();
            DialogResult dialogoResult
              = modificar.ShowDialog();
        }
    }
}
