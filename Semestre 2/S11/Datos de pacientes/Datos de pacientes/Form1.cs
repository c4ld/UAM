namespace Datos_de_pacientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string apellido = Apellido.Text;
            string fechaNac = FechaNac.Text;
            DateTime fechaNacDate;

            // Validar fecha de nacimiento
            if (DateTime.TryParse(fechaNac, out fechaNacDate))
            {}
            else
            {
                MessageBox.Show("Fecha inválida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Nombre: " + nombre + "\n Apellido: " + apellido);
        }
    }
}
