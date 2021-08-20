
namespace ProyectoBiblioteca
{
    partial class FrmPrestamos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLector = new System.Windows.Forms.ComboBox();
            this.dgLibro = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgPrestamo = new System.Windows.Forms.DataGridView();
            this.IDLIBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.lblIdLector = new System.Windows.Forms.Label();
            this.lblIdLibro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 93;
            this.label2.Text = "PRESTAMOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 94;
            this.label1.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(197, 100);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(26, 29);
            this.lblUsuario.TabIndex = 95;
            this.lblUsuario.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 96;
            this.label4.Text = "Lector:";
            // 
            // cmbLector
            // 
            this.cmbLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLector.FormattingEnabled = true;
            this.cmbLector.Location = new System.Drawing.Point(135, 143);
            this.cmbLector.Name = "cmbLector";
            this.cmbLector.Size = new System.Drawing.Size(371, 33);
            this.cmbLector.TabIndex = 98;
            this.cmbLector.SelectedIndexChanged += new System.EventHandler(this.cmbLector_SelectedIndexChanged);
            // 
            // dgLibro
            // 
            this.dgLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLibro.Location = new System.Drawing.Point(48, 296);
            this.dgLibro.Name = "dgLibro";
            this.dgLibro.RowHeadersWidth = 51;
            this.dgLibro.RowTemplate.Height = 24;
            this.dgLibro.Size = new System.Drawing.Size(432, 156);
            this.dgLibro.TabIndex = 99;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 29);
            this.label5.TabIndex = 100;
            this.label5.Text = "Libros Disponibles:";
            // 
            // btnPrestar
            // 
            this.btnPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestar.Location = new System.Drawing.Point(539, 296);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(87, 32);
            this.btnPrestar.TabIndex = 101;
            this.btnPrestar.Text = ">";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(539, 355);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 32);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "<";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgPrestamo
            // 
            this.dgPrestamo.AllowUserToAddRows = false;
            this.dgPrestamo.AllowUserToDeleteRows = false;
            this.dgPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLIBRO,
            this.TITULO});
            this.dgPrestamo.Location = new System.Drawing.Point(678, 296);
            this.dgPrestamo.Name = "dgPrestamo";
            this.dgPrestamo.ReadOnly = true;
            this.dgPrestamo.RowHeadersWidth = 51;
            this.dgPrestamo.RowTemplate.Height = 24;
            this.dgPrestamo.Size = new System.Drawing.Size(308, 156);
            this.dgPrestamo.TabIndex = 103;
            // 
            // IDLIBRO
            // 
            this.IDLIBRO.HeaderText = "IDLIBRO";
            this.IDLIBRO.MinimumWidth = 6;
            this.IDLIBRO.Name = "IDLIBRO";
            this.IDLIBRO.ReadOnly = true;
            this.IDLIBRO.Visible = false;
            this.IDLIBRO.Width = 125;
            // 
            // TITULO
            // 
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.MinimumWidth = 6;
            this.TITULO.Name = "TITULO";
            this.TITULO.ReadOnly = true;
            this.TITULO.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 104;
            this.label6.Text = "Fecha Prestamo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(773, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 29);
            this.label7.TabIndex = 106;
            this.label7.Text = "Prestamos:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(48, 21);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 32);
            this.btnSalir.TabIndex = 107;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(521, 420);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 32);
            this.btnAceptar.TabIndex = 108;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(673, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 110;
            this.label8.Text = "Cantidad:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(295, 190);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(26, 29);
            this.lblFecha.TabIndex = 112;
            this.lblFecha.Text = "0";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(852, 100);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(26, 29);
            this.lblCantidad.TabIndex = 113;
            this.lblCantidad.Text = "0";
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUser.Location = new System.Drawing.Point(380, 100);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(26, 29);
            this.lblIdUser.TabIndex = 116;
            this.lblIdUser.Text = "0";
            this.lblIdUser.Visible = false;
            // 
            // lblIdLector
            // 
            this.lblIdLector.AutoSize = true;
            this.lblIdLector.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLector.Location = new System.Drawing.Point(673, 143);
            this.lblIdLector.Name = "lblIdLector";
            this.lblIdLector.Size = new System.Drawing.Size(26, 29);
            this.lblIdLector.TabIndex = 117;
            this.lblIdLector.Text = "0";
            this.lblIdLector.Visible = false;
            // 
            // lblIdLibro
            // 
            this.lblIdLibro.AutoSize = true;
            this.lblIdLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLibro.Location = new System.Drawing.Point(673, 190);
            this.lblIdLibro.Name = "lblIdLibro";
            this.lblIdLibro.Size = new System.Drawing.Size(26, 29);
            this.lblIdLibro.TabIndex = 118;
            this.lblIdLibro.Text = "0";
            this.lblIdLibro.Visible = false;
            // 
            // FrmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 490);
            this.Controls.Add(this.lblIdLibro);
            this.Controls.Add(this.lblIdLector);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgPrestamo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgLibro);
            this.Controls.Add(this.cmbLector);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrestamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLector;
        private System.Windows.Forms.DataGridView dgLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgPrestamo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.Label lblIdLector;
        private System.Windows.Forms.Label lblIdLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLIBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
    }
}