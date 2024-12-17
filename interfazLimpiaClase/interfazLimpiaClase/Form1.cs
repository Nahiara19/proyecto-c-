using System.Runtime.InteropServices; // Necesario para importar las funciones nativas
using System.Windows.Forms;
namespace interfazLimpiaClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AbrirFormularioEnPanel(new principal());
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraDeTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)//mas
        {
            panel1.Visible = !panel1.Visible;
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            // Al hacer clic en "Inicio", restablece la interfaz
            AbrirFormularioEnPanel(new principal());
        }


        private void Registro_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new formularioR());
        }
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formularioHijo.TopLevel = false;
            formularioHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formularioHijo);
            this.panelContenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new formularioL());
        }

        private void CerrarS_Click(object sender, EventArgs e)
        {
            // Confirmación de cerrar sesión
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas cerrar la sesión?",
                "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Si el usuario selecciona "Sí", cerramos la sesión
                MessageBox.Show("Has cerrado la sesión.", "Sesión cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AbrirFormularioEnPanel(new principal()); // Redirige a la pantalla principal
            }
            else
            {
                // Si el usuario selecciona "No", mostramos un mensaje de cancelación
                MessageBox.Show("No se ha cerrado la sesión.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
