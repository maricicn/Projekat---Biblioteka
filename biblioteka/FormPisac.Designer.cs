﻿namespace biblioteka
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
            this.btOk = new System.Windows.Forms.Button();
            this.btDesno = new System.Windows.Forms.Button();
            this.btLevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImePisca
            // 
            this.txtImePisca.Location = new System.Drawing.Point(166, 75);
            this.txtImePisca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImePisca.Name = "txtImePisca";
            this.txtImePisca.Size = new System.Drawing.Size(76, 20);
            this.txtImePisca.TabIndex = 2;
            // 
            // txtPrezimePisca
            // 
            this.txtPrezimePisca.Location = new System.Drawing.Point(166, 98);
            this.txtPrezimePisca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrezimePisca.Name = "txtPrezimePisca";
            this.txtPrezimePisca.Size = new System.Drawing.Size(76, 20);
            this.txtPrezimePisca.TabIndex = 3;
            // 
            // txtGodinaRodjenjaPisca
            // 
            this.txtGodinaRodjenjaPisca.Location = new System.Drawing.Point(166, 145);
            this.txtGodinaRodjenjaPisca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGodinaRodjenjaPisca.Name = "txtGodinaRodjenjaPisca";
            this.txtGodinaRodjenjaPisca.Size = new System.Drawing.Size(76, 20);
            this.txtGodinaRodjenjaPisca.TabIndex = 4;
            // 
            // cbStatusPisca
            // 
            this.cbStatusPisca.FormattingEnabled = true;
            this.cbStatusPisca.Items.AddRange(new object[] {
            "Aktivan",
            "Neaktivan"});
            this.cbStatusPisca.Location = new System.Drawing.Point(166, 50);
            this.cbStatusPisca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatusPisca.Name = "cbStatusPisca";
            this.cbStatusPisca.Size = new System.Drawing.Size(92, 21);
            this.cbStatusPisca.TabIndex = 5;
            // 
            // lblStatusPisca
            // 
            this.lblStatusPisca.AutoSize = true;
            this.lblStatusPisca.Location = new System.Drawing.Point(97, 53);
            this.lblStatusPisca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusPisca.Name = "lblStatusPisca";
            this.lblStatusPisca.Size = new System.Drawing.Size(37, 13);
            this.lblStatusPisca.TabIndex = 6;
            this.lblStatusPisca.Text = "Status";
            this.lblStatusPisca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblImePisca
            // 
            this.lblImePisca.AutoSize = true;
            this.lblImePisca.Location = new System.Drawing.Point(97, 79);
            this.lblImePisca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImePisca.Name = "lblImePisca";
            this.lblImePisca.Size = new System.Drawing.Size(24, 13);
            this.lblImePisca.TabIndex = 7;
            this.lblImePisca.Text = "Ime";
            // 
            // lblPrezimePisca
            // 
            this.lblPrezimePisca.AutoSize = true;
            this.lblPrezimePisca.Location = new System.Drawing.Point(97, 102);
            this.lblPrezimePisca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrezimePisca.Name = "lblPrezimePisca";
            this.lblPrezimePisca.Size = new System.Drawing.Size(44, 13);
            this.lblPrezimePisca.TabIndex = 8;
            this.lblPrezimePisca.Text = "Prezime";
            // 
            // lblGodinaRodjenjaPisca
            // 
            this.lblGodinaRodjenjaPisca.AutoSize = true;
            this.lblGodinaRodjenjaPisca.Location = new System.Drawing.Point(58, 147);
            this.lblGodinaRodjenjaPisca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGodinaRodjenjaPisca.Name = "lblGodinaRodjenjaPisca";
            this.lblGodinaRodjenjaPisca.Size = new System.Drawing.Size(83, 13);
            this.lblGodinaRodjenjaPisca.TabIndex = 9;
            this.lblGodinaRodjenjaPisca.Text = "GodinaRodjenja";
            // 
            // lblPolPisca
            // 
            this.lblPolPisca.AutoSize = true;
            this.lblPolPisca.Location = new System.Drawing.Point(97, 123);
            this.lblPolPisca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPolPisca.Name = "lblPolPisca";
            this.lblPolPisca.Size = new System.Drawing.Size(22, 13);
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
            this.cbPol.Location = new System.Drawing.Point(166, 120);
            this.cbPol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(92, 21);
            this.cbPol.TabIndex = 11;
            // 
            // lblNapomenePisca
            // 
            this.lblNapomenePisca.AutoSize = true;
            this.lblNapomenePisca.Location = new System.Drawing.Point(58, 175);
            this.lblNapomenePisca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNapomenePisca.Name = "lblNapomenePisca";
            this.lblNapomenePisca.Size = new System.Drawing.Size(59, 13);
            this.lblNapomenePisca.TabIndex = 12;
            this.lblNapomenePisca.Text = "Napomene";
            // 
            // txtNapomenePisca
            // 
            this.txtNapomenePisca.AcceptsReturn = true;
            this.txtNapomenePisca.Location = new System.Drawing.Point(166, 175);
            this.txtNapomenePisca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNapomenePisca.Multiline = true;
            this.txtNapomenePisca.Name = "txtNapomenePisca";
            this.txtNapomenePisca.Size = new System.Drawing.Size(167, 86);
            this.txtNapomenePisca.TabIndex = 13;
            this.txtNapomenePisca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(382, 131);
            this.btOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(56, 19);
            this.btOk.TabIndex = 14;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btDesno
            // 
            this.btDesno.Location = new System.Drawing.Point(549, 369);
            this.btDesno.Name = "btDesno";
            this.btDesno.Size = new System.Drawing.Size(75, 23);
            this.btDesno.TabIndex = 15;
            this.btDesno.Text = ">";
            this.btDesno.UseVisualStyleBackColor = true;
            this.btDesno.Click += new System.EventHandler(this.btDesno_Click);
            // 
            // btLevo
            // 
            this.btLevo.Location = new System.Drawing.Point(222, 369);
            this.btLevo.Name = "btLevo";
            this.btLevo.Size = new System.Drawing.Size(75, 23);
            this.btLevo.TabIndex = 16;
            this.btLevo.Text = "<";
            this.btLevo.UseVisualStyleBackColor = true;
            this.btLevo.Click += new System.EventHandler(this.btLevo_Click);
            // 
            // FormPisac
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;

            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.btLevo);
            this.Controls.Add(this.btDesno);

            this.Controls.Add(this.btOk);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPisac";
            this.Text = "FormPisac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatusPisca;
        private System.Windows.Forms.Label lblImePisca;
        private System.Windows.Forms.Label lblPrezimePisca;
        private System.Windows.Forms.Label lblGodinaRodjenjaPisca;
        private System.Windows.Forms.Label lblPolPisca;
        private System.Windows.Forms.Label lblNapomenePisca;
        public System.Windows.Forms.TextBox txtImePisca;
        public System.Windows.Forms.TextBox txtPrezimePisca;
        public System.Windows.Forms.TextBox txtGodinaRodjenjaPisca;
        public System.Windows.Forms.ComboBox cbStatusPisca;
        public System.Windows.Forms.ComboBox cbPol;
        public System.Windows.Forms.TextBox txtNapomenePisca;
        private System.Windows.Forms.Button btOk;
        public System.Windows.Forms.Button btDesno;
        public System.Windows.Forms.Button btLevo;
    }
}