namespace Tp_aula_04
{
    partial class Form1
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
            this.Cpf = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.valorHora = new System.Windows.Forms.Label();
            this.horasTrabalhadas = new System.Windows.Forms.Label();
            this.inputSalario = new System.Windows.Forms.TextBox();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.inputVh = new System.Windows.Forms.TextBox();
            this.inputHT = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.inputCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Cpf
            // 
            this.Cpf.AutoSize = true;
            this.Cpf.Location = new System.Drawing.Point(41, 42);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(23, 13);
            this.Cpf.TabIndex = 0;
            this.Cpf.Text = "Cpf";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(41, 72);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(35, 13);
            this.nome.TabIndex = 2;
            this.nome.Text = "Nome";
            // 
            // valorHora
            // 
            this.valorHora.AutoSize = true;
            this.valorHora.Location = new System.Drawing.Point(41, 104);
            this.valorHora.Name = "valorHora";
            this.valorHora.Size = new System.Drawing.Size(57, 13);
            this.valorHora.TabIndex = 3;
            this.valorHora.Text = "Valor Hora";
            // 
            // horasTrabalhadas
            // 
            this.horasTrabalhadas.AutoSize = true;
            this.horasTrabalhadas.Location = new System.Drawing.Point(41, 138);
            this.horasTrabalhadas.Name = "horasTrabalhadas";
            this.horasTrabalhadas.Size = new System.Drawing.Size(97, 13);
            this.horasTrabalhadas.TabIndex = 4;
            this.horasTrabalhadas.Text = "Horas Trabalhadas";
            // 
            // inputSalario
            // 
            this.inputSalario.Location = new System.Drawing.Point(93, 176);
            this.inputSalario.Name = "inputSalario";
            this.inputSalario.ReadOnly = true;
            this.inputSalario.Size = new System.Drawing.Size(100, 20);
            this.inputSalario.TabIndex = 5;
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(93, 69);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(167, 20);
            this.inputNome.TabIndex = 6;
            // 
            // inputVh
            // 
            this.inputVh.Location = new System.Drawing.Point(104, 101);
            this.inputVh.Name = "inputVh";
            this.inputVh.Size = new System.Drawing.Size(156, 20);
            this.inputVh.TabIndex = 7;
            // 
            // inputHT
            // 
            this.inputHT.Location = new System.Drawing.Point(144, 135);
            this.inputHT.Name = "inputHT";
            this.inputHT.Size = new System.Drawing.Size(116, 20);
            this.inputHT.TabIndex = 8;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(76, 216);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(117, 58);
            this.calcular.TabIndex = 9;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // inputCpf
            // 
            this.inputCpf.Location = new System.Drawing.Point(93, 39);
            this.inputCpf.Mask = "000.000.000-00";
            this.inputCpf.Name = "inputCpf";
            this.inputCpf.Size = new System.Drawing.Size(167, 20);
            this.inputCpf.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 365);
            this.Controls.Add(this.inputCpf);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.inputHT);
            this.Controls.Add(this.inputVh);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.inputSalario);
            this.Controls.Add(this.horasTrabalhadas);
            this.Controls.Add(this.valorHora);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.Cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cpf;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label valorHora;
        private System.Windows.Forms.Label horasTrabalhadas;
        private System.Windows.Forms.TextBox inputSalario;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.TextBox inputVh;
        private System.Windows.Forms.TextBox inputHT;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.MaskedTextBox inputCpf;
    }
}

