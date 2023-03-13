namespace Tp___130323
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cpf = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.dTrabalhados = new System.Windows.Forms.Label();
            this.vDiaria = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.inputDtrab = new System.Windows.Forms.TextBox();
            this.inputVdia = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.Button();
            this.sBase = new System.Windows.Forms.Label();
            this.outputSbase = new System.Windows.Forms.TextBox();
            this.SLiquido = new System.Windows.Forms.Label();
            this.outputSliquido = new System.Windows.Forms.TextBox();
            this.IR = new System.Windows.Forms.Label();
            this.outputIR = new System.Windows.Forms.TextBox();
            this.inputCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Cpf
            // 
            this.Cpf.AutoSize = true;
            this.Cpf.Font = new System.Drawing.Font("Swis721 Blk BT", 8F);
            this.Cpf.Location = new System.Drawing.Point(12, 13);
            this.Cpf.Name = "Cpf";
            this.Cpf.Size = new System.Drawing.Size(31, 14);
            this.Cpf.TabIndex = 0;
            this.Cpf.Text = "Cpf:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Swis721 Blk BT", 8F);
            this.Nome.Location = new System.Drawing.Point(174, 13);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(45, 14);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome:";
            // 
            // dTrabalhados
            // 
            this.dTrabalhados.AutoSize = true;
            this.dTrabalhados.Font = new System.Drawing.Font("Swis721 Blk BT", 8F);
            this.dTrabalhados.Location = new System.Drawing.Point(13, 67);
            this.dTrabalhados.Name = "dTrabalhados";
            this.dTrabalhados.Size = new System.Drawing.Size(119, 14);
            this.dTrabalhados.TabIndex = 2;
            this.dTrabalhados.Text = "Dias Trabalhados:";
            // 
            // vDiaria
            // 
            this.vDiaria.AutoSize = true;
            this.vDiaria.Font = new System.Drawing.Font("Swis721 Blk BT", 8F);
            this.vDiaria.Location = new System.Drawing.Point(174, 67);
            this.vDiaria.Name = "vDiaria";
            this.vDiaria.Size = new System.Drawing.Size(102, 14);
            this.vDiaria.TabIndex = 3;
            this.vDiaria.Text = "Valor da diaria:";
            // 
            // inputNome
            // 
            this.inputNome.BackColor = System.Drawing.Color.Silver;
            this.inputNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputNome.Location = new System.Drawing.Point(177, 30);
            this.inputNome.Multiline = true;
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(116, 20);
            this.inputNome.TabIndex = 5;
            this.inputNome.TextChanged += new System.EventHandler(this.inputNome_TextChanged);
            // 
            // inputDtrab
            // 
            this.inputDtrab.BackColor = System.Drawing.Color.Silver;
            this.inputDtrab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDtrab.Location = new System.Drawing.Point(16, 84);
            this.inputDtrab.Multiline = true;
            this.inputDtrab.Name = "inputDtrab";
            this.inputDtrab.Size = new System.Drawing.Size(116, 20);
            this.inputDtrab.TabIndex = 6;
            // 
            // inputVdia
            // 
            this.inputVdia.BackColor = System.Drawing.Color.Silver;
            this.inputVdia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputVdia.Location = new System.Drawing.Point(177, 84);
            this.inputVdia.Multiline = true;
            this.inputVdia.Name = "inputVdia";
            this.inputVdia.Size = new System.Drawing.Size(116, 20);
            this.inputVdia.TabIndex = 7;
            // 
            // Calc
            // 
            this.Calc.BackColor = System.Drawing.Color.Silver;
            this.Calc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calc.BackgroundImage")));
            this.Calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc.Font = new System.Drawing.Font("Swis721 Blk BT", 8F);
            this.Calc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Calc.Location = new System.Drawing.Point(177, 214);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(116, 93);
            this.Calc.TabIndex = 8;
            this.Calc.Text = "Calcular";
            this.Calc.UseVisualStyleBackColor = false;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // sBase
            // 
            this.sBase.AutoSize = true;
            this.sBase.Font = new System.Drawing.Font("Swis721 Blk BT", 8F);
            this.sBase.Location = new System.Drawing.Point(13, 293);
            this.sBase.Name = "sBase";
            this.sBase.Size = new System.Drawing.Size(89, 14);
            this.sBase.TabIndex = 9;
            this.sBase.Text = "Salario Base:";
            this.sBase.Click += new System.EventHandler(this.sBase_Click);
            // 
            // outputSbase
            // 
            this.outputSbase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputSbase.Location = new System.Drawing.Point(16, 310);
            this.outputSbase.Multiline = true;
            this.outputSbase.Name = "outputSbase";
            this.outputSbase.ReadOnly = true;
            this.outputSbase.Size = new System.Drawing.Size(116, 20);
            this.outputSbase.TabIndex = 10;
            // 
            // SLiquido
            // 
            this.SLiquido.AutoSize = true;
            this.SLiquido.Font = new System.Drawing.Font("Swis721 Blk BT", 8F);
            this.SLiquido.Location = new System.Drawing.Point(13, 236);
            this.SLiquido.Name = "SLiquido";
            this.SLiquido.Size = new System.Drawing.Size(103, 14);
            this.SLiquido.TabIndex = 11;
            this.SLiquido.Text = "Salario Liquido:";
            // 
            // outputSliquido
            // 
            this.outputSliquido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputSliquido.Location = new System.Drawing.Point(16, 253);
            this.outputSliquido.Multiline = true;
            this.outputSliquido.Name = "outputSliquido";
            this.outputSliquido.ReadOnly = true;
            this.outputSliquido.Size = new System.Drawing.Size(116, 20);
            this.outputSliquido.TabIndex = 12;
            // 
            // IR
            // 
            this.IR.AutoSize = true;
            this.IR.Font = new System.Drawing.Font("Swis721 Blk BT", 8F);
            this.IR.Location = new System.Drawing.Point(13, 177);
            this.IR.Name = "IR";
            this.IR.Size = new System.Drawing.Size(119, 14);
            this.IR.TabIndex = 13;
            this.IR.Text = "Imposto de Renda:";
            this.IR.Click += new System.EventHandler(this.IR_Click);
            // 
            // outputIR
            // 
            this.outputIR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputIR.Location = new System.Drawing.Point(16, 194);
            this.outputIR.Multiline = true;
            this.outputIR.Name = "outputIR";
            this.outputIR.ReadOnly = true;
            this.outputIR.Size = new System.Drawing.Size(116, 20);
            this.outputIR.TabIndex = 14;
            // 
            // inputCpf
            // 
            this.inputCpf.BackColor = System.Drawing.Color.Silver;
            this.inputCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputCpf.ForeColor = System.Drawing.Color.Black;
            this.inputCpf.Location = new System.Drawing.Point(19, 30);
            this.inputCpf.Mask = "000.000.000-00";
            this.inputCpf.Name = "inputCpf";
            this.inputCpf.Size = new System.Drawing.Size(113, 13);
            this.inputCpf.TabIndex = 15;
            this.inputCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.inputCpf_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(331, 349);
            this.Controls.Add(this.inputCpf);
            this.Controls.Add(this.outputIR);
            this.Controls.Add(this.IR);
            this.Controls.Add(this.outputSliquido);
            this.Controls.Add(this.SLiquido);
            this.Controls.Add(this.outputSbase);
            this.Controls.Add(this.sBase);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.inputVdia);
            this.Controls.Add(this.inputDtrab);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.vDiaria);
            this.Controls.Add(this.dTrabalhados);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Cpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cpf;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label dTrabalhados;
        private System.Windows.Forms.Label vDiaria;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.TextBox inputDtrab;
        private System.Windows.Forms.TextBox inputVdia;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Label sBase;
        private System.Windows.Forms.TextBox outputSbase;
        private System.Windows.Forms.Label SLiquido;
        private System.Windows.Forms.TextBox outputSliquido;
        private System.Windows.Forms.Label IR;
        private System.Windows.Forms.TextBox outputIR;
        private System.Windows.Forms.MaskedTextBox inputCpf;
    }
}

