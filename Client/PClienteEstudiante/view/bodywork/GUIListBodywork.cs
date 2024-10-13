using PClienteEstudiante.view.motorcycle;
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

namespace PClienteEstudiante.view.bodywork
{
    public partial class GUIListBodywork : Form
    {
        private List<Bodywork> bodyworks;
        public GUIListBodywork()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
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
                        dataGridBody.AutoGenerateColumns = false;
                        dataGridBody.DataSource = bodyworks;
                        dataGridBody.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No bodyworks found.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the list of bodyworks.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
