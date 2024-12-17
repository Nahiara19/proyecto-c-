namespace interfazLimpiaClase
{
    partial class formularioR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new Label();
            textBox1 = new TextBox();
            Correo = new Label();
            textBox2 = new TextBox();
            Contraseña = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Comprueba = new Label();
            Aceptar = new Button();
            Limpiar = new Button();
            Salir = new Button();
            Telefono = new Label();
            textBox5 = new TextBox();
            fecha = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(12, 45);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(134, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre Completo";
            Nombre.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 45);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nombre y apellidos";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 1;
            // 
            // Correo
            // 
            Correo.AutoSize = true;
            Correo.Location = new Point(12, 96);
            Correo.Name = "Correo";
            Correo.Size = new Size(46, 20);
            Correo.TabIndex = 2;
            Correo.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 96);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Introduce tu email";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Location = new Point(12, 160);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(83, 20);
            Contraseña.TabIndex = 4;
            Contraseña.Text = "Contraseña";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 157);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Introduce tu contraseña";
            textBox3.Size = new Size(217, 27);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(218, 220);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.PlaceholderText = "Introduce tu contraseña";
            textBox4.Size = new Size(217, 27);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Comprueba
            // 
            Comprueba.AutoSize = true;
            Comprueba.Location = new Point(12, 220);
            Comprueba.Name = "Comprueba";
            Comprueba.Size = new Size(188, 20);
            Comprueba.TabIndex = 7;
            Comprueba.Text = "Comprobación contraseña ";
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(71, 348);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(234, 29);
            Aceptar.TabIndex = 8;
            Aceptar.Text = "ACEPTAR";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(493, 348);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(234, 29);
            Limpiar.TabIndex = 9;
            Limpiar.Text = "LIMPIAR";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(277, 398);
            Salir.Name = "Salir";
            Salir.Size = new Size(234, 29);
            Salir.TabIndex = 10;
            Salir.Text = "SALIR";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Location = new Point(470, 52);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(67, 20);
            Telefono.TabIndex = 11;
            Telefono.Text = "Telefono";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(571, 52);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Introduce tu número de telefono";
            textBox5.Size = new Size(217, 27);
            textBox5.TabIndex = 12;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // fecha
            // 
            fecha.AutoSize = true;
            fecha.Location = new Point(543, 113);
            fecha.Name = "fecha";
            fecha.Size = new Size(149, 20);
            fecha.TabIndex = 13;
            fecha.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(477, 153);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(298, 27);
            dateTimePicker1.TabIndex = 14;
            // 
            // formularioR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(fecha);
            Controls.Add(textBox5);
            Controls.Add(Telefono);
            Controls.Add(Salir);
            Controls.Add(Limpiar);
            Controls.Add(Aceptar);
            Controls.Add(Comprueba);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(Contraseña);
            Controls.Add(textBox2);
            Controls.Add(Correo);
            Controls.Add(textBox1);
            Controls.Add(Nombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formularioR";
            Text = "Formulario Registro";
            Load += formularioR_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private TextBox textBox1;
        private Label Correo;
        private TextBox textBox2;
        private Label Contraseña;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Comprueba;
        private Button Aceptar;
        private Button Limpiar;
        private Button Salir;
        private Label Telefono;
        private TextBox textBox5;
        private Label fecha;
        private DateTimePicker dateTimePicker1;
    }
}