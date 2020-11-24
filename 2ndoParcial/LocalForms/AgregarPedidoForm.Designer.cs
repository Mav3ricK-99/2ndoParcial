namespace LocalForms
{
    partial class AgregarPedidoForm
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.cmboBoxOpcionPedido = new System.Windows.Forms.ComboBox();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblDemora = new System.Windows.Forms.Label();
            this.chckBoxDelivery = new System.Windows.Forms.CheckBox();
            this.txtBoxInfoDelivery = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNumero.Location = new System.Drawing.Point(12, 16);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(249, 22);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "El siguiente pedido sera el N°";
            // 
            // cmboBoxOpcionPedido
            // 
            this.cmboBoxOpcionPedido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmboBoxOpcionPedido.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBoxOpcionPedido.FormattingEnabled = true;
            this.cmboBoxOpcionPedido.Location = new System.Drawing.Point(16, 86);
            this.cmboBoxOpcionPedido.Name = "cmboBoxOpcionPedido";
            this.cmboBoxOpcionPedido.Size = new System.Drawing.Size(272, 25);
            this.cmboBoxOpcionPedido.Sorted = true;
            this.cmboBoxOpcionPedido.TabIndex = 2;
            this.cmboBoxOpcionPedido.SelectedIndexChanged += new System.EventHandler(this.cmboBoxOpcionPedido_SelectedIndexChanged);
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpcion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblOpcion.Location = new System.Drawing.Point(12, 64);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(126, 19);
            this.lblOpcion.TabIndex = 1;
            this.lblOpcion.Text = "Ingrese el Pedido";
            // 
            // lblDemora
            // 
            this.lblDemora.AutoSize = true;
            this.lblDemora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDemora.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemora.ForeColor = System.Drawing.Color.Black;
            this.lblDemora.Location = new System.Drawing.Point(13, 126);
            this.lblDemora.Name = "lblDemora";
            this.lblDemora.Size = new System.Drawing.Size(135, 17);
            this.lblDemora.TabIndex = 3;
            this.lblDemora.Text = "Demora del Pedido - ";
            // 
            // chckBoxDelivery
            // 
            this.chckBoxDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chckBoxDelivery.AutoSize = true;
            this.chckBoxDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chckBoxDelivery.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBoxDelivery.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chckBoxDelivery.Location = new System.Drawing.Point(16, 172);
            this.chckBoxDelivery.Name = "chckBoxDelivery";
            this.chckBoxDelivery.Padding = new System.Windows.Forms.Padding(1);
            this.chckBoxDelivery.Size = new System.Drawing.Size(125, 25);
            this.chckBoxDelivery.TabIndex = 4;
            this.chckBoxDelivery.Text = "Para delivery";
            this.chckBoxDelivery.UseVisualStyleBackColor = true;
            this.chckBoxDelivery.CheckStateChanged += new System.EventHandler(this.chckBoxDelivery_CheckStateChanged);
            // 
            // txtBoxInfoDelivery
            // 
            this.txtBoxInfoDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxInfoDelivery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxInfoDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxInfoDelivery.Enabled = false;
            this.txtBoxInfoDelivery.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInfoDelivery.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxInfoDelivery.Location = new System.Drawing.Point(16, 219);
            this.txtBoxInfoDelivery.MaxLength = 200;
            this.txtBoxInfoDelivery.Multiline = true;
            this.txtBoxInfoDelivery.Name = "txtBoxInfoDelivery";
            this.txtBoxInfoDelivery.Size = new System.Drawing.Size(272, 66);
            this.txtBoxInfoDelivery.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.Location = new System.Drawing.Point(90, 356);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 43);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            this.btnAgregar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseDown);
            this.btnAgregar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseUp);
            // 
            // AgregarPedidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(318, 416);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBoxInfoDelivery);
            this.Controls.Add(this.chckBoxDelivery);
            this.Controls.Add(this.lblDemora);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.cmboBoxOpcionPedido);
            this.Controls.Add(this.lblNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarPedidoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Pedido";
            this.Load += new System.EventHandler(this.AgregarPedidoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmboBoxOpcionPedido;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblDemora;
        private System.Windows.Forms.CheckBox chckBoxDelivery;
        private System.Windows.Forms.TextBox txtBoxInfoDelivery;
        private System.Windows.Forms.Button btnAgregar;
    }
}