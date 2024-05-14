﻿using System;
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
        List<Album> albums;
        List<Cancion> canciones;
        string tituloAlbum;
        string genero;
        string artista;
        string nombreArtistico;
        int anyo;
        double duracion;
        bool esVinilo;
        Album album;

        public AgregarAlbum()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            albums = new List<Album>();

            tituloAlbum = textBox1.Text;
            genero = textBox3.Text;
            
            artista = textBox4.Text;
            anyo.Equals(textBox5);
            duracion.Equals(textBox6.Text);

            albums.Add(new Album(tituloAlbum, genero, new Artista(nombreArtistico),
                anyo,duracion,esVinilo));

            MessageBox.Show("Los datos se han guardado correctamente ");

            for (int i = 0; i < albums.Count; i++)
            {
                MessageBox.Show("Los datos del álbum son : " + albums[i]);
            }
            StreamWriter ficheroAlbumes = new StreamWriter("albumes.txt");

            ficheroAlbumes.WriteLine(albums);

            if (checkBox1.Checked)
            {
                esVinilo = true;
            }

            ficheroAlbumes.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void AgregarAlbum_Load(object sender, EventArgs e)
        {

        }
    }
}
