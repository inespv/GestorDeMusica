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
    public partial class Buscar : Form
    {
        Menu menu;
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            menu.ShowDialog();
            menu.Hide();
        }
        private void label3_Click_1(object sender, EventArgs e)
        {
            seleccion.Text = comboCategoria.Text;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            seleccion2.Text = comboBoxCriterio.Text;
        }
    }
}
