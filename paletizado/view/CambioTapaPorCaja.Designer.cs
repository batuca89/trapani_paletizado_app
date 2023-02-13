namespace paletizado.view
{
    partial class CambioTapaPorCaja
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lectura = new System.Windows.Forms.TextBox();
            this.cambioTapaPorCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgva = new System.Windows.Forms.DataGridView();
            this.txt_error = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idempaquevolcadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesocajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambioDeTapaPorCadaCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_cargar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cambioTapaPorCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambioDeTapaPorCadaCajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_cargar);
            this.panel1.Controls.Add(this.txt_error);
            this.panel1.Controls.Add(this.dgva);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_lectura);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 524);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lectura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lea todas las cajas que desea cambiar y luego pulse cargar";
            // 
            // txt_lectura
            // 
            this.txt_lectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lectura.Location = new System.Drawing.Point(131, 123);
            this.txt_lectura.Name = "txt_lectura";
            this.txt_lectura.Size = new System.Drawing.Size(313, 26);
            this.txt_lectura.TabIndex = 0;
            this.txt_lectura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgva
            // 
            this.dgva.AutoGenerateColumns = false;
            this.dgva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.idempaquevolcadoDataGridViewTextBoxColumn,
            this.pesocajaDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgva.DataSource = this.cambioDeTapaPorCadaCajaBindingSource;
            this.dgva.Location = new System.Drawing.Point(493, 123);
            this.dgva.Name = "dgva";
            this.dgva.Size = new System.Drawing.Size(590, 276);
            this.dgva.TabIndex = 4;
            // 
            // txt_error
            // 
            this.txt_error.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_error.ForeColor = System.Drawing.Color.Black;
            this.txt_error.Location = new System.Drawing.Point(9, 193);
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(435, 22);
            this.txt_error.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_empleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // idempaquevolcadoDataGridViewTextBoxColumn
            // 
            this.idempaquevolcadoDataGridViewTextBoxColumn.DataPropertyName = "Id_empaque_volcado";
            this.idempaquevolcadoDataGridViewTextBoxColumn.HeaderText = "Id_empaque_volcado";
            this.idempaquevolcadoDataGridViewTextBoxColumn.Name = "idempaquevolcadoDataGridViewTextBoxColumn";
            // 
            // pesocajaDataGridViewTextBoxColumn
            // 
            this.pesocajaDataGridViewTextBoxColumn.DataPropertyName = "Peso_caja";
            this.pesocajaDataGridViewTextBoxColumn.HeaderText = "Peso_caja";
            this.pesocajaDataGridViewTextBoxColumn.Name = "pesocajaDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cod_empaque";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cod_empaque";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo_barra";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo_barra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cambioDeTapaPorCadaCajaBindingSource
            // 
            this.cambioDeTapaPorCadaCajaBindingSource.DataSource = typeof(paletizado.models.CambioDeTapaPorCadaCaja);
            // 
            // btn_cargar
            // 
            this.btn_cargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar.Location = new System.Drawing.Point(243, 451);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(142, 49);
            this.btn_cargar.TabIndex = 6;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(637, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CambioTapaPorCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 524);
            this.Controls.Add(this.panel1);
            this.Name = "CambioTapaPorCaja";
            this.Text = "CambioTapaPorCaja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cambioTapaPorCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cambioDeTapaPorCadaCajaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVolcadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpaqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cambioTapaPorCajaBindingSource;
        private System.Windows.Forms.DataGridView dgva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempaquevolcadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesocajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource cambioDeTapaPorCadaCajaBindingSource;
        private System.Windows.Forms.TextBox txt_error;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cargar;
    }
}