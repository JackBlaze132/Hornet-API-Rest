using PClienteEstudiante.view.bodywork;
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

namespace PClienteEstudiante.view.searchedAutomobile
{
    public partial class GUIUpdateAutomobile : Form
    {
        private List<Bodywork> bodyworks;
        public GUIUpdateAutomobile()
        {
            InitializeComponent();
        }

        private void btnSearchAutomobile_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo esté lleno.
                if (string.IsNullOrWhiteSpace(txtIdAuto.Text) || !int.TryParse(txtIdAuto.Text, out int automobileId))
                {
                    MessageBox.Show("Please enter a valid ID to search.");
                    ClearForm();
                    return;
                }

                // Definir el parámetro de búsqueda.
                RestRequest request;
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);

                request = new RestRequest($"/automobiles/search?id={automobileId}", Method.Get);

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
                        LoadBodyworks();
                        txtIdAuto.Text = automobile.id.ToString();
                        txtIdAuto.ReadOnly = true;
                        txtBrandAuto.Text = automobile.brand;
                        txtPriceAuto.Text = automobile.price.ToString();
                        txtSnidAuto.Text = automobile.snid;
                        comboBoxBodyAuto.Text = automobile.bodywork != null ? automobile.bodywork.name : "Unassigned";
                        boxABS.Checked = automobile.absBrake;
                        datePickerAuto.Value = automobile.arrivalDate;
                        enableFields();
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

        private void btnUpdateAutomobile_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el ID no esté vacío y sea numérico.
                if (string.IsNullOrWhiteSpace(txtIdAuto.Text) || !int.TryParse(txtIdAuto.Text, out int automobileId))
                {
                    MessageBox.Show("Please enter a valid numeric ID.");
                    return;
                }

                // Obtener el Bodywork seleccionado.
                Bodywork selectedBodywork = (Bodywork)comboBoxBodyAuto.SelectedItem;

                // Crear un objeto Automobile con los valores del formulario.
                var automobile = new Automobile
                {
                    id = automobileId,
                    brand = txtBrandAuto.Text,
                    price = decimal.Parse(txtPriceAuto.Text),
                    snid = txtSnidAuto.Text,
                    absBrake = boxABS.Checked,
                    bodywork = selectedBodywork.id == 0 ? null : selectedBodywork, // Incluir el Bodywork seleccionado.
                    arrivalDate = datePickerAuto.Value
                };

                // Configurar la solicitud PUT al servidor.
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/automobiles/update/{automobile.id}", Method.Put);

                request.AddJsonBody(automobile); // Agregar el JSON al cuerpo de la solicitud.

                var response = client.Execute(request); // Ejecutar la solicitud PUT.

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Automobile updated successfully.");
                    btnReset.PerformClick(); // Limpiar el formulario.
                    automobile = null; // Reiniciar el automóvil buscado.
                }
                else
                {
                    MessageBox.Show("Failed to update the automobile." + response.StatusCode);
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

        private void enableFields()
        {
            txtBrandAuto.ReadOnly = false;
            txtPriceAuto.ReadOnly = false;
            txtSnidAuto.ReadOnly = false;
            comboBoxBodyAuto.Enabled = true;
            boxABS.Enabled = true;
            datePickerAuto.Enabled = true;
        }

        private void enableIdField()
        {
            txtIdAuto.ReadOnly = false;
        }

        private void disableFields()
        {
            txtBrandAuto.ReadOnly = true;
            txtPriceAuto.ReadOnly = true;
            txtSnidAuto.ReadOnly = true;
            comboBoxBodyAuto.Enabled = false;
            boxABS.Enabled = false;
            datePickerAuto.Enabled = false;
        }

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
                        var bodyworkList = new List<Bodywork>
                        {
                            new Bodywork { id = 0, name = "No Assign" } // El id es 0 y name es "Select" para mostrarlo como opción nula
                        };
                        bodyworkList.AddRange(bodyworks);
                        comboBoxBodyAuto.DataSource = bodyworkList;
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

        private void datePickerAuto_ValueChanged(object sender, EventArgs e)
        {
            datePickerAuto.CustomFormat = "dd/MM/yyyy";
        }

        private void btnResetAuto_Click(object sender, EventArgs e)
        {
            ClearForm();
            disableFields();
            enableIdField();
        }
    }
}
