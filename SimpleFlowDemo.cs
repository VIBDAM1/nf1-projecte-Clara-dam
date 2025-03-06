using System;
using System.Drawing;
using System.Windows.Forms;

namespace exempleswiki
{
    public class SimpleFlowDemo : Form
    {
        private FlowLayoutPanel flowPanel;
        private Button btnAdd;

        public SimpleFlowDemo()
        {
            // Configurar el formulario
            this.Text = "Ejemplo Simple FlowLayout";
            this.Size = new Size(300, 250);

            // Crear FlowLayoutPanel
            flowPanel = new FlowLayoutPanel {
                BackColor = Color.LightBlue,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            // Botón para añadir controles
            btnAdd = new Button {
                Text = "Añadir Botón",
                Dock = DockStyle.Bottom,
                Height = 30
            };

            // Evento para añadir controles
            btnAdd.Click += (sender, e) => {
                var newButton = new Button {
                    Text = $"Botón {flowPanel.Controls.Count + 1}",
                    Margin = new Padding(5),
                    AutoSize = true
                };
                flowPanel.Controls.Add(newButton);
            };

            // Añadir controles al formulario
            Controls.Add(flowPanel);
            Controls.Add(btnAdd);
        }
    }
}