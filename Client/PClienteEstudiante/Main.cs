using PClienteEstudiante.view;
using PClienteEstudiante.view.automobile;
using PClienteEstudiante.view.bodywork;
using PClienteEstudiante.view.motorcycle;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClienteEstudiante
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addMotorcycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAddMotorcycle gUIAddMotorcycle = new GUIAddMotorcycle();
            gUIAddMotorcycle.Show();
        }

        private void searchMotorcycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUISearchMotorcycle gUISearchMotorcycle = new GUISearchMotorcycle();
            gUISearchMotorcycle.Show();
        }

        private void deleteMotorcycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIDeleteMotorcycle gUIDeleteMotorcycle = new GUIDeleteMotorcycle();
            gUIDeleteMotorcycle.Show();
        }

        private void updateMotorcycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIUpdateMotorcycle gUIUpdateMotorcycle = new GUIUpdateMotorcycle();
            gUIUpdateMotorcycle.Show();
        }

        private void listMotorcycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListMotorcycle gUIListMotorcycle = new GUIListMotorcycle();
            gUIListMotorcycle.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by: \n\n Eder Martínez\n Jaime Rodriguez\n Jhon Cardenas \n\n Hornet©2024", "About us");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.Close();
        }

        private void listBodyworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListBodywork gUIListBodywork = new GUIListBodywork();
            gUIListBodywork.Show();
        }

        private void addBodyworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAddBodywork gUIAddBodywork = new GUIAddBodywork();
            gUIAddBodywork.Show();
        }

        private void searchBodyworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUISearchBodywork gUISearchBodywork = new GUISearchBodywork();
            gUISearchBodywork.Show();
        }

        private void deleteBodyworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIDeleteBodywork gUIDeleteBodywork = new GUIDeleteBodywork();
            gUIDeleteBodywork.Show();
        }

        private void updateBodyworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIUpdateBodywork gUIUpdateBodywork = new GUIUpdateBodywork();
            gUIUpdateBodywork.Show();
        }

        private void addAutomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAddAutomobile gUIAddAutomobile = new GUIAddAutomobile();
            gUIAddAutomobile.Show();
        }

        private void searchAutomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUISearchAutomobile gUISearchAutomobile = new GUISearchAutomobile();
            gUISearchAutomobile.Show();
        }

        private void deleteAutomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIDeleteAutomobile gUIDeleteAutomobile = new GUIDeleteAutomobile();
            gUIDeleteAutomobile.Show();
        }

        private void updateAutomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIUpdateAutomobile gUIUpdateAutomobile = new GUIUpdateAutomobile();
            gUIUpdateAutomobile.Show();
        }

        private void listAutomobileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIListAutomobile gUIListAutomobile = new GUIListAutomobile();
            gUIListAutomobile.Show();
        }
    }
}
