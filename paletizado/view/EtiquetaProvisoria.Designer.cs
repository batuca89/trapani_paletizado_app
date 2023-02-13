namespace paletizado.view
{
    partial class EtiquetaProvisoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cospel_nro = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_calibre = new System.Windows.Forms.TextBox();
            this.txt_con_embalado = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.txt_codigo_barra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_envase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_envase);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_codigo_barra);
            this.panel1.Controls.Add(this.picture);
            this.panel1.Controls.Add(this.txt_con_embalado);
            this.panel1.Controls.Add(this.txt_calibre);
            this.panel1.Controls.Add(this.txt_marca);
            this.panel1.Controls.Add(this.txt_cospel_nro);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 505);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etiqueta Provisoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calibre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Provisorio Nro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cond embalado:";
            // 
            // txt_cospel_nro
            // 
            this.txt_cospel_nro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cospel_nro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cospel_nro.Location = new System.Drawing.Point(430, 71);
            this.txt_cospel_nro.Name = "txt_cospel_nro";
            this.txt_cospel_nro.Size = new System.Drawing.Size(132, 31);
            this.txt_cospel_nro.TabIndex = 5;
            // 
            // txt_marca
            // 
            this.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.Location = new System.Drawing.Point(229, 124);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(333, 31);
            this.txt_marca.TabIndex = 6;
            // 
            // txt_calibre
            // 
            this.txt_calibre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_calibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_calibre.Location = new System.Drawing.Point(229, 176);
            this.txt_calibre.Name = "txt_calibre";
            this.txt_calibre.Size = new System.Drawing.Size(333, 31);
            this.txt_calibre.TabIndex = 7;
            // 
            // txt_con_embalado
            // 
            this.txt_con_embalado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_con_embalado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_con_embalado.Location = new System.Drawing.Point(229, 269);
            this.txt_con_embalado.Name = "txt_con_embalado";
            this.txt_con_embalado.Size = new System.Drawing.Size(329, 31);
            this.txt_con_embalado.TabIndex = 8;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(13, 367);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(534, 119);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picture.TabIndex = 9;
            this.picture.TabStop = false;
            // 
            // txt_codigo_barra
            // 
            this.txt_codigo_barra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo_barra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_barra.Location = new System.Drawing.Point(109, 333);
            this.txt_codigo_barra.Name = "txt_codigo_barra";
            this.txt_codigo_barra.Size = new System.Drawing.Size(329, 28);
            this.txt_codigo_barra.TabIndex = 10;
            this.txt_codigo_barra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Conf. Imp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(290, 528);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(141, 36);
            this.btn_imprimir.TabIndex = 12;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // txt_envase
            // 
            this.txt_envase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_envase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_envase.Location = new System.Drawing.Point(229, 225);
            this.txt_envase.Name = "txt_envase";
            this.txt_envase.Size = new System.Drawing.Size(333, 31);
            this.txt_envase.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Envase:";
            // 
            // EtiquetaProvisoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 576);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "EtiquetaProvisoria";
            this.Text = "EtiquetaProvisoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo_barra;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox txt_con_embalado;
        private System.Windows.Forms.TextBox txt_calibre;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_cospel_nro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox txt_envase;
        private System.Windows.Forms.Label label6;
    }
}