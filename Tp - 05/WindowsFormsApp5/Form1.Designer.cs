namespace WindowsFormsApp5
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
            this.Convert = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fahrenheit = new System.Windows.Forms.TextBox();
            this.Celsius = new System.Windows.Forms.TextBox();
            this.CtoF = new System.Windows.Forms.RadioButton();
            this.FtoC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(24, 287);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(197, 64);
            this.Convert.TabIndex = 0;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(120, 251);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(13, 13);
            this.Result.TabIndex = 1;
            this.Result.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Celsius";
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.Location = new System.Drawing.Point(121, 61);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(100, 20);
            this.Fahrenheit.TabIndex = 3;
            // 
            // Celsius
            // 
            this.Celsius.Location = new System.Drawing.Point(121, 116);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(100, 20);
            this.Celsius.TabIndex = 4;
            // 
            // CtoF
            // 
            this.CtoF.AutoSize = true;
            this.CtoF.Checked = true;
            this.CtoF.Location = new System.Drawing.Point(13, 183);
            this.CtoF.Name = "CtoF";
            this.CtoF.Size = new System.Drawing.Size(102, 17);
            this.CtoF.TabIndex = 6;
            this.CtoF.TabStop = true;
            this.CtoF.Text = "conveter celsius";
            this.CtoF.UseVisualStyleBackColor = true;
            // 
            // FtoC
            // 
            this.FtoC.AutoSize = true;
            this.FtoC.Location = new System.Drawing.Point(121, 183);
            this.FtoC.Name = "FtoC";
            this.FtoC.Size = new System.Drawing.Size(118, 17);
            this.FtoC.TabIndex = 7;
            this.FtoC.Text = "Converter Farenheit";
            this.FtoC.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FtoC);
            this.Controls.Add(this.CtoF);
            this.Controls.Add(this.Celsius);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fahrenheit;
        private System.Windows.Forms.TextBox Celsius;
        private System.Windows.Forms.RadioButton CtoF;
        private System.Windows.Forms.RadioButton FtoC;
        private System.Windows.Forms.Label label1;
    }
}

