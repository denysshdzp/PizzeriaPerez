namespace PizzeriaPerez
{
    partial class frmCombosPedido
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
            this.txtCantidadExtra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbExtra = new System.Windows.Forms.ComboBox();
            this.iNGREDIENTEEXTRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaFDataSet3 = new PizzeriaPerez.PizzeriaFDataSet3();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.cbCombo = new System.Windows.Forms.ComboBox();
            this.cOMBOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaFDataSet8 = new PizzeriaPerez.PizzeriaFDataSet8();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cOMBOTableAdapter = new PizzeriaPerez.PizzeriaFDataSet8TableAdapters.COMBOTableAdapter();
            this.iNGREDIENTEEXTRATableAdapter = new PizzeriaPerez.PizzeriaFDataSet3TableAdapters.INGREDIENTEEXTRATableAdapter();
            this.pizzeriaFDataSet9 = new PizzeriaPerez.PizzeriaFDataSet9();
            this.sPObtenerDetallesComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPObtenerDetallesComboTableAdapter = new PizzeriaPerez.PizzeriaFDataSet9TableAdapters.SPObtenerDetallesComboTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreComboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioComboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreIngredienteExtraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioIngredienteExtraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPObtenerDetallesComboBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaFDataSet11 = new PizzeriaPerez.PizzeriaFDataSet11();
            this.pizzeriaFDataSet10 = new PizzeriaPerez.PizzeriaFDataSet10();
            this.sPObtenerDetalleComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPObtenerDetalleComboTableAdapter = new PizzeriaPerez.PizzeriaFDataSet10TableAdapters.SPObtenerDetalleComboTableAdapter();
            this.sPObtenerDetallesComboTableAdapter1 = new PizzeriaPerez.PizzeriaFDataSet11TableAdapters.SPObtenerDetallesComboTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iNGREDIENTEEXTRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMBOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerDetallesComboBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerDetallesComboBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerDetalleComboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidadExtra
            // 
            this.txtCantidadExtra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCantidadExtra.Location = new System.Drawing.Point(387, 394);
            this.txtCantidadExtra.Name = "txtCantidadExtra";
            this.txtCantidadExtra.Size = new System.Drawing.Size(118, 30);
            this.txtCantidadExtra.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(274, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cantidad:";
            // 
            // cbExtra
            // 
            this.cbExtra.DataSource = this.iNGREDIENTEEXTRABindingSource;
            this.cbExtra.DisplayMember = "NombreIngrediente";
            this.cbExtra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtra.FormattingEnabled = true;
            this.cbExtra.Location = new System.Drawing.Point(387, 332);
            this.cbExtra.Name = "cbExtra";
            this.cbExtra.Size = new System.Drawing.Size(125, 29);
            this.cbExtra.TabIndex = 29;
            this.cbExtra.ValueMember = "idIngredienteExtra";
            // 
            // iNGREDIENTEEXTRABindingSource
            // 
            this.iNGREDIENTEEXTRABindingSource.DataMember = "INGREDIENTEEXTRA";
            this.iNGREDIENTEEXTRABindingSource.DataSource = this.pizzeriaFDataSet3;
            // 
            // pizzeriaFDataSet3
            // 
            this.pizzeriaFDataSet3.DataSetName = "PizzeriaFDataSet3";
            this.pizzeriaFDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(96, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Ingrediente extra a agregar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(249, 464);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 51);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(249, 168);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(293, 128);
            this.txtComentarios.TabIndex = 22;
            // 
            // cbCombo
            // 
            this.cbCombo.DataSource = this.cOMBOBindingSource;
            this.cbCombo.DisplayMember = "NombreCombo";
            this.cbCombo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombo.FormattingEnabled = true;
            this.cbCombo.Location = new System.Drawing.Point(269, 110);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(273, 29);
            this.cbCombo.TabIndex = 20;
            this.cbCombo.ValueMember = "idCombo";
            // 
            // cOMBOBindingSource
            // 
            this.cOMBOBindingSource.DataMember = "COMBO";
            this.cOMBOBindingSource.DataSource = this.pizzeriaFDataSet8;
            // 
            // pizzeriaFDataSet8
            // 
            this.pizzeriaFDataSet8.DataSetName = "PizzeriaFDataSet8";
            this.pizzeriaFDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Comentarios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Combo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Combos";
            // 
            // cOMBOTableAdapter
            // 
            this.cOMBOTableAdapter.ClearBeforeFill = true;
            // 
            // iNGREDIENTEEXTRATableAdapter
            // 
            this.iNGREDIENTEEXTRATableAdapter.ClearBeforeFill = true;
            // 
            // pizzeriaFDataSet9
            // 
            this.pizzeriaFDataSet9.DataSetName = "PizzeriaFDataSet9";
            this.pizzeriaFDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPObtenerDetallesComboBindingSource
            // 
            this.sPObtenerDetallesComboBindingSource.DataMember = "SPObtenerDetallesCombo";
            this.sPObtenerDetallesComboBindingSource.DataSource = this.pizzeriaFDataSet9;
            // 
            // sPObtenerDetallesComboTableAdapter
            // 
            this.sPObtenerDetallesComboTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreComboDataGridViewTextBoxColumn,
            this.precioComboDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn,
            this.nombreIngredienteExtraDataGridViewTextBoxColumn,
            this.precioIngredienteExtraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPObtenerDetallesComboBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(584, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(600, 398);
            this.dataGridView1.TabIndex = 32;
            // 
            // nombreComboDataGridViewTextBoxColumn
            // 
            this.nombreComboDataGridViewTextBoxColumn.DataPropertyName = "NombreCombo";
            this.nombreComboDataGridViewTextBoxColumn.HeaderText = "NombreCombo";
            this.nombreComboDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreComboDataGridViewTextBoxColumn.Name = "nombreComboDataGridViewTextBoxColumn";
            this.nombreComboDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioComboDataGridViewTextBoxColumn
            // 
            this.precioComboDataGridViewTextBoxColumn.DataPropertyName = "PrecioCombo";
            this.precioComboDataGridViewTextBoxColumn.HeaderText = "PrecioCombo";
            this.precioComboDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioComboDataGridViewTextBoxColumn.Name = "precioComboDataGridViewTextBoxColumn";
            this.precioComboDataGridViewTextBoxColumn.Width = 150;
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            this.comentariosDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreIngredienteExtraDataGridViewTextBoxColumn
            // 
            this.nombreIngredienteExtraDataGridViewTextBoxColumn.DataPropertyName = "NombreIngredienteExtra";
            this.nombreIngredienteExtraDataGridViewTextBoxColumn.HeaderText = "NombreIngredienteExtra";
            this.nombreIngredienteExtraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreIngredienteExtraDataGridViewTextBoxColumn.Name = "nombreIngredienteExtraDataGridViewTextBoxColumn";
            this.nombreIngredienteExtraDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioIngredienteExtraDataGridViewTextBoxColumn
            // 
            this.precioIngredienteExtraDataGridViewTextBoxColumn.DataPropertyName = "PrecioIngredienteExtra";
            this.precioIngredienteExtraDataGridViewTextBoxColumn.HeaderText = "PrecioIngredienteExtra";
            this.precioIngredienteExtraDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioIngredienteExtraDataGridViewTextBoxColumn.Name = "precioIngredienteExtraDataGridViewTextBoxColumn";
            this.precioIngredienteExtraDataGridViewTextBoxColumn.Width = 150;
            // 
            // sPObtenerDetallesComboBindingSource1
            // 
            this.sPObtenerDetallesComboBindingSource1.DataMember = "SPObtenerDetallesCombo";
            this.sPObtenerDetallesComboBindingSource1.DataSource = this.pizzeriaFDataSet11;
            // 
            // pizzeriaFDataSet11
            // 
            this.pizzeriaFDataSet11.DataSetName = "PizzeriaFDataSet11";
            this.pizzeriaFDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzeriaFDataSet10
            // 
            this.pizzeriaFDataSet10.DataSetName = "PizzeriaFDataSet10";
            this.pizzeriaFDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPObtenerDetalleComboBindingSource
            // 
            this.sPObtenerDetalleComboBindingSource.DataMember = "SPObtenerDetalleCombo";
            this.sPObtenerDetalleComboBindingSource.DataSource = this.pizzeriaFDataSet10;
            // 
            // sPObtenerDetalleComboTableAdapter
            // 
            this.sPObtenerDetalleComboTableAdapter.ClearBeforeFill = true;
            // 
            // sPObtenerDetallesComboTableAdapter1
            // 
            this.sPObtenerDetallesComboTableAdapter1.ClearBeforeFill = true;
            // 
            // frmCombosPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1219, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCantidadExtra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbExtra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.cbCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCombosPedido";
            this.Text = "frmCombosPedido";
            this.Load += new System.EventHandler(this.frmCombosPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iNGREDIENTEEXTRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMBOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerDetallesComboBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerDetallesComboBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerDetalleComboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbExtra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.ComboBox cbCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PizzeriaFDataSet8 pizzeriaFDataSet8;
        private System.Windows.Forms.BindingSource cOMBOBindingSource;
        private PizzeriaFDataSet8TableAdapters.COMBOTableAdapter cOMBOTableAdapter;
        private PizzeriaFDataSet3 pizzeriaFDataSet3;
        private System.Windows.Forms.BindingSource iNGREDIENTEEXTRABindingSource;
        private PizzeriaFDataSet3TableAdapters.INGREDIENTEEXTRATableAdapter iNGREDIENTEEXTRATableAdapter;
        private PizzeriaFDataSet9 pizzeriaFDataSet9;
        private System.Windows.Forms.BindingSource sPObtenerDetallesComboBindingSource;
        private PizzeriaFDataSet9TableAdapters.SPObtenerDetallesComboTableAdapter sPObtenerDetallesComboTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzeriaFDataSet10 pizzeriaFDataSet10;
        private System.Windows.Forms.BindingSource sPObtenerDetalleComboBindingSource;
        private PizzeriaFDataSet10TableAdapters.SPObtenerDetalleComboTableAdapter sPObtenerDetalleComboTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioComboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreIngredienteExtraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioIngredienteExtraDataGridViewTextBoxColumn;
        private PizzeriaFDataSet11 pizzeriaFDataSet11;
        private System.Windows.Forms.BindingSource sPObtenerDetallesComboBindingSource1;
        private PizzeriaFDataSet11TableAdapters.SPObtenerDetallesComboTableAdapter sPObtenerDetallesComboTableAdapter1;
    }
}