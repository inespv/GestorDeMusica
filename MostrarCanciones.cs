using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMusica
{
    public partial class MostrarCanciones : Form
    {
        Cancion cancion;
        GestorCanciones gestorCanciones;
        List<Cancion> canciones;
        public MostrarCanciones()
        {
            InitializeComponent();
            gestorCanciones = new GestorCanciones();
            canciones = new List<Cancion>();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opciones = " ";
            opciones.Equals(comboBox1.Items);
        }
       
        private void MostrarCanciones_Load(object sender, EventArgs e)
        {
            MostrarCanciones_Load(sender, e, cancionBindingSource);
        }

        private void MostrarCanciones_Load(object sender, EventArgs e, BindingSource cancionBindingSource)
        {
            
        }
    }
}
