using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using PClienteEstudiante.view.motorcycle;

namespace PClienteEstudiante.view
{
    public partial class GUIAddMotorcycle : Form
    {
        public GUIAddMotorcycle()
        {
            InitializeComponent();
        }

        private void btnAddMoto_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/motorcycles/add", Method.Post);

                var motorcycle = new Motorcycle
                {
                    id = int.Parse(txtIdMoto.Text),
                    brand = txtBrandMoto.Text,
                    price = decimal.Parse(txtPriceMoto.Text),
                    snid = txtModelMotorcycle.Text,
                    absBrake = boxABS.Checked,
                    forkType = txtFroktype.Text,
                    helmetIncluded = boxHelmet.Checked,
                    arrivalDate = datePickerMotorcycle.Value
                };

                request.AddJsonBody(motorcycle);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Motorcycle added successfully: " + response.StatusDescription);
                    txtIdMoto.Text = "";
                    txtBrandMoto.Text = "";
                    txtPriceMoto.Text = "";
                    txtModelMotorcycle.Text = "";
                    boxABS.Checked = false;
                    txtFroktype.Text = "";
                    boxHelmet.Checked = false;
                    datePickerMotorcycle.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Error adding motorcycle: " + response.StatusDescription);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void txtIdMoto_TextChanged(object sender, EventArgs e) { }
        private void txtBrandMoto_TextChanged(object sender, EventArgs e) { }
        private void txtPriceMoto_TextChanged(object sender, EventArgs e) { }
        private void txtModelMotorcycle_TextChanged(object sender, EventArgs e) { }
        private void boxABS_CheckedChanged(object sender, EventArgs e) { }
        private void txtFroktype_TextChanged(object sender, EventArgs e) { }
        private void boxHelmet_CheckedChanged(object sender, EventArgs e) { }
        private void datePickerMotorcycle_ValueChanged(object sender, EventArgs e) { }
    }

}
