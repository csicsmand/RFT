using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restapi3
{
    public partial class Bejelentkezes : Form
    {
        public Bejelentkezes()
        {
            InitializeComponent();
        }

        private void Bejelentkezés_Click(object sender, EventArgs e)
        {
            if (!Felhasználónév.Text.Equals("admin") || !Jelszó.Text.Equals("admin"))
            {
                MessageBox.Show("Sikertelen bejelentkezés!");
            }
            else
            {
                MessageBox.Show("Sikeres bejelentkezés!");
                FoKepernyo.bejelentkezve = true;
                this.Close();
            }
        }

        private void Kilépés_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
