
namespace biblioteka
{
    partial class FormaDodajKnjigu
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblPisci = new System.Windows.Forms.Label();
            this.lblGodinaIzdavanja = new System.Windows.Forms.Label();
            this.lblRedniBrojIzdanja = new System.Windows.Forms.Label();
            this.lblZanr = new System.Windows.Forms.Label();
            this.lblStanje = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblUkupanBrojPrimeraka = new System.Windows.Forms.Label();
            this.lblPolica = new System.Windows.Forms.Label();
            this.lblProstorija = new System.Windows.Forms.Label();
            this.lblDatumIzdavanja = new System.Windows.Forms.Label();
            this.lblCitalac = new System.Windows.Forms.Label();
            this.lblSvaIzdanja = new System.Windows.Forms.Label();
            this.lblRokZaVracanje = new System.Windows.Forms.Label();
            this.lblBibliotekar = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtRedniBrojIzdanja = new System.Windows.Forms.TextBox();
            this.txtGodinaIzdavanja = new System.Windows.Forms.TextBox();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtStanje = new System.Windows.Forms.TextBox();
            this.txtUkupanBrojPrimeraka = new System.Windows.Forms.TextBox();
            this.txtNapomene = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbZanr = new System.Windows.Forms.ComboBox();
            this.cbProstorija = new System.Windows.Forms.ComboBox();
            this.cbPolica = new System.Windows.Forms.ComboBox();
            this.cbCitalac = new System.Windows.Forms.ComboBox();
            this.cbBibliotekar = new System.Windows.Forms.ComboBox();
            this.clbPisci = new System.Windows.Forms.CheckedListBox();
            this.clbSvaIzdavanja = new System.Windows.Forms.CheckedListBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btLevo = new System.Windows.Forms.Button();
            this.btDesno = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(54, 28);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(54, 52);
            this.lblNaziv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblPisci
            // 
            this.lblPisci.AutoSize = true;
            this.lblPisci.Location = new System.Drawing.Point(54, 76);
            this.lblPisci.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPisci.Name = "lblPisci";
            this.lblPisci.Size = new System.Drawing.Size(29, 13);
            this.lblPisci.TabIndex = 2;
            this.lblPisci.Text = "Pisci";
            // 
            // lblGodinaIzdavanja
            // 
            this.lblGodinaIzdavanja.AutoSize = true;
            this.lblGodinaIzdavanja.Location = new System.Drawing.Point(54, 154);
            this.lblGodinaIzdavanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGodinaIzdavanja.Name = "lblGodinaIzdavanja";
            this.lblGodinaIzdavanja.Size = new System.Drawing.Size(87, 13);
            this.lblGodinaIzdavanja.TabIndex = 5;
            this.lblGodinaIzdavanja.Text = "GodinaIzdavanja";
            // 
            // lblRedniBrojIzdanja
            // 
            this.lblRedniBrojIzdanja.AutoSize = true;
            this.lblRedniBrojIzdanja.Location = new System.Drawing.Point(54, 129);
            this.lblRedniBrojIzdanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRedniBrojIzdanja.Name = "lblRedniBrojIzdanja";
            this.lblRedniBrojIzdanja.Size = new System.Drawing.Size(87, 13);
            this.lblRedniBrojIzdanja.TabIndex = 4;
            this.lblRedniBrojIzdanja.Text = "RedniBrojIzdanja";
            // 
            // lblZanr
            // 
            this.lblZanr.AutoSize = true;
            this.lblZanr.Location = new System.Drawing.Point(54, 106);
            this.lblZanr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZanr.Name = "lblZanr";
            this.lblZanr.Size = new System.Drawing.Size(29, 13);
            this.lblZanr.TabIndex = 3;
            this.lblZanr.Text = "Zanr";
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.Location = new System.Drawing.Point(54, 232);
            this.lblStanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(37, 13);
            this.lblStanje.TabIndex = 8;
            this.lblStanje.Text = "Stanje";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(54, 208);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 7;
            this.lblISBN.Text = "ISBN";
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Location = new System.Drawing.Point(54, 184);
            this.lblIzdavac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(45, 13);
            this.lblIzdavac.TabIndex = 6;
            this.lblIzdavac.Text = "Izdavac";
            // 
            // lblUkupanBrojPrimeraka
            // 
            this.lblUkupanBrojPrimeraka.AutoSize = true;
            this.lblUkupanBrojPrimeraka.Location = new System.Drawing.Point(54, 309);
            this.lblUkupanBrojPrimeraka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUkupanBrojPrimeraka.Name = "lblUkupanBrojPrimeraka";
            this.lblUkupanBrojPrimeraka.Size = new System.Drawing.Size(110, 13);
            this.lblUkupanBrojPrimeraka.TabIndex = 11;
            this.lblUkupanBrojPrimeraka.Text = "UkupanBrojPrimeraka";
            // 
            // lblPolica
            // 
            this.lblPolica.AutoSize = true;
            this.lblPolica.Location = new System.Drawing.Point(54, 284);
            this.lblPolica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPolica.Name = "lblPolica";
            this.lblPolica.Size = new System.Drawing.Size(36, 13);
            this.lblPolica.TabIndex = 10;
            this.lblPolica.Text = "Polica";
            // 
            // lblProstorija
            // 
            this.lblProstorija.AutoSize = true;
            this.lblProstorija.Location = new System.Drawing.Point(54, 261);
            this.lblProstorija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProstorija.Name = "lblProstorija";
            this.lblProstorija.Size = new System.Drawing.Size(50, 13);
            this.lblProstorija.TabIndex = 9;
            this.lblProstorija.Text = "Prostorija";
            // 
            // lblDatumIzdavanja
            // 
            this.lblDatumIzdavanja.AutoSize = true;
            this.lblDatumIzdavanja.Location = new System.Drawing.Point(54, 388);
            this.lblDatumIzdavanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumIzdavanja.Name = "lblDatumIzdavanja";
            this.lblDatumIzdavanja.Size = new System.Drawing.Size(84, 13);
            this.lblDatumIzdavanja.TabIndex = 14;
            this.lblDatumIzdavanja.Text = "DatumIzdavanja";
            // 
            // lblCitalac
            // 
            this.lblCitalac.AutoSize = true;
            this.lblCitalac.Location = new System.Drawing.Point(54, 363);
            this.lblCitalac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCitalac.Name = "lblCitalac";
            this.lblCitalac.Size = new System.Drawing.Size(39, 13);
            this.lblCitalac.TabIndex = 13;
            this.lblCitalac.Text = "Citalac";
            // 
            // lblSvaIzdanja
            // 
            this.lblSvaIzdanja.AutoSize = true;
            this.lblSvaIzdanja.Location = new System.Drawing.Point(54, 340);
            this.lblSvaIzdanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSvaIzdanja.Name = "lblSvaIzdanja";
            this.lblSvaIzdanja.Size = new System.Drawing.Size(60, 13);
            this.lblSvaIzdanja.TabIndex = 12;
            this.lblSvaIzdanja.Text = "SvaIzdanja";
            // 
            // lblRokZaVracanje
            // 
            this.lblRokZaVracanje.AutoSize = true;
            this.lblRokZaVracanje.Location = new System.Drawing.Point(54, 417);
            this.lblRokZaVracanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRokZaVracanje.Name = "lblRokZaVracanje";
            this.lblRokZaVracanje.Size = new System.Drawing.Size(82, 13);
            this.lblRokZaVracanje.TabIndex = 15;
            this.lblRokZaVracanje.Text = "RokZaVracanje";
            // 
            // lblBibliotekar
            // 
            this.lblBibliotekar.AutoSize = true;
            this.lblBibliotekar.Location = new System.Drawing.Point(54, 441);
            this.lblBibliotekar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBibliotekar.Name = "lblBibliotekar";
            this.lblBibliotekar.Size = new System.Drawing.Size(56, 13);
            this.lblBibliotekar.TabIndex = 16;
            this.lblBibliotekar.Text = "Bibliotekar";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(56, 462);
            this.lblNapomena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(59, 13);
            this.lblNapomena.TabIndex = 17;
            this.lblNapomena.Text = "Napomene";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(178, 52);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(93, 20);
            this.txtNaziv.TabIndex = 19;
            // 
            // txtRedniBrojIzdanja
            // 
            this.txtRedniBrojIzdanja.Location = new System.Drawing.Point(178, 129);
            this.txtRedniBrojIzdanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRedniBrojIzdanja.Name = "txtRedniBrojIzdanja";
            this.txtRedniBrojIzdanja.Size = new System.Drawing.Size(93, 20);
            this.txtRedniBrojIzdanja.TabIndex = 22;
            // 
            // txtGodinaIzdavanja
            // 
            this.txtGodinaIzdavanja.Location = new System.Drawing.Point(178, 154);
            this.txtGodinaIzdavanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGodinaIzdavanja.Name = "txtGodinaIzdavanja";
            this.txtGodinaIzdavanja.Size = new System.Drawing.Size(93, 20);
            this.txtGodinaIzdavanja.TabIndex = 23;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(178, 182);
            this.txtIzdavac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(93, 20);
            this.txtIzdavac.TabIndex = 24;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(178, 208);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(93, 20);
            this.txtISBN.TabIndex = 25;
            // 
            // txtStanje
            // 
            this.txtStanje.Location = new System.Drawing.Point(178, 228);
            this.txtStanje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStanje.Name = "txtStanje";
            this.txtStanje.Size = new System.Drawing.Size(93, 20);
            this.txtStanje.TabIndex = 26;
            // 
            // txtUkupanBrojPrimeraka
            // 
            this.txtUkupanBrojPrimeraka.Location = new System.Drawing.Point(178, 305);
            this.txtUkupanBrojPrimeraka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUkupanBrojPrimeraka.Name = "txtUkupanBrojPrimeraka";
            this.txtUkupanBrojPrimeraka.Size = new System.Drawing.Size(93, 20);
            this.txtUkupanBrojPrimeraka.TabIndex = 29;
            // 
            // txtNapomene
            // 
            this.txtNapomene.AcceptsReturn = true;
            this.txtNapomene.Location = new System.Drawing.Point(178, 460);
            this.txtNapomene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNapomene.Multiline = true;
            this.txtNapomene.Name = "txtNapomene";
            this.txtNapomene.Size = new System.Drawing.Size(93, 19);
            this.txtNapomene.TabIndex = 35;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Aktivan",
            "Neaktivan"});
            this.cbStatus.Location = new System.Drawing.Point(178, 28);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(93, 21);
            this.cbStatus.TabIndex = 36;
            // 
            // cbZanr
            // 
            this.cbZanr.FormattingEnabled = true;
            this.cbZanr.Items.AddRange(new object[] {
            "Istorijski",
            "SF",
            "Krimi",
            "Fantastika"});
            this.cbZanr.Location = new System.Drawing.Point(178, 106);
            this.cbZanr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbZanr.Name = "cbZanr";
            this.cbZanr.Size = new System.Drawing.Size(93, 21);
            this.cbZanr.TabIndex = 38;
            // 
            // cbProstorija
            // 
            this.cbProstorija.FormattingEnabled = true;
            this.cbProstorija.Location = new System.Drawing.Point(178, 255);
            this.cbProstorija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProstorija.Name = "cbProstorija";
            this.cbProstorija.Size = new System.Drawing.Size(93, 21);
            this.cbProstorija.TabIndex = 39;
            // 
            // cbPolica
            // 
            this.cbPolica.FormattingEnabled = true;
            this.cbPolica.Location = new System.Drawing.Point(178, 279);
            this.cbPolica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPolica.Name = "cbPolica";
            this.cbPolica.Size = new System.Drawing.Size(93, 21);
            this.cbPolica.TabIndex = 40;
            // 
            // cbCitalac
            // 
            this.cbCitalac.FormattingEnabled = true;
            this.cbCitalac.Location = new System.Drawing.Point(178, 360);
            this.cbCitalac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCitalac.Name = "cbCitalac";
            this.cbCitalac.Size = new System.Drawing.Size(93, 21);
            this.cbCitalac.TabIndex = 41;
            // 
            // cbBibliotekar
            // 
            this.cbBibliotekar.FormattingEnabled = true;
            this.cbBibliotekar.Location = new System.Drawing.Point(178, 436);
            this.cbBibliotekar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBibliotekar.Name = "cbBibliotekar";
            this.cbBibliotekar.Size = new System.Drawing.Size(92, 21);
            this.cbBibliotekar.TabIndex = 42;
            // 
            // clbPisci
            // 
            this.clbPisci.FormattingEnabled = true;
            this.clbPisci.Location = new System.Drawing.Point(292, 43);
            this.clbPisci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbPisci.Name = "clbPisci";
            this.clbPisci.ScrollAlwaysVisible = true;
            this.clbPisci.Size = new System.Drawing.Size(93, 94);
            this.clbPisci.TabIndex = 46;
            // 
            // clbSvaIzdavanja
            // 
            this.clbSvaIzdavanja.FormattingEnabled = true;
            this.clbSvaIzdavanja.Items.AddRange(new object[] {
            "da",
            "da",
            "da",
            "da",
            "da",
            "ne",
            "ne",
            "ne"});
            this.clbSvaIzdavanja.Location = new System.Drawing.Point(178, 327);
            this.clbSvaIzdavanja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clbSvaIzdavanja.Name = "clbSvaIzdavanja";
            this.clbSvaIzdavanja.ScrollAlwaysVisible = true;
            this.clbSvaIzdavanja.Size = new System.Drawing.Size(93, 19);
            this.clbSvaIzdavanja.TabIndex = 47;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(478, 179);
            this.btOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(169, 77);
            this.btOk.TabIndex = 48;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btLevo
            // 
            this.btLevo.Location = new System.Drawing.Point(393, 411);
            this.btLevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLevo.Name = "btLevo";
            this.btLevo.Size = new System.Drawing.Size(56, 19);
            this.btLevo.TabIndex = 50;
            this.btLevo.Text = "<";
            this.btLevo.UseVisualStyleBackColor = true;
            this.btLevo.Click += new System.EventHandler(this.btLevo_Click);
            // 
            // btDesno
            // 
            this.btDesno.Location = new System.Drawing.Point(638, 411);
            this.btDesno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDesno.Name = "btDesno";
            this.btDesno.Size = new System.Drawing.Size(56, 19);
            this.btDesno.TabIndex = 49;
            this.btDesno.Text = ">";
            this.btDesno.UseVisualStyleBackColor = true;
            this.btDesno.Click += new System.EventHandler(this.btDesno_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 388);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker1.TabIndex = 51;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(178, 414);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker2.TabIndex = 52;
            // 
            // FormaDodajKnjigu
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 522);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btLevo);
            this.Controls.Add(this.btDesno);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.clbSvaIzdavanja);
            this.Controls.Add(this.clbPisci);
            this.Controls.Add(this.cbBibliotekar);
            this.Controls.Add(this.cbCitalac);
            this.Controls.Add(this.cbPolica);
            this.Controls.Add(this.cbProstorija);
            this.Controls.Add(this.cbZanr);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtNapomene);
            this.Controls.Add(this.txtUkupanBrojPrimeraka);
            this.Controls.Add(this.txtStanje);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.txtGodinaIzdavanja);
            this.Controls.Add(this.txtRedniBrojIzdanja);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblBibliotekar);
            this.Controls.Add(this.lblRokZaVracanje);
            this.Controls.Add(this.lblDatumIzdavanja);
            this.Controls.Add(this.lblCitalac);
            this.Controls.Add(this.lblSvaIzdanja);
            this.Controls.Add(this.lblUkupanBrojPrimeraka);
            this.Controls.Add(this.lblPolica);
            this.Controls.Add(this.lblProstorija);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.lblGodinaIzdavanja);
            this.Controls.Add(this.lblRedniBrojIzdanja);
            this.Controls.Add(this.lblZanr);
            this.Controls.Add(this.lblPisci);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblStatus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormaDodajKnjigu";
            this.Text = "FormaDodajKnjigu";
            this.Load += new System.EventHandler(this.FormaDodajKnjigu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Label lblNaziv;
        public System.Windows.Forms.Label lblPisci;
        public System.Windows.Forms.Label lblGodinaIzdavanja;
        public System.Windows.Forms.Label lblRedniBrojIzdanja;
        public System.Windows.Forms.Label lblZanr;
        public System.Windows.Forms.Label lblStanje;
        public System.Windows.Forms.Label lblISBN;
        public System.Windows.Forms.Label lblIzdavac;
        public System.Windows.Forms.Label lblUkupanBrojPrimeraka;
        public System.Windows.Forms.Label lblPolica;
        public System.Windows.Forms.Label lblProstorija;
        public System.Windows.Forms.Label lblDatumIzdavanja;
        public System.Windows.Forms.Label lblCitalac;
        public System.Windows.Forms.Label lblSvaIzdanja;
        public System.Windows.Forms.Label lblRokZaVracanje;
        public System.Windows.Forms.Label lblBibliotekar;
        public System.Windows.Forms.Label lblNapomena;
        public System.Windows.Forms.TextBox txtNaziv;
        public System.Windows.Forms.TextBox txtRedniBrojIzdanja;
        public System.Windows.Forms.TextBox txtGodinaIzdavanja;
        public System.Windows.Forms.TextBox txtIzdavac;
        public System.Windows.Forms.TextBox txtISBN;
        public System.Windows.Forms.TextBox txtStanje;
        public System.Windows.Forms.TextBox txtUkupanBrojPrimeraka;
        public System.Windows.Forms.TextBox txtNapomene;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.ComboBox cbZanr;
        public System.Windows.Forms.ComboBox cbProstorija;
        public System.Windows.Forms.ComboBox cbPolica;
        public System.Windows.Forms.ComboBox cbCitalac;
        public System.Windows.Forms.ComboBox cbBibliotekar;
        public System.Windows.Forms.CheckedListBox clbPisci;
        public System.Windows.Forms.CheckedListBox clbSvaIzdavanja;
        public System.Windows.Forms.Button btOk;
        public System.Windows.Forms.Button btLevo;
        public System.Windows.Forms.Button btDesno;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}