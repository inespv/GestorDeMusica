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
        Bienvenida form;

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
        private void button1_Click(object sender, EventArgs e)
        {
            form = new Bienvenida();
            DialogResult dialogoResult
                = form.ShowDialog();
        }
    }
}
