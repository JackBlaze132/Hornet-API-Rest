using System;
using System.Text.Json;
using System.Windows.Forms;
using RestSharp;

namespace PClienteEstudiante.view.bodywork
{
    // This form provides functionality to search for and delete bodywork records by ID using a REST API.
    public partial class GUIDeleteBodywork : Form
    {
        private Bodywork searchedBodywork; // Stores the currently selected bodywork object.

        // Initializes the form components.
        public GUIDeleteBodywork()
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
                    searchedBodywork = JsonSerializer.Deserialize<Bodywork>(response.Content);

                    if (searchedBodywork != null)
                    {
                        // Display the bodywork name in the corresponding text box.
                        txtNameBody.Text = searchedBodywork.name;
                        boxSunroof.Checked = searchedBodywork.hasSunroof;
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

        // Event handler for the "Delete" button.
        // Sends a DELETE request to the REST API to delete the bodywork by ID.
        private void btnDeleteBody_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdBody.Text))
            {
                MessageBox.Show("Please provide a valid Bodywork ID.");
                return;
            }

            // Confirm the deletion with the user.
            var confirmResult = MessageBox.Show("Are you sure you want to delete this bodywork?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var options = new RestClientOptions("http://localhost:8090");
                    var client = new RestClient(options);
                    var request = new RestRequest($"/bodyworks/delete/{txtIdBody.Text}", Method.Delete);

                    var response = client.Execute(request);

                    if (response.IsSuccessful)
                    {
                        MessageBox.Show("Bodywork deleted successfully.");
                        // Clear the text boxes and reset the selected bodywork.
                        txtIdBody.Text = "";
                        txtNameBody.Text = "";
                        boxSunroof.Checked = false;
                        searchedBodywork = null;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the bodywork.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle and display any exception that occurs during the deletion.
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
