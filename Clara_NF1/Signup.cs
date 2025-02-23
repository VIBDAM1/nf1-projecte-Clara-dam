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
    public partial class Signup : Form
    {
        private main_form _mainForm; // Referencia al formulario principal

        // Constructor que recibe una referencia al formulario principal
        public Signup(main_form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; // Asignar la referencia
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Si us plau, omple tots els camps. Torna a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Compte creat amb èxit! Benvingut/da!", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir la ventana de HomePage (nueva ventana)
                Form1 form1 = new Form1();
                form1.Show();

                // Cerrar el formulario principal (main_form)
                _mainForm.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(new Inici(_mainForm));
        }
    }
}
