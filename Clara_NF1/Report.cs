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
            DialogResult result = MessageBox.Show("Estàs segur que vols exportar l'informe actual?", "Confirmació d'Exportació", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)

            {
                // Mostrar un quadre de per seleccionar el format de exportació
                string[] formats = { "CSV", "PDF", "Excel" };
                string format = Microsoft.VisualBasic.Interaction.InputBox("Selecciona el format d'exportació:", "Format d'Exportació", formats[0]);
                if (formats.Contains(format))
                {
                    // Simular la exportació de l'informe
                    MessageBox.Show($"L'informe s'ha exportat correctament en format {format}!", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Format no vàlid seleccionat. L'exportació ha estat cancel·lada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            // Preguntar a l'usuari si vol imprimir l'informe
            DialogResult result = MessageBox.Show("Vols imprimir l'informe actual?", "Confirmació d'Impressió", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Mostrar un quadre per seleccionar el format d'impresió
                string[] formats = { "PDF", "Word", "Imatge" };
                string format = Microsoft.VisualBasic.Interaction.InputBox("Selecciona el format d'impressió:", "Format d'Impressió", formats[0]);

                if (formats.Contains(format))
                {
                    // Simular l'enviament a la impressora
                    MessageBox.Show($"S'està enviant a la impressora en format {format}. Si us plau, espera un moment...", "Imprimint", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Format no vàlid seleccionat. L'impressió ha estat cancel·lada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
