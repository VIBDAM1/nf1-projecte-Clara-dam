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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            // Asignar eventos Click a los Labels de las tareas
            tasca1.Click += (sender, e) => ToggleLabelBackground(tasca1);
            tasca2.Click += (sender, e) => ToggleLabelBackground(tasca2);
            tasca3.Click += (sender, e) => ToggleLabelBackground(tasca3);
            tasca4.Click += (sender, e) => ToggleLabelBackground(tasca4);
            tasca5.Click += (sender, e) => ToggleLabelBackground(tasca5);
            tasca6.Click += (sender, e) => ToggleLabelBackground(tasca6);
            tasca7.Click += (sender, e) => ToggleLabelBackground(tasca7);
            tasca8.Click += (sender, e) => ToggleLabelBackground(tasca8);
            tasca9.Click += (sender, e) => ToggleLabelBackground(tasca9);
        }

        private void ToggleLabelBackground(Label label)
        {
            // Cambiar el color de fondo del Label
            if (label.BackColor == Color.DarkSlateBlue)
            {
                label.BackColor = Color.FromArgb(64, 64, 64); // Volver a gris
            }
            else
            {
                label.BackColor = Color.DarkSlateBlue; // Cambiar a DarkSlateBlue
            }
        }
    }
}

