namespace DemoCrud2
{
    partial class FrmDetalhe
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
            this.components = new System.ComponentModel.Container();
            this.bsDetalhe = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeDetalhe = new System.Windows.Forms.TextBox();
            this.txtEnderecoDetalhe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalhe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeDetalhe
            // 
            this.txtNomeDetalhe.Location = new System.Drawing.Point(38, 84);
            this.txtNomeDetalhe.Name = "txtNomeDetalhe";
            this.txtNomeDetalhe.Size = new System.Drawing.Size(306, 23);
            this.txtNomeDetalhe.TabIndex = 1;
            // 
            // txtEnderecoDetalhe
            // 
            this.txtEnderecoDetalhe.Location = new System.Drawing.Point(38, 161);
            this.txtEnderecoDetalhe.Name = "txtEnderecoDetalhe";
            this.txtEnderecoDetalhe.Size = new System.Drawing.Size(306, 23);
            this.txtEnderecoDetalhe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 23);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(337, 282);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 58);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelado
            // 
            this.btnCancelado.Location = new System.Drawing.Point(474, 282);
            this.btnCancelado.Name = "btnCancelado";
            this.btnCancelado.Size = new System.Drawing.Size(104, 58);
            this.btnCancelado.TabIndex = 7;
            this.btnCancelado.Text = "CANCELADO";
            this.btnCancelado.UseVisualStyleBackColor = true;
            this.btnCancelado.Click += new System.EventHandler(this.btnCancelado_Click);
            // 
            // FrmDetalhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 393);
            this.Controls.Add(this.btnCancelado);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnderecoDetalhe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeDetalhe);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDetalhe";
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bsDetalhe;
        private Label label1;
        private TextBox txtNomeDetalhe;
        private TextBox txtEnderecoDetalhe;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button btnOK;
        private Button btnCancelado;
    }
}