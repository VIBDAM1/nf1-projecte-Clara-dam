using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clara_NF1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            // Simular la exportación del informe
            MessageBox.Show("Informe exportat correctament!", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
