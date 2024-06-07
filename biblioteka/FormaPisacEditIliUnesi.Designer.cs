
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
            this.btDodajPisca = new System.Windows.Forms.Button();
            this.btEditPisca = new System.Windows.Forms.Button();
            this.cbPisci = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btDodajPisca
            // 
            this.btDodajPisca.Location = new System.Drawing.Point(128, 154);
            this.btDodajPisca.Name = "btDodajPisca";
            this.btDodajPisca.Size = new System.Drawing.Size(229, 73);
            this.btDodajPisca.TabIndex = 0;
            this.btDodajPisca.Text = "Dodaj Pisca";
            this.btDodajPisca.UseVisualStyleBackColor = true;
            this.btDodajPisca.Click += new System.EventHandler(this.btDodajPisca_Click);
            // 
            // btEditPisca
            // 
            this.btEditPisca.Location = new System.Drawing.Point(448, 154);
            this.btEditPisca.Name = "btEditPisca";
            this.btEditPisca.Size = new System.Drawing.Size(229, 73);
            this.btEditPisca.TabIndex = 1;
            this.btEditPisca.Text = "Edituj Pisca";
            this.btEditPisca.UseVisualStyleBackColor = true;
            this.btEditPisca.Click += new System.EventHandler(this.btEditPisca_Click);
            // 
            // cbPisci
            // 
            this.cbPisci.FormattingEnabled = true;
            this.cbPisci.Location = new System.Drawing.Point(448, 233);
            this.cbPisci.Name = "cbPisci";
            this.cbPisci.Size = new System.Drawing.Size(229, 24);
            this.cbPisci.TabIndex = 2;
            this.cbPisci.Text = "Pisci";
            this.cbPisci.SelectedIndexChanged += new System.EventHandler(this.cbPisci_SelectedIndexChanged);
            // 
            // FormaPisacEditIliUnesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbPisci);
            this.Controls.Add(this.btEditPisca);
            this.Controls.Add(this.btDodajPisca);
            this.Name = "FormaPisacEditIliUnesi";
            this.Text = "FormaPisacEditIliUnesi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDodajPisca;
        private System.Windows.Forms.Button btEditPisca;
        private System.Windows.Forms.ComboBox cbPisci;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}