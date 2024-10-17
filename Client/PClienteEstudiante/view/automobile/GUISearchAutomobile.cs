using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClienteEstudiante.view.automobile
{
    public partial class GUISearchAutomobile : Form
    {
        public GUISearchAutomobile()
        {
            InitializeComponent();
        }

        private void txtIdAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSnidAuto_TextChanged(object sender, EventArgs e)
        {

        }

        private void datePickerAuto_ValueChanged(object sender, EventArgs e)
        {
            datePickerAuto.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSearchAutomobile_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que al menos uno de los dos campos esté lleno.
                if (string.IsNullOrWhiteSpace(txtIdAuto.Text) && string.IsNullOrWhiteSpace(txtSnidAuto.Text))
                {
                    MessageBox.Show("Please enter either an ID or SNID to search.");
                    ClearForm();
                    return;
                }

                // Definir el parámetro de búsqueda.
                RestRequest request;
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);

                // Si se proporciona el ID, validar que sea numérico y crear la solicitud con ID.
                if (!string.IsNullOrWhiteSpace(txtIdAuto.Text))
                {
                    if (!int.TryParse(txtIdAuto.Text, out int automobileId))
                    {
                        MessageBox.Show("The ID must be a numeric value.");
                        ClearForm();
                        return;
                    }

                    request = new RestRequest($"/automobiles/search?id={automobileId}", Method.Get);
                }
                else
                {
                    // Si no hay ID, crear la solicitud con el SNID.
                    string snid = txtSnidAuto.Text;
                    request = new RestRequest($"/automobiles/search?snid={snid}", Method.Get);
                }

                var response = client.Execute(request); // Ejecutar la solicitud GET.

                if (response.IsSuccessful)
                {
                    var jsonOptions = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Ignorar mayúsculas y minúsculas en los nombres de propiedades.
                    };

                    // Deserializar la respuesta en un objeto Automobile.
                    var automobile = JsonSerializer.Deserialize<Automobile>(response.Content, jsonOptions);

                    if (automobile != null)
                    {
                        // Llenar los campos del formulario con los datos del automóvil.
                        txtIdAuto.Text = automobile.id.ToString();
                        txtBrandAuto.Text = automobile.brand;
                        txtPriceAuto.Text = automobile.price.ToString();
                        txtSnidAuto.Text = automobile.snid;
                        comboBoxBodyAuto.Text = automobile.bodyworks[0].name;
                        boxABS.Checked = automobile.absBrake;
                        datePickerAuto.Value = automobile.arrivalDate;
                    }
                    else
                    {
                        MessageBox.Show("No automobile found with the provided ID or SNID.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the automobile.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones durante la solicitud.
                MessageBox.Show($"An error occurred: {ex.Message}");
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
