using System;
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

namespace biblioteka
{
    public partial class Form1 : Form
    {

        private List<Librarian> librarians;
        public Form1()
        {
            InitializeComponent();
            //SetCustomCursor();
            librarians = new List<Librarian>
            {
                new Librarian { Username = "admin", Password = "admin123" }
            };
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

            Librarian librarian = librarians.Find(l => l.Username == username && l.Password == password);
            if (librarian != null)
            {
                MessageBox.Show("Uspesno logovanje");
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

            Librarian newLibrarian = new Librarian { Username = username, Password = password };
            librarians.Add(newLibrarian);

            MessageBox.Show($"dodat je novi bibliotekar.\nUsername: {username}");

            // Poništavanje unosa
            username1.Text = "";
            password1.Text = "";
        }
        public class Librarian
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("username je admin, a password je admin123");
        }
    }
}
