namespace Candy
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.nickname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NICKNAME:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "JUGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nickname
            // 
            this.nickname.Location = new System.Drawing.Point(159, 48);
            this.nickname.Name = "nickname";
            this.nickname.Size = new System.Drawing.Size(144, 22);
            this.nickname.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 199);
            this.Controls.Add(this.nickname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox nickname;
    }
}