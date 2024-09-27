using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClienteEstudiante
{
    public class Estudiante
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8081");
            var client = new RestClient(options);
            var request = new RestRequest("/students/", Method.Get);

            var response = client.Execute(request);
            var estudiante = JsonSerializer.Deserialize<Estudiante>(response.Content);
            // Display the student's details in the text fields
            txtCodigo.Text = estudiante.codigo.ToString();
            txtNombre.Text = estudiante.nombre;

        }

        /*
        private void btnPost_Click(object sender, EventArgs e)
        {
            var codigo = txtCodigo.Text;

            var options = new RestClientOptions("http://localhost:8081");
            var client = new RestClient(options);
            var request = new RestRequest("/students/" + codigo, Method.Post);

            var response = client.Execute(request);
            txtCodigo.Text = response.Content;


            MessageBox.Show(response.StatusCode.ToString());
        }
        */

        private void btnPost_Click(object sender, EventArgs e)
        {
            var options = new RestClientOptions("http://localhost:8081");
            var client = new RestClient(options);
            var request = new RestRequest("/students", Method.Post);

            // Obtener los datos del estudiante desde los campos de texto
            var estudiante = new Estudiante
            {
                codigo = int.Parse(txtCodigo.Text),
                nombre = txtNombre.Text
            };

            request.AddJsonBody(estudiante);

            // Convertir el objeto a JSON
            //var estudianteJson = JsonSerializer.Serialize(estudiante);

            // Agregar el objeto JSON al cuerpo de la solicitud
            //request.AddStringBody(estudianteJson, ContentType.Json);

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                MessageBox.Show("Estudiante registrado correctamente: " + response.StatusDescription);
                txtCodigo.Text = "";
                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Error al registrar estudiante: " + response.StatusDescription);
            }
        }
    }
}
