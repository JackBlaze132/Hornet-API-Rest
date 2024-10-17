using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using System.Linq;
using System.Net.Http;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUIListMotorcycle : Form
    {
        private List<Motorcycle> allMotorcycles;
        public GUIListMotorcycle()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != checkedListBox1.SelectedIndex)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
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


        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dataGridMoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/motorcycles/get", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    allMotorcycles = JsonSerializer.Deserialize<List<Motorcycle>>(response.Content);

                    if (allMotorcycles != null && allMotorcycles.Count > 0)
                    {
                        dataGridMoto.AutoGenerateColumns = false;
                        dataGridMoto.DataSource = allMotorcycles;
                        dataGridMoto.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No motorcycles found.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the list of motorcycles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void Filter_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                // Construir la URL base del endpoint
                string baseUrl = "http://localhost:8090/motorcycles/get";
                List<string> queryParams = new List<string>();

                // Añadir filtro de Helmet Included si está seleccionado
                if (checkedListBox1.GetItemChecked(0)) // "YES" Select
                {
                    queryParams.Add("helmetIncluded=true");
                }
                else if (checkedListBox1.GetItemChecked(1)) // "NOT" Select
                {
                    queryParams.Add("helmetIncluded=false");
                }

                // Añadir filtro de ABS Brake si está seleccionado
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
                        // Leer y deserializar la respuesta en una lista de motocicletas
                        string responseData = await response.Content.ReadAsStringAsync();
                        var motorcycles = System.Text.Json.JsonSerializer.Deserialize<List<Motorcycle>>(responseData);

                        // Asignar los datos al DataGrid
                        dataGridMoto.DataSource = motorcycles;
                        dataGridMoto.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No motorcycles found with the specified filters.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while filtering motorcycles: " + ex.Message);
                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
    

