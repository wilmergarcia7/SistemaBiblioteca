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
    public partial class FrmPrestamos : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        DataTable dtLibros = new DataTable();
        
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToShortDateString();
            lblIdUser.Text = Login.idUsuario.ToString();
            lblUsuario.Text = Login.Usuario.ToString();
            var tLibros = from p in entity.Libros
                          where p.estado == true
                          select new
                            {
                                p.idLibro,
                                p.titulo,
                                p.fechaLanzamiento

                            };
            dtLibros = tLibros.CopyAnonymusToDataTable();
            dgLibro.DataSource = dtLibros;

            var tLector = from p in entity.Lectores
                          where p.estado == true
                          select new
                          {
                              p.idLector,
                              p.nombreLector,                             

                          };
            DataTable dLector = tLector.CopyAnonymusToDataTable();
            cmbLector.DataSource = dLector;
            cmbLector.DisplayMember = dLector.Columns[1].ColumnName;
            cmbLector.ValueMember = dLector.Columns[0].ColumnName;
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (dgLibro.SelectedRows.Count > 0)
            {
                int indice = dgLibro.CurrentCell.RowIndex;
                long idLibro = Convert.ToInt64(dgLibro.Rows[indice].Cells[0].Value.ToString());
                string nombreLibro = dgLibro.Rows[indice].Cells[1].Value.ToString();

                dgPrestamo.Rows.Add(idLibro.ToString(), nombreLibro);

                dtLibros = (DataTable)dgLibro.DataSource;
                dtLibros.Rows.RemoveAt(indice);
                dgLibro.DataSource = dtLibros;

                lblCantidad.Text = Convert.ToString(dgPrestamo.Rows.Count);
            }
            else
            {
                MessageBox.Show("Seleccione un libro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgPrestamo.SelectedRows.Count > 0)
            {
                
                int indice = dgPrestamo.CurrentCell.RowIndex;
                long idLibro = Convert.ToInt64(dgPrestamo.Rows[indice].Cells[0].Value.ToString());
                string nombreLibro = dgPrestamo.Rows[indice].Cells[1].Value.ToString();

                dtLibros.Rows.Add(idLibro.ToString(), nombreLibro, "");
                
                dgLibro.DataSource = dtLibros;
                dgPrestamo.Rows.RemoveAt(indice);

                
             
                lblCantidad.Text = Convert.ToString(dgPrestamo.Rows.Count);
                
                
                //decimal total = 0;


            }
            else
            {
                MessageBox.Show("Seleccione un libro a remover");

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgPrestamo.SelectedRows.Count > 0)
            {

                Prestamos tPrestamo = new Prestamos();
                tPrestamo.idUsuario = Convert.ToInt32(lblIdUser.Text);           
                tPrestamo.idLector = Convert.ToInt32(lblIdLector.Text);                
                tPrestamo.fechaPrestamo = Convert.ToDateTime(lblFecha.Text);
                tPrestamo.estado = true;
                tPrestamo.cantidad = Convert.ToInt32(lblCantidad.Text);
                tPrestamo.status = "Prestado";
                entity.Prestamos.Add(tPrestamo);
                entity.SaveChanges();

                foreach (DataGridViewRow dr in dgPrestamo.Rows)
                {
                    Detalleprestamo tDet = new Detalleprestamo();
                    tDet.idLibro = Convert.ToInt32(dr.Cells[0].Value);
                    tDet.idPrestamo = tPrestamo.idPrestamo;                                      
                    entity.Detalleprestamo.Add(tDet);
                    
                    entity.SaveChanges();
                   
                     
                }
                

                MessageBox.Show("¡El prestamo se ha realizado exitosamente!");
                dgPrestamo.Rows.Clear();

                
                var tlibros = from p in entity.Libros
                                where p.estado == true
                                select new
                                {
                                    p.idLibro,
                                    p.titulo,
                                    p.fechaLanzamiento

                                };

              
                dtLibros = tlibros.CopyAnonymusToDataTable();
                dgLibro.DataSource = dtLibros;

                lblCantidad.Text = "0";
              

            }
            else
            {
                MessageBox.Show("Seleccione al menos un libro");

            }
        
        }

        private void cmbLector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLector.SelectedIndex >= 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    var idLector = Convert.ToInt32(cmbLector.SelectedIndex);
                    var tDestino = entity.Lectores.FirstOrDefault(x => x.idLector == idLector);
                    lblIdLector.Text = Convert.ToString(cmbLector.SelectedIndex+100);


                }
                catch (Exception)
                {

                }
            }
        }
    }
}
