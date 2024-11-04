
namespace Datos_de_pacientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Apellido = new TextBox();
            label3 = new Label();
            FechaNac = new TextBox();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label5 = new Label();
            panel1 = new Panel();
            Alergias = new RichTextBox();
            checkBox1 = new CheckBox();
            panel2 = new Panel();
            MotivoConsulta = new RichTextBox();
            label8 = new Label();
            label7 = new Label();
            Departamento = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.Location = new Point(9, 48);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(135, 23);
            Nombre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 30);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // Apellido
            // 
            Apellido.Location = new Point(150, 48);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(135, 23);
            Apellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, -3);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Datos del paciente";
            // 
            // FechaNac
            // 
            FechaNac.Location = new Point(9, 98);
            FechaNac.Name = "FechaNac";
            FechaNac.Size = new Size(135, 23);
            FechaNac.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 80);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha de nacimiento";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(150, 98);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(36, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "M";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(192, 98);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "F";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(150, 80);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Género";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Alergias);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(FechaNac);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Apellido);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Nombre);
            panel1.Cursor = Cursors.No;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 238);
            panel1.TabIndex = 4;
            // 
            // Alergias
            // 
            Alergias.Location = new Point(9, 161);
            Alergias.Name = "Alergias";
            Alergias.Size = new Size(276, 62);
            Alergias.TabIndex = 6;
            Alergias.Text = "";
            Alergias.TextChanged += Alergias_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(9, 136);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Alergias";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            checkBox1.CheckStateChanged += checkBox1_CheckedChanged_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(MotivoConsulta);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(Departamento);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(314, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 238);
            panel2.TabIndex = 6;
            // 
            // MotivoConsulta
            // 
            MotivoConsulta.Location = new Point(16, 98);
            MotivoConsulta.Name = "MotivoConsulta";
            MotivoConsulta.Size = new Size(247, 125);
            MotivoConsulta.TabIndex = 11;
            MotivoConsulta.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 80);
            label8.Name = "label8";
            label8.Size = new Size(121, 15);
            label8.TabIndex = 14;
            label8.Text = "Motivo de la consulta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 30);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 13;
            label7.Text = "Departamento";
            // 
            // Departamento
            // 
            Departamento.FormattingEnabled = true;
            Departamento.Items.AddRange(new object[] { "Cardiología", "Pedriatría", "Emergencias", "Neurología" });
            Departamento.Location = new Point(16, 48);
            Departamento.Name = "Departamento";
            Departamento.Size = new Size(247, 23);
            Departamento.TabIndex = 12;
            Departamento.Text = "Seleccionar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, -3);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 11;
            label6.Text = "Consulta";
            // 
            // button1
            // 
            button1.Location = new Point(520, 256);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(439, 256);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(358, 256);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 289);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Entrada de pacientes";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void Alergias_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
             // Establece visibilidad de Alergias en función del estado de checkBox1
    Alergias.Visible = checkBox1.Checked;
    if (!Alergias.Visible) // Si Alergias no es visible, limpiar el texto
    {
        Alergias.Clear();
    }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox Nombre;
        private Label label2;
        private Label label1;
        private TextBox Apellido;
        private Label label3;
        private TextBox FechaNac;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label5;
        private Panel panel1;
        private RichTextBox Alergias;
        private CheckBox checkBox1;
        private Panel panel2;
        private RichTextBox MotivoConsulta;
        private Label label8;
        private Label label7;
        private ComboBox Departamento;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}