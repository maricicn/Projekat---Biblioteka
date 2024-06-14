﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Policy;

namespace biblioteka
{
    public partial class Form1 : Form
    {

        Size[] sizes;
        Point[] points;
        Font[] fonts;
        Padding[] paddings;
        public static string idimeprezime;

        Size size;

        public static List<Librarian> librarians;
        public Form1()
        {
            InitializeComponent();

            Data.UcitajPisce();
            Data.UcitajKnjige();
            Data.UcitajIzdavanja();
            Data.ucitajBibliotekare();
            Data.UcitajCitaoce();
            Data.PopuniListuZakasnjenja();
            


            //Resizovanje
            sizes = new Size[Controls.Count];
            points = new Point[Controls.Count];
            fonts = new Font[Controls.Count];
            paddings = new Padding[Controls.Count];

            for (int i = 0; i < Controls.Count; i++)
            {
                sizes[i] = Controls[i].Size;
                points[i] = Controls[i].Location;
                fonts[i] = Controls[i].Font;
                paddings[i] = Controls[i].Padding;
            }

            size = ClientSize;



            //SetCustomCursor();
            librarians = new List<Librarian>
            {
                new Librarian ("admin", "admin123")
            };
            popuniBibliotekare();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void SetCustomCursor1()
        {
            /*
            // Učitaj sliku kursora iz resursa
            Cursor customCursor;
            using (var stream = new System.IO.MemoryStream(Properties.Resources.sl6))
            {
                customCursor = new Cursor(stream);
            }

            // Postavi kursor za celu formu
            this.Cursor = customCursor;
            */
        }
        
        private void username2(object sender, EventArgs e)
        {
            string username = username1.Text;
        }
            
        private void password_TextChanged(object sender, EventArgs e)
        {
            string password = this.password1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = username1.Text;
            string password = password1.Text;

            Librarian librarian = librarians.Find(l => l.username == username && l.password == password);
            if (librarian != null)
            {
                MessageBox.Show("Uspesno logovanje");
                vracanje_knjiga.Enabled = true;
                izdavanje_knjiga.Enabled = true;
                izvestaj.Enabled = true;
                prostorija.Enabled = true;
                polica.Enabled = true;
                pisac.Enabled = true;
                knjiga.Enabled = true;
                bibliotekar.Enabled = true;
                citalac.Enabled = true;
                idimeprezime = librarian.id_ime_prezime;
                
                // Ovde možete otvoriti glavnu formu aplikacije.
            }
            else
            {
                MessageBox.Show("netacan username ili password.");
            }
        }

        private void izlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novi_Click(object sender, EventArgs e)
        {
            string username = username1.Text;
            string password = password1.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username ili password ne mogu biti prazni.");
                return;
            }

            Librarian newLibrarian = new Librarian(username, password);
            librarians.Add(newLibrarian);

            MessageBox.Show($"dodat je novi bibliotekar.\nUsername: {username}");

            // Poništavanje unosa
            username1.Text = "";
            password1.Text = "";
        }
        public class Librarian
        {
            public string username;
            public string password;
            public string id_ime_prezime;
            public Librarian(string username, string password)
            {
                this.username = username;
                this.password = password;
            }
            public Librarian(string username, string password, string id_ime_prezime)
            {
                this.username = username;
                this.password = password;
                this.id_ime_prezime = id_ime_prezime;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("username je admin, a password je admin123");
        }

        private void pisac_Click(object sender, EventArgs e)
        {
            FormaPisacEditIliUnesi forma = new FormaPisacEditIliUnesi();
            forma.ShowDialog();
        }

        private void knjiga_Click(object sender, EventArgs e)
        {
            FormaKnjigaUnesiIliEdituj forma = new FormaKnjigaUnesiIliEdituj();
            forma.ShowDialog();
        }

        private void izdavanje_knjiga_Click(object sender, EventArgs e)
        {
            FormIzdavanjeKnjige izdavanje = new FormIzdavanjeKnjige();
            izdavanje.ShowDialog();
        }

        private void vracanje_knjiga_Click(object sender, EventArgs e)
        {
            FormVracanjeKnjige vracanje = new FormVracanjeKnjige();
            vracanje.ShowDialog();
        }

        private void polica_Click(object sender, EventArgs e)
        {
            POLICA2 pOLICA2 = new POLICA2();
            pOLICA2.ShowDialog();
        }

        private void prostorija_Click(object sender, EventArgs e)
        {
            PROSTORIJA37 p = new PROSTORIJA37();
            p.ShowDialog();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            float ratioX = (float)ClientSize.Width / size.Width;
            float ratioY = (float)ClientSize.Height / size.Height;

            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].Location = new Point((int)(points[i].X * ratioX), (int)(points[i].Y * ratioY));
                Controls[i].Size = new Size((int)(sizes[i].Width * ratioX), (int)(sizes[i].Height * ratioY));
                Controls[i].Font = new Font(fonts[i].FontFamily, fonts[i].Size * ratioY);
                Controls[i].Padding = new Padding((int)(paddings[i].Left * ratioX), (int)(paddings[i].Top * ratioY), (int)(paddings[i].Right * ratioX), (int)(paddings[i].Bottom * ratioY));
            }
        }

        private void bibliotekar_Click(object sender, EventArgs e)
        {
            BibliotekarLoby bibliotekar = new BibliotekarLoby();
            bibliotekar.ShowDialog();
        }

        private void izvestaj_Click(object sender, EventArgs e)
        {
            FormIzvestaj izvestaj = new FormIzvestaj();
            izvestaj.ShowDialog();
        }
        public static void popuniBibliotekare()
        {
            for (int i = 0; i < Bibliotekar.bibliotekari.Count; i++)
            {
                string username = Bibliotekar.bibliotekari[i].KorisnickoIme;
                string password = Bibliotekar.bibliotekari[i].Lozinka;
                string id_ime_prezime = Bibliotekar.bibliotekari[i].ID + " " + Bibliotekar.bibliotekari[i].Ime + " " + Bibliotekar.bibliotekari[i].Prezime;
                Librarian newLibrarian = new Librarian(username, password, id_ime_prezime);
                librarians.Add(newLibrarian);
            }
        }

        private void citalac_Click(object sender, EventArgs e)
        {
            FormaCItalac forma = new FormaCItalac();
            forma.ShowDialog();
        }
    }
}
