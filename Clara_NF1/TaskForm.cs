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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si los campos están vacíos
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(richTextBox1.Text) ||
                checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Si us plau, omple tots els camps per continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Felicitats! Tasca creada amb èxit.", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}