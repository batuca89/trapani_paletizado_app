namespace paletizado.view
{
    partial class Lectura_etiquetas
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
            this.txt_lectura = new System.Windows.Forms.TextBox();
            this.txt_up = new System.Windows.Forms.TextBox();
            this.txt_personal = new System.Windows.Forms.TextBox();
            this.txt_error_up = new System.Windows.Forms.TextBox();
            this.txt_error_emnalador = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txt_error_emnalador);
            this.panel1.Controls.Add(this.txt_error_up);
            this.panel1.Controls.Add(this.txt_personal);
            this.panel1.Controls.Add(this.txt_up);
            this.panel1.Controls.Add(this.txt_lectura);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_lectura
            // 
            this.txt_lectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lectura.Location = new System.Drawing.Point(74, 61);
            this.txt_lectura.Name = "txt_lectura";
            this.txt_lectura.Size = new System.Drawing.Size(247, 29);
            this.txt_lectura.TabIndex = 0;
            this.txt_lectura.TextChanged += new System.EventHandler(this.txt_lectura_TextChanged);
            // 
            // txt_up
            // 
            this.txt_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_up.Location = new System.Drawing.Point(11, 167);
            this.txt_up.Name = "txt_up";
            this.txt_up.Size = new System.Drawing.Size(361, 29);
            this.txt_up.TabIndex = 1;
            // 
            // txt_personal
            // 
            this.txt_personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personal.Location = new System.Drawing.Point(11, 274);
            this.txt_personal.Name = "txt_personal";
            this.txt_personal.Size = new System.Drawing.Size(361, 29);
            this.txt_personal.TabIndex = 2;
            // 
            // txt_error_up
            // 
            this.txt_error_up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_error_up.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_error_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_error_up.ForeColor = System.Drawing.Color.Red;
            this.txt_error_up.Location = new System.Drawing.Point(11, 202);
            this.txt_error_up.Name = "txt_error_up";
            this.txt_error_up.Size = new System.Drawing.Size(361, 22);
            this.txt_error_up.TabIndex = 3;
            // 
            // txt_error_emnalador
            // 
            this.txt_error_emnalador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_error_emnalador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_error_emnalador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_error_emnalador.ForeColor = System.Drawing.Color.Red;
            this.txt_error_emnalador.Location = new System.Drawing.Point(11, 309);
            this.txt_error_emnalador.Name = "txt_error_emnalador";
            this.txt_error_emnalador.Size = new System.Drawing.Size(361, 22);
            this.txt_error_emnalador.TabIndex = 4;
            // 
            // Lectura_etiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 447);
            this.Controls.Add(this.panel1);
            this.Name = "Lectura_etiquetas";
            this.Text = "Lectura_etiquetas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_personal;
        private System.Windows.Forms.TextBox txt_up;
        private System.Windows.Forms.TextBox txt_lectura;
        private System.Windows.Forms.TextBox txt_error_up;
        private System.Windows.Forms.TextBox txt_error_emnalador;
    }
}