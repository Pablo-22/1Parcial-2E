
namespace Principal
{
    partial class frmVisualizarProductos
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
            this.btnVender = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(777, 270);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.Location = new System.Drawing.Point(647, 310);
            // 
            // lblcantidad
            // 
            this.lblcantidad.Location = new System.Drawing.Point(776, 373);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(776, 402);
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            // 
            // lblCategoriaProducto
            // 
            this.lblCategoriaProducto.Location = new System.Drawing.Point(1002, 511);
            // 
            // lblCategoriaAnimal
            // 
            this.lblCategoriaAnimal.Location = new System.Drawing.Point(776, 511);
            // 
            // cmbCategoriaProducto
            // 
            this.cmbCategoriaProducto.Location = new System.Drawing.Point(1002, 539);
            // 
            // cmbCategoriaAnimal
            // 
            this.cmbCategoriaAnimal.Location = new System.Drawing.Point(777, 539);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(211, 328);
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(1002, 373);
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(776, 237);
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(211, 207);
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(211, 356);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(1002, 402);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(798, 265);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(211, 249);
            // 
            // lblPeso
            // 
            this.lblPeso.Location = new System.Drawing.Point(1002, 237);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(1002, 265);
            // 
            // btnVender
            // 
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnVender.Location = new System.Drawing.Point(400, 87);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(148, 48);
            this.btnVender.TabIndex = 25;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnEditar.Location = new System.Drawing.Point(606, 87);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(148, 48);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // btnAniadir
            // 
            this.btnAniadir.FlatAppearance.BorderSize = 0;
            this.btnAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAniadir.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAniadir.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAniadir.Location = new System.Drawing.Point(812, 87);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(148, 48);
            this.btnAniadir.TabIndex = 27;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir1_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnterior.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnAnterior.Location = new System.Drawing.Point(41, 385);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(53, 98);
            this.btnAnterior.TabIndex = 28;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior1_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSiguiente.Location = new System.Drawing.Point(1271, 385);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(53, 98);
            this.btnSiguiente.TabIndex = 29;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente1_Click);
            // 
            // frmVisualizarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 784);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVender);
            this.Name = "frmVisualizarProductos";
            this.Text = "VisualizarProductos";
            this.Load += new System.EventHandler(this.VisualizarProductos_Load);
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
            this.Controls.SetChildIndex(this.btnVender, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnAniadir, 0);
            this.Controls.SetChildIndex(this.btnAnterior, 0);
            this.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}