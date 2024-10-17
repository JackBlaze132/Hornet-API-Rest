using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using RestSharp;

namespace PClienteEstudiante.view.bodywork
{
    // This form provides functionality to search for bodywork records by ID or Name using a REST API.
    public partial class GUISearchBodywork : Form
    {
        private Bodywork searchedBodywork; // Stores the searched bodywork object.

        public GUISearchBodywork()
        {
            InitializeComponent();
        }

        // Event handler for the "Search" button.
        // Sends a GET request to the REST API to search for a bodywork by ID or Name.
        private void btnSearchBody_Click(object sender, EventArgs e)
        {
            string id = txtIdBody.Text;
            string name = txtNameBody.Text;

            // Validate that at least one field is provided.
            if (string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter either an ID or Name.");
                return;
            }

            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                RestRequest request;

                // Determine whether to search by ID or Name.
                if (!string.IsNullOrWhiteSpace(id))
                {
                    request = new RestRequest($"/bodyworks/search?id={id}", Method.Get);
                }
                else
                {
                    request = new RestRequest($"/bodyworks/search?name={name}", Method.Get);
                }

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    // Deserialize the response to a Bodywork object.
                    searchedBodywork = JsonSerializer.Deserialize<Bodywork>(response.Content);

                    if (searchedBodywork != null)
                    {
                        // Display the bodywork details in the corresponding text boxes.
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
                    MessageBox.Show("Failed to retrieve the bodywork.");
                }
            }
            catch (Exception ex)
            {
                // Handle and display any exception that occurs during the request.
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnClearBody_Click(object sender, EventArgs e)
        {
            txtIdBody.Text = string.Empty;
            txtNameBody.Text = string.Empty;
            boxSunroof.Checked = false;
        }
    }
}
