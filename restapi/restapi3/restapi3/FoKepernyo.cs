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
        
       public class Termek
        {

            public int id { get; set; }
            public String nev { get; set; }
            public int darab { get; set; }
            public int ar { get; set; }
        }

    }
}
