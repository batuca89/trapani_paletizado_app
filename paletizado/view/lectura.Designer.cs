namespace paletizado.view
{
    partial class lectura
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
            this.label9 = new System.Windows.Forms.Label();
            this.cb_calibre = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_cospel_nro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_condicion_embalado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_empleado = new System.Windows.Forms.TextBox();
            this.txt_error = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_up = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lecturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEmpaqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSenasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tareaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calibreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.envaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturaCajasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_envases_disponibles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cajas_leidas = new System.Windows.Forms.TextBox();
            this.txt_lectura = new System.Windows.Forms.TextBox();
            this.lecturaCajasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaCajasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaCajasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cb_calibre);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txt_cospel_nro);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cb_condicion_embalado);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_marca);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_empleado);
            this.panel1.Controls.Add(this.txt_error);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_up);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_envases_disponibles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_cajas_leidas);
            this.panel1.Controls.Add(this.txt_lectura);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 737);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1029, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Provisorio Nro:";
            // 
            // cb_calibre
            // 
            this.cb_calibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_calibre.FormattingEnabled = true;
            this.cb_calibre.Location = new System.Drawing.Point(483, 59);
            this.cb_calibre.Name = "cb_calibre";
            this.cb_calibre.Size = new System.Drawing.Size(152, 28);
            this.cb_calibre.TabIndex = 22;
            this.cb_calibre.SelectedIndexChanged += new System.EventHandler(this.cb_calibre_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 676);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 47);
            this.button2.TabIndex = 21;
            this.button2.Text = "Imprimir Etiqueta Provisoaria";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_cospel_nro
            // 
            this.txt_cospel_nro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cospel_nro.Location = new System.Drawing.Point(1111, 19);
            this.txt_cospel_nro.Name = "txt_cospel_nro";
            this.txt_cospel_nro.Size = new System.Drawing.Size(86, 26);
            this.txt_cospel_nro.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lectura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Condicion embalado:";
            // 
            // cb_condicion_embalado
            // 
            this.cb_condicion_embalado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_condicion_embalado.FormattingEnabled = true;
            this.cb_condicion_embalado.Location = new System.Drawing.Point(847, 58);
            this.cb_condicion_embalado.Name = "cb_condicion_embalado";
            this.cb_condicion_embalado.Size = new System.Drawing.Size(180, 28);
            this.cb_condicion_embalado.TabIndex = 17;
            this.cb_condicion_embalado.SelectedIndexChanged += new System.EventHandler(this.cb_condicion_embalado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Calibre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Marca:";
            // 
            // txt_marca
            // 
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.Location = new System.Drawing.Point(788, 16);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ReadOnly = true;
            this.txt_marca.Size = new System.Drawing.Size(180, 26);
            this.txt_marca.TabIndex = 13;
            this.txt_marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(957, 676);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cargar Provisorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Empleado:";
            // 
            // txt_empleado
            // 
            this.txt_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empleado.Location = new System.Drawing.Point(70, 132);
            this.txt_empleado.Name = "txt_empleado";
            this.txt_empleado.Size = new System.Drawing.Size(253, 26);
            this.txt_empleado.TabIndex = 10;
            // 
            // txt_error
            // 
            this.txt_error.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_error.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_error.Location = new System.Drawing.Point(337, 107);
            this.txt_error.Multiline = true;
            this.txt_error.Name = "txt_error";
            this.txt_error.Size = new System.Drawing.Size(872, 51);
            this.txt_error.TabIndex = 9;
            this.txt_error.TextChanged += new System.EventHandler(this.txt_error_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "UP:";
            // 
            // txt_up
            // 
            this.txt_up.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_up.Location = new System.Drawing.Point(70, 77);
            this.txt_up.Name = "txt_up";
            this.txt_up.Size = new System.Drawing.Size(253, 26);
            this.txt_up.TabIndex = 7;
            this.txt_up.TextChanged += new System.EventHandler(this.txt_up_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lecturaDataGridViewTextBoxColumn,
            this.codEmpaqueDataGridViewTextBoxColumn,
            this.fechaSenasaDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn,
            this.tareaDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn,
            this.observacionesDataGridViewTextBoxColumn,
            this.upDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.variedadDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.calibreDataGridViewTextBoxColumn,
            this.envaseDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.lecturaCajasBindingSource1;
            this.dgv.Location = new System.Drawing.Point(20, 178);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1177, 492);
            this.dgv.TabIndex = 6;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lecturaDataGridViewTextBoxColumn
            // 
            this.lecturaDataGridViewTextBoxColumn.DataPropertyName = "Lectura";
            this.lecturaDataGridViewTextBoxColumn.HeaderText = "Lectura";
            this.lecturaDataGridViewTextBoxColumn.Name = "lecturaDataGridViewTextBoxColumn";
            // 
            // codEmpaqueDataGridViewTextBoxColumn
            // 
            this.codEmpaqueDataGridViewTextBoxColumn.DataPropertyName = "CodEmpaque";
            this.codEmpaqueDataGridViewTextBoxColumn.HeaderText = "CodEmpaque";
            this.codEmpaqueDataGridViewTextBoxColumn.Name = "codEmpaqueDataGridViewTextBoxColumn";
            // 
            // fechaSenasaDataGridViewTextBoxColumn
            // 
            this.fechaSenasaDataGridViewTextBoxColumn.DataPropertyName = "FechaSenasa";
            this.fechaSenasaDataGridViewTextBoxColumn.HeaderText = "FechaSenasa";
            this.fechaSenasaDataGridViewTextBoxColumn.Name = "fechaSenasaDataGridViewTextBoxColumn";
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            // 
            // tareaDataGridViewTextBoxColumn
            // 
            this.tareaDataGridViewTextBoxColumn.DataPropertyName = "Tarea";
            this.tareaDataGridViewTextBoxColumn.HeaderText = "Tarea";
            this.tareaDataGridViewTextBoxColumn.Name = "tareaDataGridViewTextBoxColumn";
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            this.observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            this.observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // upDataGridViewTextBoxColumn
            // 
            this.upDataGridViewTextBoxColumn.DataPropertyName = "Up";
            this.upDataGridViewTextBoxColumn.HeaderText = "Up";
            this.upDataGridViewTextBoxColumn.Name = "upDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // variedadDataGridViewTextBoxColumn
            // 
            this.variedadDataGridViewTextBoxColumn.DataPropertyName = "Variedad";
            this.variedadDataGridViewTextBoxColumn.HeaderText = "Variedad";
            this.variedadDataGridViewTextBoxColumn.Name = "variedadDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // calibreDataGridViewTextBoxColumn
            // 
            this.calibreDataGridViewTextBoxColumn.DataPropertyName = "Calibre";
            this.calibreDataGridViewTextBoxColumn.HeaderText = "Calibre";
            this.calibreDataGridViewTextBoxColumn.Name = "calibreDataGridViewTextBoxColumn";
            // 
            // envaseDataGridViewTextBoxColumn
            // 
            this.envaseDataGridViewTextBoxColumn.DataPropertyName = "Envase";
            this.envaseDataGridViewTextBoxColumn.HeaderText = "Envase";
            this.envaseDataGridViewTextBoxColumn.Name = "envaseDataGridViewTextBoxColumn";
            // 
            // lecturaCajasBindingSource1
            // 
            this.lecturaCajasBindingSource1.DataSource = typeof(paletizado.models.LecturaCajas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Disponibles:";
            // 
            // txt_envases_disponibles
            // 
            this.txt_envases_disponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_envases_disponibles.Location = new System.Drawing.Point(660, 16);
            this.txt_envases_disponibles.Name = "txt_envases_disponibles";
            this.txt_envases_disponibles.ReadOnly = true;
            this.txt_envases_disponibles.Size = new System.Drawing.Size(65, 26);
            this.txt_envases_disponibles.TabIndex = 4;
            this.txt_envases_disponibles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_envases_disponibles.TextChanged += new System.EventHandler(this.txt_envases_disponibles_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cajas Leídas:";
            // 
            // txt_cajas_leidas
            // 
            this.txt_cajas_leidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cajas_leidas.Location = new System.Drawing.Point(500, 16);
            this.txt_cajas_leidas.Name = "txt_cajas_leidas";
            this.txt_cajas_leidas.ReadOnly = true;
            this.txt_cajas_leidas.Size = new System.Drawing.Size(70, 26);
            this.txt_cajas_leidas.TabIndex = 2;
            this.txt_cajas_leidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_lectura
            // 
            this.txt_lectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lectura.Location = new System.Drawing.Point(70, 24);
            this.txt_lectura.Name = "txt_lectura";
            this.txt_lectura.Size = new System.Drawing.Size(253, 26);
            this.txt_lectura.TabIndex = 1;
            this.txt_lectura.ModifiedChanged += new System.EventHandler(this.txt_lectura_ModifiedChanged);
            this.txt_lectura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lecturaCajasBindingSource
            // 
            this.lecturaCajasBindingSource.DataSource = typeof(paletizado.models.LecturaCajas);
            // 
            // lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 736);
            this.Controls.Add(this.panel1);
            this.Name = "lectura";
            this.Text = "lectura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaCajasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturaCajasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_envases_disponibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cajas_leidas;
        private System.Windows.Forms.TextBox txt_lectura;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEmpaqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSenasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tareaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn variedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calibreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn envaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lecturaCajasBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_up;
        private System.Windows.Forms.TextBox txt_error;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_empleado;
        private System.Windows.Forms.BindingSource lecturaCajasBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_condicion_embalado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_cospel_nro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_calibre;
        private System.Windows.Forms.Label label9;
    }
}