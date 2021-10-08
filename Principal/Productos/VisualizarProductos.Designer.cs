
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
            this.btnVender1 = new System.Windows.Forms.Button();
            this.btnEditar1 = new System.Windows.Forms.Button();
            this.btnAniadir1 = new System.Windows.Forms.Button();
            this.btnAnterior1 = new System.Windows.Forms.Button();
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            // 
            // btnVender1
            // 
            this.btnVender1.Location = new System.Drawing.Point(387, 87);
            this.btnVender1.Name = "btnVender1";
            this.btnVender1.Size = new System.Drawing.Size(126, 37);
            this.btnVender1.TabIndex = 25;
            this.btnVender1.Text = "Vender";
            this.btnVender1.UseVisualStyleBackColor = true;
            this.btnVender1.Click += new System.EventHandler(this.btnVender1_Click);
            // 
            // btnEditar1
            // 
            this.btnEditar1.Location = new System.Drawing.Point(574, 87);
            this.btnEditar1.Name = "btnEditar1";
            this.btnEditar1.Size = new System.Drawing.Size(126, 37);
            this.btnEditar1.TabIndex = 26;
            this.btnEditar1.Text = "Editar";
            this.btnEditar1.UseVisualStyleBackColor = true;
            this.btnEditar1.Click += new System.EventHandler(this.btnEditar1_Click);
            // 
            // btnAniadir1
            // 
            this.btnAniadir1.Location = new System.Drawing.Point(765, 87);
            this.btnAniadir1.Name = "btnAniadir1";
            this.btnAniadir1.Size = new System.Drawing.Size(126, 37);
            this.btnAniadir1.TabIndex = 27;
            this.btnAniadir1.Text = "Añadir";
            this.btnAniadir1.UseVisualStyleBackColor = true;
            this.btnAniadir1.Click += new System.EventHandler(this.btnAniadir1_Click);
            // 
            // btnAnterior1
            // 
            this.btnAnterior1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnterior1.Location = new System.Drawing.Point(41, 385);
            this.btnAnterior1.Name = "btnAnterior1";
            this.btnAnterior1.Size = new System.Drawing.Size(53, 82);
            this.btnAnterior1.TabIndex = 28;
            this.btnAnterior1.Text = "<";
            this.btnAnterior1.UseVisualStyleBackColor = true;
            this.btnAnterior1.Click += new System.EventHandler(this.btnAnterior1_Click);
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente1.Location = new System.Drawing.Point(1271, 385);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(53, 82);
            this.btnSiguiente1.TabIndex = 29;
            this.btnSiguiente1.Text = ">";
            this.btnSiguiente1.UseVisualStyleBackColor = true;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente1_Click);
            // 
            // frmVisualizarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.btnSiguiente1);
            this.Controls.Add(this.btnAnterior1);
            this.Controls.Add(this.btnAniadir1);
            this.Controls.Add(this.btnEditar1);
            this.Controls.Add(this.btnVender1);
            this.Name = "frmVisualizarProductos";
            this.Text = "VisualizarProductos";
            this.Load += new System.EventHandler(this.VisualizarProductos_Load);
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
            this.Controls.SetChildIndex(this.txtStock, 0);
            this.Controls.SetChildIndex(this.lblStock, 0);
            this.Controls.SetChildIndex(this.lblCantidadProductos, 0);
            this.Controls.SetChildIndex(this.btnVolver, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnVender1, 0);
            this.Controls.SetChildIndex(this.btnEditar1, 0);
            this.Controls.SetChildIndex(this.btnAniadir1, 0);
            this.Controls.SetChildIndex(this.btnAnterior1, 0);
            this.Controls.SetChildIndex(this.btnSiguiente1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVender1;
        private System.Windows.Forms.Button btnEditar1;
        private System.Windows.Forms.Button btnAniadir1;
        private System.Windows.Forms.Button btnAnterior1;
        private System.Windows.Forms.Button btnSiguiente1;
    }
}