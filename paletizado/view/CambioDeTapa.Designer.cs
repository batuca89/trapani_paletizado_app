namespace paletizado.view
{
    partial class CambioDeTapa
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
            this.txt_cajas_leidas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_leer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cajas = new System.Windows.Forms.TextBox();
            this.txt_lectura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_cajas_leidas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_leer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_cajas);
            this.panel1.Controls.Add(this.txt_lectura);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_info);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 469);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_cajas_leidas
            // 
            this.txt_cajas_leidas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_cajas_leidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cajas_leidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cajas_leidas.Location = new System.Drawing.Point(296, 240);
            this.txt_cajas_leidas.Name = "txt_cajas_leidas";
            this.txt_cajas_leidas.Size = new System.Drawing.Size(47, 22);
            this.txt_cajas_leidas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de cajas leidas:";
            // 
            // txt_leer
            // 
            this.txt_leer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_leer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_leer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leer.Location = new System.Drawing.Point(51, 134);
            this.txt_leer.Name = "txt_leer";
            this.txt_leer.Size = new System.Drawing.Size(296, 22);
            this.txt_leer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cajas:";
            // 
            // txt_cajas
            // 
            this.txt_cajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cajas.Location = new System.Drawing.Point(370, 83);
            this.txt_cajas.Name = "txt_cajas";
            this.txt_cajas.Size = new System.Drawing.Size(47, 29);
            this.txt_cajas.TabIndex = 3;
            // 
            // txt_lectura
            // 
            this.txt_lectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lectura.Location = new System.Drawing.Point(51, 174);
            this.txt_lectura.Name = "txt_lectura";
            this.txt_lectura.Size = new System.Drawing.Size(217, 29);
            this.txt_lectura.TabIndex = 2;
            this.txt_lectura.TextChanged += new System.EventHandler(this.txt_lectura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lectura de caja";
            // 
            // txt_info
            // 
            this.txt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.Location = new System.Drawing.Point(3, 83);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(296, 29);
            this.txt_info.TabIndex = 0;
            this.txt_info.TextChanged += new System.EventHandler(this.txt_info_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear nuevo Provisorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(238, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Agregar a un provisorio existente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(518, 363);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(387, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 51);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cambio de tapa por caja";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CambioDeTapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 475);
            this.Controls.Add(this.panel1);
            this.Name = "CambioDeTapa";
            this.Text = "CambioDeTapa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_cajas;
        private System.Windows.Forms.TextBox txt_lectura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_leer;
        private System.Windows.Forms.TextBox txt_cajas_leidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}