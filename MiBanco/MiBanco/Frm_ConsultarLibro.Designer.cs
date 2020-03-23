namespace MiBanco
{
    partial class Frm_ConsultarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConsultarLibro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Busqueda = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 128);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelvLight", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(548, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 43);
            this.label6.TabIndex = 7;
            this.label6.Text = "Consultas";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("HelvLight", 12F);
            this.btn_salir.Location = new System.Drawing.Point(1084, 146);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(121, 46);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Font = new System.Drawing.Font("HelvLight", 12F);
            this.btn_Ejecutar.Location = new System.Drawing.Point(1144, 799);
            this.btn_Ejecutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(121, 50);
            this.btn_Ejecutar.TabIndex = 13;
            this.btn_Ejecutar.Text = "Mostrar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 243);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 476);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 812);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(778, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Busqueda
            // 
            this.Busqueda.Font = new System.Drawing.Font("HelvLight", 12F);
            this.Busqueda.Location = new System.Drawing.Point(105, 799);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(185, 46);
            this.Busqueda.TabIndex = 17;
            this.Busqueda.Text = "Busqueda:";
            this.Busqueda.UseVisualStyleBackColor = true;
            this.Busqueda.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("HelvLight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(1079, 711);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 28);
            this.label11.TabIndex = 34;
            this.label11.Text = "Biblioteca Ulacit";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1084, 518);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(259, 159);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(728, 882);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 102);
            this.panel2.TabIndex = 37;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Usuarios",
            "Libros",
            "Mantenimiento"});
            this.comboBox1.Location = new System.Drawing.Point(465, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 28);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelvLight", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Seleccione el tipo de consulta:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("HelvLight", 12F);
            this.button1.Location = new System.Drawing.Point(1056, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 50);
            this.button1.TabIndex = 41;
            this.button1.Text = "Ingresar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("HelvLight", 12F);
            this.button2.Location = new System.Drawing.Point(1056, 332);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 50);
            this.button2.TabIndex = 42;
            this.button2.Text = "Eliminar Usuario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("HelvLight", 12F);
            this.button3.Location = new System.Drawing.Point(1056, 410);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 50);
            this.button3.TabIndex = 43;
            this.button3.Text = "Modificar Usuario";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("HelvLight", 12F);
            this.button4.Location = new System.Drawing.Point(1056, 254);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(209, 50);
            this.button4.TabIndex = 44;
            this.button4.Text = "Modificar Libro";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("HelvLight", 12F);
            this.button5.Location = new System.Drawing.Point(1056, 332);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(209, 50);
            this.button5.TabIndex = 45;
            this.button5.Text = "Eliminar Libro";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("HelvLight", 12F);
            this.button6.Location = new System.Drawing.Point(1056, 254);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(209, 50);
            this.button6.TabIndex = 46;
            this.button6.Text = "Restaurar Libro";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Frm_ConsultarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1321, 950);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1343, 1006);
            this.Name = "Frm_ConsultarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Ulacit";
            this.Load += new System.EventHandler(this.Frm_Reportar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Busqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}