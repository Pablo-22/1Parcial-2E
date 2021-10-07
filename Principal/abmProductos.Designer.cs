
namespace Principal
{
    partial class frmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbCategoriaAnimal = new System.Windows.Forms.ComboBox();
            this.cmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.lblCategoriaAnimal = new System.Windows.Forms.Label();
            this.lblCategoriaProducto = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAniadirProducto = new System.Windows.Forms.Button();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            this.btnAutocompletarProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(187, 187);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(489, 43);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecio.Location = new System.Drawing.Point(804, 203);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(159, 28);
            this.txtPrecio.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.White;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMarca.Location = new System.Drawing.Point(978, 340);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.PlaceholderText = "Marca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(147, 28);
            this.txtMarca.TabIndex = 2;
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(187, 294);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.ReadOnly = true;
            this.rtxtDescripcion.Size = new System.Drawing.Size(489, 206);
            this.rtxtDescripcion.TabIndex = 3;
            this.rtxtDescripcion.Text = "";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(187, 145);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(782, 175);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(978, 311);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(187, 266);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripción";
            // 
            // cmbCategoriaAnimal
            // 
            this.cmbCategoriaAnimal.BackColor = System.Drawing.Color.White;
            this.cmbCategoriaAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaAnimal.Enabled = false;
            this.cmbCategoriaAnimal.FormattingEnabled = true;
            this.cmbCategoriaAnimal.Location = new System.Drawing.Point(782, 477);
            this.cmbCategoriaAnimal.Name = "cmbCategoriaAnimal";
            this.cmbCategoriaAnimal.Size = new System.Drawing.Size(121, 23);
            this.cmbCategoriaAnimal.TabIndex = 8;
            // 
            // cmbCategoriaProducto
            // 
            this.cmbCategoriaProducto.BackColor = System.Drawing.Color.White;
            this.cmbCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaProducto.Enabled = false;
            this.cmbCategoriaProducto.FormattingEnabled = true;
            this.cmbCategoriaProducto.Location = new System.Drawing.Point(978, 475);
            this.cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            this.cmbCategoriaProducto.Size = new System.Drawing.Size(147, 23);
            this.cmbCategoriaProducto.TabIndex = 9;
            // 
            // lblCategoriaAnimal
            // 
            this.lblCategoriaAnimal.AutoSize = true;
            this.lblCategoriaAnimal.Location = new System.Drawing.Point(782, 449);
            this.lblCategoriaAnimal.Name = "lblCategoriaAnimal";
            this.lblCategoriaAnimal.Size = new System.Drawing.Size(99, 15);
            this.lblCategoriaAnimal.TabIndex = 10;
            this.lblCategoriaAnimal.Text = "Categoría Animal";
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.AutoSize = true;
            this.lblCategoriaProducto.Location = new System.Drawing.Point(978, 450);
            this.lblCategoriaProducto.Name = "lblCategoriaProducto";
            this.lblCategoriaProducto.Size = new System.Drawing.Size(110, 15);
            this.lblCategoriaProducto.TabIndex = 11;
            this.lblCategoriaProducto.Text = "Categoría Producto";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.Location = new System.Drawing.Point(1235, 365);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(38, 65);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnterior.Location = new System.Drawing.Point(39, 365);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(38, 65);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.Color.White;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStock.Location = new System.Drawing.Point(782, 340);
            this.txtStock.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "Stock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(121, 28);
            this.txtStock.TabIndex = 14;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(782, 311);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(36, 15);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "Stock";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.White;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.Location = new System.Drawing.Point(406, 62);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(126, 43);
            this.btnVender.TabIndex = 16;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.Location = new System.Drawing.Point(605, 62);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(126, 43);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAniadirProducto
            // 
            this.btnAniadirProducto.BackColor = System.Drawing.Color.White;
            this.btnAniadirProducto.FlatAppearance.BorderSize = 0;
            this.btnAniadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadirProducto.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAniadirProducto.Location = new System.Drawing.Point(804, 62);
            this.btnAniadirProducto.Name = "btnAniadirProducto";
            this.btnAniadirProducto.Size = new System.Drawing.Size(126, 43);
            this.btnAniadirProducto.TabIndex = 18;
            this.btnAniadirProducto.Text = "Añadir producto";
            this.btnAniadirProducto.UseVisualStyleBackColor = false;
            this.btnAniadirProducto.Click += new System.EventHandler(this.btnAniadirProducto_Click);
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadProductos.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCantidadProductos.Location = new System.Drawing.Point(1072, 197);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(53, 33);
            this.lblCantidadProductos.TabIndex = 19;
            this.lblCantidadProductos.Text = "0/3";
            // 
            // btnAutocompletarProducto
            // 
            this.btnAutocompletarProducto.BackColor = System.Drawing.Color.White;
            this.btnAutocompletarProducto.FlatAppearance.BorderSize = 0;
            this.btnAutocompletarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutocompletarProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAutocompletarProducto.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAutocompletarProducto.Location = new System.Drawing.Point(187, 506);
            this.btnAutocompletarProducto.Name = "btnAutocompletarProducto";
            this.btnAutocompletarProducto.Size = new System.Drawing.Size(123, 33);
            this.btnAutocompletarProducto.TabIndex = 20;
            this.btnAutocompletarProducto.Text = "Autocompletar";
            this.btnAutocompletarProducto.UseVisualStyleBackColor = false;
            this.btnAutocompletarProducto.Visible = false;
            this.btnAutocompletarProducto.Click += new System.EventHandler(this.btnAutocompletarProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Azure;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(471, 570);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(167, 47);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Azure;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(711, 570);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(167, 47);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 40);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "<-   Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(783, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "$";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAutocompletarProducto);
            this.Controls.Add(this.lblCantidadProductos);
            this.Controls.Add(this.btnAniadirProducto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
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
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.TextBox txtPrecio;
        protected System.Windows.Forms.TextBox txtMarca;
        protected System.Windows.Forms.RichTextBox rtxtDescripcion;
        protected System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.Label lblPrecio;
        protected System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.Label lblDescripcion;
        protected System.Windows.Forms.ComboBox cmbCategoriaAnimal;
        protected System.Windows.Forms.ComboBox cmbCategoriaProducto;
        protected System.Windows.Forms.Label lblCategoriaAnimal;
        protected System.Windows.Forms.Label lblCategoriaProducto;
        protected System.Windows.Forms.Button btnSiguiente;
        protected System.Windows.Forms.Button btnAnterior;
        protected System.Windows.Forms.TextBox txtStock;
        protected System.Windows.Forms.Label lblStock;
        protected System.Windows.Forms.Button btnVender;
        protected System.Windows.Forms.Button btnEditar;
        protected System.Windows.Forms.Button btnAniadirProducto;
        protected System.Windows.Forms.Label lblCantidadProductos;
        protected System.Windows.Forms.Button btnAutocompletarProducto;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnVolver;
        protected System.Windows.Forms.Button btnAceptar;
    }
}

