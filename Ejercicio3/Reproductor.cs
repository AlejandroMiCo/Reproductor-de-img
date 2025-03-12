using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Reproductor : UserControl
    {
        public Reproductor()
        {
            InitializeComponent();
        }

        bool isPlaying = false;
        private int minutos;
        public int Minutos
        {
            get
            {
                return minutos;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                minutos = value < 60 ? value : 0;
                lblTime.Text = $"{minutos.ToString("#00")}:{segundos.ToString("#00")}";
                this.Refresh();
            }
        }

        private int segundos;
        public int Segundos
        {
            get
            {
                return segundos;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                segundos = value;        // No ternaria Ç_Ç
                if (segundos > 59)
                {
                    segundos %= 60;
                    this.OnDesbordaTiempo(EventArgs.Empty);
                }
                lblTime.Text = $"{minutos.ToString("#00")}:{segundos.ToString("#00")}";
                this.Refresh();
            }
        }

        public event EventHandler PlayClick;

        protected virtual void OnPlayClick(EventArgs e)
        {
            isPlaying = !isPlaying;
            btnReproducir.Text = isPlaying ? "Pause" : "Play";  // Esta al reves para informar de la accion que se realizara
            PlayClick?.Invoke(this, e);
        }

        public event EventHandler DesbordaTiempo;

        protected virtual void OnDesbordaTiempo(EventArgs e)
        {
            DesbordaTiempo?.Invoke(this, e);
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            OnPlayClick(e);
        }
    }
}
