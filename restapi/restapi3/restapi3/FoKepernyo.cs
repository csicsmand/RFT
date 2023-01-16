using RestSharp;
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
    public partial class FoKepernyo : Form
    {
        public static bool bejelentkezve = false;

        public FoKepernyo()
        {
            InitializeComponent();

        }

        private void FoKepernyo_Load(object sender, EventArgs e)
        {
            Funkciok.SelectedItem = "GET";
        }
    }
}
