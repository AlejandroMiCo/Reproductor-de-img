namespace Aplicacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCargarImagenes = new System.Windows.Forms.Button();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.pbCajaDeImagenes = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reproductor1 = new Ejercicio3.Reproductor();
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaDeImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarImagenes
            // 
            this.btnCargarImagenes.Location = new System.Drawing.Point(387, 12);
            this.btnCargarImagenes.Name = "btnCargarImagenes";
            this.btnCargarImagenes.Size = new System.Drawing.Size(131, 44);
            this.btnCargarImagenes.TabIndex = 1;
            this.btnCargarImagenes.Text = "Cargar Imagenes";
            this.btnCargarImagenes.UseVisualStyleBackColor = true;
            this.btnCargarImagenes.Click += new System.EventHandler(this.btnCargarImagenes_Click);
            // 
            // cbTiempo
            // 
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Location = new System.Drawing.Point(387, 62);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(131, 21);
            this.cbTiempo.TabIndex = 2;
            // 
            // pbCajaDeImagenes
            // 
            this.pbCajaDeImagenes.Location = new System.Drawing.Point(13, 12);
            this.pbCajaDeImagenes.Name = "pbCajaDeImagenes";
            this.pbCajaDeImagenes.Size = new System.Drawing.Size(368, 286);
            this.pbCajaDeImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCajaDeImagenes.TabIndex = 4;
            this.pbCajaDeImagenes.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // reproductor1
            // 
            this.reproductor1.Location = new System.Drawing.Point(398, 108);
            this.reproductor1.Minutos = 0;
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Segundos = 0;
            this.reproductor1.Size = new System.Drawing.Size(105, 54);
            this.reproductor1.TabIndex = 5;
            this.reproductor1.PlayClick += new System.EventHandler(this.reproductor1_PlayClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 310);
            this.Controls.Add(this.reproductor1);
            this.Controls.Add(this.pbCajaDeImagenes);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.btnCargarImagenes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reproduztor Molon";
            ((System.ComponentModel.ISupportInitialize)(this.pbCajaDeImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCargarImagenes;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.PictureBox pbCajaDeImagenes;
        private System.Windows.Forms.Timer timer1;
        private Ejercicio3.Reproductor reproductor1;
    }
}

