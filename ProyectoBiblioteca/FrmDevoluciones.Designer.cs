
namespace ProyectoBiblioteca
{
    partial class FrmDevoluciones
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
            this.lblFechaprestamo = new System.Windows.Forms.Label();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgDevolucion = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgPrestamos = new System.Windows.Forms.DataGridView();
            this.lblIdPrestamo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDíasRetrasados = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblISV = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFactura = new System.Windows.Forms.Button();
            this.IDPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLibros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDevolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaprestamo
            // 
            this.lblFechaprestamo.AutoSize = true;
            this.lblFechaprestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaprestamo.Location = new System.Drawing.Point(735, 43);
            this.lblFechaprestamo.Name = "lblFechaprestamo";
            this.lblFechaprestamo.Size = new System.Drawing.Size(26, 29);
            this.lblFechaprestamo.TabIndex = 140;
            this.lblFechaprestamo.Text = "0";
            this.lblFechaprestamo.Visible = false;
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUser.Location = new System.Drawing.Point(295, 90);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(26, 29);
            this.lblIdUser.TabIndex = 138;
            this.lblIdUser.Text = "0";
            this.lblIdUser.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(866, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 29);
            this.lblTotal.TabIndex = 137;
            this.lblTotal.Text = "0.00";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(304, 140);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(26, 29);
            this.lblFecha.TabIndex = 135;
            this.lblFecha.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(740, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 134;
            this.label9.Text = "Total:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(660, 463);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 32);
            this.btnAceptar.TabIndex = 132;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(37, 21);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 35);
            this.btnSalir.TabIndex = 131;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(866, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 29);
            this.label7.TabIndex = 130;
            this.label7.Text = "Libros Devueltos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 129;
            this.label6.Text = "Días retrasados:";
            // 
            // dgDevolucion
            // 
            this.dgDevolucion.AllowUserToAddRows = false;
            this.dgDevolucion.AllowUserToDeleteRows = false;
            this.dgDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPrestamo,
            this.idLibros,
            this.TITULO,
            this.Fecha,
            this.LECTOR,
            this.EDAD});
            this.dgDevolucion.Location = new System.Drawing.Point(805, 291);
            this.dgDevolucion.Name = "dgDevolucion";
            this.dgDevolucion.ReadOnly = true;
            this.dgDevolucion.RowHeadersWidth = 51;
            this.dgDevolucion.RowTemplate.Height = 24;
            this.dgDevolucion.Size = new System.Drawing.Size(308, 156);
            this.dgDevolucion.TabIndex = 128;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(674, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 32);
            this.btnCancelar.TabIndex = 127;
            this.btnCancelar.Text = "<";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.Location = new System.Drawing.Point(674, 312);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(87, 32);
            this.btnDevolucion.TabIndex = 126;
            this.btnDevolucion.Text = ">";
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 29);
            this.label5.TabIndex = 125;
            this.label5.Text = "Libros prestados:";
            // 
            // dgPrestamos
            // 
            this.dgPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrestamos.Location = new System.Drawing.Point(37, 291);
            this.dgPrestamos.Name = "dgPrestamos";
            this.dgPrestamos.RowHeadersWidth = 51;
            this.dgPrestamos.RowTemplate.Height = 24;
            this.dgPrestamos.Size = new System.Drawing.Size(582, 156);
            this.dgPrestamos.TabIndex = 124;
            // 
            // lblIdPrestamo
            // 
            this.lblIdPrestamo.AutoSize = true;
            this.lblIdPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPrestamo.Location = new System.Drawing.Point(1018, 90);
            this.lblIdPrestamo.Name = "lblIdPrestamo";
            this.lblIdPrestamo.Size = new System.Drawing.Size(26, 29);
            this.lblIdPrestamo.TabIndex = 121;
            this.lblIdPrestamo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 120;
            this.label1.Text = "Código Prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 32);
            this.label2.TabIndex = 119;
            this.label2.Text = "DEVOLUCIONES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 29);
            this.label3.TabIndex = 141;
            this.label3.Text = "Fecha devolución:";
            // 
            // lblDíasRetrasados
            // 
            this.lblDíasRetrasados.AutoSize = true;
            this.lblDíasRetrasados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDíasRetrasados.Location = new System.Drawing.Point(304, 178);
            this.lblDíasRetrasados.Name = "lblDíasRetrasados";
            this.lblDíasRetrasados.Size = new System.Drawing.Size(26, 29);
            this.lblDíasRetrasados.TabIndex = 142;
            this.lblDíasRetrasados.Text = "0";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(263, 88);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(26, 29);
            this.lblUsuario.TabIndex = 143;
            this.lblUsuario.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(741, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 29);
            this.label4.TabIndex = 144;
            this.label4.Text = "ISV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(741, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 29);
            this.label8.TabIndex = 145;
            this.label8.Text = "Subtotal:";
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISV.Location = new System.Drawing.Point(866, 160);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(58, 29);
            this.lblISV.TabIndex = 146;
            this.lblISV.Text = "0.00";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.Location = new System.Drawing.Point(866, 189);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(58, 29);
            this.lblTotalPago.TabIndex = 147;
            this.lblTotalPago.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 29);
            this.label10.TabIndex = 148;
            this.label10.Text = "Usuario:";
            // 
            // btnFactura
            // 
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Location = new System.Drawing.Point(990, 463);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(123, 32);
            this.btnFactura.TabIndex = 149;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // IDPrestamo
            // 
            this.IDPrestamo.HeaderText = "IdPrestamo";
            this.IDPrestamo.MinimumWidth = 6;
            this.IDPrestamo.Name = "IDPrestamo";
            this.IDPrestamo.ReadOnly = true;
            this.IDPrestamo.Visible = false;
            this.IDPrestamo.Width = 125;
            // 
            // idLibros
            // 
            this.idLibros.HeaderText = "IdLibro";
            this.idLibros.MinimumWidth = 6;
            this.idLibros.Name = "idLibros";
            this.idLibros.ReadOnly = true;
            this.idLibros.Visible = false;
            this.idLibros.Width = 125;
            // 
            // TITULO
            // 
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.MinimumWidth = 6;
            this.TITULO.Name = "TITULO";
            this.TITULO.ReadOnly = true;
            this.TITULO.Width = 125;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Visible = false;
            this.Fecha.Width = 125;
            // 
            // LECTOR
            // 
            this.LECTOR.HeaderText = "LECTOR";
            this.LECTOR.MinimumWidth = 6;
            this.LECTOR.Name = "LECTOR";
            this.LECTOR.ReadOnly = true;
            this.LECTOR.Visible = false;
            this.LECTOR.Width = 125;
            // 
            // EDAD
            // 
            this.EDAD.HeaderText = "EDAD";
            this.EDAD.MinimumWidth = 6;
            this.EDAD.Name = "EDAD";
            this.EDAD.ReadOnly = true;
            this.EDAD.Visible = false;
            this.EDAD.Width = 125;
            // 
            // FrmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 523);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.lblISV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDíasRetrasados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFechaprestamo);
            this.Controls.Add(this.lblIdUser);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgDevolucion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgPrestamos);
            this.Controls.Add(this.lblIdPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDevoluciones";
            this.Load += new System.EventHandler(this.FrmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDevolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaprestamo;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgDevolucion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgPrestamos;
        private System.Windows.Forms.Label lblIdPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDíasRetrasados;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn LECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDAD;
    }
}