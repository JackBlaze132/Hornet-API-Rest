using System;
using RestSharp;
using System.Windows.Forms;

namespace PClienteEstudiante.view.bodywork
{
    public partial class GUIAddBodywork : Form
    {
        public GUIAddBodywork()
        {
            InitializeComponent();
        }

        private void btnAddMoto_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("http://localhost:8090");
                var request = new RestRequest("/bodyworks/add", Method.Post);

                var bodywork = new Bodywork
                {
                    id = int.Parse(txtIdBody.Text),
                    name = txtNameBody.Text
                };

                request.AddJsonBody(bodywork);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    MessageBox.Show("Bodywork added successfully: " + response.StatusDescription);
                    txtIdBody.Text = "";
                    txtNameBody.Text = "";
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

        private void txtIdBody_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameBody_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
