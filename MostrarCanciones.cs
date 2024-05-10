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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this song ? ","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cancionBindingSource.RemoveCurrent();
                }
            }
        }
        private void MostrarCanciones_Load(object sender, EventArgs e)
        {
            cancionBindingSource.Add(new Cancion()
            {
                Titulo = "Folelé ",
                Genero = "Música urbana ",
                Album = new Album("Me Muevo con Dios", false),
                Artista = new Artista("Cruz Cafuné"),
                Anyo = 2023,
                Duracion = 76,
            });

            cancionBindingSource.Add(new Cancion()
            {
                Titulo = "Cuando Bebe ",
                Genero = "Reggaeton",
                Album = new Album("Famouz", false),
                Artista =new Artista("Jhayco,Rafa Pabön"),
                Anyo = 2019,
                Duracion = 4.04
            });
            cancionBindingSource.Add(new Cancion()
            {
                Titulo = "Un desperdicio ",
                Genero = "Música urbana ",
                Album = new Album("a new star(1993)",true),
                Artista = new Artista("Rels B"),
                Anyo = 2024,
                Duracion = 3.43
            });
            cancionBindingSource.Add(new Cancion()
            {
                Titulo = "Un desperdicio ",
                Genero = "Música urbana ",
                Album = new Album("a new star(1993)", true),
                Artista = new Artista("Rels B"),
                Anyo = 2024,
                Duracion = 3.43
            });
            cancionBindingSource.Add(new Cancion()
            {
                Titulo = "46020",
                Genero = "Reggaeton català",
                Album = new Album("Cor i foc", false),
                Artista = new Artista("Maluks"),
                Anyo = 2023,
                Duracion = 2.31
            });
        }
    }
}
