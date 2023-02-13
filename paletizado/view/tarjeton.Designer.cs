namespace paletizado.view
{
    partial class tarjeton
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
            this.txt_codigo_barra = new System.Windows.Forms.TextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cajas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_up = new System.Windows.Forms.DataGridView();
            this.upDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetonUpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_calibres = new System.Windows.Forms.DataGridView();
            this.calibreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetonCalibresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_empleado = new System.Windows.Forms.DataGridView();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetonPersonalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_empaques = new System.Windows.Forms.DataGridView();
            this.empaqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetonEmpaqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_envase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_variedad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cospel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_impresora = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tarjetonPersonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarjetonPersonalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonUpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calibres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonCalibresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonPersonalBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empaques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonEmpaqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonPersonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonPersonalBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txt_codigo_barra);
            this.panel1.Controls.Add(this.image);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_cajas);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_peso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgv_up);
            this.panel1.Controls.Add(this.dgv_calibres);
            this.panel1.Controls.Add(this.dgv_empleado);
            this.panel1.Controls.Add(this.dgv_empaques);
            this.panel1.Controls.Add(this.txt_fecha);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_envase);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_marca);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_variedad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_cospel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 1024);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_codigo_barra
            // 
            this.txt_codigo_barra.AcceptsTab = true;
            this.txt_codigo_barra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_codigo_barra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_codigo_barra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_barra.Location = new System.Drawing.Point(292, 970);
            this.txt_codigo_barra.Name = "txt_codigo_barra";
            this.txt_codigo_barra.ReadOnly = true;
            this.txt_codigo_barra.Size = new System.Drawing.Size(211, 22);
            this.txt_codigo_barra.TabIndex = 30;
            this.txt_codigo_barra.TextChanged += new System.EventHandler(this.txt_codigo_barra_TextChanged);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(142, 850);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(472, 114);
            this.image.TabIndex = 29;
            this.image.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 808);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kg";
            // 
            // txt_cajas
            // 
            this.txt_cajas.AcceptsTab = true;
            this.txt_cajas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_cajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cajas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cajas.Location = new System.Drawing.Point(697, 810);
            this.txt_cajas.Name = "txt_cajas";
            this.txt_cajas.ReadOnly = true;
            this.txt_cajas.Size = new System.Drawing.Size(82, 22);
            this.txt_cajas.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(570, 808);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cant. Cajas:";
            // 
            // txt_peso
            // 
            this.txt_peso.AcceptsTab = true;
            this.txt_peso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_peso.Location = new System.Drawing.Point(406, 808);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(97, 22);
            this.txt_peso.TabIndex = 25;
            this.txt_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_peso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 808);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Peso estimado:";
            // 
            // dgv_up
            // 
            this.dgv_up.AutoGenerateColumns = false;
            this.dgv_up.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_up.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_up.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.upDataGridViewTextBoxColumn,
            this.cajasDataGridViewTextBoxColumn3});
            this.dgv_up.DataSource = this.tarjetonUpBindingSource;
            this.dgv_up.Location = new System.Drawing.Point(19, 579);
            this.dgv_up.Name = "dgv_up";
            this.dgv_up.ReadOnly = true;
            this.dgv_up.Size = new System.Drawing.Size(353, 197);
            this.dgv_up.TabIndex = 23;
            this.dgv_up.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_up_CellContentClick);
            // 
            // upDataGridViewTextBoxColumn
            // 
            this.upDataGridViewTextBoxColumn.DataPropertyName = "Up";
            this.upDataGridViewTextBoxColumn.HeaderText = "Up";
            this.upDataGridViewTextBoxColumn.Name = "upDataGridViewTextBoxColumn";
            this.upDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajasDataGridViewTextBoxColumn3
            // 
            this.cajasDataGridViewTextBoxColumn3.DataPropertyName = "Cajas";
            this.cajasDataGridViewTextBoxColumn3.HeaderText = "Cajas";
            this.cajasDataGridViewTextBoxColumn3.Name = "cajasDataGridViewTextBoxColumn3";
            this.cajasDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tarjetonUpBindingSource
            // 
            this.tarjetonUpBindingSource.DataSource = typeof(paletizado.models.TarjetonUp);
            // 
            // dgv_calibres
            // 
            this.dgv_calibres.AutoGenerateColumns = false;
            this.dgv_calibres.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_calibres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_calibres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calibreDataGridViewTextBoxColumn,
            this.cajasDataGridViewTextBoxColumn2});
            this.dgv_calibres.DataSource = this.tarjetonCalibresBindingSource;
            this.dgv_calibres.Location = new System.Drawing.Point(455, 579);
            this.dgv_calibres.Name = "dgv_calibres";
            this.dgv_calibres.ReadOnly = true;
            this.dgv_calibres.Size = new System.Drawing.Size(346, 201);
            this.dgv_calibres.TabIndex = 22;
            // 
            // calibreDataGridViewTextBoxColumn
            // 
            this.calibreDataGridViewTextBoxColumn.DataPropertyName = "Calibre";
            this.calibreDataGridViewTextBoxColumn.HeaderText = "Calibre";
            this.calibreDataGridViewTextBoxColumn.Name = "calibreDataGridViewTextBoxColumn";
            this.calibreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajasDataGridViewTextBoxColumn2
            // 
            this.cajasDataGridViewTextBoxColumn2.DataPropertyName = "Cajas";
            this.cajasDataGridViewTextBoxColumn2.HeaderText = "Cajas";
            this.cajasDataGridViewTextBoxColumn2.Name = "cajasDataGridViewTextBoxColumn2";
            this.cajasDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tarjetonCalibresBindingSource
            // 
            this.tarjetonCalibresBindingSource.DataSource = typeof(paletizado.models.TarjetonCalibres);
            // 
            // dgv_empleado
            // 
            this.dgv_empleado.AutoGenerateColumns = false;
            this.dgv_empleado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empleadoDataGridViewTextBoxColumn,
            this.cajasDataGridViewTextBoxColumn1});
            this.dgv_empleado.DataSource = this.tarjetonPersonalBindingSource2;
            this.dgv_empleado.Location = new System.Drawing.Point(13, 321);
            this.dgv_empleado.Name = "dgv_empleado";
            this.dgv_empleado.ReadOnly = true;
            this.dgv_empleado.Size = new System.Drawing.Size(499, 235);
            this.dgv_empleado.TabIndex = 21;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajasDataGridViewTextBoxColumn1
            // 
            this.cajasDataGridViewTextBoxColumn1.DataPropertyName = "Cajas";
            this.cajasDataGridViewTextBoxColumn1.HeaderText = "Cajas";
            this.cajasDataGridViewTextBoxColumn1.Name = "cajasDataGridViewTextBoxColumn1";
            this.cajasDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tarjetonPersonalBindingSource2
            // 
            this.tarjetonPersonalBindingSource2.DataSource = typeof(paletizado.models.TarjetonPersonal);
            // 
            // dgv_empaques
            // 
            this.dgv_empaques.AutoGenerateColumns = false;
            this.dgv_empaques.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_empaques.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_empaques.ColumnHeadersHeight = 30;
            this.dgv_empaques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_empaques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empaqueDataGridViewTextBoxColumn,
            this.cajasDataGridViewTextBoxColumn});
            this.dgv_empaques.DataSource = this.tarjetonEmpaqueBindingSource;
            this.dgv_empaques.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_empaques.Location = new System.Drawing.Point(13, 135);
            this.dgv_empaques.Name = "dgv_empaques";
            this.dgv_empaques.ReadOnly = true;
            this.dgv_empaques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_empaques.Size = new System.Drawing.Size(520, 160);
            this.dgv_empaques.TabIndex = 20;
            // 
            // empaqueDataGridViewTextBoxColumn
            // 
            this.empaqueDataGridViewTextBoxColumn.DataPropertyName = "Empaque";
            this.empaqueDataGridViewTextBoxColumn.HeaderText = "Empaque";
            this.empaqueDataGridViewTextBoxColumn.Name = "empaqueDataGridViewTextBoxColumn";
            this.empaqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cajasDataGridViewTextBoxColumn
            // 
            this.cajasDataGridViewTextBoxColumn.DataPropertyName = "Cajas";
            this.cajasDataGridViewTextBoxColumn.HeaderText = "Cajas";
            this.cajasDataGridViewTextBoxColumn.Name = "cajasDataGridViewTextBoxColumn";
            this.cajasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarjetonEmpaqueBindingSource
            // 
            this.tarjetonEmpaqueBindingSource.DataSource = typeof(paletizado.models.TarjetonEmpaque);
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(628, 22);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(183, 22);
            this.txt_fecha.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha:";
            // 
            // txt_envase
            // 
            this.txt_envase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_envase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_envase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_envase.Location = new System.Drawing.Point(647, 90);
            this.txt_envase.Name = "txt_envase";
            this.txt_envase.ReadOnly = true;
            this.txt_envase.Size = new System.Drawing.Size(154, 22);
            this.txt_envase.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Envase:";
            // 
            // txt_marca
            // 
            this.txt_marca.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_marca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_marca.Location = new System.Drawing.Point(371, 90);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ReadOnly = true;
            this.txt_marca.Size = new System.Drawing.Size(162, 22);
            this.txt_marca.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Marca:";
            // 
            // txt_variedad
            // 
            this.txt_variedad.AcceptsTab = true;
            this.txt_variedad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_variedad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_variedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_variedad.Location = new System.Drawing.Point(115, 90);
            this.txt_variedad.Name = "txt_variedad";
            this.txt_variedad.ReadOnly = true;
            this.txt_variedad.Size = new System.Drawing.Size(154, 22);
            this.txt_variedad.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Variedad:";
            // 
            // txt_cospel
            // 
            this.txt_cospel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_cospel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cospel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cospel.Location = new System.Drawing.Point(170, 22);
            this.txt_cospel.Name = "txt_cospel";
            this.txt_cospel.ReadOnly = true;
            this.txt_cospel.Size = new System.Drawing.Size(109, 22);
            this.txt_cospel.TabIndex = 1;
            this.txt_cospel.TextChanged += new System.EventHandler(this.txt_cospel_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provisorio Nro:";
            // 
            // btn_impresora
            // 
            this.btn_impresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_impresora.Location = new System.Drawing.Point(677, 12);
            this.btn_impresora.Name = "btn_impresora";
            this.btn_impresora.Size = new System.Drawing.Size(164, 44);
            this.btn_impresora.TabIndex = 1;
            this.btn_impresora.Text = "Imprimir";
            this.btn_impresora.UseVisualStyleBackColor = true;
            this.btn_impresora.Click += new System.EventHandler(this.btn_impresora_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confi. Impresora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarjetonPersonalBindingSource
            // 
            this.tarjetonPersonalBindingSource.DataSource = typeof(paletizado.models.TarjetonPersonal);
            // 
            // tarjetonPersonalBindingSource1
            // 
            this.tarjetonPersonalBindingSource1.DataSource = typeof(paletizado.models.TarjetonPersonal);
            // 
            // tarjeton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 1063);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_impresora);
            this.Controls.Add(this.panel1);
            this.Name = "tarjeton";
            this.Text = "tarjeton";
            this.Load += new System.EventHandler(this.tarjeton_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonUpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_calibres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonCalibresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonPersonalBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empaques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonEmpaqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonPersonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarjetonPersonalBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cospel;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_envase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_variedad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_empaques;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tarjetonEmpaqueBindingSource;
        private System.Windows.Forms.BindingSource tarjetonPersonalBindingSource;
        private System.Windows.Forms.DataGridView dgv_empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tarjetonPersonalBindingSource2;
        private System.Windows.Forms.BindingSource tarjetonPersonalBindingSource1;
        private System.Windows.Forms.DataGridView dgv_up;
        private System.Windows.Forms.DataGridView dgv_calibres;
        private System.Windows.Forms.DataGridViewTextBoxColumn calibreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource tarjetonCalibresBindingSource;
        private System.Windows.Forms.TextBox txt_cajas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.DataGridViewTextBoxColumn upDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasDataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource tarjetonUpBindingSource;
        private System.Windows.Forms.Button btn_impresora;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_codigo_barra;
    }
}