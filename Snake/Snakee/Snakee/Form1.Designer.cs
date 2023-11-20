namespace Snakee
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iniciar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.puntaje = new System.Windows.Forms.Label();
            this.mejorPuntaje = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.puntajesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(215, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 469);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.subirVisual);
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iniciar.Location = new System.Drawing.Point(748, 251);
            this.iniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(100, 42);
            this.iniciar.TabIndex = 1;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(748, 300);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.BackColor = System.Drawing.Color.DeepPink;
            this.puntaje.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.Location = new System.Drawing.Point(16, 130);
            this.puntaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(117, 28);
            this.puntaje.TabIndex = 3;
            this.puntaje.Text = "Tu puntaje:";
            this.puntaje.Visible = false;
            this.puntaje.Click += new System.EventHandler(this.puntaje_Click);
            // 
            // mejorPuntaje
            // 
            this.mejorPuntaje.AutoSize = true;
            this.mejorPuntaje.BackColor = System.Drawing.Color.Coral;
            this.mejorPuntaje.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mejorPuntaje.Location = new System.Drawing.Point(16, 192);
            this.mejorPuntaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mejorPuntaje.Name = "mejorPuntaje";
            this.mejorPuntaje.Size = new System.Drawing.Size(151, 28);
            this.mejorPuntaje.TabIndex = 4;
            this.mejorPuntaje.Text = "Mejor Puntaje:";
            this.mejorPuntaje.Visible = false;
            // 
            // tiempo
            // 
            this.tiempo.Interval = 200;
            this.tiempo.Tick += new System.EventHandler(this.eventoTiempo);
            // 
            // puntajesBtn
            // 
            this.puntajesBtn.Location = new System.Drawing.Point(758, 114);
            this.puntajesBtn.Name = "puntajesBtn";
            this.puntajesBtn.Size = new System.Drawing.Size(101, 60);
            this.puntajesBtn.TabIndex = 5;
            this.puntajesBtn.Text = "MEJORES PUNTAJES";
            this.puntajesBtn.UseVisualStyleBackColor = true;
            this.puntajesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 481);
            this.Controls.Add(this.puntajesBtn);
            this.Controls.Add(this.mejorPuntaje);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Label mejorPuntaje;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Button puntajesBtn;
    }
}

