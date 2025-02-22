namespace Clara_NF1
{
    public partial class Inici : Form
    {
        private main_form _mainForm; // Referencia al formulario principal

        // Constructor que recibe una referencia al formulario principal
        public Inici(main_form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; // Asignar la referencia
            button1.Click += button1_Click;
            button2.Click += button2_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Navegar al formulario de Signup
            _mainForm.LoadFormInPanel(new Signup(_mainForm));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Navegar al formulario de Login
            _mainForm.LoadFormInPanel(new Login(_mainForm));
        }
    }
}
