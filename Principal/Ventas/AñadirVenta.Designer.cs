
namespace Principal
{
    partial class frmAniadirVenta
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
            this.lblCantidadDeUnidades = new System.Windows.Forms.Label();
            this.lblFechaDeVenta = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dateFechaDeVenta = new System.Windows.Forms.DateTimePicker();
            this.numCantidadDeUnidades = new System.Windows.Forms.NumericUpDown();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.cmbMetodoDePago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadDeUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidadDeUnidades
            // 
            this.lblCantidadDeUnidades.AutoSize = true;
            this.lblCantidadDeUnidades.Location = new System.Drawing.Point(333, 213);
            this.lblCantidadDeUnidades.Name = "lblCantidadDeUnidades";
            this.lblCantidadDeUnidades.Size = new System.Drawing.Size(122, 15);
            this.lblCantidadDeUnidades.TabIndex = 60;
            this.lblCantidadDeUnidades.Text = "Cantidad de unidades";
            // 
            // lblFechaDeVenta
            // 
            this.lblFechaDeVenta.AutoSize = true;
            this.lblFechaDeVenta.Location = new System.Drawing.Point(174, 213);
            this.lblFechaDeVenta.Name = "lblFechaDeVenta";
            this.lblFechaDeVenta.Size = new System.Drawing.Size(86, 15);
            this.lblFechaDeVenta.TabIndex = 57;
            this.lblFechaDeVenta.Text = "Fecha de venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(706, 342);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 49;
            this.lblCliente.Text = "Cliente";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(42, 342);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(56, 15);
            this.lblProducto.TabIndex = 48;
            this.lblProducto.Text = "Producto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Azure;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(695, 631);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(191, 58);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Azure;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(475, 631);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(191, 58);
            this.btnAceptar.TabIndex = 62;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dateFechaDeVenta
            // 
            this.dateFechaDeVenta.CalendarFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaDeVenta.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateFechaDeVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaDeVenta.Location = new System.Drawing.Point(174, 237);
            this.dateFechaDeVenta.MaxDate = new System.DateTime(2025, 10, 11, 0, 0, 0, 0);
            this.dateFechaDeVenta.Name = "dateFechaDeVenta";
            this.dateFechaDeVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateFechaDeVenta.Size = new System.Drawing.Size(129, 33);
            this.dateFechaDeVenta.TabIndex = 64;
            this.dateFechaDeVenta.Value = new System.DateTime(2021, 10, 11, 0, 0, 0, 0);
            // 
            // numCantidadDeUnidades
            // 
            this.numCantidadDeUnidades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numCantidadDeUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCantidadDeUnidades.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numCantidadDeUnidades.Location = new System.Drawing.Point(333, 237);
            this.numCantidadDeUnidades.Name = "numCantidadDeUnidades";
            this.numCantidadDeUnidades.Size = new System.Drawing.Size(322, 33);
            this.numCantidadDeUnidades.TabIndex = 65;
            this.numCantidadDeUnidades.ValueChanged += new System.EventHandler(this.numCantidadDeUnidades_ValueChanged);
            // 
            // lstProductos
            // 
            this.lstProductos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProductos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.HorizontalScrollbar = true;
            this.lstProductos.ItemHeight = 18;
            this.lstProductos.Location = new System.Drawing.Point(42, 372);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(613, 216);
            this.lstProductos.Sorted = true;
            this.lstProductos.TabIndex = 66;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // lstClientes
            // 
            this.lstClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstClientes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.HorizontalScrollbar = true;
            this.lstClientes.ItemHeight = 18;
            this.lstClientes.Location = new System.Drawing.Point(706, 372);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(613, 216);
            this.lstClientes.Sorted = true;
            this.lstClientes.TabIndex = 67;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(322, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(486, 78);
            this.lblTitulo.TabIndex = 68;
            this.lblTitulo.Text = "Añadir una venta";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSubTitulo.Location = new System.Drawing.Point(330, 112);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(446, 23);
            this.lblSubTitulo.TabIndex = 69;
            this.lblSubTitulo.Text = "Seleccione un producto y un cliente para realizar la venta.";
            // 
            // cmbMetodoDePago
            // 
            this.cmbMetodoDePago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMetodoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoDePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMetodoDePago.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMetodoDePago.FormattingEnabled = true;
            this.cmbMetodoDePago.Location = new System.Drawing.Point(706, 236);
            this.cmbMetodoDePago.Name = "cmbMetodoDePago";
            this.cmbMetodoDePago.Size = new System.Drawing.Size(461, 34);
            this.cmbMetodoDePago.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(706, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Método de pago";
            // 
            // frmAniadirVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMetodoDePago);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.numCantidadDeUnidades);
            this.Controls.Add(this.dateFechaDeVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblCantidadDeUnidades);
            this.Controls.Add(this.lblFechaDeVenta);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAniadirVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirVenta";
            this.Load += new System.EventHandler(this.frmAñadirVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidadDeUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblCantidadDeUnidades;
        protected System.Windows.Forms.Label lblFechaDeVenta;
        protected System.Windows.Forms.Label lblCliente;
        protected System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dateFechaDeVenta;
        private System.Windows.Forms.NumericUpDown numCantidadDeUnidades;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.ComboBox cmbMetodoDePago;
        protected System.Windows.Forms.Label label1;
    }
}