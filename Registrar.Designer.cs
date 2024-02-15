namespace SolisLuciaTPLab3
{
    partial class Registrar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNatural = new System.Windows.Forms.TextBox();
            this.txtIntencional = new System.Windows.Forms.TextBox();
            this.txtDesconocida = new System.Windows.Forms.TextBox();
            this.txtNegligencia = new System.Windows.Forms.TextBox();
            this.dtpAnio = new System.Windows.Forms.DateTimePicker();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImportar);
            this.groupBox2.Controls.Add(this.btnSeleccionar);
            this.groupBox2.Controls.Add(this.txtRuta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 153);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importar Datos";
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Transparent;
            this.btnImportar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Location = new System.Drawing.Point(308, 101);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(95, 23);
            this.btnImportar.TabIndex = 13;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Location = new System.Drawing.Point(83, 24);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(95, 23);
            this.btnSeleccionar.TabIndex = 14;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.BackColor = System.Drawing.Color.DimGray;
            this.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRuta.Location = new System.Drawing.Point(21, 64);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(382, 13);
            this.txtRuta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Archivo xls";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtNatural);
            this.groupBox1.Controls.Add(this.txtIntencional);
            this.groupBox1.Controls.Add(this.txtDesconocida);
            this.groupBox1.Controls.Add(this.txtNegligencia);
            this.groupBox1.Controls.Add(this.dtpAnio);
            this.groupBox1.Controls.Add(this.cmbProvincia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 224);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Registro";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(307, 167);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 29);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNatural
            // 
            this.txtNatural.BackColor = System.Drawing.Color.DimGray;
            this.txtNatural.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNatural.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNatural.Location = new System.Drawing.Point(303, 84);
            this.txtNatural.Name = "txtNatural";
            this.txtNatural.Size = new System.Drawing.Size(100, 13);
            this.txtNatural.TabIndex = 11;
            this.txtNatural.TextChanged += new System.EventHandler(this.txtNatural_TextChanged);
            // 
            // txtIntencional
            // 
            this.txtIntencional.BackColor = System.Drawing.Color.DimGray;
            this.txtIntencional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIntencional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIntencional.Location = new System.Drawing.Point(89, 118);
            this.txtIntencional.Name = "txtIntencional";
            this.txtIntencional.Size = new System.Drawing.Size(100, 13);
            this.txtIntencional.TabIndex = 10;
            this.txtIntencional.TextChanged += new System.EventHandler(this.txtIntencional_TextChanged);
            // 
            // txtDesconocida
            // 
            this.txtDesconocida.BackColor = System.Drawing.Color.DimGray;
            this.txtDesconocida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesconocida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDesconocida.Location = new System.Drawing.Point(303, 118);
            this.txtDesconocida.Name = "txtDesconocida";
            this.txtDesconocida.Size = new System.Drawing.Size(100, 13);
            this.txtDesconocida.TabIndex = 9;
            this.txtDesconocida.TextChanged += new System.EventHandler(this.txtDesconocida_TextChanged);
            // 
            // txtNegligencia
            // 
            this.txtNegligencia.BackColor = System.Drawing.Color.DimGray;
            this.txtNegligencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNegligencia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNegligencia.Location = new System.Drawing.Point(89, 84);
            this.txtNegligencia.Name = "txtNegligencia";
            this.txtNegligencia.Size = new System.Drawing.Size(100, 13);
            this.txtNegligencia.TabIndex = 8;
            this.txtNegligencia.TextChanged += new System.EventHandler(this.txtNegligencia_TextChanged);
            // 
            // dtpAnio
            // 
            this.dtpAnio.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpAnio.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.dtpAnio.CustomFormat = "";
            this.dtpAnio.Location = new System.Drawing.Point(303, 37);
            this.dtpAnio.Name = "dtpAnio";
            this.dtpAnio.ShowUpDown = true;
            this.dtpAnio.Size = new System.Drawing.Size(100, 20);
            this.dtpAnio.TabIndex = 7;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmbProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvincia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(89, 36);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(141, 21);
            this.cmbProvincia.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descononcida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Negligencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Natural";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intencional";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provincia";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(79, 25);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(8, 8);
            this.printPreviewControl1.TabIndex = 9;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.printPreviewControl1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNatural;
        private System.Windows.Forms.TextBox txtIntencional;
        private System.Windows.Forms.TextBox txtDesconocida;
        private System.Windows.Forms.TextBox txtNegligencia;
        private System.Windows.Forms.DateTimePicker dtpAnio;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    }
}