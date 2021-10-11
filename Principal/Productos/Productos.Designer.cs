
namespace Principal
{
    partial class frmProductosBase
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.lblCategoriaAnimal = new System.Windows.Forms.Label();
            this.cmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaAnimal = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(777, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "$";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 40);
            this.btnVolver.TabIndex = 40;
            this.btnVolver.Text = "<-   Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadProductos.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCantidadProductos.Location = new System.Drawing.Point(647, 310);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(53, 33);
            this.lblCantidadProductos.TabIndex = 39;
            this.lblCantidadProductos.Text = "0/3";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(776, 373);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(53, 15);
            this.lblcantidad.TabIndex = 38;
            this.lblcantidad.Text = "cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcantidad.Location = new System.Drawing.Point(776, 402);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.PlaceholderText = "Cantidad";
            this.txtcantidad.ReadOnly = true;
            this.txtcantidad.Size = new System.Drawing.Size(121, 30);
            this.txtcantidad.TabIndex = 37;
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Location = new System.Drawing.Point(1002, 512);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(110, 15);
            this.lblCategoriaProducto.TabIndex = 36;
            this.lblCategoriaProducto.Text = "Categoría Producto";
            // 
            // lblCategoriaAnimal
            // 
            this.lblCategoriaAnimal.AutoSize = true;
            this.lblCategoriaAnimal.Location = new System.Drawing.Point(776, 511);
            this.lblCategoriaAnimal.Name = "lblCategoriaAnimal";
            this.lblCategoriaAnimal.Size = new System.Drawing.Size(99, 15);
            this.lblCategoriaAnimal.TabIndex = 35;
            this.lblCategoriaAnimal.Text = "Categoría Animal";
            // 
            // cmbCategoriaProducto
            // 
            this.cmbCategoriaProducto.BackColor = System.Drawing.Color.White;
            this.cmbCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaProducto.Enabled = false;
            this.cmbCategoriaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoriaProducto.FormattingEnabled = true;
            this.cmbCategoriaProducto.Location = new System.Drawing.Point(1002, 537);
            this.cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            this.cmbCategoriaProducto.Size = new System.Drawing.Size(147, 23);
            this.cmbCategoriaProducto.TabIndex = 34;
            // 
            // cmbCategoriaAnimal
            // 
            this.cmbCategoriaAnimal.BackColor = System.Drawing.Color.White;
            this.cmbCategoriaAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaAnimal.Enabled = false;
            this.cmbCategoriaAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoriaAnimal.FormattingEnabled = true;
            this.cmbCategoriaAnimal.Location = new System.Drawing.Point(776, 539);
            this.cmbCategoriaAnimal.Name = "cmbCategoriaAnimal";
            this.cmbCategoriaAnimal.Size = new System.Drawing.Size(121, 23);
            this.cmbCategoriaAnimal.TabIndex = 33;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(211, 328);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(1002, 373);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 31;
            this.lblMarca.Text = "Marca";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(776, 237);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 30;
            this.lblPrecio.Text = "Precio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(211, 207);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(211, 356);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.ReadOnly = true;
            this.rtxtDescripcion.Size = new System.Drawing.Size(489, 206);
            this.rtxtDescripcion.TabIndex = 28;
            this.rtxtDescripcion.Text = "";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.White;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMarca.Location = new System.Drawing.Point(1002, 402);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PlaceholderText = "Marca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(147, 30);
            this.txtMarca.TabIndex = 27;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(798, 265);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(159, 30);
            this.txtPrecio.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(211, 249);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(489, 43);
            this.txtNombre.TabIndex = 25;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(1002, 237);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(32, 15);
            this.lblPeso.TabIndex = 42;
            this.lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.White;
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPeso.Location = new System.Drawing.Point(1002, 265);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PlaceholderText = "Peso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(147, 30);
            this.txtPeso.TabIndex = 43;
            // 
            // frmProductosBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblCantidadProductos);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblCategoriaProducto);
            this.Controls.Add(this.lblCategoriaAnimal);
            this.Controls.Add(this.cmbCategoriaProducto);
            this.Controls.Add(this.cmbCategoriaAnimal);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductosBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button btnVolver;
        protected System.Windows.Forms.Label lblCantidadProductos;
        protected System.Windows.Forms.Label lblcantidad;
        protected System.Windows.Forms.TextBox txtcantidad;
        protected System.Windows.Forms.Label lblCategoriaProducto;
        protected System.Windows.Forms.Label lblCategoriaAnimal;
        protected System.Windows.Forms.ComboBox cmbCategoriaProducto;
        protected System.Windows.Forms.ComboBox cmbCategoriaAnimal;
        protected System.Windows.Forms.Label lblDescripcion;
        protected System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.Label lblPrecio;
        protected System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.RichTextBox rtxtDescripcion;
        protected System.Windows.Forms.TextBox txtMarca;
        protected System.Windows.Forms.TextBox txtPrecio;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.Label lblPeso;
        protected System.Windows.Forms.TextBox txtPeso;
    }
}