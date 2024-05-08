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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gestorCanciones = new GestorCanciones();
            canciones = new List<Cancion>();

            //canciones.ForEach(canciones => canciones.)
            
        }

        private void MostrarCanciones_Load(object sender, EventArgs e)
        {

            cancionBindingSource.Add(new Cancion()
            {
                Titulo= "Folelé ",Genero = "Música urbana ",Album = new Album("Me Muevo con Dios",
            "Música urbana",new Artista("Cruz Cafuné"),2023,76,false),Anyo =2023,Duracion =76
            });

            cancionBindingSource.Add(new Cancion()
            {
                Titulo = "Cuando Bebe ",
                Genero = "Reggaeton",
                Album = new Album("Famouz",
         "Reggaeton", new Artista("Jhayco,Rafa Pabön"), 2019, 50.54, false),
                Anyo = 2019,
                Duracion = 50.54
            });
            cancionBindingSource.Add(new Cancion()
            {
                Titulo = "Folelé ",
                Genero = "Música urbana ",
                Album = new Album("Me Muevo con Dios",
         "Música urbana", new Artista("Cruz Cafuné"), 2023, 76, false),
                Anyo = 2023,
                Duracion = 76
            });

        }
    }
}
