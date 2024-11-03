using System.Globalization;
using System.Text;

namespace Datos_de_pacientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Alergias.Visible = false; // Oculta el RichTextBox de Alergias al inicio
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos del formulario
            Nombre.Clear();
            Apellido.Clear();
            FechaNac.Clear();
            Departamento.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            Alergias.Clear();
            Alergias.Visible = false; // Ocultar nuevamente el campo de alergias
            MotivoConsulta.Clear();
            checkBox1.Checked = false; // Desmarcar el checkbox de alergias
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            string nombre = Nombre.Text;
            string apellido = Apellido.Text;
            string departamento = Departamento.SelectedItem?.ToString() ?? "No especificado";
            string genero = radioButton1.Checked ? "Masculino" : "Femenino";
            string motivoConsulta = MotivoConsulta.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(motivoConsulta))
            {
                MessageBox.Show("Los campos Nombre, Apellido y Motivo de Consulta son obligatorios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si hay campos vacíos
            }

            // Validar Fecha de Nacimiento
            string fechaNac = FechaNac.Text;
            DateTime fechaNacDate;
            string formato = "dd/MM/yyyy"; // Regional
            CultureInfo provider = CultureInfo.InvariantCulture;

            if (!DateTime.TryParseExact(fechaNac, formato, provider, DateTimeStyles.None, out fechaNacDate))
            {
                MessageBox.Show("Ingrese una fecha válida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si la fecha es inválida
            }

            // Alergias
            string alergias = Alergias.Visible ? Alergias.Text : "No especificado";

            // Mostrar todos los datos en el MessageBox
            var message = new StringBuilder();
            message.AppendLine($"Nombre: {nombre}");
            message.AppendLine($"Apellido: {apellido}");
            message.AppendLine($"Fecha de nacimiento: {fechaNacDate.ToString("D")}");
            message.AppendLine($"Departamento: {departamento}");
            message.AppendLine($"Género: {genero}");
            message.AppendLine($"Alergias: {alergias}");
            message.AppendLine($"Motivo de Consulta: {motivoConsulta}");

            MessageBox.Show(message.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Establece visibilidad de Alergias en función del estado de checkBox1
            Alergias.Visible = checkBox1.Checked;
            if (!Alergias.Visible) // Si Alergias no es visible, limpiar el texto
            {
                Alergias.Clear();
            }
        }
    }
}