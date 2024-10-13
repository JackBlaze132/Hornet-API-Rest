using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUIUpdateMotorcycle : Form
    {
        private Motorcycle motorcycleToEdit;

        public GUIUpdateMotorcycle()
        {
            InitializeComponent();
        }


        private void btnSearchMoto_Click(object sender, EventArgs e)
        {
            string id = txtIdMoto.Text;

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please enter a motorcycle ID.");
                clearFields();
                return;
            }

            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/motorcycles/search?id={id}", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    motorcycleToEdit = JsonSerializer.Deserialize<Motorcycle>(response.Content);

                    if (motorcycleToEdit != null)
                    {
                        txtBrandMoto.Text = motorcycleToEdit.brand;
                        txtPriceMoto.Text = motorcycleToEdit.price.ToString();
                        txtModelMotorcycle.Text = motorcycleToEdit.snid;
                        boxABS.Checked = motorcycleToEdit.absBrake;
                        txtFroktype.Text = motorcycleToEdit.forkType;
                        boxHelmet.Checked = motorcycleToEdit.helmetIncluded;
                        datePickerMotorcycle.Value = motorcycleToEdit.arrivalDate;
                        enableFields();
                    }
                    else
                    {
                        MessageBox.Show("No motorcycle found with the provided ID.");
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

        private void btnSaveMoto_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update this motorcycle?",
                                                "Confirm Update",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.No)
            {
                MessageBox.Show("Update cancelled.");
                return;
            }

            try
            {
                motorcycleToEdit.brand = txtBrandMoto.Text;
                motorcycleToEdit.price = decimal.Parse(txtPriceMoto.Text);
                motorcycleToEdit.snid = txtModelMotorcycle.Text;
                motorcycleToEdit.absBrake = boxABS.Checked;
                motorcycleToEdit.forkType = txtFroktype.Text;
                motorcycleToEdit.helmetIncluded = boxHelmet.Checked;
                motorcycleToEdit.arrivalDate = datePickerMotorcycle.Value;

                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest($"/motorcycles/update/{motorcycleToEdit.id}", Method.Put);
                request.AddJsonBody(motorcycleToEdit);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Motorcycle updated successfully.");
                    this.DialogResult = DialogResult.OK;
                    clearFields();
                    disableFields();
                }
                else
                {
                    MessageBox.Show("Failed to update the motorcycle.");
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

        private void enableFields()
        {
            txtBrandMoto.ReadOnly = false;
            txtPriceMoto.ReadOnly = false;
            txtModelMotorcycle.ReadOnly = false;
            txtFroktype.ReadOnly = false;
            boxABS.Enabled = true;
            boxHelmet.Enabled = true;
            datePickerMotorcycle.Enabled = true;
        }

        private void disableFields()
        {
            txtBrandMoto.ReadOnly = true;
            txtPriceMoto.ReadOnly = true;
            txtModelMotorcycle.ReadOnly = true;
            txtFroktype.ReadOnly = true;
            boxABS.Enabled = false;
            boxHelmet.Enabled = false;
            datePickerMotorcycle.Enabled = false;
        }

        private void clearFields()
        {
            txtBrandMoto.Text = "";
            txtPriceMoto.Text = "";
            txtModelMotorcycle.Text = "";
            txtFroktype.Text = "";
            boxABS.Checked = false;
            boxHelmet.Checked = false;
            datePickerMotorcycle.Text = "";
        }

    }
}
