using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBiblioteca
{
    public partial class FrmDevoluciones : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        DataTable dtPrestamos = new DataTable();
      
        public FrmDevoluciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmDevoluciones_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToShortDateString();
            lblIdUser.Text = Login.idUsuario.ToString();
            lblUsuario.Text = Login.Usuario.ToString();

            var tPrestamo = from p in entity.Prestamos
                            join d in entity.Detalleprestamo on p.idPrestamo equals d.idPrestamo
                            where p.status == "Prestado"
                            select new
                            {
                                id = d.idDetallePrestamo,
                                IDlibro = d.idLibro,
                                titulo = d.Libros.titulo,
                                fechaPrestamo = p.fechaPrestamo,
                                Lector = p.Lectores.nombreLector,
                                edad = p.Lectores.edad,
                                
                          };
            
            dtPrestamos = tPrestamo.CopyAnonymusToDataTable();
            dgPrestamos.DataSource = dtPrestamos;
            dgPrestamos.Columns[1].Visible = false;
            dgPrestamos.Columns[5].Visible = false;

        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            if (dgPrestamos.SelectedRows.Count > 0)
            {
                int indice = dgPrestamos.CurrentCell.RowIndex;
                long idPrestamo = Convert.ToInt64(dgPrestamos.Rows[indice].Cells[0].Value.ToString());
                long idLibro = Convert.ToInt64(dgPrestamos.Rows[indice].Cells[1].Value.ToString());
                string nombreLibro = dgPrestamos.Rows[indice].Cells[2].Value.ToString();
                string fechaPrestamo = dgPrestamos.Rows[indice].Cells[3].Value.ToString();
                string lector = dgPrestamos.Rows[indice].Cells[4].Value.ToString();
                int edad = Convert.ToInt32(dgPrestamos.Rows[indice].Cells[5].Value.ToString());


                dgDevolucion.Rows.Add(idPrestamo.ToString(),idLibro.ToString(), nombreLibro, fechaPrestamo,lector, edad.ToString());

                dtPrestamos = (DataTable)dgPrestamos.DataSource;
                dtPrestamos.Rows.RemoveAt(indice);
                dgPrestamos.DataSource = dtPrestamos;

                lblIdPrestamo.Text = idPrestamo.ToString();
                double total = 0;
                int dias = 0;
                double descuento = 0.25;
                double impuesto = 0.15;
                double subtotal = 0;
                lblFechaprestamo.Text = Convert.ToDateTime(fechaPrestamo).ToShortDateString();

                var timeSpan = Convert.ToDateTime(lblFecha.Text).AddDays(5) - Convert.ToDateTime(fechaPrestamo);
                lblDíasRetrasados.Text = timeSpan.TotalDays.ToString();
                if (timeSpan.TotalDays <= 4)
                {
                    total = 20;
                    subtotal = total - (total * impuesto);
                    impuesto = total * impuesto;
                    lblTotalPago.Text = total.ToString();
                    lblTotal.Text = subtotal.ToString();
                    lblISV.Text = impuesto.ToString();
                    if (edad > 60)
                    {
                        total = total - (total * descuento);
                        lblTotal.Text = total.ToString();
                    }
                    
                }
                else if (timeSpan.TotalDays > 4)                    
                {
                    dias = Convert.ToInt32(timeSpan.TotalDays) - 4;
                    total = 20 + (dias*4) + (0.2 * (20 + (dias * 4)));
                    subtotal = total - (total * impuesto);
                    impuesto = total * impuesto;
                    lblTotalPago.Text = total.ToString();
                    lblTotal.Text = subtotal.ToString();
                    lblISV.Text = impuesto.ToString();
                    
                    if (edad > 60)
                    {
                        total = total - (total * descuento);
                        lblTotal.Text = total.ToString();
                    }
                }

                

            }
            else
            {
                MessageBox.Show("Seleccione un libro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgDevolucion.SelectedRows.Count > 0)
            {

                int indice = dgDevolucion.CurrentCell.RowIndex;
                long idPrestamo = Convert.ToInt64(dgDevolucion.Rows[indice].Cells[0].Value.ToString());
                long idLibro = Convert.ToInt64(dgDevolucion.Rows[indice].Cells[1].Value.ToString());
                string nombreLibro = dgDevolucion.Rows[indice].Cells[2].Value.ToString();
                string fechaPrestamo = dgDevolucion.Rows[indice].Cells[3].Value.ToString();
                string lector = dgDevolucion.Rows[indice].Cells[4].Value.ToString();
                int edad = Convert.ToInt32(dgDevolucion.Rows[indice].Cells[5].Value.ToString());

                dtPrestamos.Rows.Add(idPrestamo.ToString(),idLibro.ToString(), nombreLibro,fechaPrestamo,lector,edad.ToString());

                dgPrestamos.DataSource = dtPrestamos;
                dgDevolucion.Rows.RemoveAt(indice);

                lblTotalPago.Text = "0.00";
                lblTotal.Text = "0.00";
                lblISV.Text = "0.00";
                lblDíasRetrasados.Text = "0";
                lblIdPrestamo.Text = "0";
           

            }
            else
            {
                MessageBox.Show("Seleccione un libro a remover");

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgDevolucion.SelectedRows.Count > 0)
            {

                Devoluciones tDevolucion = new Devoluciones();
                tDevolucion.idDetallePrestamo = Convert.ToInt32(lblIdPrestamo.Text);
                tDevolucion.fechaDevolucion = Convert.ToDateTime(lblFecha.Text).AddDays(5);
                tDevolucion.diasRetraso = Convert.ToInt32(lblDíasRetrasados.Text);

                tDevolucion.pagoTotal = Convert.ToDecimal(lblTotalPago.Text);
                tDevolucion.status = "Regresado";
                entity.Devoluciones.Add(tDevolucion);
                entity.SaveChanges();
                
               

                MessageBox.Show("¡Devolución exitosa!");
                dgDevolucion.Rows.Clear();


          

                var tPrestamo = from p in entity.Prestamos
                                join d in entity.Detalleprestamo on p.idPrestamo equals d.idPrestamo
                                where p.status == "Prestado"
                                select new
                                {
                                    id = d.idDetallePrestamo,
                                    IDlibro = d.idLibro,
                                    titulo = d.Libros.titulo,
                                    fechaPrestamo = p.fechaPrestamo,
                                    Lector = p.Lectores.nombreLector,
                                    edad = p.Lectores.edad,

                                };

                dtPrestamos = tPrestamo.CopyAnonymusToDataTable();
                dgPrestamos.DataSource = dtPrestamos;


                lblTotalPago.Text = "0.00";
                lblTotal.Text = "0.00";
                lblISV.Text = "0.00";
                lblDíasRetrasados.Text = "0";


            }
            else
            {
                MessageBox.Show("Seleccione al menos un libro");

            }
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            this.Hide();
            Factura factura = new Factura();
            factura.ShowDialog();
            this.Show();
        }
    }
}
