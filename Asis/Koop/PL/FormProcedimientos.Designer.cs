namespace Koop.PL
{
    partial class FormProcedimientos
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
            this.groupBoxSolicitudInterconsulta = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.dataGridCUPSPctos = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCodigoCUPS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnRealizado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnCancelado = new System.Windows.Forms.Button();
            this.BtnReprogramado = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dBSistemaDataSet1 = new Koop.DBSistemaDataSet1();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_TableAdapter = new Koop.DBSistemaDataSet1TableAdapters.Table_TableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSolicitudInterconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCUPSPctos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSistemaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSolicitudInterconsulta
            // 
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.BtnAgregar);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.dataGridCUPSPctos);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.BtnBuscar);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.TxtCodigoCUPS);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label1);
            this.groupBoxSolicitudInterconsulta.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSolicitudInterconsulta.Location = new System.Drawing.Point(9, 35);
            this.groupBoxSolicitudInterconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSolicitudInterconsulta.Name = "groupBoxSolicitudInterconsulta";
            this.groupBoxSolicitudInterconsulta.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSolicitudInterconsulta.Size = new System.Drawing.Size(780, 138);
            this.groupBoxSolicitudInterconsulta.TabIndex = 2;
            this.groupBoxSolicitudInterconsulta.TabStop = false;
            this.groupBoxSolicitudInterconsulta.Text = "Solicitud de nuevos procedimientos";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(412, 29);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(115, 28);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridCUPSPctos
            // 
            this.dataGridCUPSPctos.AutoGenerateColumns = false;
            this.dataGridCUPSPctos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCUPSPctos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridCUPSPctos.DataSource = this.tableBindingSource;
            this.dataGridCUPSPctos.Location = new System.Drawing.Point(11, 61);
            this.dataGridCUPSPctos.Name = "dataGridCUPSPctos";
            this.dataGridCUPSPctos.Size = new System.Drawing.Size(762, 70);
            this.dataGridCUPSPctos.TabIndex = 12;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(290, 29);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(115, 28);
            this.BtnBuscar.TabIndex = 258;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCodigoCUPS
            // 
            this.TxtCodigoCUPS.Location = new System.Drawing.Point(184, 32);
            this.TxtCodigoCUPS.Name = "TxtCodigoCUPS";
            this.TxtCodigoCUPS.Size = new System.Drawing.Size(100, 23);
            this.TxtCodigoCUPS.TabIndex = 257;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 254;
            this.label1.Text = "Codigo De Procedimiento:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(671, 411);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 28);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(548, 411);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 28);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(46, 10);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 15);
            this.txtID.TabIndex = 300;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(17, 9);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 16);
            this.labelID.TabIndex = 301;
            this.labelID.Text = "ID";
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(425, 411);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(115, 28);
            this.BtnNuevo.TabIndex = 302;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // BtnRealizado
            // 
            this.BtnRealizado.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizado.Location = new System.Drawing.Point(416, 186);
            this.BtnRealizado.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRealizado.Name = "BtnRealizado";
            this.BtnRealizado.Size = new System.Drawing.Size(114, 28);
            this.BtnRealizado.TabIndex = 312;
            this.BtnRealizado.Text = "Realizado";
            this.BtnRealizado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRealizado);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.BtnCancelado);
            this.groupBox1.Controls.Add(this.BtnReprogramado);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(780, 222);
            this.groupBox1.TabIndex = 309;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedimientos solicitados anteriormente";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(762, 115);
            this.dataGridView2.TabIndex = 260;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(290, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 28);
            this.button4.TabIndex = 258;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // BtnCancelado
            // 
            this.BtnCancelado.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelado.Location = new System.Drawing.Point(662, 186);
            this.BtnCancelado.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelado.Name = "BtnCancelado";
            this.BtnCancelado.Size = new System.Drawing.Size(114, 28);
            this.BtnCancelado.TabIndex = 311;
            this.BtnCancelado.Text = "Cancelado";
            this.BtnCancelado.UseVisualStyleBackColor = true;
            this.BtnCancelado.Click += new System.EventHandler(this.BtnCancelado_Click);
            // 
            // BtnReprogramado
            // 
            this.BtnReprogramado.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReprogramado.Location = new System.Drawing.Point(539, 186);
            this.BtnReprogramado.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReprogramado.Name = "BtnReprogramado";
            this.BtnReprogramado.Size = new System.Drawing.Size(114, 28);
            this.BtnReprogramado.TabIndex = 310;
            this.BtnReprogramado.Text = "Reprogramado";
            this.BtnReprogramado.UseVisualStyleBackColor = true;
            this.BtnReprogramado.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 257;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 254;
            this.label2.Text = "Codigo De Procedimiento:";
            // 
            // dBSistemaDataSet1
            // 
            this.dBSistemaDataSet1.DataSetName = "DBSistemaDataSet1";
            this.dBSistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table$";
            this.tableBindingSource.DataSource = this.dBSistemaDataSet1;
            // 
            // table_TableAdapter
            // 
            this.table_TableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBoxSolicitudInterconsulta);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProcedimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procedimientos";
            this.Load += new System.EventHandler(this.FormProcedimientos_Load);
            this.groupBoxSolicitudInterconsulta.ResumeLayout(false);
            this.groupBoxSolicitudInterconsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCUPSPctos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSistemaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSolicitudInterconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCodigoCUPS;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dataGridCUPSPctos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnRealizado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancelado;
        private System.Windows.Forms.Button BtnReprogramado;
        private DBSistemaDataSet1 dBSistemaDataSet1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DBSistemaDataSet1TableAdapters.Table_TableAdapter table_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
    }
}