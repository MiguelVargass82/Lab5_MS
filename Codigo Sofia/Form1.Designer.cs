namespace Candy
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.matrizBform = new System.Windows.Forms.TableLayoutPanel();
            this.VerificarButtom = new System.Windows.Forms.Button();
            this.buttonSALIR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // matrizBform
            // 
            this.matrizBform.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matrizBform.BackColor = System.Drawing.Color.Transparent;
            this.matrizBform.ColumnCount = 8;
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 543F));
            this.matrizBform.Location = new System.Drawing.Point(271, 21);
            this.matrizBform.Margin = new System.Windows.Forms.Padding(4);
            this.matrizBform.Name = "matrizBform";
            this.matrizBform.RowCount = 8;
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.matrizBform.Size = new System.Drawing.Size(543, 506);
            this.matrizBform.TabIndex = 67;
            this.matrizBform.Paint += new System.Windows.Forms.PaintEventHandler(this.matrizBform_Paint);
            // 
            // VerificarButtom
            // 
            this.VerificarButtom.Location = new System.Drawing.Point(859, 185);
            this.VerificarButtom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VerificarButtom.Name = "VerificarButtom";
            this.VerificarButtom.Size = new System.Drawing.Size(109, 46);
            this.VerificarButtom.TabIndex = 68;
            this.VerificarButtom.Text = "VERIFICAR";
            this.VerificarButtom.UseVisualStyleBackColor = true;
            this.VerificarButtom.Click += new System.EventHandler(this.VerificarButtom_Click);
            // 
            // buttonSALIR
            // 
            this.buttonSALIR.Location = new System.Drawing.Point(1023, 176);
            this.buttonSALIR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSALIR.Name = "buttonSALIR";
            this.buttonSALIR.Size = new System.Drawing.Size(128, 54);
            this.buttonSALIR.TabIndex = 69;
            this.buttonSALIR.Text = "SALIR";
            this.buttonSALIR.UseVisualStyleBackColor = true;
            this.buttonSALIR.Click += new System.EventHandler(this.buttonSALIR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(849, 236);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 172);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1011, 176);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 55);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Score.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(976, 329);
            this.Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(26, 39);
            this.Score.TabIndex = 72;
            this.Score.Text = " ";
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(943, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 73;
            this.label2.Text = "     ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(851, 176);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 55);
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 58);
            this.button1.TabIndex = 75;
            this.button1.Text = "MEJORES PUNTAJES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Candy.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonSALIR);
            this.Controls.Add(this.VerificarButtom);
            this.Controls.Add(this.matrizBform);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1194, 579);
            this.MinimumSize = new System.Drawing.Size(1194, 579);
            this.Name = "Form1";
            this.Text = "Candy Crush";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel matrizBform;
        private System.Windows.Forms.Button VerificarButtom;
        private System.Windows.Forms.Button buttonSALIR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}

