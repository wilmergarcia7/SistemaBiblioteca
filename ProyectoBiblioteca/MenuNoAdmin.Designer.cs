
namespace ProyectoBiblioteca
{
    partial class MenuNoAdmin
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
            this.btnLector = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNUsuario = new System.Windows.Forms.Label();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLector
            // 
            this.btnLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLector.Location = new System.Drawing.Point(71, 113);
            this.btnLector.Name = "btnLector";
            this.btnLector.Size = new System.Drawing.Size(177, 44);
            this.btnLector.TabIndex = 5;
            this.btnLector.Text = "Agregar Lector";
            this.btnLector.UseVisualStyleBackColor = true;
            this.btnLector.Click += new System.EventHandler(this.btnLector_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(71, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(167, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Cerrar Sesión";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.Location = new System.Drawing.Point(71, 178);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(177, 40);
            this.btnPrestamo.TabIndex = 6;
            this.btnPrestamo.Text = "Prestamos";
            this.btnPrestamo.UseVisualStyleBackColor = true;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(68, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 17);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "label1";
            this.lblUser.Visible = false;
            // 
            // lblNUsuario
            // 
            this.lblNUsuario.AutoSize = true;
            this.lblNUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUsuario.Location = new System.Drawing.Point(184, 37);
            this.lblNUsuario.Name = "lblNUsuario";
            this.lblNUsuario.Size = new System.Drawing.Size(64, 25);
            this.lblNUsuario.TabIndex = 8;
            this.lblNUsuario.Text = "label1";
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.Location = new System.Drawing.Point(71, 236);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(177, 41);
            this.btnDevoluciones.TabIndex = 9;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario:";
            // 
            // MenuNoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDevoluciones);
            this.Controls.Add(this.lblNUsuario);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.btnLector);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuNoAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuNoAdmin";
            this.Load += new System.EventHandler(this.MenuNoAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLector;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNUsuario;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Label label1;
    }
}