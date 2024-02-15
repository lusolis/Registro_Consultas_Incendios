namespace SolisLuciaTPLab3
{
    partial class consultar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chtConsulta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.cmbGrafico = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpAnioConsulta = new System.Windows.Forms.DateTimePicker();
            this.cmbProvinciaConsulta = new System.Windows.Forms.ComboBox();
            this.optProvincia = new System.Windows.Forms.RadioButton();
            this.optAnio = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtConsulta
            // 
            this.chtConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chtConsulta.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea2.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.LightCoral;
            chartArea2.Name = "ChartArea1";
            this.chtConsulta.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chtConsulta.Legends.Add(legend2);
            this.chtConsulta.Location = new System.Drawing.Point(12, 353);
            this.chtConsulta.Name = "chtConsulta";
            this.chtConsulta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderColor = System.Drawing.Color.Gray;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.LightSeaGreen;
            series2.LabelBackColor = System.Drawing.SystemColors.ButtonFace;
            series2.LabelForeColor = System.Drawing.SystemColors.ButtonFace;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.DimGray;
            series2.Name = "Series1";
            this.chtConsulta.Series.Add(series2);
            this.chtConsulta.Size = new System.Drawing.Size(734, 284);
            this.chtConsulta.TabIndex = 14;
            this.chtConsulta.Text = "chart1";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsulta.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 124);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvConsulta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvConsulta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(734, 223);
            this.dgvConsulta.TabIndex = 13;
            // 
            // cmbGrafico
            // 
            this.cmbGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGrafico.FormattingEnabled = true;
            this.cmbGrafico.Location = new System.Drawing.Point(373, 42);
            this.cmbGrafico.Name = "cmbGrafico";
            this.cmbGrafico.Size = new System.Drawing.Size(180, 21);
            this.cmbGrafico.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpAnioConsulta);
            this.groupBox3.Controls.Add(this.cmbProvinciaConsulta);
            this.groupBox3.Controls.Add(this.optProvincia);
            this.groupBox3.Controls.Add(this.optAnio);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(12, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 90);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Consulta";
            // 
            // dtpAnioConsulta
            // 
            this.dtpAnioConsulta.CustomFormat = "";
            this.dtpAnioConsulta.Location = new System.Drawing.Point(111, 25);
            this.dtpAnioConsulta.Name = "dtpAnioConsulta";
            this.dtpAnioConsulta.ShowUpDown = true;
            this.dtpAnioConsulta.Size = new System.Drawing.Size(76, 20);
            this.dtpAnioConsulta.TabIndex = 8;
            // 
            // cmbProvinciaConsulta
            // 
            this.cmbProvinciaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvinciaConsulta.FormattingEnabled = true;
            this.cmbProvinciaConsulta.Location = new System.Drawing.Point(111, 55);
            this.cmbProvinciaConsulta.Name = "cmbProvinciaConsulta";
            this.cmbProvinciaConsulta.Size = new System.Drawing.Size(183, 21);
            this.cmbProvinciaConsulta.TabIndex = 4;
            // 
            // optProvincia
            // 
            this.optProvincia.AutoSize = true;
            this.optProvincia.Location = new System.Drawing.Point(17, 59);
            this.optProvincia.Name = "optProvincia";
            this.optProvincia.Size = new System.Drawing.Size(88, 17);
            this.optProvincia.TabIndex = 5;
            this.optProvincia.TabStop = true;
            this.optProvincia.Text = "Por Provincia";
            this.optProvincia.UseVisualStyleBackColor = true;
            // 
            // optAnio
            // 
            this.optAnio.AutoSize = true;
            this.optAnio.Location = new System.Drawing.Point(17, 28);
            this.optAnio.Name = "optAnio";
            this.optAnio.Size = new System.Drawing.Size(63, 17);
            this.optAnio.TabIndex = 4;
            this.optAnio.TabStop = true;
            this.optAnio.Text = "Por Año";
            this.optAnio.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(370, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo de Gráfico";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(607, 66);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 32);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultar.Location = new System.Drawing.Point(607, 27);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 32);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(758, 649);
            this.Controls.Add(this.chtConsulta);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.cmbGrafico);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Name = "consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "consultar";
            this.Load += new System.EventHandler(this.consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.ComboBox cmbGrafico;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpAnioConsulta;
        private System.Windows.Forms.ComboBox cmbProvinciaConsulta;
        private System.Windows.Forms.RadioButton optProvincia;
        private System.Windows.Forms.RadioButton optAnio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
    }
}