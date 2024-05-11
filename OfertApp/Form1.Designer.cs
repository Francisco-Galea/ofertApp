namespace OfertApp
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
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            vScrollBar1 = new VScrollBar();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 425);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 443);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Positivo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(260, 443);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Negativo";
            button2.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(824, 12);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(39, 555);
            vScrollBar1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(450, 516);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 4;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(322, 516);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 5;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(674, 530);
            button5.Name = "button5";
            button5.Size = new Size(147, 34);
            button5.TabIndex = 6;
            button5.Text = "Actualizar feed";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 576);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(vScrollBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private VScrollBar vScrollBar1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
