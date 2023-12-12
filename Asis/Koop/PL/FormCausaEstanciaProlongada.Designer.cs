namespace Koop.PL
{
    partial class FormCausaEstanciaProlongada
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBoxSolicitudInterconsulta = new System.Windows.Forms.GroupBox();
            this.DtpFReporte = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEObservacion = new System.Windows.Forms.TextBox();
            this.cmbCEstancia = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBoxSolicitudInterconsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(477, 187);
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
            this.BtnGuardar.Location = new System.Drawing.Point(354, 187);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 28);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBoxSolicitudInterconsulta
            // 
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.DtpFReporte);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label2);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.txtEObservacion);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.cmbCEstancia);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label27);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label1);
            this.groupBoxSolicitudInterconsulta.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSolicitudInterconsulta.Location = new System.Drawing.Point(10, 36);
            this.groupBoxSolicitudInterconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSolicitudInterconsulta.Name = "groupBoxSolicitudInterconsulta";
            this.groupBoxSolicitudInterconsulta.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSolicitudInterconsulta.Size = new System.Drawing.Size(590, 143);
            this.groupBoxSolicitudInterconsulta.TabIndex = 1;
            this.groupBoxSolicitudInterconsulta.TabStop = false;
            this.groupBoxSolicitudInterconsulta.Text = "Causa de estancias prolongadas";
            // 
            // DtpFReporte
            // 
            this.DtpFReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFReporte.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFReporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFReporte.Location = new System.Drawing.Point(139, 28);
            this.DtpFReporte.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFReporte.MaxDate = new System.DateTime(2999, 4, 7, 0, 0, 0, 0);
            this.DtpFReporte.Name = "DtpFReporte";
            this.DtpFReporte.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpFReporte.RightToLeftLayout = true;
            this.DtpFReporte.Size = new System.Drawing.Size(91, 21);
            this.DtpFReporte.TabIndex = 331;
            this.DtpFReporte.Value = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 308;
            this.label2.Text = "Fecha De Reporte:";
            // 
            // txtEObservacion
            // 
            this.txtEObservacion.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEObservacion.Location = new System.Drawing.Point(101, 87);
            this.txtEObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEObservacion.Multiline = true;
            this.txtEObservacion.Name = "txtEObservacion";
            this.txtEObservacion.Size = new System.Drawing.Size(482, 46);
            this.txtEObservacion.TabIndex = 2;
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
            this.cmbCEstancia.Location = new System.Drawing.Point(214, 56);
            this.cmbCEstancia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCEstancia.Name = "cmbCEstancia";
            this.cmbCEstancia.Size = new System.Drawing.Size(368, 24);
            this.cmbCEstancia.TabIndex = 1;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(10, 89);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 16);
            this.label27.TabIndex = 307;
            this.label27.Text = "Observacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 254;
            this.label1.Text = "Causa de estancia prolongada:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(231, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(520, 13);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 15);
            this.txtID.TabIndex = 300;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(491, 12);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 16);
            this.labelID.TabIndex = 301;
            this.labelID.Text = "ID";
            // 
            // FormCausaEstanciaProlongada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 226);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBoxSolicitudInterconsulta);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormCausaEstanciaProlongada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Causas de estancia prolongada";
            this.groupBoxSolicitudInterconsulta.ResumeLayout(false);
            this.groupBoxSolicitudInterconsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox groupBoxSolicitudInterconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCEstancia;
        private System.Windows.Forms.TextBox txtEObservacion;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DateTimePicker DtpFReporte;
    }
}