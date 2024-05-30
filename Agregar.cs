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
        Menu menu;
        AgregarCancion agregarCancion;
        AgregarAlbum agregarAlbum;
        private GestorCanciones gestorCanciones;

        public Agregar()
        {
            InitializeComponent();
            gestorCanciones = new GestorCanciones();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            gestorCanciones.Canciones.Clear();

            agregarCancion = new AgregarCancion(gestorCanciones);

            DialogResult dialogoAgregarC 
                = agregarCancion.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            agregarAlbum = new AgregarAlbum();
            DialogResult dialogResult;
            dialogResult = agregarAlbum.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            DialogResult dialogResult;
            dialogResult = menu.ShowDialog();
        }
    }
}
