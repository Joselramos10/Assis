namespace Koop.PL
{
    partial class FormCausaCancelacionProcedimientos
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
            this.DtpFReporte = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCObservacion = new System.Windows.Forms.TextBox();
            this.cmbCausaCancelacion = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBoxSolicitudInterconsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSolicitudInterconsulta
            // 
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.DtpFReporte);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label2);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.txtCObservacion);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.cmbCausaCancelacion);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label27);
            this.groupBoxSolicitudInterconsulta.Controls.Add(this.label3);
            this.groupBoxSolicitudInterconsulta.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSolicitudInterconsulta.Location = new System.Drawing.Point(9, 36);
            this.groupBoxSolicitudInterconsulta.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSolicitudInterconsulta.Name = "groupBoxSolicitudInterconsulta";
            this.groupBoxSolicitudInterconsulta.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSolicitudInterconsulta.Size = new System.Drawing.Size(802, 133);
            this.groupBoxSolicitudInterconsulta.TabIndex = 306;
            this.groupBoxSolicitudInterconsulta.TabStop = false;
            this.groupBoxSolicitudInterconsulta.Text = "Procedimientos solicitados";
            // 
            // DtpFReporte
            // 
            this.DtpFReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFReporte.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFReporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFReporte.Location = new System.Drawing.Point(136, 33);
            this.DtpFReporte.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFReporte.MaxDate = new System.DateTime(2999, 4, 7, 0, 0, 0, 0);
            this.DtpFReporte.Name = "DtpFReporte";
            this.DtpFReporte.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DtpFReporte.RightToLeftLayout = true;
            this.DtpFReporte.Size = new System.Drawing.Size(93, 21);
            this.DtpFReporte.TabIndex = 337;
            this.DtpFReporte.Value = new System.DateTime(2023, 11, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 336;
            this.label2.Text = "Fecha De Reporte:";
            // 
            // txtCObservacion
            // 
            this.txtCObservacion.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCObservacion.Location = new System.Drawing.Point(102, 67);
            this.txtCObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtCObservacion.Multiline = true;
            this.txtCObservacion.Name = "txtCObservacion";
            this.txtCObservacion.Size = new System.Drawing.Size(678, 46);
            this.txtCObservacion.TabIndex = 333;
            // 
            // cmbCausaCancelacion
            // 
            this.cmbCausaCancelacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCausaCancelacion.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCausaCancelacion.FormattingEnabled = true;
            this.cmbCausaCancelacion.Items.AddRange(new object[] {
            "Condición clínica del paciente.",
            "Sin autorizacion.",
            "Necesidad de atención en otro nivel de complejidad.",
            "Ocurrencia de evento adverso."});
            this.cmbCausaCancelacion.Location = new System.Drawing.Point(305, 31);
            this.cmbCausaCancelacion.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCausaCancelacion.Name = "cmbCausaCancelacion";
            this.cmbCausaCancelacion.Size = new System.Drawing.Size(475, 24);
            this.cmbCausaCancelacion.TabIndex = 332;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(8, 67);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 16);
            this.label27.TabIndex = 335;
            this.label27.Text = "Observacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 334;
            this.label3.Text = "Causa:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(674, 183);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(115, 28);
            this.BtnCancelar.TabIndex = 308;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(551, 183);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(115, 28);
            this.BtnGuardar.TabIndex = 307;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormCausaCancelacionProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 224);
            this.Controls.Add(this.groupBoxSolicitudInterconsulta);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormCausaCancelacionProcedimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCausaCancelacionProcedimientos";
            this.groupBoxSolicitudInterconsulta.ResumeLayout(false);
            this.groupBoxSolicitudInterconsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSolicitudInterconsulta;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DateTimePicker DtpFReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCObservacion;
        private System.Windows.Forms.ComboBox cmbCausaCancelacion;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label3;
    }
}