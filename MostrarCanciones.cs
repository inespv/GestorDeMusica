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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if(MessageBox.Show("Estás seguro de que deseas eliminar esta canción?" +
                    " ","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cancionBindingSource.Remove(cancion);
                }
            }
            if (comboBox1.Items.Equals("Album"))
            {
                dataGridView1.Columns.Remove("Album");
            }
        }

        private void MostrarCanciones_Load(object sender, EventArgs e)
        {
            MostrarCanciones_Load(sender, e, cancionBindingSource);
        }

        private void MostrarCanciones_Load(object sender, EventArgs e, BindingSource cancionBindingSource)
        {
            AgregarCancion agregarCancion = new AgregarCancion();

            StreamWriter ficheroMostrar;
            string nombre = "canciones.txt";

            if (!File.Exists(nombre))
            {
                MessageBox.Show("El archivo se ha creado correctamente");

                ficheroMostrar = new StreamWriter("canciones.txt");

                cancionBindingSource.Add(new Cancion()
                {
                    Titulo = "Folelé ",
                    Genero = "Música urbana ",
                    Album = new Album("Me Muevo con Dios", false),
                    Artista = new Artista("Cruz Cafuné"),
                    Anyo = 2023,
                    Duracion = 76,
                });
                ficheroMostrar.WriteLine(cancionBindingSource);
                cancionBindingSource.Add(new Cancion()
                {
                    Titulo = "Cuando Bebe ",
                    Genero = "Reggaeton",
                    Album = new Album("Famouz", false),
                    Artista = new Artista("Jhayco,Rafa Pabön"),
                    Anyo = 2019,
                    Duracion = 4.04
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
                foreach(string cancions in cancionBindingSource)
                {
                    ficheroMostrar.WriteLine(cancionBindingSource);
                }

                foreach(Cancion cancion in canciones)
                {
                    ficheroMostrar.WriteLine(canciones);
                }

                MessageBox.Show(" El contenido del fichero es " + ficheroMostrar);
            } 
        }
    }
}
