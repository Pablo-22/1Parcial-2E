
namespace Principal
{
    partial class frmLogin
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
            this.btnAcceder = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreDeUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblMensajeDeError = new System.Windows.Forms.Label();
            this.btnAutocompletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcceder
            // 
            this.btnAcceder.Location = new System.Drawing.Point(92, 312);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(250, 49);
            this.btnAcceder.TabIndex = 0;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(92, 367);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(250, 49);
            this.btnRegistrarse.TabIndex = 1;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContrasenia.Location = new System.Drawing.Point(92, 202);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(250, 39);
            this.txtContrasenia.TabIndex = 2;
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(92, 122);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(250, 39);
            this.txtNombreDeUsuario.TabIndex = 3;
            // 
            // lblNombreDeUsuario
            // 
            this.lblNombreDeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDeUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreDeUsuario.Location = new System.Drawing.Point(92, 96);
            this.lblNombreDeUsuario.Name = "lblNombreDeUsuario";
            this.lblNombreDeUsuario.Size = new System.Drawing.Size(250, 23);
            this.lblNombreDeUsuario.TabIndex = 4;
            this.lblNombreDeUsuario.Text = "Nombre de usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContrasenia.Location = new System.Drawing.Point(92, 176);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(250, 23);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblMensajeDeError
            // 
            this.lblMensajeDeError.AutoSize = true;
            this.lblMensajeDeError.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeDeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeDeError.Location = new System.Drawing.Point(92, 253);
            this.lblMensajeDeError.Name = "lblMensajeDeError";
            this.lblMensajeDeError.Size = new System.Drawing.Size(0, 15);
            this.lblMensajeDeError.TabIndex = 6;
            // 
            // btnAutocompletar
            // 
            this.btnAutocompletar.Location = new System.Drawing.Point(293, 12);
            this.btnAutocompletar.Name = "btnAutocompletar";
            this.btnAutocompletar.Size = new System.Drawing.Size(116, 23);
            this.btnAutocompletar.TabIndex = 7;
            this.btnAutocompletar.Text = "Rellenar campos";
            this.btnAutocompletar.UseVisualStyleBackColor = true;
            this.btnAutocompletar.Click += new System.EventHandler(this.btnAutocompletar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 519);
            this.Controls.Add(this.btnAutocompletar);
            this.Controls.Add(this.lblMensajeDeError);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblNombreDeUsuario);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnAcceder);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtNombreDeUsuario;
        private System.Windows.Forms.Label lblNombreDeUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblMensajeDeError;
        private System.Windows.Forms.Button btnAutocompletar;
    }
}