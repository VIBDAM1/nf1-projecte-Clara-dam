using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Resources;

namespace Clara_NF1
{
    public partial class Form1 : Form
    {
        private Form currentForm; // Para mantener referencia al formulario actual
        private ResourceManager rm = new ResourceManager("Clara_NF1.Properties.Resources", typeof(Form1).Assembly);

        public Form1()
        {
            InitializeComponent();
            InicialitzarComboBox();

            // Asignar eventos Click a los PictureBox (iconos del menú)
            pictureBox8.Click += (sender, e) => LoadFormInPanel(new HomePage());
            pictureBox9.Click += (sender, e) => LoadFormInPanel(new TaskForm());
            pictureBox10.Click += (sender, e) => LoadFormInPanel(new Calendar());
            pictureBox11.Click += (sender, e) => LoadFormInPanel(new Report());
            pictureBox12.Click += (sender, e) => LoadFormInPanel(new Help(this));

            // Cargar HomePage por defecto al iniciar
            LoadFormInPanel(new HomePage());
        }

        private void InicialitzarComboBox()
        {
            // Configurar el ComboBox de idiomas
            comboBoxIdiomes.Items.AddRange(new object[] {
                "Català",     // ca-ES
                "English",    // en
                "Macedonian", // mk
                "Thai",      // th
                "Portuguese" // pt
            });

            comboBoxIdiomes.SelectedIndex = 0; // Seleccionar catalán por defecto
            comboBoxIdiomes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIdiomes.SelectedIndexChanged += comboBoxIdiomes_SelectedIndexChanged;
        }

        private void comboBoxIdiomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboBoxIdiomes.SelectedItem.ToString();
            ChangeLanguage(selectedLanguage);
        }

        // Cambia el idioma de la aplicación y recarga el formulario actual
        private void ChangeLanguage(string language)
        {
            // Obtener código de cultura y actualizar configuración regional
            string cultureCode = GetCultureCode(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureCode);

            // Actualizar título del formulario principal desde recursos
            this.Text = rm.GetString("MainFormTitle") ?? "Clara NF1";

            // Recargar el formulario actual para aplicar traducciones
            if (currentForm != null)
            {
                ReloadCurrentForm();
            }
        }

        // Recarga el formulario actual,  (caso diferente en Help)
        private void ReloadCurrentForm()
        {
            if (currentForm != null)
            {
                // Caso especial para el formulario Help que requiere referencia al Form1
                if (currentForm is Help)
                {
                    LoadFormInPanel(new Help(this)); // Pasamos la referencia this
                }
                else
                {
                    // Para otros formularios usamos
                    Type formType = currentForm.GetType();
                    LoadFormInPanel((Form)Activator.CreateInstance(formType));
                }
            }
        }

        // Obtiene el código de cultura correspondiente al idioma seleccionado
        private string GetCultureCode(string selectedLanguage)
        {
            return selectedLanguage switch
            {
                "Català" => "ca-ES",
                "English" => "en",
                "Macedonian" => "mk",
                "Thai" => "th",
                "Portuguese" => "pt",
                _ => "ca-ES" // Valor por defecto
            };
        }
        // Carga un formulario dentro del panel principal
        public void LoadFormInPanel(Form form)
        {
            // Limpiar panel antes de cargar nuevo formulario
            panel1.Controls.Clear();

            // Configurar el formulario hijo
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Añadir y mostrar el formulario
            panel1.Controls.Add(form);
            form.Show();

            // Guardar referencia al formulario actual
            currentForm = form;
        }
    }
}