
namespace biblioteka
{
    partial class FormaPisacEditIliUnesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPisacEditIliUnesi));
            this.btDodajPisca = new System.Windows.Forms.Button();
            this.btEditPisca = new System.Windows.Forms.Button();
            this.cbPisci = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.lblPronadjenPisac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btDodajPisca
            // 
            this.btDodajPisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDodajPisca.ForeColor = System.Drawing.Color.IndianRed;
            this.btDodajPisca.Image = global::biblioteka.Properties.Resources.images;
            this.btDodajPisca.Location = new System.Drawing.Point(121, 178);
            this.btDodajPisca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDodajPisca.Name = "btDodajPisca";
            this.btDodajPisca.Size = new System.Drawing.Size(229, 73);
            this.btDodajPisca.TabIndex = 0;
            this.btDodajPisca.Text = "Dodaj Pisca";
            this.btDodajPisca.UseVisualStyleBackColor = true;
            this.btDodajPisca.Click += new System.EventHandler(this.btDodajPisca_Click);
            // 
            // btEditPisca
            // 
            this.btEditPisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditPisca.ForeColor = System.Drawing.Color.IndianRed;
            this.btEditPisca.Image = global::biblioteka.Properties.Resources.images;
            this.btEditPisca.Location = new System.Drawing.Point(464, 178);
            this.btEditPisca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEditPisca.Name = "btEditPisca";
            this.btEditPisca.Size = new System.Drawing.Size(239, 73);
            this.btEditPisca.TabIndex = 1;
            this.btEditPisca.Text = "Izmeni Pisca";
            this.btEditPisca.UseVisualStyleBackColor = true;
            this.btEditPisca.Click += new System.EventHandler(this.btEditPisca_Click);
            // 
            // cbPisci
            // 
            this.cbPisci.FormattingEnabled = true;
            this.cbPisci.Location = new System.Drawing.Point(464, 257);
            this.cbPisci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPisci.Name = "cbPisci";
            this.cbPisci.Size = new System.Drawing.Size(237, 24);
            this.cbPisci.TabIndex = 2;
            this.cbPisci.SelectedIndexChanged += new System.EventHandler(this.cbPisci_SelectedIndexChanged);
            // 
            // lblPretraga
            // 
            this.lblPretraga.AutoSize = true;
            this.lblPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPretraga.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPretraga.Image = global::biblioteka.Properties.Resources.images;
            this.lblPretraga.Location = new System.Drawing.Point(116, 49);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(86, 25);
            this.lblPretraga.TabIndex = 4;
            this.lblPretraga.Text = "Pretraga";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(216, 49);
            this.txtPretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(179, 22);
            this.txtPretraga.TabIndex = 5;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // lblPronadjenPisac
            // 
            this.lblPronadjenPisac.AutoSize = true;
            this.lblPronadjenPisac.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPronadjenPisac.Image = global::biblioteka.Properties.Resources.images;
            this.lblPronadjenPisac.Location = new System.Drawing.Point(212, 86);
            this.lblPronadjenPisac.Name = "lblPronadjenPisac";
            this.lblPronadjenPisac.Size = new System.Drawing.Size(42, 17);
            this.lblPronadjenPisac.TabIndex = 6;
            this.lblPronadjenPisac.Text = "Pisac";
            this.lblPronadjenPisac.Click += new System.EventHandler(this.lblPronadjenPisac_Click);
            // 
            // FormaPisacEditIliUnesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::biblioteka.Properties.Resources.sofia_ritter_chatting_4k;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPronadjenPisac);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.lblPretraga);
            this.Controls.Add(this.cbPisci);
            this.Controls.Add(this.btEditPisca);
            this.Controls.Add(this.btDodajPisca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormaPisacEditIliUnesi";
            this.Text = "FormaPisacEditIliUnesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDodajPisca;
        private System.Windows.Forms.Button btEditPisca;
        private System.Windows.Forms.ComboBox cbPisci;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label lblPronadjenPisac;
    }
}