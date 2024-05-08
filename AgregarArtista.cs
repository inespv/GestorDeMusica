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
    public partial class AgregarArtista : Form
    {
        GestorArtistas gestorArtistas;
        List<Artista> artistas;
        string nombreArtistico;
        public AgregarArtista()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            artistas = new List<Artista>();

            nombreArtistico = textBox1.Text;

            artistas.Add(new Artista(nombreArtistico));

            MessageBox.Show("Los datos se han guardado correctamente","Aviso",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
