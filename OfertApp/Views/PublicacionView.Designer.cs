namespace OfertApp.Views
{
    partial class PublicacionView
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
            btnPublicar = new Button();
            imagen = new Panel();
            label1 = new Label();
            lblTitulo = new Label();
            lblDescripcion = new Label();
            lblInicioPromo = new Label();
            lblFinPromo = new Label();
            textBox1 = new TextBox();
            txtDescripcion = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            imagen.SuspendLayout();
            SuspendLayout();
            // 
            // btnPublicar
            // 
            btnPublicar.Location = new Point(648, 480);
            btnPublicar.Name = "btnPublicar";
            btnPublicar.Size = new Size(112, 34);
            btnPublicar.TabIndex = 0;
            btnPublicar.Text = "Publicar";
            btnPublicar.UseVisualStyleBackColor = true;
            // 
            // imagen
            // 
            imagen.BackColor = SystemColors.ControlDarkDark;
            imagen.Controls.Add(label1);
            imagen.Location = new Point(12, 12);
            imagen.Name = "imagen";
            imagen.Size = new Size(300, 400);
            imagen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 198);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 0;
            label1.Text = "Aqui iria la imagen";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(332, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 25);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(332, 55);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(104, 25);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblInicioPromo
            // 
            lblInicioPromo.AutoSize = true;
            lblInicioPromo.Location = new Point(332, 164);
            lblInicioPromo.Name = "lblInicioPromo";
            lblInicioPromo.Size = new Size(139, 25);
            lblInicioPromo.TabIndex = 4;
            lblInicioPromo.Text = "Inicio de promo";
            // 
            // lblFinPromo
            // 
            lblFinPromo.AutoSize = true;
            lblFinPromo.Location = new Point(332, 210);
            lblFinPromo.Name = "lblFinPromo";
            lblFinPromo.Size = new Size(120, 25);
            lblFinPromo.TabIndex = 5;
            lblFinPromo.Text = "Fin de promo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(479, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 31);
            textBox1.TabIndex = 6;
            textBox1.Text = "Milanesas x kg";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(481, 58);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(279, 31);
            txtDescripcion.TabIndex = 7;
            txtDescripcion.Text = "En el Mercadito el queso cremoso X está en oferta $6500";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(484, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(276, 31);
            textBox2.TabIndex = 8;
            textBox2.Text = "24/05/2024";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(487, 217);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(273, 31);
            textBox3.TabIndex = 9;
            textBox3.Text = "26/05/2024";
            // 
            // PublicacionView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 526);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtDescripcion);
            Controls.Add(textBox1);
            Controls.Add(lblFinPromo);
            Controls.Add(lblInicioPromo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Controls.Add(imagen);
            Controls.Add(btnPublicar);
            Name = "PublicacionView";
            Text = "PublicacionView";
            imagen.ResumeLayout(false);
            imagen.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPublicar;
        private Panel imagen;
        private Label label1;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblInicioPromo;
        private Label lblFinPromo;
        private TextBox textBox1;
        private TextBox txtDescripcion;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}