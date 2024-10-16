using System;
using System.Text.Json;
using System.Windows.Forms;
using RestSharp;

namespace PClienteEstudiante.view.bodywork
{
    // This form provides functionality to search for and update bodywork records by ID using a REST API.
    public partial class GUIUpdateBodywork : Form
    {
        private Bodywork searchedBodywork; // Stores the currently selected bodywork object.

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

                if (string.IsNullOrWhiteSpace(txtIdBody.Text))
                {
                    MessageBox.Show("Please enter an ID to search.");
                    return;
                }

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
                        // Populate the text boxes with the bodywork data.
                        txtNameBody.Text = searchedBodywork.name;
                        boxSunroof.Checked = searchedBodywork.hasSunroof;
                        txtNameBody.ReadOnly = false;
                        boxSunroof.Enabled = true;
                        txtIdBody.ReadOnly = true;
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
            if (searchedBodywork == null)
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
                searchedBodywork.id = int.Parse(txtIdBody.Text);
                searchedBodywork.name = txtNameBody.Text;
                searchedBodywork.hasSunroof = boxSunroof.Checked;

                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/bodyworks/update/{searchedBodywork.id}", Method.Put);

                // Serialize the updated bodywork object into JSON.
                string bodyworkJson = JsonSerializer.Serialize(searchedBodywork);
                request.AddJsonBody(bodyworkJson);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Bodywork updated successfully.");
                    searchedBodywork = null; // Reset the selected bodywork
                    clearField();
                    btnReset.PerformClick();
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

        private void btnResetBody_Click(object sender, EventArgs e)
        {
            clearField();
            enableIdField();
            disableFields();
        }

        private void clearField()
        {
            txtIdBody.Text = "";
            txtNameBody.Text = "";
            boxSunroof.Checked = false;
        }

        private void enableIdField()
        {
            txtIdBody.ReadOnly = false;

        }

        private void disableFields()
        {
            txtNameBody.ReadOnly = true;
            boxSunroof.Enabled = false;
        }
    }
}
