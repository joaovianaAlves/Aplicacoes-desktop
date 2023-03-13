namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTarefa = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnrREMOVE = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.LISTA = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(188, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarefa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data:";
            // 
            // textTarefa
            // 
            this.textTarefa.Location = new System.Drawing.Point(68, 81);
            this.textTarefa.Name = "textTarefa";
            this.textTarefa.Size = new System.Drawing.Size(200, 20);
            this.textTarefa.TabIndex = 3;
            this.textTarefa.Text = "asd";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Lime;
            this.btnADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADD.Location = new System.Drawing.Point(294, 41);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(92, 41);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "Add";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnrREMOVE
            // 
            this.btnrREMOVE.BackColor = System.Drawing.Color.Red;
            this.btnrREMOVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrREMOVE.Location = new System.Drawing.Point(294, 265);
            this.btnrREMOVE.Name = "btnrREMOVE";
            this.btnrREMOVE.Size = new System.Drawing.Size(92, 46);
            this.btnrREMOVE.TabIndex = 5;
            this.btnrREMOVE.Text = "Remove";
            this.btnrREMOVE.UseVisualStyleBackColor = false;
            this.btnrREMOVE.Click += new System.EventHandler(this.btnrREMOVE_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(68, 41);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 7;
            this.toolTip1.SetToolTip(this.date, "Selecione Uma data");
            // 
            // LISTA
            // 
            this.LISTA.FormattingEnabled = true;
            this.LISTA.Location = new System.Drawing.Point(24, 116);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(345, 134);
            this.LISTA.TabIndex = 6;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 323);
            this.Controls.Add(this.date);
            this.Controls.Add(this.LISTA);
            this.Controls.Add(this.btnrREMOVE);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.textTarefa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTarefa;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnrREMOVE;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ListBox LISTA;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

