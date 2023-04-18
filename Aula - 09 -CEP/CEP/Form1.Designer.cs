namespace CEP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCEP = new System.Windows.Forms.Label();
            this.InputCep = new System.Windows.Forms.TextBox();
            this.OutputCidade = new System.Windows.Forms.TextBox();
            this.OutPutEndereço = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDigitar = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lbluf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OutPutBairro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCEP
            // 
            this.lblCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCEP.ForeColor = System.Drawing.Color.MintCream;
            this.lblCEP.Location = new System.Drawing.Point(273, 31);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(51, 25);
            this.lblCEP.TabIndex = 1;
            this.lblCEP.Text = "CEP";
            this.lblCEP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCEP.Click += new System.EventHandler(this.lblCEP_Click);
            // 
            // InputCep
            // 
            this.InputCep.Location = new System.Drawing.Point(357, 113);
            this.InputCep.Name = "InputCep";
            this.InputCep.Size = new System.Drawing.Size(100, 27);
            this.InputCep.TabIndex = 2;
            // 
            // OutputCidade
            // 
            this.OutputCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputCidade.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputCidade.ForeColor = System.Drawing.Color.MintCream;
            this.OutputCidade.Location = new System.Drawing.Point(366, 177);
            this.OutputCidade.Name = "OutputCidade";
            this.OutputCidade.ReadOnly = true;
            this.OutputCidade.Size = new System.Drawing.Size(333, 27);
            this.OutputCidade.TabIndex = 3;
            // 
            // OutPutEndereço
            // 
            this.OutPutEndereço.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutPutEndereço.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutPutEndereço.ForeColor = System.Drawing.Color.MintCream;
            this.OutPutEndereço.Location = new System.Drawing.Point(366, 210);
            this.OutPutEndereço.Name = "OutPutEndereço";
            this.OutPutEndereço.ReadOnly = true;
            this.OutPutEndereço.Size = new System.Drawing.Size(333, 27);
            this.OutPutEndereço.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 6;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.ForeColor = System.Drawing.Color.MintCream;
            this.btnConsulta.Location = new System.Drawing.Point(0, 80);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(200, 60);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.lblCEP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 80);
            this.panel2.TabIndex = 9;
            // 
            // lblDigitar
            // 
            this.lblDigitar.AutoSize = true;
            this.lblDigitar.Location = new System.Drawing.Point(228, 113);
            this.lblDigitar.Name = "lblDigitar";
            this.lblDigitar.Size = new System.Drawing.Size(112, 21);
            this.lblDigitar.TabIndex = 10;
            this.lblDigitar.Text = "Digite o Cep:";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(228, 213);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(132, 21);
            this.lblLocalidade.TabIndex = 11;
            this.lblLocalidade.Text = "Localidade / Uf:";
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(248, 219);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(0, 21);
            this.lbluf.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Logadouro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bairro:";
            // 
            // OutPutBairro
            // 
            this.OutPutBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutPutBairro.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutPutBairro.ForeColor = System.Drawing.Color.MintCream;
            this.OutPutBairro.Location = new System.Drawing.Point(366, 243);
            this.OutPutBairro.Name = "OutPutBairro";
            this.OutPutBairro.ReadOnly = true;
            this.OutPutBairro.Size = new System.Drawing.Size(333, 27);
            this.OutPutBairro.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutPutBairro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbluf);
            this.Controls.Add(this.lblLocalidade);
            this.Controls.Add(this.lblDigitar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.InputCep);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OutPutEndereço);
            this.Controls.Add(this.OutputCidade);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblCEP;
        private TextBox InputCep;
        private TextBox OutputCidade;
        private TextBox OutPutEndereço;
        private Panel panel1;
        private Panel panelLogo;
        private Button btnConsulta;
        private Panel panel2;
        private Label lblDigitar;
        private Label lblLocalidade;
        private Label lbluf;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox OutPutBairro;
    }
}