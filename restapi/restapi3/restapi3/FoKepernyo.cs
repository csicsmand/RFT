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
        
		if (Funkciok.SelectedItem.Equals("GET")) //KÉSZ
            {
                try
                {
                    Visszaad.Items.Add("GET LEKÉRDEZÉS:");
                    var client = new RestClient("http://127.0.0.1:3000/termek/");
                    var request = new RestRequest(Method.GET);
                    request.RequestFormat = DataFormat.Json;

                    IRestResponse<List<Termek>> response = client.Execute<List<Termek>>(request);
                    var content = response.Content;
                    foreach (Termek emp in response.Data)
                    {
                        Visszaad.Items.Add("ID: " + emp.id + ", NÉV: " + emp.nev + ", DARAB: " + emp.darab + ", ÁR:." + emp.ar + " HUF");
                    }

                    /*foreach (Termek ter in response.Data)
                    {
                        Visszaad2.DataSource = response.Data;
                        Visszaad2.Refresh();
                    }*/
                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba az adatok lekérése során!");
                }
            }
		
		private void Bejelentkezés_Click(object sender, EventArgs e)
        {
            if (bejelentkezve)
            {
                MessageBox.Show("Már be vagy jelentkezve!");
            }
            else
            {
                Bejelentkezes bejelent = new Bejelentkezes();
                bejelent.Show();
            }

        }
        
		if (Funkciok.SelectedItem.Equals("GET(ID)"))
            {
                try
                {
                    Visszaad.Items.Add("GET LEKÉRDEZÉS ID ALAPJÁN:");
                    string temp = "http://127.0.0.1:3000/termek/" + ID.Text;
                    var client = new RestClient(temp);
                    var request = new RestRequest(Method.GET);
                    request.RequestFormat = DataFormat.Json;
                    IRestResponse<List<Termek>> response = client.Execute<List<Termek>>(request);
                    var content = response.Content;
                    foreach (Termek emp in response.Data)
                    {
                        Visszaad.Items.Add("ID: " + emp.id + ", NÉV: " + emp.nev + ", DARAB: " + emp.darab + ", ÁR:." + emp.ar + " HUF");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba az adatok lekérése során!");
                }
            }

        if (Funkciok.SelectedItem.Equals("DELETE(ID)"))
            {
                if (bejelentkezve)
                {
                    try
                    {
                        string temp = "http://127.0.0.1:3000/termek/" + ID.Text;
                        var client = new RestClient(temp);
                        var request = new RestRequest(Method.DELETE);
                        IRestResponse response = client.Execute(request);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hiba az adat törlése során!");
                    }
                }
                else
                    MessageBox.Show("Bejelentkezés szükséges!");

            }
        }
            
       private void Kilépés_Click(object sender, EventArgs e)
        {
            if (bejelentkezve)
            {
                bejelentkezve = false;
                MessageBox.Show("Sikeresen kilépett!");
            }
            else
                MessageBox.Show("Nincs bejelentkezve!");
                
        }
        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void AddNev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void AddDarab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void AddAr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = !char.IsNumber(e.KeyChar);
            }
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (bejelentkezve)
            {
                try
                {
                    string temp = "http://127.0.0.1:3000/termek/" + ID.Text;
                    var client = new RestClient(temp);
                    var request = new RestRequest(Method.PUT);
                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new Termek
                    {
                        id = int.Parse(ID.Text),
                        nev = AddNev.Text,
                        darab = int.Parse(AddDarab.Text),
                        ar = int.Parse(AddAr.Text)
                    });

                    IRestResponse response = client.Execute(request);
                    var content = response.Content;
                    //Visszaad2.Text = content;
                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba az adatok frissítése során!");
                }
            }
            else
                MessageBox.Show("Bejelentkezés szükséges!");
        }

        private void CLEAR_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Eddigi tartalom törölve!");
            Visszaad.Items.Clear();
        }

        private void ADD_Click(object sender, EventArgs e) 
        {
            if (bejelentkezve)
            {
                try
                {
                    var client = new RestClient("http://127.0.0.1:3000/termek");
                    var request = new RestRequest(Method.POST);  //Create
                    request.RequestFormat = DataFormat.Json;
                    request.AddBody(new Termek
                    {
                        id = int.Parse(ID.Text),
                        nev = AddNev.Text,
                        darab = int.Parse(AddDarab.Text),
                        ar = int.Parse(AddAr.Text)
                    });
                    IRestResponse response = client.Execute(request);
                }
                catch (Exception)
                {

                    MessageBox.Show("Hiba az adatok hozzáadása során!");
                }
            }
            else
                MessageBox.Show("Bejelentkezés szükséges!");

        }


        
       public class Termek
        {

            public int id { get; set; }
            public String nev { get; set; }
            public int darab { get; set; }
            public int ar { get; set; }
        }

    }
}
