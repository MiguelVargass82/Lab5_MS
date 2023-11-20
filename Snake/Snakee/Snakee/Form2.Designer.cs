namespace Snakee
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum3 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textNum4 = new System.Windows.Forms.TextBox();
            this.textNum5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUMERO 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "NUMERO 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "NUMERO 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "LOS 5 MEJORES";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(168, 132);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(410, 22);
            this.textNum1.TabIndex = 6;
            this.textNum1.Text = "No existe";
            // 
            // textNum3
            // 
            this.textNum3.Location = new System.Drawing.Point(168, 230);
            this.textNum3.Name = "textNum3";
            this.textNum3.Size = new System.Drawing.Size(410, 22);
            this.textNum3.TabIndex = 7;
            this.textNum3.Text = "No existe";
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(168, 181);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(410, 22);
            this.textNum2.TabIndex = 8;
            this.textNum2.Text = "No existe";
            // 
            // textNum4
            // 
            this.textNum4.Location = new System.Drawing.Point(168, 274);
            this.textNum4.Name = "textNum4";
            this.textNum4.Size = new System.Drawing.Size(410, 22);
            this.textNum4.TabIndex = 9;
            this.textNum4.Text = "No existe";
            // 
            // textNum5
            // 
            this.textNum5.Location = new System.Drawing.Point(168, 335);
            this.textNum5.Name = "textNum5";
            this.textNum5.Size = new System.Drawing.Size(410, 22);
            this.textNum5.TabIndex = 10;
            this.textNum5.Text = "No existe";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 420);
            this.Controls.Add(this.textNum5);
            this.Controls.Add(this.textNum4);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum3);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textNum1;
        public System.Windows.Forms.TextBox textNum3;
        public System.Windows.Forms.TextBox textNum2;
        public System.Windows.Forms.TextBox textNum4;
        public System.Windows.Forms.TextBox textNum5;
    }
}