using System;
using System.Text.Json;
using System.Windows.Forms;
using RestSharp;

namespace PClienteEstudiante.view.bodywork
{
    // This form provides functionality to search for and update bodywork records by ID using a REST API.
    public partial class GUIUpdateBodywork : Form
    {
        private Bodywork serchedBodywork; // Stores the currently selected bodywork object.

        // Initializes the form components.
        public GUIUpdateBodywork()
        {
            InitializeComponent();
        }

        // Event handler for the "Search" button.
        // Sends a GET request to the REST API to search for a bodywork by ID.
        private void btnSearchBody_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/bodyworks/search?id={txtIdBody.Text}", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    // Deserialize the response to a Bodywork object.
                    serchedBodywork = JsonSerializer.Deserialize<Bodywork>(response.Content);

                    if (serchedBodywork != null)
                    {
                        // Populate the text boxes with the bodywork data.
                        txtNameBody.Text = serchedBodywork.name;
                        txtNameBody.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("No bodywork found with the provided ID.");
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

        // Event handler for the "Update" button.
        // Sends a PUT request to the REST API to update the bodywork by ID.
        private void btnUpdateBody_Click(object sender, EventArgs e)
        {
            if (serchedBodywork == null)
            {
                MessageBox.Show("Please search for a bodywork first.");
                return;
            }

            if (string.IsNullOrEmpty(txtNameBody.Text))
            {
                MessageBox.Show("Please provide a valid name for the bodywork.");
                return;
            }

            try
            {
                // Update the selected bodywork object with the new data.
                serchedBodywork.id = int.Parse(txtIdBody.Text);
                serchedBodywork.name = txtNameBody.Text;

                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/bodyworks/update/{serchedBodywork.id}", Method.Put);

                // Serialize the updated bodywork object into JSON.
                string bodyworkJson = JsonSerializer.Serialize(serchedBodywork);
                request.AddJsonBody(bodyworkJson);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Bodywork updated successfully.");
                    serchedBodywork = null; // Reset the selected bodywork
                    txtIdBody.Text = "";
                    txtNameBody.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to update the bodywork.");
                }
            }
            catch (Exception ex)
            {
                // Handle and display any exception that occurs during the update.
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
