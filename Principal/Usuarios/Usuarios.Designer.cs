
namespace Principal
{
    partial class frmUsuariosBase
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
            this.btnExportarTicket = new System.Windows.Forms.Button();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExportarTicket
            // 
            this.btnExportarTicket.FlatAppearance.BorderSize = 0;
            this.btnExportarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarTicket.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportarTicket.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnExportarTicket.Location = new System.Drawing.Point(677, 178);
            this.btnExportarTicket.Name = "btnExportarTicket";
            this.btnExportarTicket.Size = new System.Drawing.Size(210, 65);
            this.btnExportarTicket.TabIndex = 79;
            this.btnExportarTicket.Text = "Exportar lista de usuarios";
            this.btnExportarTicket.UseVisualStyleBackColor = true;
            this.btnExportarTicket.Click += new System.EventHandler(this.btnExportarTicket_Click);
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSubTitulo.Location = new System.Drawing.Point(61, 196);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(557, 23);
            this.lblSubTitulo.TabIndex = 78;
            this.lblSubTitulo.Text = "Puede visualizar todos los usuarios, eliminarlos o editar sus credenciales.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTitulo.Location = new System.Drawing.Point(52, 118);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(266, 78);
            this.lblTitulo.TabIndex = 77;
            this.lblTitulo.Text = "Usuarios";
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(26, 26);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(127, 40);
            this.btnVolver.TabIndex = 76;
            this.btnVolver.Text = "<-   Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsuarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.ItemHeight = 19;
            this.lstUsuarios.Location = new System.Drawing.Point(52, 249);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(1283, 494);
            this.lstUsuarios.TabIndex = 73;
            // 
            // frmUsuariosBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.btnExportarTicket);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lstUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuariosBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuariosBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportarTicket;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        protected System.Windows.Forms.Button btnVolver;
        protected System.Windows.Forms.ListBox lstUsuarios;
    }
}