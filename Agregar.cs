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
    public partial class Agregar : Form
    {
        AgregarCancion cancion;
        public Agregar()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cancion = new AgregarCancion();
            cancion.ShowDialog();
        }
    }
}
