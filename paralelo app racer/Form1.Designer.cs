namespace paralelo_app_racer
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
            panel1 = new Panel();
            button1 = new Button();
            generar = new Button();
            borrar = new Button();
            comenzar = new Button();
            txtnumero = new TextBox();
            txtarreglo = new TextBox();
            txtbinaria = new TextBox();
            txtbsecuencial = new TextBox();
            txtinsercion = new TextBox();
            txtquick = new TextBox();
            txtburbuja = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(generar);
            panel1.Controls.Add(borrar);
            panel1.Controls.Add(comenzar);
            panel1.Controls.Add(txtnumero);
            panel1.Controls.Add(txtarreglo);
            panel1.Controls.Add(txtbinaria);
            panel1.Controls.Add(txtbsecuencial);
            panel1.Controls.Add(txtinsercion);
            panel1.Controls.Add(txtquick);
            panel1.Controls.Add(txtburbuja);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 343);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(550, 299);
            button1.Name = "button1";
            button1.Size = new Size(176, 32);
            button1.TabIndex = 20;
            button1.Text = "salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // generar
            // 
            generar.BackColor = Color.Snow;
            generar.FlatStyle = FlatStyle.Flat;
            generar.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            generar.Location = new Point(15, 299);
            generar.Name = "generar";
            generar.Size = new Size(157, 32);
            generar.TabIndex = 19;
            generar.Text = "Generar";
            generar.UseVisualStyleBackColor = false;
            generar.Click += generar_Click;
            // 
            // borrar
            // 
            borrar.BackColor = Color.Snow;
            borrar.FlatStyle = FlatStyle.Flat;
            borrar.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            borrar.Location = new Point(357, 299);
            borrar.Name = "borrar";
            borrar.Size = new Size(176, 34);
            borrar.TabIndex = 18;
            borrar.Text = "Reiniciar";
            borrar.UseVisualStyleBackColor = false;
            borrar.Click += borrar_Click;
            // 
            // comenzar
            // 
            comenzar.BackColor = Color.Snow;
            comenzar.FlatStyle = FlatStyle.Flat;
            comenzar.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point);
            comenzar.Location = new Point(187, 299);
            comenzar.Name = "comenzar";
            comenzar.Size = new Size(157, 32);
            comenzar.TabIndex = 17;
            comenzar.Text = "Comenzar";
            comenzar.UseVisualStyleBackColor = false;
            comenzar.Click += button1_Click;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(381, 102);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(345, 23);
            txtnumero.TabIndex = 16;
            // 
            // txtarreglo
            // 
            txtarreglo.Location = new Point(15, 102);
            txtarreglo.Name = "txtarreglo";
            txtarreglo.Size = new Size(304, 23);
            txtarreglo.TabIndex = 15;
            // 
            // txtbinaria
            // 
            txtbinaria.Location = new Point(550, 212);
            txtbinaria.Name = "txtbinaria";
            txtbinaria.ReadOnly = true;
            txtbinaria.Size = new Size(187, 23);
            txtbinaria.TabIndex = 14;
            // 
            // txtbsecuencial
            // 
            txtbsecuencial.Location = new Point(550, 165);
            txtbsecuencial.Name = "txtbsecuencial";
            txtbsecuencial.ReadOnly = true;
            txtbsecuencial.Size = new Size(187, 23);
            txtbsecuencial.TabIndex = 13;
            // 
            // txtinsercion
            // 
            txtinsercion.Location = new Point(116, 256);
            txtinsercion.Name = "txtinsercion";
            txtinsercion.ReadOnly = true;
            txtinsercion.Size = new Size(205, 23);
            txtinsercion.TabIndex = 12;
            // 
            // txtquick
            // 
            txtquick.Location = new Point(117, 211);
            txtquick.Name = "txtquick";
            txtquick.ReadOnly = true;
            txtquick.Size = new Size(202, 23);
            txtquick.TabIndex = 11;
            // 
            // txtburbuja
            // 
            txtburbuja.Location = new Point(117, 166);
            txtburbuja.Name = "txtburbuja";
            txtburbuja.ReadOnly = true;
            txtburbuja.Size = new Size(201, 23);
            txtburbuja.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(342, 214);
            label8.Name = "label8";
            label8.Size = new Size(162, 20);
            label8.TabIndex = 9;
            label8.Text = "Busqueda Binaria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(342, 167);
            label7.Name = "label7";
            label7.Size = new Size(193, 20);
            label7.TabIndex = 8;
            label7.Text = "Busqueda secuencial ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(413, 76);
            label6.Name = "label6";
            label6.Size = new Size(274, 23);
            label6.TabIndex = 7;
            label6.Text = "Numero que desea buscar.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(10, 257);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 6;
            label5.Text = "insercion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(8, 211);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 5;
            label4.Text = "Quicksort";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(11, 164);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Burbuja ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(43, 76);
            label2.Name = "label2";
            label2.Size = new Size(256, 23);
            label2.TabIndex = 3;
            label2.Text = "Introduzca un arreglo.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(238, 27);
            label1.Name = "label1";
            label1.Size = new Size(246, 23);
            label1.TabIndex = 2;
            label1.Text = "Simulador de carrera. ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 343);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Racer Paralelo ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button comenzar;
        private TextBox txtnumero;
        private TextBox txtarreglo;
        private TextBox txtbinaria;
        private TextBox txtbsecuencial;
        private TextBox txtinsercion;
        private TextBox txtquick;
        private TextBox txtburbuja;
        private Button borrar;
        private Button generar;
        private Button button1;
    }
}