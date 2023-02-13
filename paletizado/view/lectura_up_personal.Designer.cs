using System;
namespace paletizado.view
{
    partial class lectura_up_personal
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_up = new System.Windows.Forms.Label();
            this.lbl_personal = new System.Windows.Forms.Label();
            this.txt_personal_l = new System.Windows.Forms.TextBox();
            this.txt_up_l = new System.Windows.Forms.TextBox();
            this.txt_lectura_l = new System.Windows.Forms.TextBox();
            this.txt_error = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txt_error);
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_up);
            this.panel1.Controls.Add(this.lbl_personal);
            this.panel1.Controls.Add(this.txt_personal_l);
            this.panel1.Controls.Add(this.txt_up_l);
            this.panel1.Controls.Add(this.txt_lectura_l);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 413);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(119, 320);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(131, 42);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lectura:";
            // 
            // lbl_up
            // 
            this.lbl_up.AutoSize = true;
            this.lbl_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_up.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_up.Location = new System.Drawing.Point(45, 130);
            this.lbl_up.Name = "lbl_up";
            this.lbl_up.Size = new System.Drawing.Size(43, 24);
            this.lbl_up.TabIndex = 6;
            this.lbl_up.Text = "UP:";
            // 
            // lbl_personal
            // 
            this.lbl_personal.AutoSize = true;
            this.lbl_personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_personal.Location = new System.Drawing.Point(4, 213);
            this.lbl_personal.Name = "lbl_personal";
            this.lbl_personal.Size = new System.Drawing.Size(98, 24);
            this.lbl_personal.TabIndex = 5;
            this.lbl_personal.Text = "Personal:";
            // 
            // txt_personal_l
            // 
            this.txt_personal_l.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_personal_l.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_personal_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personal_l.Location = new System.Drawing.Point(108, 215);
            this.txt_personal_l.Multiline = true;
            this.txt_personal_l.Name = "txt_personal_l";
            this.txt_personal_l.Size = new System.Drawing.Size(266, 63);
            this.txt_personal_l.TabIndex = 2;
            // 
            // txt_up_l
            // 
            this.txt_up_l.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_up_l.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_up_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_up_l.Location = new System.Drawing.Point(94, 132);
            this.txt_up_l.Name = "txt_up_l";
            this.txt_up_l.Size = new System.Drawing.Size(266, 22);
            this.txt_up_l.TabIndex = 1;
            this.txt_up_l.TextChanged += new System.EventHandler(this.txt_up_TextChanged);
            // 
            // txt_lectura_l
            // 
            this.txt_lectura_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lectura_l.Location = new System.Drawing.Point(94, 51);
            this.txt_lectura_l.Name = "txt_lectura_l";
            this.txt_lectura_l.Size = new System.Drawing.Size(266, 29);
            this.txt_lectura_l.TabIndex = 0;
            this.txt_lectura_l.TextChanged += new System.EventHandler(this.txt_lectura_l_TextChanged);
            // 
            // txt_error
            // 
            this.txt_error.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_error.ForeColor = System.Drawing.Color.Red;
            this.txt_error.Location = new System.Drawing.Point(49, 97);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(311, 19);
            this.txt_error.TabIndex = 9;
            // 
            // lectura_up_personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 411);
            this.Controls.Add(this.panel1);
            this.Name = "lectura_up_personal";
            this.Text = "lectura_up_personal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_up;
        private System.Windows.Forms.Label lbl_personal;
        private System.Windows.Forms.TextBox txt_personal_l;
        private System.Windows.Forms.TextBox txt_up_l;
        private System.Windows.Forms.TextBox txt_lectura_l;
        private System.Windows.Forms.TextBox txt_error;
    }
}