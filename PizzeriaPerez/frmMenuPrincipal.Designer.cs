namespace PizzeriaPerez
{
    partial class frmMenuPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnCerrarSesion = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAdministrar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInforme = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnComboPedido = new System.Windows.Forms.Button();
            this.btnComplementoPedido = new System.Windows.Forms.Button();
            this.btnPizzaPedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pContenido = new System.Windows.Forms.Panel();
            this.pizzeriaFDataSet15BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzeriaFDataSet15 = new PizzeriaPerez.PizzeriaFDataSet15();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet15BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet15)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 40);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(531, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Menú";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.bnCerrarSesion);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnAdministrar);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnInforme);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnComboPedido);
            this.panel2.Controls.Add(this.btnComplementoPedido);
            this.panel2.Controls.Add(this.btnPizzaPedido);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 757);
            this.panel2.TabIndex = 1;
            // 
            // bnCerrarSesion
            // 
            this.bnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bnCerrarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bnCerrarSesion.Location = new System.Drawing.Point(12, 683);
            this.bnCerrarSesion.Name = "bnCerrarSesion";
            this.bnCerrarSesion.Size = new System.Drawing.Size(190, 42);
            this.bnCerrarSesion.TabIndex = 9;
            this.bnCerrarSesion.Text = "Cerrar Sesión";
            this.bnCerrarSesion.UseVisualStyleBackColor = true;
            this.bnCerrarSesion.Click += new System.EventHandler(this.bnCerrarSesion_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(39, 635);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 23);
            this.lblUser.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackgroundImage = global::PizzeriaPerez.Properties.Resources.USUARIO;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(77, 560);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 64);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(0, 447);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 42);
            this.panel7.TabIndex = 6;
            // 
            // btnAdministrar
            // 
            this.btnAdministrar.Enabled = false;
            this.btnAdministrar.FlatAppearance.BorderSize = 0;
            this.btnAdministrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdministrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdministrar.Location = new System.Drawing.Point(6, 447);
            this.btnAdministrar.Name = "btnAdministrar";
            this.btnAdministrar.Size = new System.Drawing.Size(223, 42);
            this.btnAdministrar.TabIndex = 6;
            this.btnAdministrar.Text = "Administrar";
            this.btnAdministrar.UseVisualStyleBackColor = true;
            this.btnAdministrar.Click += new System.EventHandler(this.btnAdministrar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(0, 399);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 42);
            this.panel6.TabIndex = 5;
            // 
            // btnInforme
            // 
            this.btnInforme.FlatAppearance.BorderSize = 0;
            this.btnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInforme.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInforme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInforme.Location = new System.Drawing.Point(12, 399);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(214, 42);
            this.btnInforme.TabIndex = 5;
            this.btnInforme.Text = "Informe de Venta";
            this.btnInforme.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(0, 303);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 42);
            this.panel5.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 42);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(0, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 42);
            this.panel3.TabIndex = 2;
            // 
            // btnComboPedido
            // 
            this.btnComboPedido.FlatAppearance.BorderSize = 0;
            this.btnComboPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComboPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComboPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComboPedido.Location = new System.Drawing.Point(12, 250);
            this.btnComboPedido.Name = "btnComboPedido";
            this.btnComboPedido.Size = new System.Drawing.Size(217, 42);
            this.btnComboPedido.TabIndex = 4;
            this.btnComboPedido.Text = "Combos";
            this.btnComboPedido.UseVisualStyleBackColor = true;
            this.btnComboPedido.Click += new System.EventHandler(this.btnComboPedido_Click);
            // 
            // btnComplementoPedido
            // 
            this.btnComplementoPedido.FlatAppearance.BorderSize = 0;
            this.btnComplementoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplementoPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComplementoPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComplementoPedido.Location = new System.Drawing.Point(3, 303);
            this.btnComplementoPedido.Name = "btnComplementoPedido";
            this.btnComplementoPedido.Size = new System.Drawing.Size(223, 42);
            this.btnComplementoPedido.TabIndex = 3;
            this.btnComplementoPedido.Text = "Complementos";
            this.btnComplementoPedido.UseVisualStyleBackColor = true;
            this.btnComplementoPedido.Click += new System.EventHandler(this.btnComplementoPedido_Click);
            // 
            // btnPizzaPedido
            // 
            this.btnPizzaPedido.FlatAppearance.BorderSize = 0;
            this.btnPizzaPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPizzaPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPizzaPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPizzaPedido.Location = new System.Drawing.Point(12, 202);
            this.btnPizzaPedido.Name = "btnPizzaPedido";
            this.btnPizzaPedido.Size = new System.Drawing.Size(217, 39);
            this.btnPizzaPedido.TabIndex = 2;
            this.btnPizzaPedido.Text = "Pizzas";
            this.btnPizzaPedido.UseVisualStyleBackColor = true;
            this.btnPizzaPedido.Click += new System.EventHandler(this.btnPizzaPedido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PizzeriaPerez.Properties.Resources.LOGO1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 185);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pContenido
            // 
            this.pContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenido.Location = new System.Drawing.Point(229, 40);
            this.pContenido.Name = "pContenido";
            this.pContenido.Size = new System.Drawing.Size(930, 757);
            this.pContenido.TabIndex = 2;
            this.pContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.pContenido_Paint);
            // 
            // pizzeriaFDataSet15BindingSource
            // 
            this.pizzeriaFDataSet15BindingSource.DataSource = this.pizzeriaFDataSet15;
            this.pizzeriaFDataSet15BindingSource.Position = 0;
            // 
            // pizzeriaFDataSet15
            // 
            this.pizzeriaFDataSet15.DataSetName = "PizzeriaFDataSet15";
            this.pizzeriaFDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(229, 600);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(930, 197);
            this.panel8.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.pizzeriaFDataSet15BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(855, 140);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.bnCerrarSesion;
            this.ClientSize = new System.Drawing.Size(1159, 797);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pContenido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet15BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzeriaFDataSet15)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnComboPedido;
        private System.Windows.Forms.Button btnComplementoPedido;
        private System.Windows.Forms.Button btnPizzaPedido;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnCerrarSesion;
        private System.Windows.Forms.Panel pContenido;
        private System.Windows.Forms.BindingSource pizzeriaFDataSet15BindingSource;
        private PizzeriaFDataSet15 pizzeriaFDataSet15;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnAdministrar;
        public System.Windows.Forms.Label lblUser;
    }
}