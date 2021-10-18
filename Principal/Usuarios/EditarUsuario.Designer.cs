
namespace Principal
{
    partial class frmEditarUsuario
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblMensajeDeError = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbNivelDeAcceso = new System.Windows.Forms.ComboBox();
            this.lblNivelDeAcceso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Calibri", 41.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblBienvenido.Location = new System.Drawing.Point(506, 112);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(349, 67);
            this.lblBienvenido.TabIndex = 17;
            this.lblBienvenido.Text = "Editar usuario";
            // 
            // lblMensajeDeError
            // 
            this.lblMensajeDeError.AutoSize = true;
            this.lblMensajeDeError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeDeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeDeError.Location = new System.Drawing.Point(556, 400);
            this.lblMensajeDeError.Name = "lblMensajeDeError";
            this.lblMensajeDeError.Size = new System.Drawing.Size(0, 15);
            this.lblMensajeDeError.TabIndex = 15;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContrasenia.Location = new System.Drawing.Point(556, 323);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(250, 23);
            this.lblContrasenia.TabIndex = 14;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDeUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(556, 243);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(250, 23);
            this.lblNombreDeUsuario.TabIndex = 13;
            this.lblNombreDeUsuario.Text = "Nombre de usuario";
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(556, 269);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(250, 39);
            this.txtNombreDeUsuario.TabIndex = 12;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContrasenia.Location = new System.Drawing.Point(556, 349);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(250, 39);
            this.txtContrasenia.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(556, 607);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(250, 49);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(556, 552);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(250, 49);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbNivelDeAcceso
            // 
            this.cmbNivelDeAcceso.BackColor = System.Drawing.Color.White;
            this.cmbNivelDeAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelDeAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNivelDeAcceso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbNivelDeAcceso.FormattingEnabled = true;
            this.cmbNivelDeAcceso.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.cmbNivelDeAcceso.Location = new System.Drawing.Point(556, 442);
            this.cmbNivelDeAcceso.Name = "cmbNivelDeAcceso";
            this.cmbNivelDeAcceso.Size = new System.Drawing.Size(250, 40);
            this.cmbNivelDeAcceso.TabIndex = 18;
            // 
            // lblNivelDeAcceso
            // 
            this.lblNivelDeAcceso.BackColor = System.Drawing.Color.Transparent;
            this.lblNivelDeAcceso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNivelDeAcceso.Location = new System.Drawing.Point(556, 415);
            this.lblNivelDeAcceso.Name = "lblNivelDeAcceso";
            this.lblNivelDeAcceso.Size = new System.Drawing.Size(250, 23);
            this.lblNivelDeAcceso.TabIndex = 19;
            this.lblNivelDeAcceso.Text = "Nivel de acceso";
            // 
            // frmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.lblNivelDeAcceso);
            this.Controls.Add(this.cmbNivelDeAcceso);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblMensajeDeError);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.frmEditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblMensajeDeError;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.TextBox txtNombreDeUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbNivelDeAcceso;
        private System.Windows.Forms.Label lblNivelDeAcceso;
    }
}