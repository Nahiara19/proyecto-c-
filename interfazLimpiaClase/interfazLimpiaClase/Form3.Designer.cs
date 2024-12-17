namespace interfazLimpiaClase
{
    partial class formularioL
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Aceptar = new Button();
            Salir = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(91, 110);
            label1.Name = "label1";
            label1.Size = new Size(106, 46);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(91, 241);
            label2.Name = "label2";
            label2.Size = new Size(196, 46);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(232, 127);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Introduce tu email usuario";
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 258);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Introduce tu contraseña";
            textBox2.Size = new Size(246, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(91, 365);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(164, 29);
            Aceptar.TabIndex = 4;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(502, 365);
            Salir.Name = "Salir";
            Salir.Size = new Size(164, 29);
            Salir.TabIndex = 5;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(293, 365);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(164, 29);
            Limpiar.TabIndex = 6;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // formularioL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpiar);
            Controls.Add(Salir);
            Controls.Add(Aceptar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formularioL";
            Text = "Formulario Inicio Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Aceptar;
        private Button Salir;
        private Button Limpiar;
    }
}