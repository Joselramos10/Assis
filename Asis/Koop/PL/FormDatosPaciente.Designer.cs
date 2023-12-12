namespace Koop.PL
{
    partial class FormDatosPaciente
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
            this.groupBoxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.cmbEAPB = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.groupBoxDatosIngreso = new System.Windows.Forms.GroupBox();
            this.DtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.cmbProcedencia = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEObservacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCEstancia = new System.Windows.Forms.ComboBox();
            this.BtnCEP = new System.Windows.Forms.Button();
            this.groupBoxProcedimientosSolicitados = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNvoProcedimiento = new System.Windows.Forms.Button();
            this.TxtCodigoCUPS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.codigosCUPSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codigos_CUPSDataSet = new Koop.Codigos_CUPSDataSet();
            this.groupBoxDatosClinicos = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.txtICharlson = new System.Windows.Forms.TextBox();
            this.CmbGRD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspPTratante = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSolInterconsulta = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.dBSistemaDataSet = new Koop.DBSistemaDataSet();
            this.datosPacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosPacienteTableAdapter = new Koop.DBSistemaDataSetTableAdapters.DatosPacienteTableAdapter();
            this.codigosCUPSTableAdapter = new Koop.Codigos_CUPSDataSetTableAdapters.CodigosCUPSTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbEEgreso = new System.Windows.Forms.ComboBox();
            this.CmbTEgreso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpEgreso = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDatosPersonales.SuspendLayout();
            this.groupBoxDatosIngreso.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxProcedimientosSolicitados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosCUPSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigos_CUPSDataSet)).BeginInit();
            this.groupBoxDatosClinicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPacienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatosPersonales
            // 
            this.groupBoxDatosPersonales.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxDatosPersonales.Controls.Add(this.cmbEAPB);
            this.groupBoxDatosPersonales.Controls.Add(this.txtEdad);
            this.groupBoxDatosPersonales.Controls.Add(this.cmbSexo);
            this.groupBoxDatosPersonales.Controls.Add(this.txtIdentificacion);
            this.groupBoxDatosPersonales.Controls.Add(this.label39);
            this.groupBoxDatosPersonales.Controls.Add(this.label40);
            this.groupBoxDatosPersonales.Controls.Add(this.label41);
            this.groupBoxDatosPersonales.Controls.Add(this.label42);
            this.groupBoxDatosPersonales.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosPersonales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.groupBoxDatosPersonales.Location = new System.Drawing.Point(21, 47);
            this.groupBoxDatosPersonales.Name = "groupBoxDatosPersonales";
            this.groupBoxDatosPersonales.Size = new System.Drawing.Size(1085, 58);
            this.groupBoxDatosPersonales.TabIndex = 1;
            this.groupBoxDatosPersonales.TabStop = false;
            this.groupBoxDatosPersonales.Text = "Datos Personales";
            // 
            // cmbEAPB
            // 
            this.cmbEAPB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEAPB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEAPB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEAPB.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEAPB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbEAPB.FormattingEnabled = true;
            this.cmbEAPB.Items.AddRange(new object[] {
            "ADRES - Adm. de los Recursos del Sistema General de Seguridad Social en Salud",
            "DADIS - Alcaldia Mayor De Cartagena",
            "Allianz Seguros De Vida SA",
            "Axa Colpatria  Seguros De Vida",
            "Axa Colpatria Seguros SA",
            "Caja De Compensacion Familiar Cajacopi",
            "Caja De Compensación Familiar Compensar EPS",
            "Capital Salud Eps-S SAS",
            "Centro Radio Oncologico Del Caribe",
            "Colmedica Medicina Prepagada SA",
            "Compañía Mundial De Seguros SA",
            "Compañia Seguros Bolivar SA",
            "Coomeva Eps SA",
            "Coosalud Entidad Promotora De Salud SA",
            "Direccion General Sanidad Militar",
            "Emssanar ESS",
            "Entidad Promotora De Salud Famisanar Sas",
            "Eps Medicina Prepagada Suramericana SA",
            "EPS Sanitas SAS",
            "Federacion Colombiana De Obstetricia Y Ginecologia",
            "La Previsora SA Compañia De Seguros",
            "Medplus Medicina Prepagada",
            "Mutual Ser ESS",
            "Neurodinamia SA",
            "Nueva EPS",
            "Organizacion Clinica General Del Norte",
            "Particular",
            "Policia Metropolitana De Cartagena De Indias",
            "Positiva Compania De Seguros SA",
            "Regional De Aseguramiento En Salud",
            "Riesgos Profesionales Colmena S.A Compañia De Seguros De Vida",
            "Salud Total EPS",
            "Seguros Comerciales Bolivar",
            "Seguros De Vida Alfa SA",
            "Seguros De Vida Suramericana SA",
            "Seguros Del Estado SA (Soat)",
            "Seguros Generales Suramericana SA"});
            this.cmbEAPB.Location = new System.Drawing.Point(549, 22);
            this.cmbEAPB.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEAPB.Name = "cmbEAPB";
            this.cmbEAPB.Size = new System.Drawing.Size(529, 24);
            this.cmbEAPB.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEdad.Location = new System.Drawing.Point(271, 23);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.MinimumSize = new System.Drawing.Size(4, 23);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(67, 22);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.Text = "1";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSexo.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(392, 22);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(96, 24);
            this.cmbSexo.TabIndex = 3;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdentificacion.Location = new System.Drawing.Point(107, 23);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentificacion.MinimumSize = new System.Drawing.Size(4, 24);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(107, 22);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label39.Location = new System.Drawing.Point(496, 26);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(45, 16);
            this.label39.TabIndex = 256;
            this.label39.Text = "EAPB:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label40.Location = new System.Drawing.Point(222, 26);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(41, 16);
            this.label40.TabIndex = 255;
            this.label40.Text = "Edad:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label41.Location = new System.Drawing.Point(346, 26);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(38, 16);
            this.label41.TabIndex = 254;
            this.label41.Text = "Sexo:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label42.Location = new System.Drawing.Point(7, 26);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(92, 16);
            this.label42.TabIndex = 253;
            this.label42.Text = "Identificacion:";
            // 
            // groupBoxDatosIngreso
            // 
            this.groupBoxDatosIngreso.Controls.Add(this.DtpIngreso);
            this.groupBoxDatosIngreso.Controls.Add(this.cmbProcedencia);
            this.groupBoxDatosIngreso.Controls.Add(this.label45);
            this.groupBoxDatosIngreso.Controls.Add(this.label46);
            this.groupBoxDatosIngreso.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.groupBoxDatosIngreso.Location = new System.Drawing.Point(20, 111);
            this.groupBoxDatosIngreso.Name = "groupBoxDatosIngreso";
            this.groupBoxDatosIngreso.Size = new System.Drawing.Size(490, 58);
            this.groupBoxDatosIngreso.TabIndex = 2;
            this.groupBoxDatosIngreso.TabStop = false;
            this.groupBoxDatosIngreso.Text = "Datos De Ingreso";
            // 
            // DtpIngreso
            // 
            this.DtpIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpIngreso.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpIngreso.Location = new System.Drawing.Point(63, 24);
            this.DtpIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.DtpIngreso.MaxDate = new System.DateTime(2999, 4, 7, 0, 0, 0, 0);
            this.DtpIngreso.Name = "DtpIngreso";
            this.DtpIngreso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpIngreso.RightToLeftLayout = true;
            this.DtpIngreso.Size = new System.Drawing.Size(97, 21);
            this.DtpIngreso.TabIndex = 254;
            this.DtpIngreso.Value = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // cmbProcedencia
            // 
            this.cmbProcedencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProcedencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProcedencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProcedencia.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProcedencia.FormattingEnabled = true;
            this.cmbProcedencia.Items.AddRange(new object[] {
            "Cirugía",
            "Intermedios: Amberes",
            "Intermedios: San Fernando",
            "Programado",
            "Remitido(a)",
            "Sala General: María Auxiliadora",
            "UCI: Amberes",
            "UCI: San Fernando",
            "Urgencias"});
            this.cmbProcedencia.Location = new System.Drawing.Point(278, 21);
            this.cmbProcedencia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProcedencia.Name = "cmbProcedencia";
            this.cmbProcedencia.Size = new System.Drawing.Size(205, 24);
            this.cmbProcedencia.TabIndex = 6;
            this.cmbProcedencia.Text = "Urgencias";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label45.Location = new System.Drawing.Point(187, 25);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(83, 16);
            this.label45.TabIndex = 253;
            this.label45.Text = "Procedencia";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label46.Location = new System.Drawing.Point(8, 25);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(47, 16);
            this.label46.TabIndex = 252;
            this.label46.Text = "Fecha:";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(999, 16);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 15);
            this.txtID.TabIndex = 99;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(970, 15);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 16);
            this.labelID.TabIndex = 299;
            this.labelID.Text = "ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtEObservacion);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.cmbCEstancia);
            this.groupBox5.Controls.Add(this.BtnCEP);
            this.groupBox5.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.groupBox5.Location = new System.Drawing.Point(20, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1085, 126);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Causa De Estancia Prolongada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 18);
            this.label7.TabIndex = 303;
            this.label7.Text = "Observaciones:";
            // 
            // txtEObservacion
            // 
            this.txtEObservacion.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEObservacion.Location = new System.Drawing.Point(7, 76);
            this.txtEObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEObservacion.Multiline = true;
            this.txtEObservacion.Name = "txtEObservacion";
            this.txtEObservacion.Size = new System.Drawing.Size(1071, 44);
            this.txtEObservacion.TabIndex = 302;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 28);
            this.button1.TabIndex = 301;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbCEstancia
            // 
            this.cmbCEstancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCEstancia.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCEstancia.FormattingEnabled = true;
            this.cmbCEstancia.Items.AddRange(new object[] {
            "Condición clínica del paciente",
            "Demora en la realización de procedimientos diagnósticos",
            "Demora en la realización de procedimientos quirúrgicos",
            "Demora en las autorizaciones",
            "Necesidad de atención en otro nivel de complejidad",
            "Ocurrencia de evento adverso",
            "Traslado de paciente"});
            this.cmbCEstancia.Location = new System.Drawing.Point(7, 24);
            this.cmbCEstancia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCEstancia.Name = "cmbCEstancia";
            this.cmbCEstancia.Size = new System.Drawing.Size(483, 24);
            this.cmbCEstancia.TabIndex = 11;
            // 
            // BtnCEP
            // 
            this.BtnCEP.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCEP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCEP.Location = new System.Drawing.Point(619, 23);
            this.BtnCEP.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCEP.Name = "BtnCEP";
            this.BtnCEP.Size = new System.Drawing.Size(190, 28);
            this.BtnCEP.TabIndex = 10;
            this.BtnCEP.Text = "Agregar Nueva Causa";
            this.BtnCEP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCEP.UseVisualStyleBackColor = true;
            this.BtnCEP.Click += new System.EventHandler(this.BtnCEP_Click);
            // 
            // groupBoxProcedimientosSolicitados
            // 
            this.groupBoxProcedimientosSolicitados.Controls.Add(this.dataGridView1);
            this.groupBoxProcedimientosSolicitados.Controls.Add(this.label8);
            this.groupBoxProcedimientosSolicitados.Controls.Add(this.button2);
            this.groupBoxProcedimientosSolicitados.Controls.Add(this.btnNvoProcedimiento);
            this.groupBoxProcedimientosSolicitados.Controls.Add(this.TxtCodigoCUPS);
            this.groupBoxProcedimientosSolicitados.Controls.Add(this.label6);
            this.groupBoxProcedimientosSolicitados.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProcedimientosSolicitados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.groupBoxProcedimientosSolicitados.Location = new System.Drawing.Point(21, 402);
            this.groupBoxProcedimientosSolicitados.Name = "groupBoxProcedimientosSolicitados";
            this.groupBoxProcedimientosSolicitados.Size = new System.Drawing.Size(1085, 191);
            this.groupBoxProcedimientosSolicitados.TabIndex = 6;
            this.groupBoxProcedimientosSolicitados.TabStop = false;
            this.groupBoxProcedimientosSolicitados.Text = "Procedimientos Diagnósticos y Terapéuticos Solicitados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1069, 114);
            this.dataGridView1.TabIndex = 305;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 18);
            this.label8.TabIndex = 304;
            this.label8.Text = "Lista De Procedimientos:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(292, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 304;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNvoProcedimiento
            // 
            this.btnNvoProcedimiento.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvoProcedimiento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNvoProcedimiento.Location = new System.Drawing.Point(392, 19);
            this.btnNvoProcedimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnNvoProcedimiento.Name = "btnNvoProcedimiento";
            this.btnNvoProcedimiento.Size = new System.Drawing.Size(117, 28);
            this.btnNvoProcedimiento.TabIndex = 12;
            this.btnNvoProcedimiento.Text = "Procedimientos";
            this.btnNvoProcedimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNvoProcedimiento.UseVisualStyleBackColor = true;
            this.btnNvoProcedimiento.Click += new System.EventHandler(this.btnNvoProcedimiento_Click);
            // 
            // TxtCodigoCUPS
            // 
            this.TxtCodigoCUPS.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCUPS.Location = new System.Drawing.Point(183, 22);
            this.TxtCodigoCUPS.Name = "TxtCodigoCUPS";
            this.TxtCodigoCUPS.Size = new System.Drawing.Size(103, 23);
            this.TxtCodigoCUPS.TabIndex = 303;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 16);
            this.label6.TabIndex = 302;
            this.label6.Text = "Codigo De Procedimiento:";
            // 
            // codigosCUPSBindingSource
            // 
            this.codigosCUPSBindingSource.DataMember = "CodigosCUPS";
            this.codigosCUPSBindingSource.DataSource = this.codigos_CUPSDataSet;
            // 
            // codigos_CUPSDataSet
            // 
            this.codigos_CUPSDataSet.DataSetName = "Codigos_CUPSDataSet";
            this.codigos_CUPSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxDatosClinicos
            // 
            this.groupBoxDatosClinicos.Controls.Add(this.button3);
            this.groupBoxDatosClinicos.Controls.Add(this.BtnCalcular);
            this.groupBoxDatosClinicos.Controls.Add(this.txtICharlson);
            this.groupBoxDatosClinicos.Controls.Add(this.CmbGRD);
            this.groupBoxDatosClinicos.Controls.Add(this.label2);
            this.groupBoxDatosClinicos.Controls.Add(this.cmbEspPTratante);
            this.groupBoxDatosClinicos.Controls.Add(this.label11);
            this.groupBoxDatosClinicos.Controls.Add(this.label4);
            this.groupBoxDatosClinicos.Controls.Add(this.BtnSolInterconsulta);
            this.groupBoxDatosClinicos.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosClinicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.groupBoxDatosClinicos.Location = new System.Drawing.Point(20, 175);
            this.groupBoxDatosClinicos.Name = "groupBoxDatosClinicos";
            this.groupBoxDatosClinicos.Size = new System.Drawing.Size(1085, 89);
            this.groupBoxDatosClinicos.TabIndex = 4;
            this.groupBoxDatosClinicos.TabStop = false;
            this.groupBoxDatosClinicos.Text = "Datos Clínicos";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(509, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 28);
            this.button3.TabIndex = 304;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCalcular.Location = new System.Drawing.Point(187, 18);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(77, 28);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // txtICharlson
            // 
            this.txtICharlson.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtICharlson.Location = new System.Drawing.Point(137, 20);
            this.txtICharlson.Margin = new System.Windows.Forms.Padding(4);
            this.txtICharlson.Multiline = true;
            this.txtICharlson.Name = "txtICharlson";
            this.txtICharlson.Size = new System.Drawing.Size(42, 24);
            this.txtICharlson.TabIndex = 98;
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
            this.CmbGRD.Location = new System.Drawing.Point(314, 20);
            this.CmbGRD.Margin = new System.Windows.Forms.Padding(4);
            this.CmbGRD.Name = "CmbGRD";
            this.CmbGRD.Size = new System.Drawing.Size(765, 24);
            this.CmbGRD.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(269, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 311;
            this.label2.Text = "GRR:";
            // 
            // cmbEspPTratante
            // 
            this.cmbEspPTratante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEspPTratante.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspPTratante.FormattingEnabled = true;
            this.cmbEspPTratante.Items.AddRange(new object[] {
            "Cardiología",
            "Cirugía De Tórax",
            "Cirugía General",
            "Cirugía Maxilofacial",
            "Cirugía Pediátrica",
            "Cirugía Plástica",
            "Cirugía Vascular",
            "Endocrinología",
            "Ginecología",
            "Infectología",
            "Maxilofacial",
            "Medicina Interna",
            "Neurocirugía",
            "Nutrición",
            "Ortopedia",
            "Otorrinolaringología",
            "Pediatría",
            "Psicología",
            "Radiología Intervencionista",
            "Soporte Nutricional",
            "Toxicología",
            "Trabajo Social",
            "Urología"});
            this.cmbEspPTratante.Location = new System.Drawing.Point(201, 53);
            this.cmbEspPTratante.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEspPTratante.Name = "cmbEspPTratante";
            this.cmbEspPTratante.Size = new System.Drawing.Size(289, 24);
            this.cmbEspPTratante.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(7, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 308;
            this.label11.Text = "Indice de Charlson:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 16);
            this.label4.TabIndex = 307;
            this.label4.Text = "Especialidad principal tratante:";
            // 
            // BtnSolInterconsulta
            // 
            this.BtnSolInterconsulta.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSolInterconsulta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnSolInterconsulta.Location = new System.Drawing.Point(619, 50);
            this.BtnSolInterconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSolInterconsulta.Name = "BtnSolInterconsulta";
            this.BtnSolInterconsulta.Size = new System.Drawing.Size(190, 28);
            this.BtnSolInterconsulta.TabIndex = 9;
            this.BtnSolInterconsulta.Text = "Solicitar Nueva Interconsulta";
            this.BtnSolInterconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSolInterconsulta.UseVisualStyleBackColor = true;
            this.BtnSolInterconsulta.Click += new System.EventHandler(this.BtnSolInterconsulta_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(983, 600);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(115, 28);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(741, 600);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(115, 28);
            this.BtnNuevo.TabIndex = 9;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(500, 600);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 28);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(620, 600);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(115, 28);
            this.BtnBuscar.TabIndex = 8;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(862, 600);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(115, 28);
            this.BtnModificar.TabIndex = 300;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // dBSistemaDataSet
            // 
            this.dBSistemaDataSet.DataSetName = "DBSistemaDataSet";
            this.dBSistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosPacienteBindingSource
            // 
            this.datosPacienteBindingSource.DataMember = "DatosPaciente";
            this.datosPacienteBindingSource.DataSource = this.dBSistemaDataSet;
            // 
            // datosPacienteTableAdapter
            // 
            this.datosPacienteTableAdapter.ClearBeforeFill = true;
            // 
            // codigosCUPSTableAdapter
            // 
            this.codigosCUPSTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(186, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 307;
            this.label5.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(352, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 308;
            this.label3.Text = "Tipo:";
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
            this.CmbEEgreso.Location = new System.Drawing.Point(246, 23);
            this.CmbEEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.CmbEEgreso.Name = "CmbEEgreso";
            this.CmbEEgreso.Size = new System.Drawing.Size(98, 24);
            this.CmbEEgreso.TabIndex = 14;
            this.CmbEEgreso.Text = "Vivo";
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
            this.CmbTEgreso.Location = new System.Drawing.Point(396, 23);
            this.CmbTEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.CmbTEgreso.Name = "CmbTEgreso";
            this.CmbTEgreso.Size = new System.Drawing.Size(187, 24);
            this.CmbTEgreso.TabIndex = 15;
            this.CmbTEgreso.Text = "Alta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 309;
            this.label1.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DtpEgreso);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbTEgreso);
            this.groupBox1.Controls.Add(this.CmbEEgreso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(516, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 58);
            this.groupBox1.TabIndex = 3;
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
            this.DtpEgreso.Location = new System.Drawing.Point(62, 25);
            this.DtpEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.DtpEgreso.MaxDate = new System.DateTime(2999, 4, 7, 0, 0, 0, 0);
            this.DtpEgreso.Name = "DtpEgreso";
            this.DtpEgreso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpEgreso.RightToLeftLayout = true;
            this.DtpEgreso.Size = new System.Drawing.Size(97, 21);
            this.DtpEgreso.TabIndex = 255;
            this.DtpEgreso.Value = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // FormDatosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 656);
            this.Controls.Add(this.groupBoxProcedimientosSolicitados);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.groupBoxDatosClinicos);
            this.Controls.Add(this.groupBoxDatosIngreso);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.groupBoxDatosPersonales);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDatosPaciente";
            this.Text = "DatosPaciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxDatosPersonales.ResumeLayout(false);
            this.groupBoxDatosPersonales.PerformLayout();
            this.groupBoxDatosIngreso.ResumeLayout(false);
            this.groupBoxDatosIngreso.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxProcedimientosSolicitados.ResumeLayout(false);
            this.groupBoxProcedimientosSolicitados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigosCUPSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigos_CUPSDataSet)).EndInit();
            this.groupBoxDatosClinicos.ResumeLayout(false);
            this.groupBoxDatosClinicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBSistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosPacienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosPersonales;
        private System.Windows.Forms.ComboBox cmbEAPB;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox groupBoxDatosIngreso;
        private System.Windows.Forms.ComboBox cmbProcedencia;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBoxProcedimientosSolicitados;
        private System.Windows.Forms.GroupBox groupBoxDatosClinicos;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox txtICharlson;
        private System.Windows.Forms.ComboBox CmbGRD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEspPTratante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnSolInterconsulta;
        private System.Windows.Forms.Button btnNvoProcedimiento;
        private System.Windows.Forms.Button BtnCEP;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnModificar;
        private DBSistemaDataSet dBSistemaDataSet;
        private System.Windows.Forms.BindingSource datosPacienteBindingSource;
        private DBSistemaDataSetTableAdapters.DatosPacienteTableAdapter datosPacienteTableAdapter;
        private System.Windows.Forms.ComboBox cmbCEstancia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEObservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TxtCodigoCUPS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Codigos_CUPSDataSet codigos_CUPSDataSet;
        private System.Windows.Forms.BindingSource codigosCUPSBindingSource;
        private Codigos_CUPSDataSetTableAdapters.CodigosCUPSTableAdapter codigosCUPSTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbEEgreso;
        private System.Windows.Forms.ComboBox CmbTEgreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpIngreso;
        private System.Windows.Forms.DateTimePicker DtpEgreso;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}