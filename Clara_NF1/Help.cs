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
    public partial class Help : Form
    {
        private Form1 _mainForm; // Referencia al formulario principal (Form1)

        public Help(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; // Asignar la referencia

            // Asignar evento Click al botón
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cargar el formulario Contact en el panel1 de Form1
            _mainForm.LoadFormInPanel(new Contact(_mainForm));
        }
    }
}
