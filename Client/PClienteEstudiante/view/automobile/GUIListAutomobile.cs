using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using PClienteEstudiante.view.bodywork;
using RestSharp;

namespace PClienteEstudiante.view.searchedAutomobile
{
    public partial class GUIListAutomobile : Form
    {
        private List<Automobile> allAutomobiles; // Stores the list of automobiles.

        public GUIListAutomobile()
        {
            InitializeComponent();
        }

        // Event handler for the "List" button.
        // Sends a GET request to the REST API to retrieve the list of automobiles.
        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/automobiles/get", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    // Deserialize the response to a list of Automobile objects.
                    allAutomobiles = JsonSerializer.Deserialize<List<Automobile>>(response.Content);

                    if (allAutomobiles != null && allAutomobiles.Count > 0)
                    {
                        // Transform the list of bodyworks to display only names.
                        var displayList = allAutomobiles.Select(auto => new
                        {
                            auto.id,
                            auto.brand,
                            auto.price,
                            auto.snid,
                            auto.absBrake,
                            bodyworkName = auto.bodywork?.name ?? "N/A", // Acceso directo a 'bodywork' en singular
                            auto.arrivalDate
                        }).ToList();

                        // Configure the DataGridView to display the automobiles.
                        dataGridAutomobile.AutoGenerateColumns = true;
                        dataGridAutomobile.DataSource = displayList;
                        dataGridAutomobile.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No automobiles found.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the list of automobiles.");
                }
            }
            catch (Exception ex)
            {
                // Handle and display any exception that occurs.
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                // Construir la URL base del endpoint
                string baseUrl = "http://localhost:8090/automobiles/get";
                List<string> queryParams = new List<string>();

                // Añadir filtro de ABS Brake si está seleccionado en CheckedListBox2
                if (checkedListBox2.GetItemChecked(0)) // "YES" Select
                {
                    queryParams.Add("absBrake=true");
                }
                else if (checkedListBox2.GetItemChecked(1)) // "NO" Select
                {
                    queryParams.Add("absBrake=false");
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
                        // Leer y deserializar la respuesta en una lista de automóviles
                        string responseData = await response.Content.ReadAsStringAsync();
                        var automobiles = System.Text.Json.JsonSerializer.Deserialize<List<Automobile>>(responseData);

                        // Asignar los datos al DataGrid
                        dataGridAutomobile.DataSource = automobiles;
                        dataGridAutomobile.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No automobiles found with the specified filters.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filtering automobiles: " + ex.Message);
                }
            }
        }

    }
}
