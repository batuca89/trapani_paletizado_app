namespace paletizado.view
{
    partial class Buscar_cospel
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
            this.txt_buscar_cospel = new System.Windows.Forms.TextBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_error = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txt_error);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.txt_buscar_cospel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 357);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Provisorio";
            // 
            // txt_buscar_cospel
            // 
            this.txt_buscar_cospel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_cospel.Location = new System.Drawing.Point(36, 140);
            this.txt_buscar_cospel.Name = "txt_buscar_cospel";
            this.txt_buscar_cospel.Size = new System.Drawing.Size(313, 38);
            this.txt_buscar_cospel.TabIndex = 1;
            this.txt_buscar_cospel.TextChanged += new System.EventHandler(this.txt_buscar_cospel_TextChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(120, 280);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(130, 38);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // txt_error
            // 
            this.txt_error.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_error.ForeColor = System.Drawing.Color.Red;
            this.txt_error.Location = new System.Drawing.Point(36, 195);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(313, 31);
            this.txt_error.TabIndex = 3;
            // 
            // Buscar_cospel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 356);
            this.Controls.Add(this.panel1);
            this.Name = "Buscar_cospel";
            this.Text = "Buscar_cospel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_buscar_cospel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_error;
    }
}