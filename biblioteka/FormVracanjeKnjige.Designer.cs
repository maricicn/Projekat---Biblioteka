namespace biblioteka
{
    partial class FormVracanjeKnjige
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVracanjeKnjige));
            this.cBBibliotekar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dTVracanje = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cBKnjiga = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBCitalac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cBBibliotekar
            // 
            this.cBBibliotekar.FormattingEnabled = true;
            this.cBBibliotekar.Location = new System.Drawing.Point(584, 254);
            this.cBBibliotekar.Name = "cBBibliotekar";
            this.cBBibliotekar.Size = new System.Drawing.Size(192, 21);
            this.cBBibliotekar.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Image = global::biblioteka.Properties.Resources.images;
            this.label6.Location = new System.Drawing.Point(608, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bibliotekar:";
            // 
            // dTVracanje
            // 
            this.dTVracanje.Location = new System.Drawing.Point(337, 305);
            this.dTVracanje.Name = "dTVracanje";
            this.dTVracanje.Size = new System.Drawing.Size(200, 20);
            this.dTVracanje.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Image = global::biblioteka.Properties.Resources.images;
            this.label5.Location = new System.Drawing.Point(341, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Datum vraćanja:";
            // 
            // cBKnjiga
            // 
            this.cBKnjiga.FormattingEnabled = true;
            this.cBKnjiga.Location = new System.Drawing.Point(59, 305);
            this.cBKnjiga.Name = "cBKnjiga";
            this.cBKnjiga.Size = new System.Drawing.Size(192, 21);
            this.cBKnjiga.TabIndex = 15;
            this.cBKnjiga.SelectedIndexChanged += new System.EventHandler(this.cBKnjiga_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Image = global::biblioteka.Properties.Resources.images;
            this.label3.Location = new System.Drawing.Point(54, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Knjiga koja se vraća:";
            // 
            // cBCitalac
            // 
            this.cBCitalac.FormattingEnabled = true;
            this.cBCitalac.Location = new System.Drawing.Point(59, 185);
            this.cBCitalac.Name = "cBCitalac";
            this.cBCitalac.Size = new System.Drawing.Size(192, 21);
            this.cBCitalac.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Image = global::biblioteka.Properties.Resources.images;
            this.label2.Location = new System.Drawing.Point(54, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Čitalac koji vraća knjigu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Image = global::biblioteka.Properties.Resources.images;
            this.label1.Location = new System.Drawing.Point(263, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vraćanje knjige";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.BackgroundImage = global::biblioteka.Properties.Resources.images;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(644, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 67);
            this.button1.TabIndex = 22;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Image = global::biblioteka.Properties.Resources.images;
            this.label4.Location = new System.Drawing.Point(341, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rok za vracanje knjige:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // FormVracanjeKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::biblioteka.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBBibliotekar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dTVracanje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBKnjiga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBCitalac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVracanjeKnjige";
            this.Text = "FormVracanjeKnjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBBibliotekar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTVracanje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBKnjiga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBCitalac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}