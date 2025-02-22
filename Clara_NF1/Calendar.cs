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
    public partial class Calendar : Form
    {
        private int _currentMonth = 1; // Variable para almacenar el mes actual (1 = enero, 2 = febrero, etc.)

        public Calendar()
        {
            InitializeComponent();

            // Cargar la imagen inicial (enero)
            UpdateCalendarImage();

            // Asignar eventos a los botones
            anterior.Click += anterior_Click;
            seguent.Click += seguent_Click;
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            // Cambiar al mes anterior
            _currentMonth--;
            if (_currentMonth < 1)
            {
                _currentMonth = 12; // Volver a diciembre si estamos en enero
            }

            // Actualizar la imagen del calendario
            UpdateCalendarImage();
        }

        private void seguent_Click(object sender, EventArgs e)
        {
            // Cambiar al mes siguiente
            _currentMonth++;
            if (_currentMonth > 12)
            {
                _currentMonth = 1; // Volver a enero si estamos en diciembre
            }

            // Actualizar la imagen del calendario
            UpdateCalendarImage();
        }

        private void UpdateCalendarImage()
        {
            // Obtener la ruta del ejecutable (bin\Debug o bin\Release)
            string startupPath = Application.StartupPath;

            // Construir la ruta a la carpeta Resources (subiendo dos niveles)
            string resourcesPath = Path.Combine(startupPath, "..", "..", "..", "Resources");

            // Ruta completa a la imagen
            string imagePath = Path.Combine(resourcesPath, $"{_currentMonth}.png");

            // Verificar si la imagen existe y cargarla
            if (File.Exists(imagePath))
            {
                pictureBox2.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"No s'ha trobat la imatge per al mes {_currentMonth}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
