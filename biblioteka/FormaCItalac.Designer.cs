namespace biblioteka
{
    partial class FormaCItalac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaCItalac));
            this.lblPronadjenCitalac = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.cbCitaoci = new System.Windows.Forms.ComboBox();
            this.btEditCitaoca = new System.Windows.Forms.Button();
            this.btDodajCitaoca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPronadjenCitalac
            // 
            this.lblPronadjenCitalac.AutoSize = true;
            this.lblPronadjenCitalac.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPronadjenCitalac.Image = global::biblioteka.Properties.Resources.images;
            this.lblPronadjenCitalac.Location = new System.Drawing.Point(104, 148);
            this.lblPronadjenCitalac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPronadjenCitalac.Name = "lblPronadjenCitalac";
            this.lblPronadjenCitalac.Size = new System.Drawing.Size(56, 13);
            this.lblPronadjenCitalac.TabIndex = 15;
            this.lblPronadjenCitalac.Text = "Bibliotekar";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(105, 123);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(135, 20);
            this.txtPretraga.TabIndex = 14;
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPretraga.Image = global::biblioteka.Properties.Resources.images;
            this.lblPretraga.Location = new System.Drawing.Point(30, 123);
            this.lblPretraga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(70, 20);
            this.lblPretraga.TabIndex = 13;
            this.lblPretraga.Text = "Pretraga";
            // 
            // cbCitaoci
            // 
            this.cbCitaoci.FormattingEnabled = true;
            this.cbCitaoci.Location = new System.Drawing.Point(550, 307);
            this.cbCitaoci.Margin = new System.Windows.Forms.Padding(2);
            this.cbCitaoci.Name = "cbCitaoci";
            this.cbCitaoci.Size = new System.Drawing.Size(223, 21);
            this.cbCitaoci.TabIndex = 12;
            // 
            // btEditCitaoca
            // 
            this.btEditCitaoca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btEditCitaoca.BackgroundImage")));
            this.btEditCitaoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditCitaoca.ForeColor = System.Drawing.Color.IndianRed;
            this.btEditCitaoca.Location = new System.Drawing.Point(550, 189);
            this.btEditCitaoca.Name = "btEditCitaoca";
            this.btEditCitaoca.Size = new System.Drawing.Size(222, 96);
            this.btEditCitaoca.TabIndex = 11;
            this.btEditCitaoca.Text = "Edituj Citaoca";
            this.btEditCitaoca.UseVisualStyleBackColor = true;
            this.btEditCitaoca.Click += new System.EventHandler(this.btEditCitaoca_Click);
            // 
            // btDodajCitaoca
            // 
            this.btDodajCitaoca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDodajCitaoca.BackgroundImage")));
            this.btDodajCitaoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDodajCitaoca.ForeColor = System.Drawing.Color.IndianRed;
            this.btDodajCitaoca.Location = new System.Drawing.Point(27, 189);
            this.btDodajCitaoca.Name = "btDodajCitaoca";
            this.btDodajCitaoca.Size = new System.Drawing.Size(222, 96);
            this.btDodajCitaoca.TabIndex = 10;
            this.btDodajCitaoca.Text = "Dodaj Citaoca";
            this.btDodajCitaoca.UseVisualStyleBackColor = true;
            this.btDodajCitaoca.Click += new System.EventHandler(this.btDodajCitaoca_Click);
            // 
            // FormaCItalac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPronadjenCitalac);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.cbCitaoci);
            this.Controls.Add(this.btEditCitaoca);
            this.Controls.Add(this.btDodajCitaoca);
            this.Name = "FormaCItalac";
            this.Text = "FormaCItalac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPronadjenCitalac;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.ComboBox cbCitaoci;
        private System.Windows.Forms.Button btEditCitaoca;
        private System.Windows.Forms.Button btDodajCitaoca;
    }
}