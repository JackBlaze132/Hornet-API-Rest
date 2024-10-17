using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUIDeleteMotorcycle : Form
    {
        private Motorcycle motorcycleToEdit; // Store the motorcycle to be edited or deleted.

        public GUIDeleteMotorcycle()
        {
            InitializeComponent();
        }

        // Event handler for the "Search" button.
        private void btnSearchMoto_Click(object sender, EventArgs e)
        {
            string id = txtIdMoto.Text;

            // Validate that the ID field is not empty.
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please enter a motorcycle ID.");
                clearFields(); // Clear the fields if no valid ID is provided.
                return;
            }

            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/motorcycles/search?id={id}", Method.Get);

                var response = client.Execute(request); // Execute the GET request.

                if (response.IsSuccessful)
                {
                    // Deserialize the response into a Motorcycle object.
                    motorcycleToEdit = JsonSerializer.Deserialize<Motorcycle>(response.Content);

                    if (motorcycleToEdit != null)
                    {
                        // Populate the fields with the motorcycle data.
                        txtBrandMoto.Text = motorcycleToEdit.brand;
                        txtPriceMoto.Text = motorcycleToEdit.price.ToString();
                        txtModelMotorcycle.Text = motorcycleToEdit.snid;
                        boxABS.Checked = motorcycleToEdit.absBrake;
                        txtFroktype.Text = motorcycleToEdit.forkType;
                        boxHelmet.Checked = motorcycleToEdit.helmetIncluded;
                        datePickerMotorcycle.Value = motorcycleToEdit.arrivalDate;
                    }
                    else
                    {
                        MessageBox.Show("No motorcycle found with the provided ID.");
                        clearFields(); // Clear the fields if no motorcycle is found.
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the motorcycle.");
                    clearFields(); // Clear the fields on failure.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Event handler for the "Delete" button.
        private void btnDeleteMoto_Click(object sender, EventArgs e)
        {
            // Validate if a motorcycle is selected for deletion.
            if (motorcycleToEdit == null)
            {
                MessageBox.Show("Please search for a motorcycle first.");
                return;
            }

            // Confirm the deletion with the user.
            var confirmResult = MessageBox.Show("Are you sure you want to delete this motorcycle?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var options = new RestClientOptions("http://localhost:8090");
                    var client = new RestClient(options);
                    var request = new RestRequest($"/motorcycles/delete/{motorcycleToEdit.id}", Method.Delete);

                    var response = client.Execute(request); // Execute the DELETE request.

                    if (response.IsSuccessful)
                    {
                        MessageBox.Show("Motorcycle deleted successfully.");
                        clearFields(); // Clear the form after successful deletion.
                        motorcycleToEdit = null; // Reset the motorcycle object.
                        txtIdMoto.Text = ""; // Clear the ID field.
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

        // Clear all input fields on the form.
        private void clearFields()
        {
            txtBrandMoto.Text = "";
            txtPriceMoto.Text = "";
            txtModelMotorcycle.Text = "";
            txtFroktype.Text = "";
            boxABS.Checked = false;
            boxHelmet.Checked = false;
            datePickerMotorcycle.Value = DateTime.Now; // Reset to current date.
        }
    }
}
