
namespace Principal
{
    partial class frmUsuarios_VistaDeEmpleado
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
            this.btnCambiarContrasenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            // 
            // btnCambiarContrasenia
            // 
            this.btnCambiarContrasenia.FlatAppearance.BorderSize = 0;
            this.btnCambiarContrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContrasenia.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarContrasenia.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnCambiarContrasenia.Location = new System.Drawing.Point(952, 181);
            this.btnCambiarContrasenia.Name = "btnCambiarContrasenia";
            this.btnCambiarContrasenia.Size = new System.Drawing.Size(383, 53);
            this.btnCambiarContrasenia.TabIndex = 80;
            this.btnCambiarContrasenia.Text = "Cambiar mi contraseña";
            this.btnCambiarContrasenia.UseVisualStyleBackColor = true;
            this.btnCambiarContrasenia.Click += new System.EventHandler(this.btnCambiarContrasenia_Click);
            // 
            // frmUsuarios_VistaDeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.btnCambiarContrasenia);
            this.Name = "frmUsuarios_VistaDeEmpleado";
            this.Text = "Usuarios_VistaDeEmpleado";
            this.Load += new System.EventHandler(this.frmUsuarios_VistaDeEmpleado_Load);
            this.Controls.SetChildIndex(this.lstUsuarios, 0);
            this.Controls.SetChildIndex(this.btnVolver, 0);
            this.Controls.SetChildIndex(this.btnCambiarContrasenia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCambiarContrasenia;
    }
}