namespace Taller
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
            label1 = new Label();
            Marca = new TextBox();
            Año = new TextBox();
            label2 = new Label();
            Modelo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Matrícula = new TextBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            Registrar = new Button();
            Cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // Marca
            // 
            Marca.Location = new Point(12, 27);
            Marca.Name = "Marca";
            Marca.Size = new Size(199, 23);
            Marca.TabIndex = 1;
            // 
            // Año
            // 
            Año.Location = new Point(12, 131);
            Año.Name = "Año";
            Año.Size = new Size(199, 23);
            Año.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Año";
            label2.Click += label2_Click;
            // 
            // Modelo
            // 
            Modelo.Location = new Point(12, 76);
            Modelo.Name = "Modelo";
            Modelo.Size = new Size(199, 23);
            Modelo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Matrícula";
            // 
            // Matrícula
            // 
            Matrícula.Location = new Point(12, 186);
            Matrícula.Name = "Matrícula";
            Matrícula.Size = new Size(199, 23);
            Matrícula.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 224);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Tiene seguro";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 257);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 9;
            label5.Text = "Tipo de reparación";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Motor", "Transmisión", "Frenos", "Suspensión", "Carrocería", "Climatización" });
            comboBox1.Location = new Point(12, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Seleccione";
            // 
            // Registrar
            // 
            Registrar.Location = new Point(136, 315);
            Registrar.Name = "Registrar";
            Registrar.Size = new Size(75, 23);
            Registrar.TabIndex = 11;
            Registrar.Text = "Registrar";
            Registrar.UseVisualStyleBackColor = true;
            Registrar.Click += Registrar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(55, 315);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(75, 23);
            Cancelar.TabIndex = 12;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(225, 355);
            Controls.Add(Cancelar);
            Controls.Add(Registrar);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(Matrícula);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Modelo);
            Controls.Add(label2);
            Controls.Add(Año);
            Controls.Add(Marca);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Registre su carro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Marca;
        private TextBox Año;
        private Label label2;
        private TextBox Modelo;
        private Label label3;
        private Label label4;
        private TextBox Matrícula;
        private CheckBox checkBox1;
        private Label label5;
        private ComboBox comboBox1;
        private Button Registrar;
        private Button Cancelar;
    }
}
