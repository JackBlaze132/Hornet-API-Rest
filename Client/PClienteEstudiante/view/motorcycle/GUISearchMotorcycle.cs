using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUISearchMotorcycle : Form
    {
        public GUISearchMotorcycle()
        {
            InitializeComponent();
        }

        private void txtIdMoto_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridMoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSearchMoto_Click(object sender, EventArgs e)
        {
            string id = txtIdMoto.Text;
            string snid = txtSnid.Text;

            if (string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(snid))
            {
                MessageBox.Show("Please enter either an ID or SNID.");
                return;
            }

            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                RestRequest request;

                if (!string.IsNullOrWhiteSpace(id))
                {
                    request = new RestRequest($"/motorcycles/search?id={id}", Method.Get);
                }
                else
                {
                    request = new RestRequest($"/motorcycles/search?snid={snid}", Method.Get);
                }

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var motorcycle = JsonSerializer.Deserialize<Motorcycle>(response.Content);

                    if (motorcycle != null)
                    {
                        dataGridMoto.DataSource = new List<Motorcycle> { motorcycle };
                        dataGridMoto.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No motorcycle found.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the motorcycle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }


}
