using System;
using System.Windows.Forms;

namespace interfazLimpiaClase
{
    public partial class formularioR : Form
    {
        public formularioR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este es el label del nombre completo, no se requiere acción aquí
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Validación de la contraseña
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text)) 
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmación antes de registrar al usuario
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas registrar estos datos?",
                "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Aquí puedo agregar la lógica para guardar los datos 

                MessageBox.Show("Ya has sido registrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después del registro (opcional)
                LimpiarCampos();
            }
            else
            {
                // Si hace clic en "No", los campos permanecen rellenos
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();  // Nombre
            textBox2.Clear();  // Email
            textBox3.Clear();  // Contraseña
            textBox4.Clear();  // Confirmación Contraseña
            textBox5.Clear();  // Teléfono
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // Confirmación para cancelar el registro
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas cancelar el registro?",
                "Cancelar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Regresar a la pantalla de inicio 
                this.Close();  // Cierra el formulario de registro y vuelve a la pantalla anterior (Form1)
            }
            else
            {
                // Si el usuario cancela la acción, se queda en el formulario actual
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Validación de email 
            if (!string.IsNullOrWhiteSpace(textBox2.Text) && !textBox2.Text.Contains("@"))
            {
                MessageBox.Show("Por favor, ingresa un email válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Validación de contraseña 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Validación del teléfono: solo números y obligatorio
            if (!string.IsNullOrWhiteSpace(textBox5.Text) && !textBox5.Text.All(char.IsDigit))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formularioR_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
