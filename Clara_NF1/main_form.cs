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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cargar el formulario de Inici en el panel1, pasando la referencia de main_form
            LoadFormInPanel(new Inici(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cargar el formulario de Signup en el panel1, pasando la referencia de main_form
            LoadFormInPanel(new Signup(this));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cargar el formulario de Login en el panel1, pasando la referencia de main_form
            LoadFormInPanel(new Login(this));
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            // Cargar el formulario de Inici por defecto al iniciar la aplicación, pasando la referencia de main_form
            LoadFormInPanel(new Inici(this));
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
