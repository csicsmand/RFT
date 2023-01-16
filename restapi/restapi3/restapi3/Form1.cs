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
    public partial class Form1 : Form
    {

        //String URL = "http://aries.ektf.hu/~ksanyi/restapi/v1/";
        String URL = "http://127.0.0.1:3000/employees/";
        String ROUTE = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = "";
            var request = new RestRequest(ROUTE, Method.GET);
            request.RequestFormat = DataFormat.Json;

            IRestResponse<List<Employee>> response = client.Execute<List<Employee>>(request);
            foreach (Employee emp in response.Data)
            {
                listBox1.Items.Add(emp.id+" "+emp.employee_name); //stb.
            }
            
            //var content = response.Content;
            //textBox1.Text = content;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = textBox2.Text;
            var request = new RestRequest(ROUTE, Method.GET);  //read by id
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            textBox2.Text = content;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.POST);  //Create
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Employee
            {
                id=int.Parse(textBox3.Text),
                employee_name = textBox4.Text,
                employee_age = int.Parse(textBox5.Text),
                employee_salary = int.Parse(textBox6.Text)
            });
            IRestResponse response = client.Execute(request);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            String ROUTE = textBox1.Text;
            var request = new RestRequest(ROUTE, Method.DELETE);  //Delete by id
            //request.AddParameter("id", int.Parse(textBox1.Text));
            IRestResponse response = client.Execute(request);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var client = new RestClient(URL);
            var request = new RestRequest(ROUTE, Method.PUT);  //Create
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new Employee
            {
                id = int.Parse(textBox3.Text),
                employee_name = textBox4.Text,
                employee_age = int.Parse(textBox5.Text),
                employee_salary = int.Parse(textBox6.Text)
            });
            IRestResponse response = client.Execute(request);

            
        }
    }

    public class Employee
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public decimal employee_salary { get; set; }
        public decimal employee_age { get; set; }
    }

}
