namespace Koop.PL
{
    partial class FormBuscar
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
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNvoProcedimiento = new System.Windows.Forms.Button();
            this.BtnSolInterconsulta = new System.Windows.Forms.Button();
            this.BtnCEP = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpEgreso = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTEgreso = new System.Windows.Forms.ComboBox();
            this.CmbEEgreso = new System.Windows.Forms.ComboBox();
            this.CmbGRD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatosPersonales.Controls.Add(this.dataGridView1);
            this.groupBoxDatosPersonales.Controls.Add(this.btnNvoProcedimiento);
            this.groupBoxDatosPersonales.Controls.Add(this.BtnSolInterconsulta);
            this.groupBoxDatosPersonales.Controls.Add(this.BtnCEP);
            this.groupBoxDatosPersonales.Controls.Add(this.txtIdentificacion);
            this.groupBoxDatosPersonales.Controls.Add(this.label42);
            this.groupBoxDatosPersonales.Controls.Add(this.BtnBuscar);
            this.groupBoxDatosPersonales.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosPersonales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(9, 36);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(788, 85);
            this.groupBoxDatosPersonales.TabIndex = 259;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos De Busqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 22);
            this.dataGridView1.TabIndex = 320;
            // 
            // btnNvoProcedimiento
            // 
            this.btnNvoProcedimiento.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvoProcedimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNvoProcedimiento.Location = new System.Drawing.Point(667, 50);
            this.btnNvoProcedimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnNvoProcedimiento.Name = "btnNvoProcedimiento";
            this.btnNvoProcedimiento.Size = new System.Drawing.Size(113, 28);
            this.btnNvoProcedimiento.TabIndex = 322;
            this.btnNvoProcedimiento.Text = "Procedimientos";
            this.btnNvoProcedimiento.UseVisualStyleBackColor = true;
            this.btnNvoProcedimiento.Click += new System.EventHandler(this.btnNvoProcedimiento_Click_1);
            // 
            // BtnSolInterconsulta
            // 
            this.BtnSolInterconsulta.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSolInterconsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSolInterconsulta.Location = new System.Drawing.Point(546, 50);
            this.BtnSolInterconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSolInterconsulta.Name = "BtnSolInterconsulta";
            this.BtnSolInterconsulta.Size = new System.Drawing.Size(113, 28);
            this.BtnSolInterconsulta.TabIndex = 320;
            this.BtnSolInterconsulta.Text = "Interconsultas";
            this.BtnSolInterconsulta.UseVisualStyleBackColor = true;
            this.BtnSolInterconsulta.Click += new System.EventHandler(this.BtnSolInterconsulta_Click_1);
            // 
            // BtnCEP
            // 
            this.BtnCEP.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCEP.Location = new System.Drawing.Point(375, 49);
            this.BtnCEP.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCEP.Name = "BtnCEP";
            this.BtnCEP.Size = new System.Drawing.Size(164, 28);
            this.BtnCEP.TabIndex = 321;
            this.BtnCEP.Text = "Causa De Larga Estancia";
            this.BtnCEP.UseVisualStyleBackColor = true;
            this.BtnCEP.Click += new System.EventHandler(this.BtnCEP_Click_1);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdentificacion.Location = new System.Drawing.Point(107, 22);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificacion.MinimumSize = new System.Drawing.Size(4, 24);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(107, 22);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label42.Location = new System.Drawing.Point(7, 25);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(92, 16);
            this.label42.TabIndex = 253;
            this.label42.Text = "Identificacion:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(221, 19);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(115, 28);
            this.BtnBuscar.TabIndex = 260;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpEgreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbTEgreso);
            this.groupBox1.Controls.Add(this.CmbEEgreso);
            this.groupBox1.Controls.Add(this.CmbGRD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 98);
            this.groupBox1.TabIndex = 312;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos De Egreso";
            // 
            // DtpEgreso
            // 
            this.DtpEgreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpEgreso.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEgreso.Location = new System.Drawing.Point(62, 62);
            this.DtpEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.DtpEgreso.MaxDate = new System.DateTime(2999, 4, 7, 0, 0, 0, 0);
            this.DtpEgreso.Name = "DtpEgreso";
            this.DtpEgreso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpEgreso.RightToLeftLayout = true;
            this.DtpEgreso.Size = new System.Drawing.Size(75, 21);
            this.DtpEgreso.TabIndex = 13;
            this.DtpEgreso.Value = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 309;
            this.label1.Text = "Fecha:";
            // 
            // CmbTEgreso
            // 
            this.CmbTEgreso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbTEgreso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbTEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbTEgreso.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTEgreso.FormattingEnabled = true;
            this.CmbTEgreso.Items.AddRange(new object[] {
            "Alta",
            "Alta Voluntaria",
            "Cirugía",
            "Homecare",
            "Hostal",
            "Intermedios Amberes",
            "Intermedios San Fernando",
            "Remitido(a)",
            "SG María Auxiliadora",
            "UCI Amb.",
            "UCI SF."});
            this.CmbTEgreso.Location = new System.Drawing.Point(382, 60);
            this.CmbTEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.CmbTEgreso.Name = "CmbTEgreso";
            this.CmbTEgreso.Size = new System.Drawing.Size(187, 24);
            this.CmbTEgreso.TabIndex = 15;
            this.CmbTEgreso.Text = "Alta";
            // 
            // CmbEEgreso
            // 
            this.CmbEEgreso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbEEgreso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbEEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbEEgreso.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEEgreso.FormattingEnabled = true;
            this.CmbEEgreso.Items.AddRange(new object[] {
            "Vivo",
            "Fallecido(a)"});
            this.CmbEEgreso.Location = new System.Drawing.Point(227, 60);
            this.CmbEEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.CmbEEgreso.Name = "CmbEEgreso";
            this.CmbEEgreso.Size = new System.Drawing.Size(98, 24);
            this.CmbEEgreso.TabIndex = 14;
            this.CmbEEgreso.Text = "Vivo";
            // 
            // CmbGRD
            // 
            this.CmbGRD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbGRD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbGRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbGRD.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGRD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.CmbGRD.FormattingEnabled = true;
            this.CmbGRD.Items.AddRange(new object[] {
            "Enf. y trastornos del sistema nervioso.",
            "Enf. y trastornos del ojo.",
            "Enf. y trastornos del oído, nariz, boca y garganta.",
            "Enf. y trastornos del sistema respiratorio.",
            "Enf. y trastornos del sistema circulatorio.",
            "Enf. y trastornos del sistema digestivo.",
            "Enf. y trastornos del sistema hepatobiliar y páncreas.",
            "Enf. y trastornos del sistema musculoesquelético y tejido conectivo.",
            "Enf. y trastornos de la piel, del tejido subcutáneo y de la mama.",
            "Enf. y trastornos endocrinos, nutricionales y metabólicos.",
            "Enf. y trastornos del riñón y vías urinarias.",
            "Enf. y trastornos del sistema reproductor masculino.",
            "Enf. y trastornos del sistema reproductor femenino.",
            "Embarazo, parto y puerperio.",
            "Recién nacidos y cuadros del periodo perinatal.",
            "Enf. y trastornos de la sangre, del sistema hematopoyético y del sistema inmunita" +
                "rio.",
            "Enf. y trastornos mieloproliferativos y neoplasias poco diferenciadas.",
            "Enf. infecciosas y parasitarias (sistémicas o afectación no especificada).",
            "Enf. o trastornos mentales.",
            "Trastornos mentales y del comportamiento.",
            "Heridas, envenenamientos y efectos tóxicos de las drogas.",
            "Quemaduras.",
            "Factores que influyen en el estado de salud y otros contactos con Servicios Sanit" +
                "arios.",
            "Infecciones por el Virus de la Inmunodeficiencia Humana.",
            "Politraumatismos importantes."});
            this.CmbGRD.Location = new System.Drawing.Point(52, 28);
            this.CmbGRD.Margin = new System.Windows.Forms.Padding(4);
            this.CmbGRD.Name = "CmbGRD";
            this.CmbGRD.Size = new System.Drawing.Size(727, 24);
            this.CmbGRD.TabIndex = 313;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(338, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 308;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 317;
            this.label4.Text = "GRR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(167, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 307;
            this.label2.Text = "Estado:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(674, 231);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 28);
            this.BtnGuardar.TabIndex = 261;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 313;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpEgreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTEgreso;
        private System.Windows.Forms.ComboBox CmbEEgreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbGRD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNvoProcedimiento;
        private System.Windows.Forms.Button BtnSolInterconsulta;
        private System.Windows.Forms.Button BtnCEP;
        private System.Windows.Forms.Button button1;
    }
}