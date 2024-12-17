namespace interfazLimpiaClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BarraDeTitulo = new Panel();
            Minimizar = new PictureBox();
            Maximizar = new PictureBox();
            Cerrar = new PictureBox();
            MenuV = new Panel();
            panel1 = new Panel();
            CerrarS = new Button();
            Login = new Button();
            Mas = new Button();
            Registro = new Button();
            Inicio = new Button();
            panelContenedor = new Panel();
            BarraDeTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Cerrar).BeginInit();
            MenuV.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BarraDeTitulo
            // 
            BarraDeTitulo.BackColor = Color.PaleVioletRed;
            BarraDeTitulo.Controls.Add(Minimizar);
            BarraDeTitulo.Controls.Add(Maximizar);
            BarraDeTitulo.Controls.Add(Cerrar);
            BarraDeTitulo.Dock = DockStyle.Top;
            BarraDeTitulo.Location = new Point(0, 0);
            BarraDeTitulo.Name = "BarraDeTitulo";
            BarraDeTitulo.Size = new Size(800, 35);
            BarraDeTitulo.TabIndex = 0;
            BarraDeTitulo.MouseDown += BarraDeTitulo_MouseDown;
            // 
            // Minimizar
            // 
            Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimizar.BackColor = Color.Yellow;
            Minimizar.Cursor = Cursors.Hand;
            Minimizar.Location = new Point(741, 3);
            Minimizar.Name = "Minimizar";
            Minimizar.Size = new Size(25, 25);
            Minimizar.TabIndex = 3;
            Minimizar.TabStop = false;
            Minimizar.Click += Minimizar_Click;
            // 
            // Maximizar
            // 
            Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximizar.BackColor = Color.Lime;
            Maximizar.Cursor = Cursors.Hand;
            Maximizar.Location = new Point(710, 3);
            Maximizar.Name = "Maximizar";
            Maximizar.Size = new Size(25, 25);
            Maximizar.TabIndex = 2;
            Maximizar.TabStop = false;
            Maximizar.Click += Maximizar_Click;
            // 
            // Cerrar
            // 
            Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cerrar.BackColor = Color.Red;
            Cerrar.Cursor = Cursors.Hand;
            Cerrar.Location = new Point(772, 3);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(25, 25);
            Cerrar.TabIndex = 1;
            Cerrar.TabStop = false;
            Cerrar.Click += Cerrar_Click;
            // 
            // MenuV
            // 
            MenuV.BackColor = Color.LightGray;
            MenuV.Controls.Add(panel1);
            MenuV.Controls.Add(Mas);
            MenuV.Controls.Add(Registro);
            MenuV.Controls.Add(Inicio);
            MenuV.Dock = DockStyle.Left;
            MenuV.Location = new Point(0, 35);
            MenuV.Name = "MenuV";
            MenuV.Size = new Size(250, 415);
            MenuV.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(CerrarS);
            panel1.Controls.Add(Login);
            panel1.Location = new Point(33, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 192);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // CerrarS
            // 
            CerrarS.BackColor = Color.PaleVioletRed;
            CerrarS.FlatAppearance.BorderSize = 0;
            CerrarS.FlatStyle = FlatStyle.Flat;
            CerrarS.Image = (Image)resources.GetObject("CerrarS.Image");
            CerrarS.ImageAlign = ContentAlignment.MiddleLeft;
            CerrarS.Location = new Point(0, 111);
            CerrarS.Name = "CerrarS";
            CerrarS.Size = new Size(198, 29);
            CerrarS.TabIndex = 5;
            CerrarS.Text = " Cerrar Sesion";
            CerrarS.UseVisualStyleBackColor = false;
            CerrarS.Click += CerrarS_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.PaleVioletRed;
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Image = (Image)resources.GetObject("Login.Image");
            Login.ImageAlign = ContentAlignment.MiddleLeft;
            Login.Location = new Point(0, 29);
            Login.Name = "Login";
            Login.Size = new Size(198, 29);
            Login.TabIndex = 4;
            Login.Text = " LOGIN";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Mas
            // 
            Mas.BackColor = Color.PaleVioletRed;
            Mas.FlatAppearance.BorderSize = 0;
            Mas.FlatStyle = FlatStyle.Flat;
            Mas.Image = Properties.Resources.mas1;
            Mas.ImageAlign = ContentAlignment.MiddleLeft;
            Mas.Location = new Point(33, 143);
            Mas.Name = "Mas";
            Mas.Size = new Size(198, 29);
            Mas.TabIndex = 2;
            Mas.Text = "MAS ...";
            Mas.UseVisualStyleBackColor = false;
            Mas.Click += button1_Click;
            // 
            // Registro
            // 
            Registro.BackColor = Color.PaleVioletRed;
            Registro.FlatAppearance.BorderSize = 0;
            Registro.FlatStyle = FlatStyle.Flat;
            Registro.Image = (Image)resources.GetObject("Registro.Image");
            Registro.ImageAlign = ContentAlignment.MiddleLeft;
            Registro.Location = new Point(33, 85);
            Registro.Name = "Registro";
            Registro.Size = new Size(198, 29);
            Registro.TabIndex = 1;
            Registro.Text = " REGISTRO";
            Registro.UseVisualStyleBackColor = false;
            Registro.Click += Registro_Click;
            // 
            // Inicio
            // 
            Inicio.BackColor = Color.PaleVioletRed;
            Inicio.FlatAppearance.BorderSize = 0;
            Inicio.FlatStyle = FlatStyle.Flat;
            Inicio.Image = (Image)resources.GetObject("Inicio.Image");
            Inicio.ImageAlign = ContentAlignment.MiddleLeft;
            Inicio.Location = new Point(33, 36);
            Inicio.Name = "Inicio";
            Inicio.Size = new Size(198, 29);
            Inicio.TabIndex = 0;
            Inicio.Text = "INICIO";
            Inicio.UseVisualStyleBackColor = false;
            Inicio.Click += Inicio_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(550, 415);
            panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedor);
            Controls.Add(MenuV);
            Controls.Add(BarraDeTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            BarraDeTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Cerrar).EndInit();
            MenuV.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraDeTitulo;
        private PictureBox Minimizar;
        private PictureBox Maximizar;
        private PictureBox Cerrar;
        private Panel MenuV;
        private Button Inicio;
        private Button Registro;
        private Button Mas;
        private Panel panel1;
        private Button CerrarS;
        private Button Login;
        private Panel panelContenedor;
    }
}
