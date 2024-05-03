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
    public partial class Form1 : Form
    {
        Menu menuInicio;
        public Form1()
        {
            InitializeComponent();
            menuInicio = new Menu();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            menuInicio.ShowDialog();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
