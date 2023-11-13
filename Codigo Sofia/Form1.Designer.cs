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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.matrizBform = new System.Windows.Forms.TableLayoutPanel();
            this.VerificarButtom = new System.Windows.Forms.Button();
            this.buttonSALIR = new System.Windows.Forms.Button();
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
            this.matrizBform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.matrizBform.Location = new System.Drawing.Point(27, 26);
            this.matrizBform.Name = "matrizBform";
            this.matrizBform.RowCount = 8;
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.matrizBform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.matrizBform.Size = new System.Drawing.Size(407, 411);
            this.matrizBform.TabIndex = 67;
            this.matrizBform.Paint += new System.Windows.Forms.PaintEventHandler(this.matrizBform_Paint);
            // 
            // VerificarButtom
            // 
            this.VerificarButtom.Location = new System.Drawing.Point(572, 92);
            this.VerificarButtom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VerificarButtom.Name = "VerificarButtom";
            this.VerificarButtom.Size = new System.Drawing.Size(82, 37);
            this.VerificarButtom.TabIndex = 68;
            this.VerificarButtom.Text = "VERIFICAR";
            this.VerificarButtom.UseVisualStyleBackColor = true;
            this.VerificarButtom.Click += new System.EventHandler(this.VerificarButtom_Click);
            // 
            // buttonSALIR
            // 
            this.buttonSALIR.Location = new System.Drawing.Point(572, 203);
            this.buttonSALIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSALIR.Name = "buttonSALIR";
            this.buttonSALIR.Size = new System.Drawing.Size(96, 44);
            this.buttonSALIR.TabIndex = 69;
            this.buttonSALIR.Text = "SALIR";
            this.buttonSALIR.UseVisualStyleBackColor = true;
            this.buttonSALIR.Click += new System.EventHandler(this.buttonSALIR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::Candy.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 440);
            this.Controls.Add(this.buttonSALIR);
            this.Controls.Add(this.VerificarButtom);
            this.Controls.Add(this.matrizBform);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 479);
            this.MinimumSize = new System.Drawing.Size(900, 479);
            this.Name = "Form1";
            this.Text = "Candy Crush";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel matrizBform;
        private System.Windows.Forms.Button VerificarButtom;
        private System.Windows.Forms.Button buttonSALIR;
    }
}

