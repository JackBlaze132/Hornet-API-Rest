using PClienteEstudiante.view.motorcycle;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClienteEstudiante.view.bodywork
{
    public partial class GUIListBodywork : Form
    {
        private List<Bodywork> bodyworks;
        public GUIListBodywork()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/bodyworks/get", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    bodyworks = JsonSerializer.Deserialize<List<Bodywork>>(response.Content);

                    if (bodyworks != null && bodyworks.Count > 0)
                    {
                        dataGridBody.AutoGenerateColumns = false;
                        dataGridBody.DataSource = bodyworks;
                        dataGridBody.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No bodyworks found.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the list of bodyworks.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (i != checkedListBox2.SelectedIndex)
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
            }
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string baseUrl = "http://localhost:8090/bodyworks/get";
                List<string> queryParams = new List<string>();

                if (checkedListBox2.GetItemChecked(0)) // "YES" Select
                {
                    queryParams.Add("hasSunroof=true");
                }
                else if (checkedListBox2.GetItemChecked(1)) // "NO" Select
                {
                    queryParams.Add("hasSunroof=false");
                }
                // Construir la URL completa con los parámetros de consulta
                string url = baseUrl;
                if (queryParams.Count > 0)
                {
                    url += "?" + string.Join("&", queryParams);
                }
                try
                {
                    // Hacer la solicitud GET al servidor
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Leer y deserializar la respuesta en una lista de motocicletas
                        string responseData = await response.Content.ReadAsStringAsync();
                        var bodyworks = System.Text.Json.JsonSerializer.Deserialize<List<Bodywork>>(responseData);

                        // Asignar los datos al DataGrid
                        dataGridBody.DataSource = bodyworks;
                        dataGridBody.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No bodyworks found with the specified filters." + url);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filtering bodyworks: " + ex.Message);
                }
            }
        }
    }
}
