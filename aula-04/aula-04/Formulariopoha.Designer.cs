namespace aula_04
{
    partial class Formulariopoha
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
            this.Ra = new System.Windows.Forms.Label();
            this.InputRa = new System.Windows.Forms.TextBox();
            this.Media = new System.Windows.Forms.Label();
            this.Calcular = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.InputNome = new System.Windows.Forms.TextBox();
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.InputP1 = new System.Windows.Forms.TextBox();
            this.InputP2 = new System.Windows.Forms.TextBox();
            this.InputMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ra
            // 
            this.Ra.AutoSize = true;
            this.Ra.Location = new System.Drawing.Point(39, 67);
            this.Ra.Name = "Ra";
            this.Ra.Size = new System.Drawing.Size(21, 13);
            this.Ra.TabIndex = 0;
            this.Ra.Text = "Ra";
            // 
            // InputRa
            // 
            this.InputRa.Location = new System.Drawing.Point(80, 67);
            this.InputRa.Name = "InputRa";
            this.InputRa.Size = new System.Drawing.Size(277, 20);
            this.InputRa.TabIndex = 1;
            // 
            // Media
            // 
            this.Media.AutoSize = true;
            this.Media.Location = new System.Drawing.Point(55, 221);
            this.Media.Name = "Media";
            this.Media.Size = new System.Drawing.Size(36, 13);
            this.Media.TabIndex = 2;
            this.Media.Text = "Media";
            this.Media.Click += new System.EventHandler(this.Media_Click);
            // 
            // Calcular
            // 
            this.Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calcular.Location = new System.Drawing.Point(254, 123);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(88, 41);
            this.Calcular.TabIndex = 3;
            this.Calcular.TabStop = false;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(39, 26);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            // 
            // InputNome
            // 
            this.InputNome.Location = new System.Drawing.Point(80, 23);
            this.InputNome.Name = "InputNome";
            this.InputNome.Size = new System.Drawing.Size(277, 20);
            this.InputNome.TabIndex = 5;
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Location = new System.Drawing.Point(40, 121);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(20, 13);
            this.P1.TabIndex = 6;
            this.P1.Text = "P1";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Location = new System.Drawing.Point(40, 151);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(20, 13);
            this.P2.TabIndex = 7;
            this.P2.Text = "P2";
            // 
            // InputP1
            // 
            this.InputP1.Location = new System.Drawing.Point(80, 118);
            this.InputP1.Name = "InputP1";
            this.InputP1.Size = new System.Drawing.Size(100, 20);
            this.InputP1.TabIndex = 8;
            // 
            // InputP2
            // 
            this.InputP2.Location = new System.Drawing.Point(80, 144);
            this.InputP2.Name = "InputP2";
            this.InputP2.Size = new System.Drawing.Size(100, 20);
            this.InputP2.TabIndex = 9;
            // 
            // InputMedia
            // 
            this.InputMedia.Location = new System.Drawing.Point(159, 218);
            this.InputMedia.Name = "InputMedia";
            this.InputMedia.ReadOnly = true;
            this.InputMedia.Size = new System.Drawing.Size(100, 20);
            this.InputMedia.TabIndex = 10;
            // 
            // Formulariopoha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 283);
            this.Controls.Add(this.InputMedia);
            this.Controls.Add(this.InputP2);
            this.Controls.Add(this.InputP1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.InputNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Media);
            this.Controls.Add(this.InputRa);
            this.Controls.Add(this.Ra);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formulariopoha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formulariopoha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ra;
        private System.Windows.Forms.TextBox InputRa;
        private System.Windows.Forms.Label Media;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox InputNome;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.TextBox InputP1;
        private System.Windows.Forms.TextBox InputP2;
        private System.Windows.Forms.TextBox InputMedia;
    }
}

