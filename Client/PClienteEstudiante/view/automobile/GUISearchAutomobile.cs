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
    public partial class GUISearchAutomobile : Form
    {
        private Automobile searchedAutomobile;
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
            string id = txtIdAuto.Text.Trim();
            string snid = txtSnidAuto.Text.Trim();

            // Validar que al menos uno de los campos esté lleno
            if (string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(snid))
            {
                MessageBox.Show("Please enter either an ID or SNID to search.");
                ClearForm();
                return;
            }

            Cursor = Cursors.WaitCursor;

            try
            {
                var client = new RestClient("http://localhost:8090");
                string query = "";

                // Construir el query dinámicamente
                if (!string.IsNullOrWhiteSpace(id))
                {
                    if (!int.TryParse(id, out int automobileId))
                    {
                        MessageBox.Show("The ID must be a numeric value.");
                        ClearForm();
                        return;
                    }
                    query += $"id={automobileId}&";
                }

                if (!string.IsNullOrWhiteSpace(snid))
                {
                    query += $"snid={snid}";
                }

                var request = new RestRequest($"/automobiles/search?{query.TrimEnd('&')}", Method.Get);
                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Ignorar mayúsculas y minúsculas en los nombres de propiedades
                    };

                    // Deserializar la respuesta en una lista de automóviles
                    searchedAutomobile = JsonSerializer.Deserialize<Automobile>(response.Content, options);

                    if (searchedAutomobile != null)
                    {
                        // Mostrar el primer resultado
                        txtIdAuto.Text = searchedAutomobile.id.ToString();
                        txtBrandAuto.Text = searchedAutomobile.brand;
                        txtPriceAuto.Text = searchedAutomobile.price.ToString();
                        txtSnidAuto.Text = searchedAutomobile.snid;
                        comboBoxBodyAuto.Text = searchedAutomobile.bodywork != null ? searchedAutomobile.bodywork.name : "Unassigned";
                        boxABS.Checked = searchedAutomobile.absBrake;
                        datePickerAuto.Value = searchedAutomobile.arrivalDate;
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
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                Cursor = Cursors.Default;
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
