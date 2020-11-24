namespace LocalForms
{
    partial class MainForm
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

        protected void PrepararDataGridViewPreparacion()
        {
            this.dtaGridPreparacion.RowHeadersVisible = false;
            this.dtaGridPreparacion.Columns[0].Width = 45;
            this.dtaGridPreparacion.Columns[1].Width = 100;
            this.dtaGridPreparacion.Columns[4].Width = 85;
            this.dtaGridPreparacion.Columns[6].Width = 55;
            this.dtaGridPreparacion.Columns[7].Width = 160;
            this.dtaGridPreparacion.Columns[2].Visible = false;
            this.dtaGridPreparacion.Columns[3].Visible = false;
            this.dtaGridPreparacion.Columns[5].Visible = false;
            this.dtaGridPreparacion.Columns[8].Visible = false;
            this.dtaGridPreparacion.Columns[9].Visible = false;

        }

        protected void PrepararDataGridViewEntregados()
        {
            this.dtaGridEntregados.RowHeadersVisible = false;
            this.dtaGridEntregados.Columns[0].Width = 30;
            this.dtaGridEntregados.Columns[2].Visible = false;
            this.dtaGridEntregados.Columns[3].Visible = false;
            this.dtaGridEntregados.Columns[5].Visible = false;
            this.dtaGridEntregados.Columns[6].Visible = false;
            this.dtaGridEntregados.Columns[7].Visible = false;
            this.dtaGridEntregados.Columns[9].Visible = false;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtaGridPreparacion = new System.Windows.Forms.DataGridView();
            this.lblPreparacion = new System.Windows.Forms.Label();
            this.dtaGridEntregados = new System.Windows.Forms.DataGridView();
            this.lblEntregados = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridPreparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridEntregados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridPreparacion
            // 
            this.dtaGridPreparacion.AllowUserToAddRows = false;
            this.dtaGridPreparacion.AllowUserToDeleteRows = false;
            this.dtaGridPreparacion.AllowUserToResizeColumns = false;
            this.dtaGridPreparacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dtaGridPreparacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtaGridPreparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGridPreparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridPreparacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridPreparacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtaGridPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridPreparacion.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtaGridPreparacion.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtaGridPreparacion.Location = new System.Drawing.Point(12, 55);
            this.dtaGridPreparacion.Name = "dtaGridPreparacion";
            this.dtaGridPreparacion.ReadOnly = true;
            this.dtaGridPreparacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridPreparacion.Size = new System.Drawing.Size(518, 336);
            this.dtaGridPreparacion.TabIndex = 3;
            // 
            // lblPreparacion
            // 
            this.lblPreparacion.AutoSize = true;
            this.lblPreparacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparacion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPreparacion.Location = new System.Drawing.Point(8, 19);
            this.lblPreparacion.Name = "lblPreparacion";
            this.lblPreparacion.Size = new System.Drawing.Size(190, 21);
            this.lblPreparacion.TabIndex = 1;
            this.lblPreparacion.Text = "Pedidos en Preparacion\r\n";
            // 
            // dtaGridEntregados
            // 
            this.dtaGridEntregados.AllowUserToAddRows = false;
            this.dtaGridEntregados.AllowUserToDeleteRows = false;
            this.dtaGridEntregados.AllowUserToResizeColumns = false;
            this.dtaGridEntregados.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dtaGridEntregados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtaGridEntregados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGridEntregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridEntregados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridEntregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtaGridEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridEntregados.DefaultCellStyle = dataGridViewCellStyle13;
            this.dtaGridEntregados.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtaGridEntregados.Location = new System.Drawing.Point(536, 55);
            this.dtaGridEntregados.Name = "dtaGridEntregados";
            this.dtaGridEntregados.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridEntregados.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtaGridEntregados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridEntregados.Size = new System.Drawing.Size(393, 336);
            this.dtaGridEntregados.TabIndex = 4;
            // 
            // lblEntregados
            // 
            this.lblEntregados.AutoSize = true;
            this.lblEntregados.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregados.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEntregados.Location = new System.Drawing.Point(532, 19);
            this.lblEntregados.Name = "lblEntregados";
            this.lblEntregados.Size = new System.Drawing.Size(161, 21);
            this.lblEntregados.TabIndex = 2;
            this.lblEntregados.Text = "Pedidos Entregados";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(363, 410);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(167, 38);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar pedido";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(941, 460);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblEntregados);
            this.Controls.Add(this.dtaGridEntregados);
            this.Controls.Add(this.lblPreparacion);
            this.Controls.Add(this.dtaGridPreparacion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negocio de";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridPreparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridEntregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridPreparacion;
        private System.Windows.Forms.Label lblPreparacion;
        private System.Windows.Forms.DataGridView dtaGridEntregados;
        private System.Windows.Forms.Label lblEntregados;
        private System.Windows.Forms.Button btnAgregar;
    }
}