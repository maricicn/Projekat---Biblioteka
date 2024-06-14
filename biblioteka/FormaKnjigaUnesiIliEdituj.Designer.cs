
namespace biblioteka
{
    partial class FormaKnjigaUnesiIliEdituj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaKnjigaUnesiIliEdituj));
            this.cbPisci = new System.Windows.Forms.ComboBox();
            this.btEditKnjiga = new System.Windows.Forms.Button();
            this.btDodajKnjigu = new System.Windows.Forms.Button();
            this.lblPronadjenaKnjiga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbPisci
            // 
            this.cbPisci.FormattingEnabled = true;
            this.cbPisci.Location = new System.Drawing.Point(347, 206);
            this.cbPisci.Margin = new System.Windows.Forms.Padding(2);
            this.cbPisci.Name = "cbPisci";
            this.cbPisci.Size = new System.Drawing.Size(173, 21);
            this.cbPisci.TabIndex = 5;
            this.cbPisci.SelectedIndexChanged += new System.EventHandler(this.cbPisci_SelectedIndexChanged);
            // 
            // btEditKnjiga
            // 
            this.btEditKnjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditKnjiga.ForeColor = System.Drawing.Color.IndianRed;
            this.btEditKnjiga.Image = ((System.Drawing.Image)(resources.GetObject("btEditKnjiga.Image")));
            this.btEditKnjiga.Location = new System.Drawing.Point(347, 141);
            this.btEditKnjiga.Margin = new System.Windows.Forms.Padding(2);
            this.btEditKnjiga.Name = "btEditKnjiga";
            this.btEditKnjiga.Size = new System.Drawing.Size(172, 59);
            this.btEditKnjiga.TabIndex = 4;
            this.btEditKnjiga.Text = "Edituj Knjigu";
            this.btEditKnjiga.UseVisualStyleBackColor = true;
            this.btEditKnjiga.Click += new System.EventHandler(this.btEditKnjiga_Click);
            // 
            // btDodajKnjigu
            // 
            this.btDodajKnjigu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDodajKnjigu.ForeColor = System.Drawing.Color.IndianRed;
            this.btDodajKnjigu.Image = ((System.Drawing.Image)(resources.GetObject("btDodajKnjigu.Image")));
            this.btDodajKnjigu.Location = new System.Drawing.Point(69, 141);
            this.btDodajKnjigu.Margin = new System.Windows.Forms.Padding(2);
            this.btDodajKnjigu.Name = "btDodajKnjigu";
            this.btDodajKnjigu.Size = new System.Drawing.Size(182, 59);
            this.btDodajKnjigu.TabIndex = 3;
            this.btDodajKnjigu.Text = "Dodaj Knjigu";
            this.btDodajKnjigu.UseVisualStyleBackColor = true;
            this.btDodajKnjigu.Click += new System.EventHandler(this.btDodajKnjigu_Click);
            // 
            // lblPronadjenaKnjiga
            // 
            this.lblPronadjenaKnjiga.AutoSize = true;
            this.lblPronadjenaKnjiga.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPronadjenaKnjiga.Image = ((System.Drawing.Image)(resources.GetObject("lblPronadjenaKnjiga.Image")));
            this.lblPronadjenaKnjiga.Location = new System.Drawing.Point(117, 95);
            this.lblPronadjenaKnjiga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPronadjenaKnjiga.Name = "lblPronadjenaKnjiga";
            this.lblPronadjenaKnjiga.Size = new System.Drawing.Size(36, 13);
            this.lblPronadjenaKnjiga.TabIndex = 9;
            this.lblPronadjenaKnjiga.Text = "Knjiga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(116, 69);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(135, 20);
            this.txtPretraga.TabIndex = 8;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPretraga.Image = ((System.Drawing.Image)(resources.GetObject("lblPretraga.Image")));
            this.lblPretraga.Location = new System.Drawing.Point(42, 69);
            this.lblPretraga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(70, 20);
            this.lblPretraga.TabIndex = 7;
            this.lblPretraga.Text = "Pretraga";
            // 
            // FormaKnjigaUnesiIliEdituj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::biblioteka.Properties.Resources.Untitled_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblPronadjenaKnjiga);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.cbPisci);
            this.Controls.Add(this.btEditKnjiga);
            this.Controls.Add(this.btDodajKnjigu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormaKnjigaUnesiIliEdituj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPisci;
        private System.Windows.Forms.Button btEditKnjiga;
        private System.Windows.Forms.Button btDodajKnjigu;
        private System.Windows.Forms.Label lblPronadjenaKnjiga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPretraga;
    }
}