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

namespace PClienteEstudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8090");
            var client = new RestClient(options);
            var request = new RestRequest("/estudiantes/", Method.Get);

            var response = client.Execute(request);
            txtCodigo.Text = response.Content;

        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;

            var options = new RestClientOptions("http://localhost:8090");
            var client = new RestClient(options);
            var request = new RestRequest("/estudiantes/" + codigo, Method.Post);

            var response = client.Execute(request);
            MessageBox.Show(response.StatusCode.ToString());
        }
    }
}
