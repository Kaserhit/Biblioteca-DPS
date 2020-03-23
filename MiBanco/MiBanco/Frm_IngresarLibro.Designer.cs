namespace MiBanco
{
    partial class Frm_IngresarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IngresarLibro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_autor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Edicion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Editorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tematica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_escuela = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_asignatura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Unidades = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Isbn = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 128);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelvLight", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(435, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 43);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingresar Libro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("HelvLight", 12F);
            this.btn_salir.Location = new System.Drawing.Point(642, 643);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(151, 57);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Font = new System.Drawing.Font("HelvLight", 12F);
            this.btn_Ejecutar.Location = new System.Drawing.Point(394, 643);
            this.btn_Ejecutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(151, 57);
            this.btn_Ejecutar.TabIndex = 12;
            this.btn_Ejecutar.Text = "Confirmar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre del Libro:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(742, 157);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(324, 26);
            this.txt_nombre.TabIndex = 15;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_Santerior_TextChanged);
            // 
            // txt_autor
            // 
            this.txt_autor.Location = new System.Drawing.Point(742, 241);
            this.txt_autor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_autor.Name = "txt_autor";
            this.txt_autor.Size = new System.Drawing.Size(324, 26);
            this.txt_autor.TabIndex = 17;
            this.txt_autor.TextChanged += new System.EventHandler(this.txt_autor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autor:";
            // 
            // txt_Edicion
            // 
            this.txt_Edicion.Location = new System.Drawing.Point(742, 315);
            this.txt_Edicion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Edicion.Name = "txt_Edicion";
            this.txt_Edicion.Size = new System.Drawing.Size(324, 26);
            this.txt_Edicion.TabIndex = 21;
            this.txt_Edicion.TextChanged += new System.EventHandler(this.txt_Edicion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(596, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Edicion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Editorial
            // 
            this.txt_Editorial.Location = new System.Drawing.Point(195, 314);
            this.txt_Editorial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Editorial.Name = "txt_Editorial";
            this.txt_Editorial.Size = new System.Drawing.Size(324, 26);
            this.txt_Editorial.TabIndex = 19;
            this.txt_Editorial.TextChanged += new System.EventHandler(this.txt_Editorial_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Editorial:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_tematica
            // 
            this.txt_tematica.Location = new System.Drawing.Point(742, 405);
            this.txt_tematica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tematica.Name = "txt_tematica";
            this.txt_tematica.Size = new System.Drawing.Size(324, 26);
            this.txt_tematica.TabIndex = 25;
            this.txt_tematica.TextChanged += new System.EventHandler(this.txt_tematica_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tematica:";
            // 
            // txt_escuela
            // 
            this.txt_escuela.Location = new System.Drawing.Point(195, 405);
            this.txt_escuela.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_escuela.Name = "txt_escuela";
            this.txt_escuela.Size = new System.Drawing.Size(324, 26);
            this.txt_escuela.TabIndex = 23;
            this.txt_escuela.TextChanged += new System.EventHandler(this.txt_escuela_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Escuela:";
            // 
            // txt_asignatura
            // 
            this.txt_asignatura.Location = new System.Drawing.Point(429, 565);
            this.txt_asignatura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_asignatura.Name = "txt_asignatura";
            this.txt_asignatura.Size = new System.Drawing.Size(324, 26);
            this.txt_asignatura.TabIndex = 27;
            this.txt_asignatura.TextChanged += new System.EventHandler(this.txt_asignatura_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Asignatura:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Unidades:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_Unidades
            // 
            this.txt_Unidades.Location = new System.Drawing.Point(195, 241);
            this.txt_Unidades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Unidades.Name = "txt_Unidades";
            this.txt_Unidades.Size = new System.Drawing.Size(324, 26);
            this.txt_Unidades.TabIndex = 29;
            this.txt_Unidades.TextChanged += new System.EventHandler(this.txt_Unidades_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Isbn:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_Isbn
            // 
            this.txt_Isbn.Location = new System.Drawing.Point(195, 160);
            this.txt_Isbn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Isbn.Name = "txt_Isbn";
            this.txt_Isbn.Size = new System.Drawing.Size(324, 26);
            this.txt_Isbn.TabIndex = 31;
            this.txt_Isbn.TextChanged += new System.EventHandler(this.txt_Isbn_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiBanco.Properties.Resources.Sin_título_4;
            this.pictureBox1.Location = new System.Drawing.Point(103, 507);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 147);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("HelvLight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(89, 657);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 28);
            this.label11.TabIndex = 32;
            this.label11.Text = "Biblioteca Ulacit";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(866, 657);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 188);
            this.panel3.TabIndex = 34;
            // 
            // Frm_IngresarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1132, 762);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Isbn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Unidades);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_asignatura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tematica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_escuela);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Edicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Editorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_autor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1154, 0);
            this.Name = "Frm_IngresarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Ulacit";
            this.Load += new System.EventHandler(this.Frm_IngresarLibro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_autor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Edicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Editorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tematica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_escuela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_asignatura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Unidades;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Isbn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
    }
}