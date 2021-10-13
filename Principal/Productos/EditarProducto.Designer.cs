
namespace Principal
{
    partial class frmEditarProducto
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
            this.btnAceptarEdicion = new System.Windows.Forms.Button();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(799, 250);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.Location = new System.Drawing.Point(639, 290);
            // 
            // lblcantidad
            // 
            this.lblcantidad.Location = new System.Drawing.Point(798, 353);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(798, 382);
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.Location = new System.Drawing.Point(994, 492);
            // 
            // lblCategoriaAnimal
            // 
            this.lblCategoriaAnimal.Location = new System.Drawing.Point(798, 491);
            // 
            // cmbCategoriaProducto
            // 
            this.cmbCategoriaProducto.Location = new System.Drawing.Point(994, 517);
            // 
            // cmbCategoriaAnimal
            // 
            this.cmbCategoriaAnimal.Location = new System.Drawing.Point(798, 519);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(203, 308);
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(994, 353);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(798, 217);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(203, 187);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(203, 336);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(994, 382);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(820, 245);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(203, 229);
            // 
            // lblPeso
            // 
            this.lblPeso.Location = new System.Drawing.Point(1002, 234);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(1002, 262);
            // 
            // btnAceptarEdicion
            // 
            this.btnAceptarEdicion.BackColor = System.Drawing.Color.LightCyan;
            this.btnAceptarEdicion.FlatAppearance.BorderSize = 0;
            this.btnAceptarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarEdicion.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarEdicion.Location = new System.Drawing.Point(476, 604);
            this.btnAceptarEdicion.Name = "btnAceptarEdicion";
            this.btnAceptarEdicion.Size = new System.Drawing.Size(174, 40);
            this.btnAceptarEdicion.TabIndex = 25;
            this.btnAceptarEdicion.Text = "Aceptar";
            this.btnAceptarEdicion.UseVisualStyleBackColor = false;
            this.btnAceptarEdicion.Click += new System.EventHandler(this.btnAceptarEdicion_Click);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.BackColor = System.Drawing.Color.LightCyan;
            this.btnCancelarEdicion.FlatAppearance.BorderSize = 0;
            this.btnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdicion.Font = new System.Drawing.Font("Calibri Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarEdicion.Location = new System.Drawing.Point(709, 604);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(174, 40);
            this.btnCancelarEdicion.TabIndex = 26;
            this.btnCancelarEdicion.Text = "Cancelar";
            this.btnCancelarEdicion.UseVisualStyleBackColor = false;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSubTitulo.Location = new System.Drawing.Point(212, 121);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(598, 23);
            this.lblSubTitulo.TabIndex = 71;
            this.lblSubTitulo.Text = "Modifique los datos que desee y presione aceptar para modificar el producto.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(203, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(443, 78);
            this.lblTitulo.TabIndex = 70;
            this.lblTitulo.Text = "Editar producto";
            // 
            // frmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.btnAceptarEdicion);
            this.Name = "frmEditarProducto";
            this.Text = "EditarProducto";
            this.Load += new System.EventHandler(this.frmEditarProducto_Load);
            this.Controls.SetChildIndex(this.lblPeso, 0);
            this.Controls.SetChildIndex(this.txtPeso, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.rtxtDescripcion, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblPrecio, 0);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.cmbCategoriaAnimal, 0);
            this.Controls.SetChildIndex(this.cmbCategoriaProducto, 0);
            this.Controls.SetChildIndex(this.lblCategoriaAnimal, 0);
            this.Controls.SetChildIndex(this.lblCategoriaProducto, 0);
            this.Controls.SetChildIndex(this.txtcantidad, 0);
            this.Controls.SetChildIndex(this.lblcantidad, 0);
            this.Controls.SetChildIndex(this.lblCantidadProductos, 0);
            this.Controls.SetChildIndex(this.btnVolver, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAceptarEdicion, 0);
            this.Controls.SetChildIndex(this.btnCancelarEdicion, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.lblSubTitulo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarEdicion;
        private System.Windows.Forms.Button btnCancelarEdicion;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
    }
}