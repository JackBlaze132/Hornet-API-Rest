using System;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUIEditMotorcycle : Form
    {
        private Motorcycle motorcycleToEdit;

        public GUIEditMotorcycle(Motorcycle motorcycle)
        {
            InitializeComponent();
            motorcycleToEdit = motorcycle;
            LoadMotorcycleData();
        }

        private void LoadMotorcycleData()
        {
            txtIdMoto.Text = motorcycleToEdit.id.ToString();
            txtBrandMoto.Text = motorcycleToEdit.brand;
            txtPriceMoto.Text = motorcycleToEdit.price.ToString();
            txtModelMotorcycle.Text = motorcycleToEdit.snid;
            boxABS.Checked = motorcycleToEdit.absBrake;
            txtFroktype.Text = motorcycleToEdit.forkType;
            boxHelmet.Checked = motorcycleToEdit.helmetIncluded;
            datePickerMotorcycle.Value = motorcycleToEdit.arrivalDate;
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
                    this.Close();
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
    }
}
