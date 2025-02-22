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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Asignar eventos Click a los PictureBox (iconos del menú)
            pictureBox8.Click += (sender, e) => LoadFormInPanel(new HomePage());
            pictureBox9.Click += (sender, e) => LoadFormInPanel(new TaskForm());
            pictureBox10.Click += (sender, e) => LoadFormInPanel(new Calendar());
            pictureBox11.Click += (sender, e) => LoadFormInPanel(new Report());
            pictureBox12.Click += (sender, e) => LoadFormInPanel(new Help(this));

            // Cargar HomePage por defecto al iniciar
            LoadFormInPanel(new HomePage());
        }

        // Método para cargar un formulario dentro del panel1
        public void LoadFormInPanel(Form form)
        {
            panel1.Controls.Clear(); // Limpiar el panel antes de cargar un nuevo formulario
            form.TopLevel = false; // Indicar que el formulario no es de nivel superior
            form.FormBorderStyle = FormBorderStyle.None; // Eliminar bordes del formulario
            form.Dock = DockStyle.Fill; // Ajustar el formulario al tamaño del panel
            panel1.Controls.Add(form); // Agregar el formulario al panel
            form.Show(); // Mostrar el formulario
        }
    }
}
