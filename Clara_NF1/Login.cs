using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clara_NF1
{
    public partial class Login : Form
    {
        private main_form _mainForm; // Referencia al formulario principal

        // Constructor que recibe una referencia al formulario principal
        public Login(main_form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; // Asignar la referencia

            label3.Click += label3_Click;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Si us plau, omple tots el camp d'usuari. Torna a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Contrasenya recuperada amb èxit. Benvingut!", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir la ventana de form1 (nueva ventana)
                Form1 form1 = new Form1();
                form1.Show();

                // Cerrar el formulario principal (main_form)
                _mainForm.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Si us plau, omple tots els camps (usuari i contrasenya). Torna a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Benvingut/da!", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir la ventana de form1 (nueva ventana)
                Form1 form1 = new Form1();
                form1.Show();

                // Cerrar el formulario principal (main_form)
                _mainForm.Hide();
            }
        }
    }
}
