namespace Taller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            // Verificar que todos los campos necesarios estén llenos
            if (string.IsNullOrEmpty(Marca.Text) || string.IsNullOrEmpty(Modelo.Text) || string.IsNullOrEmpty(Año.Text) || string.IsNullOrEmpty(Matrícula.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos necesarios.");
                return;
            }

            // Obtener los valores de los controles
            string marcaValue = Marca.Text;
            string modeloValue = Modelo.Text;
            string añoValue = Año.Text;
            string matrículaValue = Matrícula.Text;
            bool tieneSeguroValue = checkBox1.Checked;
            string tipoReparaciónValue = comboBox1.SelectedItem.ToString();

            // Mostrar una ventana con los datos ingresados
            MessageBox.Show($"Marca: {marcaValue}\nModelo: {modeloValue}\nAño: {añoValue}\nMatrícula: {matrículaValue}\nTiene seguro: {tieneSeguroValue}\nTipo de reparación: {tipoReparaciónValue}");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            Marca.Text = "";
            Modelo.Text = "";
            Año.Text = "";
            Matrícula.Text = "";
            checkBox1.Checked = false;
            comboBox1.SelectedIndex = 0;
        }


    }
}
