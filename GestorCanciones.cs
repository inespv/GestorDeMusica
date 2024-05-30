using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeMusica
{
    public class GestorCanciones
    {
        private List<Cancion> canciones;

        public GestorCanciones()
        {
            Canciones = new List<Cancion>();
        }
        public List<Cancion> Canciones { get => canciones; set => canciones = value; }

        public void AgregarCancion(Cancion cancion)
        {
            Canciones.Add(cancion);
        }
    }
}
