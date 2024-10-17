using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUISearchMotorcycle : Form
    {
        public GUISearchMotorcycle()
        {
            InitializeComponent();
        }

        private void txtIdMoto_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridMoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSearchMoto_Click(object sender, EventArgs e)
        {
            string id = txtIdMoto.Text;
            string snid = txtSnid.Text;

            // Validar que al menos uno de los campos esté lleno.
            if (string.IsNullOrWhiteSpace(id) && string.IsNullOrWhiteSpace(snid))
            {
                MessageBox.Show("Please enter either an ID or SNID.");
                clearFields();
                return;
            }

            try
            {
                // Configurar cliente REST y la solicitud.
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                RestRequest request;

                // Crear la solicitud con ID o SNID, según corresponda.
                if (!string.IsNullOrWhiteSpace(id))
                {
                    request = new RestRequest($"/motorcycles/search?id={id}", Method.Get);
                }
                else
                {
                    request = new RestRequest($"/motorcycles/search?snid={snid}", Method.Get);
                }

                var response = client.Execute(request); // Ejecutar la solicitud GET.

                if (response.IsSuccessful)
                {
                    var jsonOptions = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true // Ignorar mayúsculas y minúsculas.
                    };

                    // Deserializar la respuesta en un objeto Motorcycle.
                    var motorcycle = JsonSerializer.Deserialize<Motorcycle>(response.Content, jsonOptions);

                    if (motorcycle != null)
                    {
                        // Colocar los datos del motocicleta en los campos del formulario.
                        txtIdMoto.Text = motorcycle.id.ToString();
                        txtBrandMoto.Text = motorcycle.brand;
                        txtPriceMoto.Text = motorcycle.price.ToString();
                        txtSnid.Text = motorcycle.snid;
                        boxABS.Checked = motorcycle.absBrake;
                        txtFroktype.Text = motorcycle.forkType;
                        boxHelmet.Checked = motorcycle.helmetIncluded;
                        datePickerMotorcycle.Value = motorcycle.arrivalDate;
                    }
                    else
                    {
                        MessageBox.Show("No motorcycle found with the provided ID or SNID.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the motorcycle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void clearFields()
        {
            txtIdMoto.Text = "";
            txtBrandMoto.Text = "";
            txtPriceMoto.Text = "";
            txtSnid.Text = "";
            txtFroktype.Text = "";
            boxABS.Checked = false;
            boxHelmet.Checked = false;
            datePickerMotorcycle.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }


}
