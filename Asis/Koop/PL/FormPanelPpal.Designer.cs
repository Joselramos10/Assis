namespace Koop.PL
{
    partial class FormPanelPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelPpal));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnIndicadores = new System.Windows.Forms.Button();
            this.BtnDatosPacientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(984, 541);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(128, 28);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Salir";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtnIndicadores);
            this.panel1.Controls.Add(this.BtnDatosPacientes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 608);
            this.panel1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button3.Location = new System.Drawing.Point(0, 174);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(166, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Configuración";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // BtnIndicadores
            // 
            this.BtnIndicadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.BtnIndicadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnIndicadores.FlatAppearance.BorderSize = 0;
            this.BtnIndicadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIndicadores.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIndicadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnIndicadores.Location = new System.Drawing.Point(0, 138);
            this.BtnIndicadores.Name = "BtnIndicadores";
            this.BtnIndicadores.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnIndicadores.Size = new System.Drawing.Size(166, 36);
            this.BtnIndicadores.TabIndex = 1;
            this.BtnIndicadores.Text = "Indicadores";
            this.BtnIndicadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIndicadores.UseVisualStyleBackColor = false;
            this.BtnIndicadores.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDatosPacientes
            // 
            this.BtnDatosPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.BtnDatosPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDatosPacientes.FlatAppearance.BorderSize = 0;
            this.BtnDatosPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDatosPacientes.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDatosPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BtnDatosPacientes.Location = new System.Drawing.Point(0, 102);
            this.BtnDatosPacientes.Name = "BtnDatosPacientes";
            this.BtnDatosPacientes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnDatosPacientes.Size = new System.Drawing.Size(166, 36);
            this.BtnDatosPacientes.TabIndex = 0;
            this.BtnDatosPacientes.Text = "Datos De Ingreso";
            this.BtnDatosPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDatosPacientes.UseVisualStyleBackColor = false;
            this.BtnDatosPacientes.Click += new System.EventHandler(this.BtnDatosPacientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(64)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(166, 0);
            this.panelContenedor.MaximumSize = new System.Drawing.Size(1300, 1000);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1118, 608);
            this.panelContenedor.TabIndex = 7;
            // 
            // FormPanelPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 608);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCancelar);
            this.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPanelPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asis: Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button BtnDatosPacientes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnIndicadores;
    }
}