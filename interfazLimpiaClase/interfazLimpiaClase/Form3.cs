using System;
using System.Windows.Forms;



namespace interfazLimpiaClase
{
    public partial class formularioL : Form
    {
        public formularioL()
        {
            InitializeComponent();
        }



        private void Aceptar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios (Email y Contraseña)
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("El email y la contraseña son campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Validación de formato de email (básico)
            if (!textBox1.Text.Contains("@") || !textBox1.Text.Contains("."))
            {
                MessageBox.Show("Por favor, ingresa un email válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            // Confirmación antes de proceder con el registro
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas continuar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (confirmResult == DialogResult.Yes)
            {
                // Aquí puedes agregar la lógica para iniciar sesión o hacer algún proceso relacionado



                MessageBox.Show("Has iniciado sesión correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si el usuario hace clic en "No", los campos permanecen como están.
            }
        }



        private void Salir_Click(object sender, EventArgs e)
        {
            // Confirmación para salir/cancelar
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas cancelar?", "Cancelar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (confirmResult == DialogResult.Yes)
            {
                // Cerrar el formulario y regresar a la pantalla de inicio
                this.Close(); // Cierra el formulario y vuelve a la pantalla anterior
            }
            else
            {
                // Si el usuario hace clic en "No", el formulario permanece abierto.
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Validación del campo Email.
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Validación del campo Contraseña.
        }



        private void Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  // Limpiar campo de Email
            textBox2.Clear();  // Limpiar campo de Contraseña
        }
    }
}