namespace PizzeriaPerez
{
    partial class frmComplementosPedido
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
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.cbComplemento = new System.Windows.Forms.ComboBox();
            this.cOMPLEMENTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaFDataSet3 = new PizzeriaPerez.PizzeriaFDataSet3();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadComple = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idComplementoPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreComplementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioComplementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPObtenerDetallesComplementoPedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaFDataSet12 = new PizzeriaPerez.PizzeriaFDataSet12();
            this.sPObtenerDetallesComplementoPedidoTableAdapter = new PizzeriaPerez.PizzeriaFDataSet12TableAdapters.SPObtenerDetallesComplementoPedidoTableAdapter();
            this.cOMPLEMENTOSTableAdapter = new PizzeriaPerez.PizzeriaFDataSet3TableAdapters.COMPLEMENTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPLEMENTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerDetallesComplementoPedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(233, 143);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(273, 128);
            this.txtComentarios.TabIndex = 13;
            // 
            // cbComplemento
            // 
            this.cbComplemento.DataSource = this.cOMPLEMENTOSBindingSource;
            this.cbComplemento.DisplayMember = "NombreComplementos";
            this.cbComplemento.FormattingEnabled = true;
            this.cbComplemento.Location = new System.Drawing.Point(233, 92);
            this.cbComplemento.Name = "cbComplemento";
            this.cbComplemento.Size = new System.Drawing.Size(273, 28);
            this.cbComplemento.TabIndex = 11;
            this.cbComplemento.ValueMember = "idComplementos";
            // 
            // cOMPLEMENTOSBindingSource
            // 
            this.cOMPLEMENTOSBindingSource.DataMember = "COMPLEMENTOS";
            this.cOMPLEMENTOSBindingSource.DataSource = this.pizzeriaFDataSet3;
            // 
            // pizzeriaFDataSet3
            // 
            this.pizzeriaFDataSet3.DataSetName = "PizzeriaFDataSet3";
            this.pizzeriaFDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Comentarios:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(98, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Complemento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(226, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Complementos";
            // 
            // txtCantidadComple
            // 
            this.txtCantidadComple.Location = new System.Drawing.Point(232, 291);
            this.txtCantidadComple.Name = "txtCantidadComple";
            this.txtCantidadComple.Size = new System.Drawing.Size(273, 26);
            this.txtCantidadComple.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(219, 368);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 51);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComplementoPedidoDataGridViewTextBoxColumn,
            this.nombreComplementoDataGridViewTextBoxColumn,
            this.precioComplementoDataGridViewTextBoxColumn,
            this.comentariosDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sPObtenerDetallesComplementoPedidoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(542, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(474, 375);
            this.dataGridView1.TabIndex = 17;
            // 
            // idComplementoPedidoDataGridViewTextBoxColumn
            // 
            this.idComplementoPedidoDataGridViewTextBoxColumn.DataPropertyName = "idComplementoPedido";
            this.idComplementoPedidoDataGridViewTextBoxColumn.HeaderText = "idComplementoPedido";
            this.idComplementoPedidoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idComplementoPedidoDataGridViewTextBoxColumn.Name = "idComplementoPedidoDataGridViewTextBoxColumn";
            this.idComplementoPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idComplementoPedidoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreComplementoDataGridViewTextBoxColumn
            // 
            this.nombreComplementoDataGridViewTextBoxColumn.DataPropertyName = "NombreComplemento";
            this.nombreComplementoDataGridViewTextBoxColumn.HeaderText = "NombreComplemento";
            this.nombreComplementoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreComplementoDataGridViewTextBoxColumn.Name = "nombreComplementoDataGridViewTextBoxColumn";
            this.nombreComplementoDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioComplementoDataGridViewTextBoxColumn
            // 
            this.precioComplementoDataGridViewTextBoxColumn.DataPropertyName = "PrecioComplemento";
            this.precioComplementoDataGridViewTextBoxColumn.HeaderText = "PrecioComplemento";
            this.precioComplementoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioComplementoDataGridViewTextBoxColumn.Name = "precioComplementoDataGridViewTextBoxColumn";
            this.precioComplementoDataGridViewTextBoxColumn.Width = 150;
            // 
            // comentariosDataGridViewTextBoxColumn
            // 
            this.comentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios";
            this.comentariosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.comentariosDataGridViewTextBoxColumn.Name = "comentariosDataGridViewTextBoxColumn";
            this.comentariosDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioTotalDataGridViewTextBoxColumn
            // 
            this.precioTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecioTotal";
            this.precioTotalDataGridViewTextBoxColumn.HeaderText = "PrecioTotal";
            this.precioTotalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioTotalDataGridViewTextBoxColumn.Name = "precioTotalDataGridViewTextBoxColumn";
            this.precioTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioTotalDataGridViewTextBoxColumn.Width = 150;
            // 
            // sPObtenerDetallesComplementoPedidoBindingSource
            // 
            this.sPObtenerDetallesComplementoPedidoBindingSource.DataMember = "SPObtenerDetallesComplementoPedido";
            this.sPObtenerDetallesComplementoPedidoBindingSource.DataSource = this.pizzeriaFDataSet12;
            // 
            // pizzeriaFDataSet12
            // 
            this.pizzeriaFDataSet12.DataSetName = "PizzeriaFDataSet12";
            this.pizzeriaFDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPObtenerDetallesComplementoPedidoTableAdapter
            // 
            this.sPObtenerDetallesComplementoPedidoTableAdapter.ClearBeforeFill = true;
            // 
            // cOMPLEMENTOSTableAdapter
            // 
            this.cOMPLEMENTOSTableAdapter.ClearBeforeFill = true;
            // 
            // frmComplementosPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1054, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidadComple);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.cbComplemento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComplementosPedido";
            this.Text = "frmComplementosPedido";
            this.Load += new System.EventHandler(this.frmComplementosPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOMPLEMENTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPObtenerDetallesComplementoPedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.ComboBox cbComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadComple;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PizzeriaFDataSet12 pizzeriaFDataSet12;
        private System.Windows.Forms.BindingSource sPObtenerDetallesComplementoPedidoBindingSource;
        private PizzeriaFDataSet12TableAdapters.SPObtenerDetallesComplementoPedidoTableAdapter sPObtenerDetallesComplementoPedidoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComplementoPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreComplementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioComplementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotalDataGridViewTextBoxColumn;
        private PizzeriaFDataSet3 pizzeriaFDataSet3;
        private System.Windows.Forms.BindingSource cOMPLEMENTOSBindingSource;
        private PizzeriaFDataSet3TableAdapters.COMPLEMENTOSTableAdapter cOMPLEMENTOSTableAdapter;
    }
}