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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestorDeMusica
{
    public partial class AgregarAlbum : Form
    {
        GestorAlbumes gestorAlbumes;
        public AgregarAlbum()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            gestorAlbumes = new GestorAlbumes();
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents |*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter ficheroAlbumes = new StreamWriter("albumes.txt", true))
                    {
                        await ficheroAlbumes.WriteLineAsync(tituloATB.Text);
                        await ficheroAlbumes.WriteLineAsync(generoATB.Text);
                        await ficheroAlbumes.WriteLineAsync(artistaATB.Text);
                        await ficheroAlbumes.WriteLineAsync(anyoATB.Text);
                        await ficheroAlbumes.WriteLineAsync(duracionATB.Text);

                        foreach (Album a in gestorAlbumes.Albums)
                        {
                            ficheroAlbumes.WriteLine($"{a.NombreAlbum},{a.Genero},{a.Artista}," +
                                $"{a.Anyo},{a.Duracion},{a.EsVinilo}");
                        }
                        MessageBox.Show("Los datos se han guardado correctamente ", "Mensaje"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
