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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPisac));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSkrozDesno = new System.Windows.Forms.Button();
            this.btSkrozLevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImePisca
            // 
            this.txtImePisca.Location = new System.Drawing.Point(268, 76);
            this.txtImePisca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImePisca.Name = "txtImePisca";
            this.txtImePisca.Size = new System.Drawing.Size(100, 22);
            this.txtImePisca.TabIndex = 2;
            // 
            // txtPrezimePisca
            // 
            this.txtPrezimePisca.Location = new System.Drawing.Point(268, 105);
            this.txtPrezimePisca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezimePisca.Name = "txtPrezimePisca";
            this.txtPrezimePisca.Size = new System.Drawing.Size(100, 22);
            this.txtPrezimePisca.TabIndex = 3;
            // 
            // txtGodinaRodjenjaPisca
            // 
            this.txtGodinaRodjenjaPisca.Location = new System.Drawing.Point(268, 162);
            this.txtGodinaRodjenjaPisca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.cbStatusPisca.Location = new System.Drawing.Point(268, 46);
            this.cbStatusPisca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatusPisca.Name = "cbStatusPisca";
            this.cbStatusPisca.Size = new System.Drawing.Size(121, 24);
            this.cbStatusPisca.TabIndex = 5;
            // 
            // lblStatusPisca
            // 
            this.lblStatusPisca.AutoSize = true;
            this.lblStatusPisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPisca.ForeColor = System.Drawing.Color.IndianRed;
            this.lblStatusPisca.Image = ((System.Drawing.Image)(resources.GetObject("lblStatusPisca.Image")));
            this.lblStatusPisca.Location = new System.Drawing.Point(189, 47);
            this.lblStatusPisca.Name = "lblStatusPisca";
            this.lblStatusPisca.Size = new System.Drawing.Size(68, 25);
            this.lblStatusPisca.TabIndex = 6;
            this.lblStatusPisca.Text = "Status";
            this.lblStatusPisca.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblImePisca
            // 
            this.lblImePisca.AutoSize = true;
            this.lblImePisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePisca.ForeColor = System.Drawing.Color.IndianRed;
            this.lblImePisca.Image = ((System.Drawing.Image)(resources.GetObject("lblImePisca.Image")));
            this.lblImePisca.Location = new System.Drawing.Point(215, 76);
            this.lblImePisca.Name = "lblImePisca";
            this.lblImePisca.Size = new System.Drawing.Size(44, 25);
            this.lblImePisca.TabIndex = 7;
            this.lblImePisca.Text = "Ime";
            // 
            // lblPrezimePisca
            // 
            this.lblPrezimePisca.AutoSize = true;
            this.lblPrezimePisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezimePisca.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPrezimePisca.Image = ((System.Drawing.Image)(resources.GetObject("lblPrezimePisca.Image")));
            this.lblPrezimePisca.Location = new System.Drawing.Point(175, 105);
            this.lblPrezimePisca.Name = "lblPrezimePisca";
            this.lblPrezimePisca.Size = new System.Drawing.Size(83, 25);
            this.lblPrezimePisca.TabIndex = 8;
            this.lblPrezimePisca.Text = "Prezime";
            // 
            // lblGodinaRodjenjaPisca
            // 
            this.lblGodinaRodjenjaPisca.AutoSize = true;
            this.lblGodinaRodjenjaPisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGodinaRodjenjaPisca.ForeColor = System.Drawing.Color.IndianRed;
            this.lblGodinaRodjenjaPisca.Image = ((System.Drawing.Image)(resources.GetObject("lblGodinaRodjenjaPisca.Image")));
            this.lblGodinaRodjenjaPisca.Location = new System.Drawing.Point(100, 161);
            this.lblGodinaRodjenjaPisca.Name = "lblGodinaRodjenjaPisca";
            this.lblGodinaRodjenjaPisca.Size = new System.Drawing.Size(151, 25);
            this.lblGodinaRodjenjaPisca.TabIndex = 9;
            this.lblGodinaRodjenjaPisca.Text = "GodinaRodjenja";
            // 
            // lblPolPisca
            // 
            this.lblPolPisca.AutoSize = true;
            this.lblPolPisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolPisca.ForeColor = System.Drawing.Color.IndianRed;
            this.lblPolPisca.Image = ((System.Drawing.Image)(resources.GetObject("lblPolPisca.Image")));
            this.lblPolPisca.Location = new System.Drawing.Point(221, 133);
            this.lblPolPisca.Name = "lblPolPisca";
            this.lblPolPisca.Size = new System.Drawing.Size(40, 25);
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
            this.cbPol.Location = new System.Drawing.Point(268, 132);
            this.cbPol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPol.Name = "cbPol";
            this.cbPol.Size = new System.Drawing.Size(121, 24);
            this.cbPol.TabIndex = 11;
            // 
            // lblNapomenePisca
            // 
            this.lblNapomenePisca.AutoSize = true;
            this.lblNapomenePisca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNapomenePisca.ForeColor = System.Drawing.Color.IndianRed;
            this.lblNapomenePisca.Image = ((System.Drawing.Image)(resources.GetObject("lblNapomenePisca.Image")));
            this.lblNapomenePisca.Location = new System.Drawing.Point(192, 219);
            this.lblNapomenePisca.Name = "lblNapomenePisca";
            this.lblNapomenePisca.Size = new System.Drawing.Size(108, 25);
            this.lblNapomenePisca.TabIndex = 12;
            this.lblNapomenePisca.Text = "Napomene";
            // 
            // txtNapomenePisca
            // 
            this.txtNapomenePisca.AcceptsReturn = true;
            this.txtNapomenePisca.Location = new System.Drawing.Point(144, 247);
            this.txtNapomenePisca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNapomenePisca.Multiline = true;
            this.txtNapomenePisca.Name = "txtNapomenePisca";
            this.txtNapomenePisca.Size = new System.Drawing.Size(221, 105);
            this.txtNapomenePisca.TabIndex = 13;
            this.txtNapomenePisca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.ForeColor = System.Drawing.Color.IndianRed;
            this.btOk.Location = new System.Drawing.Point(448, 270);
            this.btOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(183, 71);
            this.btOk.TabIndex = 14;
            this.btOk.Text = "GOTOVO";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btDesno
            // 
            this.btDesno.Location = new System.Drawing.Point(448, 394);
            this.btDesno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDesno.Name = "btDesno";
            this.btDesno.Size = new System.Drawing.Size(100, 28);
            this.btDesno.TabIndex = 15;
            this.btDesno.Text = ">";
            this.btDesno.UseVisualStyleBackColor = true;
            this.btDesno.Click += new System.EventHandler(this.btDesno_Click);
            // 
            // btLevo
            // 
            this.btLevo.Location = new System.Drawing.Point(269, 394);
            this.btLevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLevo.Name = "btLevo";
            this.btLevo.Size = new System.Drawing.Size(100, 28);
            this.btLevo.TabIndex = 16;
            this.btLevo.Text = "<";
            this.btLevo.UseVisualStyleBackColor = true;
            this.btLevo.Click += new System.EventHandler(this.btLevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::biblioteka.Properties.Resources.Untitled_3;
            this.pictureBox1.Location = new System.Drawing.Point(479, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btSkrozDesno
            // 
            this.btSkrozDesno.Location = new System.Drawing.Point(588, 394);
            this.btSkrozDesno.Margin = new System.Windows.Forms.Padding(4);
            this.btSkrozDesno.Name = "btSkrozDesno";
            this.btSkrozDesno.Size = new System.Drawing.Size(100, 28);
            this.btSkrozDesno.TabIndex = 18;
            this.btSkrozDesno.Text = ">>";
            this.btSkrozDesno.UseVisualStyleBackColor = true;
            this.btSkrozDesno.Click += new System.EventHandler(this.btSkrozDesno_Click);
            // 
            // btSkrozLevo
            // 
            this.btSkrozLevo.Location = new System.Drawing.Point(118, 394);
            this.btSkrozLevo.Margin = new System.Windows.Forms.Padding(4);
            this.btSkrozLevo.Name = "btSkrozLevo";
            this.btSkrozLevo.Size = new System.Drawing.Size(100, 28);
            this.btSkrozLevo.TabIndex = 19;
            this.btSkrozLevo.Text = "<<";
            this.btSkrozLevo.UseVisualStyleBackColor = true;
            this.btSkrozLevo.Click += new System.EventHandler(this.btSkrozLevo_Click);
            // 
            // FormPisac
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::biblioteka.Properties.Resources.sofia_ritter_chatting_4k2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSkrozLevo);
            this.Controls.Add(this.btSkrozDesno);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPisac";
            this.Text = "FormPisac";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btSkrozDesno;
        public System.Windows.Forms.Button btSkrozLevo;
    }
}