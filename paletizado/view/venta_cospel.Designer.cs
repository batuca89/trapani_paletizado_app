namespace paletizado.view
{
    partial class venta_cospel
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.adgv_cospel = new Zuby.ADGV.AdvancedDataGridView();
            this.ventanaCospelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ventanaCospelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventanaCospelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroCospelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVolcadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.upDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calibreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionEmbaladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCajasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasFaltantesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgv_cospel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaCospelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaCospelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaCospelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.adgv_cospel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1246, 659);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // adgv_cospel
            // 
            this.adgv_cospel.AutoGenerateColumns = false;
            this.adgv_cospel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adgv_cospel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgv_cospel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.nroCospelDataGridViewTextBoxColumn,
            this.codVolcadoDataGridViewTextBoxColumn,
            this.upDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.calibreDataGridViewTextBoxColumn,
            this.condicionEmbaladoDataGridViewTextBoxColumn,
            this.cantidadCajasDataGridViewTextBoxColumn,
            this.cajasFaltantesDataGridViewTextBoxColumn});
            this.adgv_cospel.DataSource = this.ventanaCospelBindingSource;
            this.adgv_cospel.FilterAndSortEnabled = true;
            this.adgv_cospel.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv_cospel.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.adgv_cospel.Location = new System.Drawing.Point(17, 3);
            this.adgv_cospel.Name = "adgv_cospel";
            this.adgv_cospel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgv_cospel.Size = new System.Drawing.Size(1218, 268);
            this.adgv_cospel.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.adgv_cospel.TabIndex = 1;
            this.adgv_cospel.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.adgv_cospel_SortStringChanged);
            this.adgv_cospel.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.adgv_cospel_FilterStringChanged);
            this.adgv_cospel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adgv_cospel_CellContentClick);
            // 
            // ventanaCospelBindingSource2
            // 
            this.ventanaCospelBindingSource2.DataSource = typeof(paletizado.models.VentanaCospel);
            // 
            // ventanaCospelBindingSource1
            // 
            this.ventanaCospelBindingSource1.DataSource = typeof(paletizado.models.VentanaCospel);
            // 
            // ventanaCospelBindingSource
            // 
            this.ventanaCospelBindingSource.DataSource = typeof(paletizado.models.VentanaCospel);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nroCospelDataGridViewTextBoxColumn
            // 
            this.nroCospelDataGridViewTextBoxColumn.DataPropertyName = "NroCospel";
            this.nroCospelDataGridViewTextBoxColumn.HeaderText = "NroCospel";
            this.nroCospelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nroCospelDataGridViewTextBoxColumn.Name = "nroCospelDataGridViewTextBoxColumn";
            this.nroCospelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // codVolcadoDataGridViewTextBoxColumn
            // 
            this.codVolcadoDataGridViewTextBoxColumn.DataPropertyName = "CodVolcado";
            this.codVolcadoDataGridViewTextBoxColumn.HeaderText = "CodVolcado";
            this.codVolcadoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.codVolcadoDataGridViewTextBoxColumn.Name = "codVolcadoDataGridViewTextBoxColumn";
            this.codVolcadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // upDataGridViewTextBoxColumn
            // 
            this.upDataGridViewTextBoxColumn.DataPropertyName = "Up";
            this.upDataGridViewTextBoxColumn.HeaderText = "Up";
            this.upDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.upDataGridViewTextBoxColumn.Name = "upDataGridViewTextBoxColumn";
            this.upDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // calibreDataGridViewTextBoxColumn
            // 
            this.calibreDataGridViewTextBoxColumn.DataPropertyName = "Calibre";
            this.calibreDataGridViewTextBoxColumn.HeaderText = "Calibre";
            this.calibreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.calibreDataGridViewTextBoxColumn.Name = "calibreDataGridViewTextBoxColumn";
            this.calibreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // condicionEmbaladoDataGridViewTextBoxColumn
            // 
            this.condicionEmbaladoDataGridViewTextBoxColumn.DataPropertyName = "CondicionEmbalado";
            this.condicionEmbaladoDataGridViewTextBoxColumn.HeaderText = "CondicionEmbalado";
            this.condicionEmbaladoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.condicionEmbaladoDataGridViewTextBoxColumn.Name = "condicionEmbaladoDataGridViewTextBoxColumn";
            this.condicionEmbaladoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cantidadCajasDataGridViewTextBoxColumn
            // 
            this.cantidadCajasDataGridViewTextBoxColumn.DataPropertyName = "CantidadCajas";
            this.cantidadCajasDataGridViewTextBoxColumn.HeaderText = "CantidadCajas";
            this.cantidadCajasDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cantidadCajasDataGridViewTextBoxColumn.Name = "cantidadCajasDataGridViewTextBoxColumn";
            this.cantidadCajasDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cajasFaltantesDataGridViewTextBoxColumn
            // 
            this.cajasFaltantesDataGridViewTextBoxColumn.DataPropertyName = "CajasFaltantes";
            this.cajasFaltantesDataGridViewTextBoxColumn.HeaderText = "CajasFaltantes";
            this.cajasFaltantesDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cajasFaltantesDataGridViewTextBoxColumn.Name = "cajasFaltantesDataGridViewTextBoxColumn";
            this.cajasFaltantesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // venta_cospel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 623);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "venta_cospel";
            this.Text = "venta_cospel";
            this.Load += new System.EventHandler(this.venta_cospel_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgv_cospel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaCospelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaCospelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventanaCospelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Zuby.ADGV.AdvancedDataGridView adgv_cospel;
        private System.Windows.Forms.BindingSource ventanaCospelBindingSource;
        private System.Windows.Forms.BindingSource ventanaCospelBindingSource1;
        private System.Windows.Forms.BindingSource ventanaCospelBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroCospelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVolcadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn upDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calibreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionEmbaladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCajasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasFaltantesDataGridViewTextBoxColumn;
    }
}