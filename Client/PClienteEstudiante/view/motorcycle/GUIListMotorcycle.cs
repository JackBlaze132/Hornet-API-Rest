using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RestSharp;
using System.Text.Json;
using System.Linq;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUIListMotorcycle : Form
    {
        private List<Motorcycle> allMotorcycles;
        public GUIListMotorcycle()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (i != checkedListBox1.SelectedIndex)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (i != checkedListBox2.SelectedIndex)
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dataGridMoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                var options = new RestClientOptions("http://localhost:8090");
                var client = new RestClient(options);
                var request = new RestRequest("/motorcycles/get", Method.Get);

                var response = client.Execute(request);

                if (response.IsSuccessful)
                {
                    allMotorcycles = JsonSerializer.Deserialize<List<Motorcycle>>(response.Content);

                    if (allMotorcycles != null && allMotorcycles.Count > 0)
                    {
                        dataGridMoto.AutoGenerateColumns = false;
                        dataGridMoto.DataSource = allMotorcycles;
                        dataGridMoto.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No motorcycles found.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve the list of motorcycles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (allMotorcycles == null || allMotorcycles.Count == 0)
            {
                MessageBox.Show("No motorcycles available to filter.");
                return;
            }

            var filteredMotorcycles = allMotorcycles.AsQueryable();

            // Filter Helmet Included
            if (checkedListBox1.GetItemChecked(0)) // "YES" Select
            {
                filteredMotorcycles = filteredMotorcycles.Where(m => m.helmetIncluded == true);
            }
            else if (checkedListBox1.GetItemChecked(1)) // "NOT" Select
            {
                filteredMotorcycles = filteredMotorcycles.Where(m => m.helmetIncluded == false);
            }

            // Filter ABS Included
            if (checkedListBox2.GetItemChecked(0)) // "YES" Select
            {
                filteredMotorcycles = filteredMotorcycles.Where(m => m.absBrake == true);
            }
            else if (checkedListBox2.GetItemChecked(1)) //"NO" Select
            {
                filteredMotorcycles = filteredMotorcycles.Where(m => m.absBrake == false);
            }

            dataGridMoto.DataSource = filteredMotorcycles.ToList();
            dataGridMoto.Refresh();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
    

