namespace biblioteka
{
    partial class FormPisac
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
            this.txtImePisca = new System.Windows.Forms.TextBox();
            this.txtPrezimePisca = new System.Windows.Forms.TextBox();
            this.txtGodinaRodjenjaPisca = new System.Windows.Forms.TextBox();
            this.cbStatusPisca = new System.Windows.Forms.ComboBox();
            this.lblStatusPisca = new System.Windows.Forms.Label();
            this.lblImePisca = new System.Windows.Forms.Label();
            this.lblPrezimePisca = new System.Windows.Forms.Label();
            this.lblGodinaRodjenjaPisca = new System.Windows.Forms.Label();
            this.lblPolPisca = new System.Windows.Forms.Label();
            this.cbPol = new System.Windows.Forms.ComboBox();
            this.lblNapomenePisca = new System.Windows.Forms.Label();
            this.txtNapomenePisca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btDodajPisca
            // 
            this.btDodajPisca.Location = new System.Drawing.Point(469, 125);
            this.btDodajPisca.Name = "btDodajPisca";
            this.btDodajPisca.Size = new System.Drawing.Size(75, 23);
            this.btDodajPisca.TabIndex = 0;
            this.btDodajPisca.Text = "Dodaj";
            this.btDodajPisca.UseVisualStyleBackColor = true;
            this.btDodajPisca.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImePisca
            // 
            this.txtImePisca.Location = new System.Drawing.Point(222, 92);
            this.txtImePisca.Name = "txtImePisca";
            this.txtImePisca.Size = new System.Drawing.Size(100, 22);
            this.txtImePisca.TabIndex = 2;
            // 
            // txtPrezimePisca
            // 
            this.txtPrezimePisca.Location = new System.Drawing.Point(222, 120);
            this.txtPrezimePisca.Name = "txtPrezimePisca";
            this.txtPrezimePisca.Size = new System.Drawing.Size(100, 22);
            this.txtPrezimePisca.TabIndex = 3;
            // 
            // txtGodinaRodjenjaPisca
            // 
            this.txtGodinaRodjenjaPisca.Location = new System.Drawing.Point(222, 178);
            this.txtGodinaRodjenjaPisca.Name = "txtGodinaRodjenjaPisca";
            this.txtGodinaRodjenjaPisca.Size = new System.Drawing.Size(100, 22);
            this.txtGodinaRodjenjaPisca.TabIndex = 4;
            // 
            // cbStatusPisca
            // 
            this.cbStatusPisca.FormattingEnabled = true;
            this.cbStatusPisca.Items.AddRange(new object[] {
            "Aktivan",
            "Neaktivan"});
            this.cbStatusPisca.Location = new System.Drawing.Point(222, 62);
            this.cbStatusPisca.Name = "cbStatusPisca";
            this.cbStatusPisca.Size = new System.Drawing.Size(121, 24);
            this.cbStatusPisca.TabIndex = 5;
            // 
            // lblStatusPisca
            // 
            this.lblStatusPisca.AutoSize = true;
            this.lblStatusPisca.Location = new System.Drawing.Point(129, 65);
            this.lblStatusPisca.Name = "lblStatusPisca";
            this.lblStatusPisca.Size = new System.Drawing.Size(48, 17);
            this.lblStatusPisca.TabIndex = 6;
            this.lblStatusPisca.Text = "Status";
            this.lblStatusPisca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblImePisca
            // 
            this.lblImePisca.AutoSize = true;
            this.lblImePisca.Location = new System.Drawing.Point(129, 97);
            this.lblImePisca.Name = "lblImePisca";
            this.lblImePisca.Size = new System.Drawing.Size(30, 17);
            this.lblImePisca.TabIndex = 7;
            this.lblImePisca.Text = "Ime";
            // 
            // lblPrezimePisca
            // 
            this.lblPrezimePisca.AutoSize = true;
            this.lblPrezimePisca.Location = new System.Drawing.Point(129, 125);
            this.lblPrezimePisca.Name = "lblPrezimePisca";
            this.lblPrezimePisca.Size = new System.Drawing.Size(59, 17);
            this.lblPrezimePisca.TabIndex = 8;
            this.lblPrezimePisca.Text = "Prezime";
            // 
            // lblGodinaRodjenjaPisca
            // 
            this.lblGodinaRodjenjaPisca.AutoSize = true;
            this.lblGodinaRodjenjaPisca.Location = new System.Drawing.Point(78, 181);
            this.lblGodinaRodjenjaPisca.Name = "lblGodinaRodjenjaPisca";
            this.lblGodinaRodjenjaPisca.Size = new System.Drawing.Size(110, 17);
            this.lblGodinaRodjenjaPisca.TabIndex = 9;
            this.lblGodinaRodjenjaPisca.Text = "GodinaRodjenja";
            // 
            // lblPolPisca
            // 
            this.lblPolPisca.AutoSize = true;
            this.lblPolPisca.Location = new System.Drawing.Point(129, 151);
            this.lblPolPisca.Name = "lblPolPisca";
            this.lblPolPisca.Size = new System.Drawing.Size(28, 17);
            this.lblPolPisca.TabIndex = 10;
            this.lblPolPisca.Text = "Pol";
            this.lblPolPisca.Click += new System.EventHandler(this.lblPol_Click);
            // 
            // cbPol
            // 
            this.cbPol.FormattingEnabled = true;
            this.cbPol.Items.AddRange(new object[] {
            "Muski",
            "Zenski"});
            this.cbPol.Location = new System.Drawing.Point(222, 148);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(121, 24);
            this.cbPol.TabIndex = 11;
            // 
            // lblNapomenePisca
            // 
            this.lblNapomenePisca.AutoSize = true;
            this.lblNapomenePisca.Location = new System.Drawing.Point(78, 215);
            this.lblNapomenePisca.Name = "lblNapomenePisca";
            this.lblNapomenePisca.Size = new System.Drawing.Size(77, 17);
            this.lblNapomenePisca.TabIndex = 12;
            this.lblNapomenePisca.Text = "Napomene";
            // 
            // txtNapomenePisca
            // 
            this.txtNapomenePisca.Location = new System.Drawing.Point(222, 215);
            this.txtNapomenePisca.Multiline = true;
            this.txtNapomenePisca.Name = "txtNapomenePisca";
            this.txtNapomenePisca.Size = new System.Drawing.Size(221, 105);
            this.txtNapomenePisca.TabIndex = 13;
            this.txtNapomenePisca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormPisac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.txtNapomenePisca);
            this.Controls.Add(this.lblNapomenePisca);
            this.Controls.Add(this.cbPol);
            this.Controls.Add(this.lblPolPisca);
            this.Controls.Add(this.lblGodinaRodjenjaPisca);
            this.Controls.Add(this.lblPrezimePisca);
            this.Controls.Add(this.lblImePisca);
            this.Controls.Add(this.lblStatusPisca);
            this.Controls.Add(this.cbStatusPisca);
            this.Controls.Add(this.txtGodinaRodjenjaPisca);
            this.Controls.Add(this.txtPrezimePisca);
            this.Controls.Add(this.txtImePisca);
            this.Controls.Add(this.btDodajPisca);
            this.Name = "FormPisac";
            this.Text = "FormPisac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDodajPisca;
        private System.Windows.Forms.TextBox txtImePisca;
        private System.Windows.Forms.TextBox txtPrezimePisca;
        private System.Windows.Forms.TextBox txtGodinaRodjenjaPisca;
        private System.Windows.Forms.ComboBox cbStatusPisca;
        private System.Windows.Forms.Label lblStatusPisca;
        private System.Windows.Forms.Label lblImePisca;
        private System.Windows.Forms.Label lblPrezimePisca;
        private System.Windows.Forms.Label lblGodinaRodjenjaPisca;
        private System.Windows.Forms.Label lblPolPisca;
        private System.Windows.Forms.ComboBox cbPol;
        private System.Windows.Forms.Label lblNapomenePisca;
        private System.Windows.Forms.TextBox txtNapomenePisca;
    }
}