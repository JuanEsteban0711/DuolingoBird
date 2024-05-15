
namespace DuoligoBird
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.TuboArriba = new System.Windows.Forms.PictureBox();
            this.TuboAbajo = new System.Windows.Forms.PictureBox();
            this.Puntaje = new System.Windows.Forms.Label();
            this.DesplazaPizo = new System.Windows.Forms.Timer(this.components);
            this.Tubo2Arriba = new System.Windows.Forms.PictureBox();
            this.Tubo2Abajo = new System.Windows.Forms.PictureBox();
            this.Piso = new System.Windows.Forms.PictureBox();
            this.Vuelo = new System.Windows.Forms.Timer(this.components);
            this.DesplazaTubos1 = new System.Windows.Forms.Timer(this.components);
            this.DesplazaTubo2 = new System.Windows.Forms.Timer(this.components);
            this.Taza = new System.Windows.Forms.PictureBox();
            this.LabelTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tubo2Arriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tubo2Abajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taza)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::DuoligoBird.Properties.Resources.buho1;
            this.Player.Location = new System.Drawing.Point(81, 198);
            this.Player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(99, 89);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // TuboArriba
            // 
            this.TuboArriba.BackColor = System.Drawing.Color.Transparent;
            this.TuboArriba.Image = global::DuoligoBird.Properties.Resources.tubo_morado;
            this.TuboArriba.Location = new System.Drawing.Point(305, -70);
            this.TuboArriba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TuboArriba.Name = "TuboArriba";
            this.TuboArriba.Size = new System.Drawing.Size(100, 235);
            this.TuboArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TuboArriba.TabIndex = 1;
            this.TuboArriba.TabStop = false;
            // 
            // TuboAbajo
            // 
            this.TuboAbajo.BackColor = System.Drawing.Color.Transparent;
            this.TuboAbajo.Image = global::DuoligoBird.Properties.Resources.tubo_morado;
            this.TuboAbajo.Location = new System.Drawing.Point(305, 311);
            this.TuboAbajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TuboAbajo.Name = "TuboAbajo";
            this.TuboAbajo.Size = new System.Drawing.Size(100, 235);
            this.TuboAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TuboAbajo.TabIndex = 3;
            this.TuboAbajo.TabStop = false;
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.BackColor = System.Drawing.Color.Transparent;
            this.Puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje.ForeColor = System.Drawing.Color.White;
            this.Puntaje.Location = new System.Drawing.Point(121, 170);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(24, 25);
            this.Puntaje.TabIndex = 5;
            this.Puntaje.Text = "0";
            // 
            // DesplazaPizo
            // 
            this.DesplazaPizo.Enabled = true;
            this.DesplazaPizo.Interval = 1;
            this.DesplazaPizo.Tick += new System.EventHandler(this.DesplazaPizo_Tick_1);
            // 
            // Tubo2Arriba
            // 
            this.Tubo2Arriba.BackColor = System.Drawing.Color.Transparent;
            this.Tubo2Arriba.Image = global::DuoligoBird.Properties.Resources.tubo_morado;
            this.Tubo2Arriba.Location = new System.Drawing.Point(585, -70);
            this.Tubo2Arriba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tubo2Arriba.Name = "Tubo2Arriba";
            this.Tubo2Arriba.Size = new System.Drawing.Size(100, 235);
            this.Tubo2Arriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tubo2Arriba.TabIndex = 6;
            this.Tubo2Arriba.TabStop = false;
            // 
            // Tubo2Abajo
            // 
            this.Tubo2Abajo.BackColor = System.Drawing.Color.Transparent;
            this.Tubo2Abajo.Image = global::DuoligoBird.Properties.Resources.tubo_morado;
            this.Tubo2Abajo.Location = new System.Drawing.Point(585, 311);
            this.Tubo2Abajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tubo2Abajo.Name = "Tubo2Abajo";
            this.Tubo2Abajo.Size = new System.Drawing.Size(100, 235);
            this.Tubo2Abajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tubo2Abajo.TabIndex = 7;
            this.Tubo2Abajo.TabStop = false;
            // 
            // Piso
            // 
            this.Piso.Image = global::DuoligoBird.Properties.Resources.piso1;
            this.Piso.Location = new System.Drawing.Point(0, 496);
            this.Piso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(1248, 50);
            this.Piso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piso.TabIndex = 4;
            this.Piso.TabStop = false;
            // 
            // Vuelo
            // 
            this.Vuelo.Enabled = true;
            this.Vuelo.Interval = 10;
            this.Vuelo.Tick += new System.EventHandler(this.Vuelo_Tick_1);
            // 
            // DesplazaTubos1
            // 
            this.DesplazaTubos1.Enabled = true;
            this.DesplazaTubos1.Interval = 1;
            this.DesplazaTubos1.Tick += new System.EventHandler(this.DesplazaTubos1_Tick_1);
            // 
            // DesplazaTubo2
            // 
            this.DesplazaTubo2.Enabled = true;
            this.DesplazaTubo2.Interval = 1;
            this.DesplazaTubo2.Tick += new System.EventHandler(this.DesplazaTubo2_Tick);
            // 
            // Taza
            // 
            this.Taza.BackColor = System.Drawing.Color.Transparent;
            this.Taza.Image = global::DuoligoBird.Properties.Resources.taza_blanca;
            this.Taza.Location = new System.Drawing.Point(151, 153);
            this.Taza.Name = "Taza";
            this.Taza.Size = new System.Drawing.Size(29, 40);
            this.Taza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Taza.TabIndex = 8;
            this.Taza.TabStop = false;
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.BackColor = System.Drawing.Color.Transparent;
            this.LabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimer.ForeColor = System.Drawing.Color.White;
            this.LabelTimer.Location = new System.Drawing.Point(629, 512);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(152, 25);
            this.LabelTimer.TabIndex = 9;
            this.LabelTimer.Text = "Tiempo = 0:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DuoligoBird.Properties.Resources.fondo_tierra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 546);
            this.Controls.Add(this.LabelTimer);
            this.Controls.Add(this.Piso);
            this.Controls.Add(this.Tubo2Abajo);
            this.Controls.Add(this.Tubo2Arriba);
            this.Controls.Add(this.TuboAbajo);
            this.Controls.Add(this.TuboArriba);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Taza);
            this.Controls.Add(this.Puntaje);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duolingo Bird";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tubo2Arriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tubo2Abajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Taza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox TuboArriba;
        private System.Windows.Forms.PictureBox TuboAbajo;
        private System.Windows.Forms.Label Puntaje;
        private System.Windows.Forms.Timer DesplazaPizo;
        private System.Windows.Forms.PictureBox Tubo2Arriba;
        private System.Windows.Forms.PictureBox Tubo2Abajo;
        private System.Windows.Forms.PictureBox Piso;
        private System.Windows.Forms.Timer Vuelo;
        private System.Windows.Forms.Timer DesplazaTubos1;
        private System.Windows.Forms.Timer DesplazaTubo2;
        private System.Windows.Forms.PictureBox Taza;
        private System.Windows.Forms.Label LabelTimer;
    }
}

