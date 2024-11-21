using PClienteEstudiante.view.bodywork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using RestSharp;

namespace PClienteEstudiante.view.searchedAutomobile
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
                // Crear una lista que siempre incluya la opción "No Assign"
                var bodyworkList = new List<Bodywork>
                {
                    new Bodywork { id = 0, name = "No Assign" } // The "No Assign" option
                };

                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/bodyworks/get", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    bodyworks = JsonSerializer.Deserialize<List<Bodywork>>(response.Content);

                    if (bodyworks != null && bodyworks.Count > 0)
                    {
                        // Agregar los resultados obtenidos a la lista
                        bodyworkList.AddRange(bodyworks);
                    }
                    else
                    {
                        MessageBox.Show("No bodyworks found.");
                    }
                }

                // Configurar el ComboBox con la lista de bodyworks, incluyendo "No Assign"
                comboBoxBodyAuto.DataSource = bodyworkList;
                comboBoxBodyAuto.DisplayMember = "name"; // Display the bodywork name
                comboBoxBodyAuto.ValueMember = "id"; // Use the bodywork ID as the value
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");

                // En caso de excepción, asegurar que el ComboBox tiene solo la opción "No Assign"
                comboBoxBodyAuto.DataSource = new List<Bodywork>
                {
                    new Bodywork { id = 0, name = "No Assign" }
                };
                comboBoxBodyAuto.DisplayMember = "name";
                comboBoxBodyAuto.ValueMember = "id";
            }
        }


        // Event handler for the "Add" button.
        // Sends a POST request to the server to add a new automobile.
        private void btnAddAutomobile_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/automobiles/add", Method.Post);
                // Get the selected bodywork from the ComboBox.
                Bodywork selectedBodywork = (Bodywork)comboBoxBodyAuto.SelectedItem;

                // Create a new Automobile object with the form inputs.
                var automobile = new Automobile
                {
                    id = int.Parse(txtIdAuto.Text),
                    brand = txtBrandAuto.Text,
                    price = decimal.Parse(txtPriceAuto.Text),
                    snid = txtSnidAuto.Text,
                    absBrake = boxABS.Checked,
                    bodywork = selectedBodywork.id == 0 ? null : selectedBodywork, // Add the selected bodywork object
                    arrivalDate = datePickerAuto.Value
                };

                // Serialize the automobile object, sending only the IDs of the bodyworks.
                request.AddJsonBody(automobile);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Automobile added successfully. " + response.StatusDescription);
                    txtIdAuto.Text = "";
                    txtBrandAuto.Text = "";
                    txtPriceAuto.Text = "";
                    txtSnidAuto.Text = "";
                    boxABS.Checked = false;
                    LoadBodyworks(); // Reload the bodyworks after adding a new automobile.
                    comboBoxBodyAuto.SelectedIndex = 0; // Reset ComboBox selection
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
