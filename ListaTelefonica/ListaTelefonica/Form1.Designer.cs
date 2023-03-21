namespace ListaTelefonica
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.Phone = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.InputPhone = new System.Windows.Forms.TextBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.Include = new System.Windows.Forms.Button();
            this.ListPhone = new System.Windows.Forms.ListView();
            this.Remove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(125, 63);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 13);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "Phone:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(125, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Name:";
            // 
            // InputPhone
            // 
            this.InputPhone.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InputPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputPhone.Location = new System.Drawing.Point(172, 63);
            this.InputPhone.Multiline = true;
            this.InputPhone.Name = "InputPhone";
            this.InputPhone.Size = new System.Drawing.Size(234, 20);
            this.InputPhone.TabIndex = 6;
            this.InputPhone.TextChanged += new System.EventHandler(this.InputPhone_TextChanged);
            // 
            // InputName
            // 
            this.InputName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputName.Location = new System.Drawing.Point(174, 19);
            this.InputName.Multiline = true;
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(232, 20);
            this.InputName.TabIndex = 7;
            // 
            // Include
            // 
            this.Include.Location = new System.Drawing.Point(195, 119);
            this.Include.Name = "Include";
            this.Include.Size = new System.Drawing.Size(75, 23);
            this.Include.TabIndex = 8;
            this.Include.Text = "Include:";
            this.Include.UseVisualStyleBackColor = true;
            this.Include.Click += new System.EventHandler(this.Include_Click);
            // 
            // ListPhone
            // 
            this.ListPhone.HideSelection = false;
            this.ListPhone.Location = new System.Drawing.Point(12, 176);
            this.ListPhone.Name = "ListPhone";
            this.ListPhone.Size = new System.Drawing.Size(445, 242);
            this.ListPhone.TabIndex = 9;
            this.ListPhone.UseCompatibleStateImageBehavior = false;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(331, 119);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(477, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.ListPhone);
            this.Controls.Add(this.Include);
            this.Controls.Add(this.InputName);
            this.Controls.Add(this.InputPhone);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.Phone);
            this.Name = "Test";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox InputPhone;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Button Include;
        private System.Windows.Forms.ListView ListPhone;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

