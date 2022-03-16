using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace FormListaReproduccionG2_2022_II
{
    public partial class Form1 : Form
    {
        private ArrayList canciones;
        private Musica cancion;
        public Form1()
        {
            InitializeComponent();
            canciones = new ArrayList();
        }

        private void cargarCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCanciones();
            foreach(  Musica musica in canciones)
            {
                lstbCanciones.Items.Add(musica.Cancion);
            }

        }

        private void ListaCanciones()
        {
            canciones.Add(new Musica("The Adults Are Talking ", "The strokes ","The new abnormal" ));
            canciones.Add(new Musica("If you really love nothing", "Interpol", "Marauder"));
            canciones.Add(new Musica("Valentine", "DIIV", "Is the is are"));
        }
    }
}
