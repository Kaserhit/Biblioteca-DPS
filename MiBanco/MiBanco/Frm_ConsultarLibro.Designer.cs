﻿namespace MiBanco
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Busqueda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 128);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(533, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 36);
            this.label6.TabIndex = 7;
            this.label6.Text = "Consulta Libro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(1095, 429);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(112, 35);
            this.btn_salir.TabIndex = 14;
            this.btn_salir.Text = "&Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(1095, 331);
            this.btn_Ejecutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(112, 35);
            this.btn_Ejecutar.TabIndex = 13;
            this.btn_Ejecutar.Text = "Mostrar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 243);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 290);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Busqueda
            // 
            this.Busqueda.Location = new System.Drawing.Point(67, 170);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(158, 35);
            this.Busqueda.TabIndex = 17;
            this.Busqueda.Text = "Busqueda:";
            this.Busqueda.UseVisualStyleBackColor = true;
            this.Busqueda.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_ConsultarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 684);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_ConsultarLibro";
            this.ShowIcon = false;
            this.Text = "Frm_Reportar";
            this.Load += new System.EventHandler(this.Frm_Reportar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}