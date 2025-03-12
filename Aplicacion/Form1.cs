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
using static System.Net.Mime.MediaTypeNames;

namespace Aplicacion
{
    public partial class Form1 : Form
    {
        private List<Bitmap> imagenes = new List<Bitmap>();
        private bool activo = false;
        private bool carpetanueva = false;
        private int contImagenes = 0;
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
            {
                cbTiempo.Items.Add(i + 1);
            }
            cbTiempo.SelectedIndex = 0;
        }

        private void btnCargarImagenes_Click(object sender, EventArgs e)
        {
            string[] ext = { ".jpg", ".jpeg", ".png", ".bmp", ".tiff", ".ico" };

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                imagenes.Clear();
                pbCajaDeImagenes.Image = default;
                carpetanueva = true;
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(fbd.SelectedPath);
                    FileInfo[] files = dir.GetFiles();
                    for (int i = 0; i < files.Length; i++)
                    {
                        if (ext.Contains(files[i].Extension))
                        {
                            try
                            {
                                imagenes.Add(new Bitmap(files[i].FullName));
                            }
                            catch (ArgumentException)
                            {
                            }
                        }
                    }
                }
                catch (Exception ex) when (ex is UnauthorizedAccessException || ex is ArgumentException)
                {
                    MessageBox.Show("Error al acceder al directorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            reproductor1.Segundos++;


            if (reproductor1.Segundos % ((int)cbTiempo.SelectedItem) == 0 && imagenes.Count > 0)
            {
                if (imagenes.Count -1 < contImagenes)
                {
                    contImagenes = 0;
                }

                pbCajaDeImagenes.Image = imagenes[contImagenes];
                contImagenes++;
            }
        }

        private void reproductor1_PlayClick(object sender, EventArgs e)
        {
            activo = !activo;
            if (activo)
            {
                if (carpetanueva)
                {
                    pbCajaDeImagenes.Image = imagenes[contImagenes];
                    contImagenes++;
                }
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
