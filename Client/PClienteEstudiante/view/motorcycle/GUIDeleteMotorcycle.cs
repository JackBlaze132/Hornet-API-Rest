using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using System.Collections.Generic;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUIDeleteMotorcycle : Form
    {
        private Motorcycle selectedMotorcycle;

        public GUIDeleteMotorcycle()
        {
            InitializeComponent();
        }

        private void dataGridMoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtIdMoto_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSearchMoto_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/motorcycles/search?id={txtIdMoto.Text}", Method.Get);

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

        private void btnDeleteMoto_Click(object sender, EventArgs e)
        {
            if (selectedMotorcycle == null)
            {
                MessageBox.Show("Please search for a motorcycle first.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this motorcycle?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var options = new RestClientOptions("http://localhost:8090");
                    var client = new RestClient(options);
                    var request = new RestRequest($"/motorcycles/delete/{selectedMotorcycle.id}", Method.Delete);

                    var response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
                        MessageBox.Show("Motorcycle deleted successfully.");
                        dataGridMoto.DataSource = null;
                        txtIdMoto.Text = "";
                        selectedMotorcycle = null;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the motorcycle.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.");
            }
        }
    }

}
