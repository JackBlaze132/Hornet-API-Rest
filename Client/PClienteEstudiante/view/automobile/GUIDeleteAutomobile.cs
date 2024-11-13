using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using RestSharp;

namespace PClienteEstudiante.view.automobile
{
    public partial class GUIDeleteAutomobile : Form
    {
        // Store the currently selected automobile for deletion.
        private Automobile searchedAutomobile;

        public GUIDeleteAutomobile()
        {
            InitializeComponent(); // Initialize the form components.
        }

        // Event handler for the "Search" button.
        // Sends a GET request to retrieve the automobile by ID from the server.
        private void btnSearchAuto_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate if the ID field is empty.
                if (string.IsNullOrWhiteSpace(txtIdAuto.Text))
                {
                    MessageBox.Show("Please enter a valid automobile ID.");
                    ClearForm(); // Clear the form fields.
                    return;
                }

                // Validate if the input is a valid integer.
                if (!int.TryParse(txtIdAuto.Text, out int automobileId))
                {
                    MessageBox.Show("The ID must be a numeric value.");
                    ClearForm(); // Clear the form fields.
                    return;
                }

                // Set up the REST client and request.
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/automobiles/search?id={automobileId}", Method.Get);

                var response = client.Execute(request); // Execute the GET request.

                if (response.IsSuccessful)
                {

                    searchedAutomobile = JsonSerializer.Deserialize<Automobile>(response.Content);

                    if (searchedAutomobile != null)
                    {
                        // Populate the form fields with the automobile data.
                        txtBrandAuto.Text = searchedAutomobile.brand;
                        txtPriceAuto.Text = searchedAutomobile.price.ToString();
                        txtSnidAuto.Text = searchedAutomobile.snid;
                        comboBoxBodyAuto.Text = searchedAutomobile.bodywork != null ? searchedAutomobile.bodywork.name : "Unassigned";
                        boxABS.Checked = searchedAutomobile.absBrake;
                        datePickerAuto.Value = searchedAutomobile.arrivalDate;
                    }
                    else
                    {
                        MessageBox.Show("No automobile found with the provided ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the automobile.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions during the request.
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        // Event handler for the "Delete" button.
        // Sends a DELETE request to remove the selected automobile from the server.
        private void btnDeleteAuto_Click(object sender, EventArgs e)
        {
            if (searchedAutomobile == null) // Check if an automobile was selected.
            {
                MessageBox.Show("Please search for an automobile first.");
                return;
            }

            // Confirm the deletion with the user.
            var confirmResult = MessageBox.Show("Are you sure you want to delete this automobile?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes) // If the user confirms deletion.
            {
                try
                {
                    // Set up the REST client and request.
                    var options = new RestClientOptions("http://localhost:8090");
                    var client = new RestClient(options);
                    var request = new RestRequest($"/automobiles/delete/{searchedAutomobile.id}", Method.Delete);

                    var response = client.Execute(request); // Execute the DELETE request.

                    if (response.IsSuccessful) // Check if the deletion was successful.
                    {
                        MessageBox.Show("Automobile deleted successfully.");
                        ClearForm(); // Clear the form after successful deletion.
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the automobile."); // Handle deletion failure.
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions during the request.
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled."); // If the user cancels the deletion.
            }
        }

        // Clear all input fields on the form.
        private void ClearForm()
        {
            txtIdAuto.Text = ""; // Clear the ID field.
            txtBrandAuto.Text = ""; // Clear the brand field.
            txtPriceAuto.Text = ""; // Clear the price field.
            txtSnidAuto.Text = ""; // Clear the SNID field.
            boxABS.Checked = false; // Uncheck the ABS checkbox.
            comboBoxBodyAuto.Text = ""; // Clear the ComboBox selection.
            datePickerAuto.Text = ""; // Clear the DateTimePicker field.
            searchedAutomobile = null; // Reset the selected automobile object.
        }

        // Event handler to format the date in the DateTimePicker.
        private void datePickerAuto_ValueChanged(object sender, EventArgs e)
        {
            // Set the custom date format to "dd/MM/yyyy".
            datePickerAuto.CustomFormat = "dd/MM/yyyy";
        }
    }
}
