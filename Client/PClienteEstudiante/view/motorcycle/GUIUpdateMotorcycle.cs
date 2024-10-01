using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUIUpdateMotorcycle : Form
    {
        private Motorcycle selectedMotorcycle;

        public GUIUpdateMotorcycle()
        {
            InitializeComponent();
        }

        private void txtIdMoto_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridMoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSearchMoto_Click(object sender, EventArgs e)
        {
            string id = txtIdMoto.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please enter a motorcycle ID.");
                return;
            }

            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/motorcycles/search?id={id}", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    selectedMotorcycle = JsonSerializer.Deserialize<Motorcycle>(response.Content);

                    if (selectedMotorcycle != null)
                    {
                        dataGridMoto.DataSource = new List<Motorcycle> { selectedMotorcycle };
                        dataGridMoto.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No motorcycle found with the provided ID.");
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

        private void btnUpdateMoto_Click(object sender, EventArgs e)
        {
            if (selectedMotorcycle == null)
            {
                MessageBox.Show("Please search and select a motorcycle to update.");
                return;
            }

            GUIEditMotorcycle guiEditMotorcycle = new GUIEditMotorcycle(selectedMotorcycle);
            var dialogResult = guiEditMotorcycle.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                btnSearchMoto_Click(sender, e);
            }
        }
    }
}
