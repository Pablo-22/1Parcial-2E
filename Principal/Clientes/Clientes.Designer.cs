
namespace Principal
{
    partial class frmClientesBase
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(285, 185);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(285, 393);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(36, 15);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial.Location = new System.Drawing.Point(722, 282);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(116, 15);
            this.lblHistorial.TabIndex = 2;
            this.lblHistorial.Text = "Historial de compras";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistancia.Location = new System.Drawing.Point(285, 525);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(177, 15);
            this.lblDistancia.TabIndex = 3;
            this.lblDistancia.Text = "Distancia desde nuestra sucursal";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(285, 297);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroCliente.Location = new System.Drawing.Point(722, 185);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(105, 15);
            this.lblNumeroCliente.TabIndex = 5;
            this.lblNumeroCliente.Text = "Número de cliente";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.White;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldo.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaldo.Location = new System.Drawing.Point(285, 411);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.PlaceholderText = "Saldo";
            this.txtSaldo.Size = new System.Drawing.Size(394, 59);
            this.txtSaldo.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(285, 315);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(394, 36);
            this.txtEmail.TabIndex = 8;
            // 
            // txtDistancia
            // 
            this.txtDistancia.BackColor = System.Drawing.Color.White;
            this.txtDistancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistancia.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDistancia.Location = new System.Drawing.Point(285, 543);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.PlaceholderText = "Distancia";
            this.txtDistancia.ReadOnly = true;
            this.txtDistancia.Size = new System.Drawing.Size(394, 40);
            this.txtDistancia.TabIndex = 9;
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.BackColor = System.Drawing.Color.White;
            this.txtNumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroCliente.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroCliente.Location = new System.Drawing.Point(722, 203);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.PlaceholderText = "Número";
            this.txtNumeroCliente.ReadOnly = true;
            this.txtNumeroCliente.Size = new System.Drawing.Size(353, 40);
            this.txtNumeroCliente.TabIndex = 10;
            // 
            // lstHistorial
            // 
            this.lstHistorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 23;
            this.lstHistorial.Location = new System.Drawing.Point(722, 307);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(353, 276);
            this.lstHistorial.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(285, 203);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(328, 59);
            this.txtNombre.TabIndex = 13;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 40);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "<-   Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmClientesBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 749);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblNumeroCliente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClientesBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientesBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblNombre;
        protected System.Windows.Forms.Label lblSaldo;
        protected System.Windows.Forms.Label lblHistorial;
        protected System.Windows.Forms.Label lblDistancia;
        protected System.Windows.Forms.Label lblEmail;
        protected System.Windows.Forms.Label lblNumeroCliente;
        protected System.Windows.Forms.TextBox txtSaldo;
        protected System.Windows.Forms.TextBox txtEmail;
        protected System.Windows.Forms.TextBox txtDistancia;
        protected System.Windows.Forms.ListBox lstHistorial;
        protected System.Windows.Forms.TextBox txtNumeroCliente;
        protected System.Windows.Forms.TextBox txtNombre;
        protected System.Windows.Forms.Button btnVolver;
    }
}