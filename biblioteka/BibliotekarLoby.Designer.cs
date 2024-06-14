namespace biblioteka
{
    partial class BibliotekarLoby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BibliotekarLoby));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbBibliotekari = new System.Windows.Forms.ComboBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPronadjenBibliotekar = new System.Windows.Forms.Label();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(28, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj bibliotekara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(551, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 96);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edituj bibliotekara";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbBibliotekari
            // 
            this.cbBibliotekari.FormattingEnabled = true;
            this.cbBibliotekari.Location = new System.Drawing.Point(551, 254);
            this.cbBibliotekari.Margin = new System.Windows.Forms.Padding(2);
            this.cbBibliotekari.Name = "cbBibliotekari";
            this.cbBibliotekari.Size = new System.Drawing.Size(223, 21);
            this.cbBibliotekari.TabIndex = 2;
            this.cbBibliotekari.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(106, 70);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(135, 20);
            this.txtPretraga.TabIndex = 8;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPronadjenBibliotekar
            // 
            this.lblPronadjenBibliotekar.AutoSize = true;
            this.lblPronadjenBibliotekar.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPronadjenBibliotekar.Image = global::biblioteka.Properties.Resources.images;
            this.lblPronadjenBibliotekar.Location = new System.Drawing.Point(105, 95);
            this.lblPronadjenBibliotekar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPronadjenBibliotekar.Name = "lblPronadjenBibliotekar";
            this.lblPronadjenBibliotekar.Size = new System.Drawing.Size(56, 13);
            this.lblPronadjenBibliotekar.TabIndex = 9;
            this.lblPronadjenBibliotekar.Text = "Bibliotekar";
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPretraga.Image = global::biblioteka.Properties.Resources.images;
            this.lblPretraga.Location = new System.Drawing.Point(31, 70);
            this.lblPretraga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(70, 20);
            this.lblPretraga.TabIndex = 7;
            this.lblPretraga.Text = "Pretraga";
            // 
            // BibliotekarLoby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::biblioteka.Properties.Resources.brankic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPronadjenBibliotekar);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.cbBibliotekari);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BibliotekarLoby";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.BibliotekarLoby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbBibliotekari;
        private System.Windows.Forms.Label lblPronadjenBibliotekar;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
    }
}