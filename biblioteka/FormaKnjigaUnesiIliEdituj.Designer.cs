
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
            this.cbPisci = new System.Windows.Forms.ComboBox();
            this.btEditKnjiga = new System.Windows.Forms.Button();
            this.btDodajKnjigu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPisci
            // 
            this.cbPisci.FormattingEnabled = true;
            this.cbPisci.Location = new System.Drawing.Point(446, 253);
            this.cbPisci.Name = "cbPisci";
            this.cbPisci.Size = new System.Drawing.Size(229, 24);
            this.cbPisci.TabIndex = 5;
            this.cbPisci.Text = "Pisci";
            // 
            // btEditKnjiga
            // 
            this.btEditKnjiga.Location = new System.Drawing.Point(446, 174);
            this.btEditKnjiga.Name = "btEditKnjiga";
            this.btEditKnjiga.Size = new System.Drawing.Size(229, 73);
            this.btEditKnjiga.TabIndex = 4;
            this.btEditKnjiga.Text = "Edituj Knjigu";
            this.btEditKnjiga.UseVisualStyleBackColor = true;
            this.btEditKnjiga.Click += new System.EventHandler(this.btEditKnjiga_Click);
            // 
            // btDodajKnjigu
            // 
            this.btDodajKnjigu.Location = new System.Drawing.Point(126, 174);
            this.btDodajKnjigu.Name = "btDodajKnjigu";
            this.btDodajKnjigu.Size = new System.Drawing.Size(229, 73);
            this.btDodajKnjigu.TabIndex = 3;
            this.btDodajKnjigu.Text = "Dodaj Knjigu";
            this.btDodajKnjigu.UseVisualStyleBackColor = true;
            this.btDodajKnjigu.Click += new System.EventHandler(this.btDodajKnjigu_Click);
            // 
            // FormaKnjigaUnesiIliEdituj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPisci);
            this.Controls.Add(this.btEditKnjiga);
            this.Controls.Add(this.btDodajKnjigu);
            this.Name = "FormaKnjigaUnesiIliEdituj";
            this.Text = "FormaKnjigaUnesiIliEdituj";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPisci;
        private System.Windows.Forms.Button btEditKnjiga;
        private System.Windows.Forms.Button btDodajKnjigu;
    }
}