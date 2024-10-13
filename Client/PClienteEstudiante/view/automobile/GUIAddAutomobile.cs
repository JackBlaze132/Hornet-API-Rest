using PClienteEstudiante.view.bodywork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using RestSharp;

namespace PClienteEstudiante.view.automobile
{
    public partial class GUIAddAutomobile : Form
    {
        private List<Bodywork> bodyworks; // Stores the list of bodyworks.

        public GUIAddAutomobile()
        {
            InitializeComponent();
            LoadBodyworks(); // Load the bodyworks into the ComboBox on form initialization.
        }

        // Load bodyworks from the API and populate the ComboBox.
        private void LoadBodyworks()
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/bodyworks/get", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    bodyworks = JsonSerializer.Deserialize<List<Bodywork>>(response.Content);

                    if (bodyworks != null && bodyworks.Count > 0)
                    {
                        comboBoxBodyAuto.DataSource = bodyworks;
                        comboBoxBodyAuto.DisplayMember = "name"; // Display the bodywork name
                        comboBoxBodyAuto.ValueMember = "id"; // Use the bodywork ID as the value
                    }
                    else
                    {
                        MessageBox.Show("No bodyworks found." + response.StatusDescription);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the bodyworks." + response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Event handler for the "Add" button.
        // Sends a POST request to the server to add a new automobile.
        private void btnAddAutomobile_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected bodywork from the ComboBox.
                Bodywork selectedBodywork = (Bodywork)comboBoxBodyAuto.SelectedItem;

                // Ensure a bodywork is selected.
                if (selectedBodywork == null)
                {
                    MessageBox.Show("Please select a bodywork.");
                    return;
                }

                // Create a new Automobile object with the form inputs.
                var automobile = new Automobile
                {
                    id = int.Parse(txtIdAuto.Text),
                    brand = txtBrandAuto.Text,
                    price = decimal.Parse(txtPriceAuto.Text),
                    snid = txtSnidAuto.Text,
                    absBrake = boxABS.Checked,
                    bodyworks = new List<Bodywork> { selectedBodywork }, // Add the selected bodywork object
                    arrivalDate = datePickerAuto.Value
                };

                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/automobiles/add", Method.Post);

                // Serialize the automobile object, sending only the IDs of the bodyworks.
                var serializedAutomobile = new
                {
                    automobile.id,
                    automobile.brand,
                    automobile.price,
                    automobile.snid,
                    automobile.absBrake,
                    bodyworks = automobile.bodyworks.Select(b => b.id).ToList(), // Send only the bodywork IDs
                    automobile.arrivalDate
                };

                string automobileJson = JsonSerializer.Serialize(serializedAutomobile);
                request.AddJsonBody(automobileJson);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Automobile added successfully. " + response.StatusDescription);
                    txtIdAuto.Text = "";
                    txtBrandAuto.Text = "";
                    txtPriceAuto.Text = "";
                    txtSnidAuto.Text = "";
                    boxABS.Checked = false;
                    comboBoxBodyAuto.SelectedIndex = -1; // Reset ComboBox selection
                    datePickerAuto.Value = DateTime.Now; // Clear the form after successful addition.
                }
                else
                {
                    MessageBox.Show("Failed to add the automobile." + response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void datePickerAuto_ValueChanged(object sender, EventArgs e)
        {
            datePickerAuto.CustomFormat = "dd/MM/yyyy";
        }

        private void txtSnidAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void boxABS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBodyAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrandAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
