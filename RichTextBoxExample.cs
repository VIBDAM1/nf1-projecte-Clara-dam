using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace exempleswiki
{
    public class RichTextBoxExample : Form
    {
        private RichTextBox richTextBox1;

        public RichTextBoxExample()
        {
            // Configuració del formulari
            this.Text = "Exemple RichTextBox";
            this.Size = new Size(450, 250);
            this.BackColor = Color.WhiteSmoke;

            // Configurar RichTextBox
            richTextBox1 = new RichTextBox
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(10),
                DetectUrls = true,
                Text = "Recursos útils:\n" +
                       "• Google: https://www.google.com\n" +
                       "• Microsoft Learn: https://learn.microsoft.com",
                BackColor = Color.AliceBlue,
                Font = new Font("Segoe UI", 11)
            };

            // Afegir event
            richTextBox1.LinkClicked += RichTextBox1_LinkClicked;
            this.Controls.Add(richTextBox1);
        }

        private void RichTextBox1_LinkClicked(object sender, LinkClickedEventArgs e) {
            try {
                // Obrir enllaç amb seguretat
                Process.Start(new ProcessStartInfo(e.LinkText) {
                    UseShellExecute = true
                });
            }
            catch (Exception ex) {
                MessageBox.Show($"Error obrint l'enllaç: {ex.Message}");
            }
        }
    }
}