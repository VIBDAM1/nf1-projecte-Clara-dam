using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Resources;

namespace Clara_NF1
{
    public partial class Form1 : Form
    {
        private Form currentForm;
        private ResourceManager rm = new ResourceManager("Clara_NF1.Properties.Resources", typeof(Form1).Assembly);

        public Form1()
        {
            InitializeComponent();
            SetupLanguageSelector();
            LoadFormInPanel(new HomePage());
        }

        private void SetupLanguageSelector()
        {
            // Configurar ComboBox
            comboBoxIdiomes.Items.AddRange(new[] { "Català", "English", "Macedonian", "Thai", "Portuguese" });
            comboBoxIdiomes.SelectedIndex = 0;
            comboBoxIdiomes.SelectedIndexChanged += (sender, e) => ChangeLanguage(comboBoxIdiomes.SelectedItem.ToString());

            // Asignar eventos a los PictureBox
            pictureBox8.Click += (sender, e) => LoadFormInPanel(new HomePage());
            pictureBox9.Click += (sender, e) => LoadFormInPanel(new TaskForm());
            pictureBox10.Click += (sender, e) => LoadFormInPanel(new Calendar());
            pictureBox11.Click += (sender, e) => LoadFormInPanel(new Report());
            pictureBox12.Click += (sender, e) => LoadFormInPanel(new Help(this));
        }

        private void ChangeLanguage(string language)
        {
            string cultureCode = GetCultureCode(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);

            // Recargar el formulario actual
            if (currentForm != null)
            {
                Type formType = currentForm.GetType();
                LoadFormInPanel((Form)Activator.CreateInstance(formType));
            }
        }

        private string GetCultureCode(string language)
        {
            return language switch
            {
                "Català" => "ca-ES",
                "English" => "en",
                "Macedonian" => "mk",
                "Thai" => "th",
                "Portuguese" => "pt",
                _ => "ca-ES" // Default
            };
        }

        public void LoadFormInPanel(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
            currentForm = form;
        }
    }
}