using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMusica
{
    public partial class AgregarCancion : Form
    {
        private GestorCanciones gestorCanciones;

        public AgregarCancion(GestorCanciones gestorCanciones)
        {
            InitializeComponent();
            this.gestorCanciones = gestorCanciones;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            anyoTB.MaxLength = 4;   
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            duracionTB.MaxLength = 4;
        } 
        private async void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            { Filter = "Text Documents |*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter ficheroCanciones = new StreamWriter("canciones.txt", true))
                    {
                        await ficheroCanciones.WriteLineAsync(tituloTB.Text);
                        await ficheroCanciones.WriteLineAsync(generoTB.Text);
                        await ficheroCanciones.WriteLineAsync(artistaTB.Text);
                        await ficheroCanciones.WriteLineAsync(anyoTB.Text);
                        await ficheroCanciones.WriteLineAsync(albumTB.Text);
                        await ficheroCanciones.WriteLineAsync(duracionTB.Text);

                        foreach (Cancion c in gestorCanciones.Canciones)
                        {
                            ficheroCanciones.Write($"{c.Titulo};{c.Genero};{c.Artista};" 
                                +$"{c.Anyo};{c.Album};" + $"{c.Duracion}");
                        }
                        MessageBox.Show("Los datos se han guardado correctamente ", "Mensaje"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }            
                }
            }
        }
    }
}
