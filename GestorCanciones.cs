using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeMusica
{
    public class GestorCanciones
    {
        Cancion cancion;
        List<Cancion> canciones;

        public GestorCanciones()
        {
            canciones = new List<Cancion>();
        }
        public void AgregarCancion()
        {
            canciones.Add(cancion);
        }
        public void MostrarCanciones()
        {

        }
    }
}
