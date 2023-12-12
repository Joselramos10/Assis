namespace Koop.PL
{
    partial class FormInterconsulta
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
            this.groupBoxSolicitudInterconsulta = new System.Windows.Forms.GroupBox();
            this.DtpFValoracion = new System.Windows.Forms.DateTimePicker();
            this.DtpFSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEspSolicitada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxSolicitudInterconsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSolicitudInterconsulta
            // 
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.DtpFValoracion);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.DtpFSolicitud);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label2);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.cmbEspSolicitada);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label1);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label46);
            this.groupBoxSolicitudInterconsulta.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSolicitudInterconsulta.Location = new System.Drawing.Point(8, 36);
            this.groupBoxSolicitudInterconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSolicitudInterconsulta.Name = "groupBoxSolicitudInterconsulta";
            this.groupBoxSolicitudInterconsulta.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSolicitudInterconsulta.Size = new System.Drawing.Size(496, 105);
            this.groupBoxSolicitudInterconsulta.TabIndex = 1;
            this.groupBoxSolicitudInterconsulta.TabStop = false;
            this.groupBoxSolicitudInterconsulta.Text = "Solicitud de Interconsulta";
            // 
            // DtpFValoracion
            // 
            this.DtpFValoracion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFValoracion.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFValoracion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFValoracion.Location = new System.Drawing.Point(387, 28);
            this.DtpFValoracion.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFValoracion.MaxDate = new System.DateTime(2999, 4, 7, 0, 0, 0, 0);
            this.DtpFValoracion.Name = "DtpFValoracion";
            this.DtpFValoracion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpFValoracion.RightToLeftLayout = true;
            this.DtpFValoracion.Size = new System.Drawing.Size(97, 21);
            this.DtpFValoracion.TabIndex = 332;
            this.DtpFValoracion.Value = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // DtpFSolicitud
            // 
            this.DtpFSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFSolicitud.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFSolicitud.Location = new System.Drawing.Point(140, 28);
            this.DtpFSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFSolicitud.MaxDate = new System.DateTime(2999, 4, 7, 0, 0, 0, 0);
            this.DtpFSolicitud.Name = "DtpFSolicitud";
            this.DtpFSolicitud.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpFSolicitud.RightToLeftLayout = true;
            this.DtpFSolicitud.Size = new System.Drawing.Size(97, 21);
            this.DtpFSolicitud.TabIndex = 331;
            this.DtpFSolicitud.Value = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 256;
            this.label2.Text = "Fecha De Valoración:";
            // 
            // cmbEspSolicitada
            // 
            this.cmbEspSolicitada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEspSolicitada.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEspSolicitada.FormattingEnabled = true;
            this.cmbEspSolicitada.Items.AddRange(new object[] {
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
            this.cmbEspSolicitada.Location = new System.Drawing.Point(171, 60);
            this.cmbEspSolicitada.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbEspSolicitada.Name = "cmbEspSolicitada";
            this.cmbEspSolicitada.Size = new System.Drawing.Size(314, 24);
            this.cmbEspSolicitada.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 254;
            this.label1.Text = "Interconsulta Solicitada:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(9, 30);
            this.label46.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(122, 16);
            this.label46.TabIndex = 252;
            this.label46.Text = "Fecha De Solicitud:";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(264, 148);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 28);
            this.BtnGuardar.TabIndex = 2;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(380, 148);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 28);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(424, 14);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 15);
            this.txtID.TabIndex = 300;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(395, 12);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 16);
            this.labelID.TabIndex = 301;
            this.labelID.Text = "ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 302;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormInterconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 189);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBoxSolicitudInterconsulta);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInterconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Interconsulta";
            this.groupBoxSolicitudInterconsulta.ResumeLayout(false);
            this.groupBoxSolicitudInterconsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSolicitudInterconsulta;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox cmbEspSolicitada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DateTimePicker DtpFValoracion;
        private System.Windows.Forms.DateTimePicker DtpFSolicitud;
        private System.Windows.Forms.Button button1;
    }
}