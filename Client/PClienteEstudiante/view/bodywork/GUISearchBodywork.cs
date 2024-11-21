using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using RestSharp;

namespace PClienteEstudiante.view.bodywork
{
    public partial class GUISearchBodywork : Form
    {
        private Bodywork searchedBodywork;

        public GUISearchBodywork()
        {
            InitializeComponent();
        }

        private void btnSearchBody_Click(object sender, EventArgs e)
        {
            string id = txtIdBody.Text.Trim();
            string name = txtNameBody.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter either an ID or Name.");
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                var client = new RestClient("http://localhost:8090");
                string query = "";

                // Agregar parámetros dinámicamente
                if (!string.IsNullOrWhiteSpace(id)) query += $"id={id}&";
                if (!string.IsNullOrWhiteSpace(name)) query += $"name={name}";

                var request = new RestRequest($"/bodyworks/search?{query.TrimEnd('&')}", Method.Get);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Asegura que coincida con las propiedades del modelo
                    };

                    // Deserializar a una lista si el endpoint soporta múltiples resultados
                    searchedBodywork = JsonSerializer.Deserialize<Bodywork>(response.Content, options);

                    if (searchedBodywork != null)
                    {
                        // Mostrar el primer resultado en los campos (puedes ajustar según tus necesidades)
                        txtIdBody.Text = searchedBodywork.id.ToString();
                        txtNameBody.Text = searchedBodywork.name;
                        boxSunroof.Checked = searchedBodywork.hasSunroof;
                    }
                    else
                    {
                        MessageBox.Show("No bodywork found.");
                    }
                }
                else
                {
                    // Mostrar errores específicos
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("No bodywork found for the provided criteria.");
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusDescription}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnClearBody_Click(object sender, EventArgs e)
        {
            txtIdBody.Clear();
            txtNameBody.Clear();
            boxSunroof.Checked = false;
        }
    }
}
