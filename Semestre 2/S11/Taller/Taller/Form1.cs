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
            // Verificar que todos los campos necesarios est�n llenos
            if (string.IsNullOrEmpty(Marca.Text) || string.IsNullOrEmpty(Modelo.Text) || string.IsNullOrEmpty(A�o.Text) || string.IsNullOrEmpty(Matr�cula.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos necesarios.");
                return;
            }

            // Obtener los valores de los controles
            string marcaValue = Marca.Text;
            string modeloValue = Modelo.Text;
            string a�oValue = A�o.Text;
            string matr�culaValue = Matr�cula.Text;
            bool tieneSeguroValue = checkBox1.Checked;
            string tipoReparaci�nValue = comboBox1.SelectedItem.ToString();

            // Mostrar una ventana con los datos ingresados
            MessageBox.Show($"Marca: {marcaValue}\nModelo: {modeloValue}\nA�o: {a�oValue}\nMatr�cula: {matr�culaValue}\nTiene seguro: {tieneSeguroValue}\nTipo de reparaci�n: {tipoReparaci�nValue}");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos del formulario
            Marca.Text = "";
            Modelo.Text = "";
            A�o.Text = "";
            Matr�cula.Text = "";
            checkBox1.Checked = false;
            comboBox1.SelectedIndex = 0;
        }


    }
}
