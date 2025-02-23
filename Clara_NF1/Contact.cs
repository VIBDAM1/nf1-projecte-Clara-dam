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
    public partial class Contact : Form
    {
        public Contact(Form1 mainForm)
        {
            InitializeComponent();

            // Asignar evento Click al botón (opcional si se hace en el diseñador)
            button2.Click += button2_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(richTextBox1.Text) ||
                comboBox1.SelectedItem == null)
            {
                // Mostrar mensaje de error si falta algún campo
                MessageBox.Show("Si us plau, omple tots els camps per enviar el missatge.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mostrar mensaje de éxito si todos los campos están llenos
                MessageBox.Show("El teu missatge s'ha enviat amb èxit!", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear(); // Limpiar el TextBox
                richTextBox1.Clear(); // Limpiar el RichTextBox
                comboBox1.SelectedIndex = -1; // Restablecer el ComboBox (sin selección)
            }
        }
    }
}
