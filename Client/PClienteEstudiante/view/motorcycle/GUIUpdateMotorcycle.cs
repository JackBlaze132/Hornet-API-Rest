using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClienteEstudiante.view.motorcycle
{
    public partial class GUIUpdateMotorcycle : Form
    {
        public GUIUpdateMotorcycle()
        {
            InitializeComponent();
        }

        private void btnUpdateMoto_Click(object sender, EventArgs e)
        {
            GUIEditMotorcycle guiEditMotorcycle = new GUIEditMotorcycle();
            guiEditMotorcycle.Show();
        }
    }
}
