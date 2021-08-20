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
    public partial class FrmLibros : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idLibro = 0;
        bool editar = false;
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            var tLibros = from d in entity.Libros
                         
                          select new
                            {
                                d.idLibro,
                                d.titulo,
                                d.fechaLanzamiento,
                                d.Autores.nombreCompletoAutor,
                                d.Categorias.categoria,
                                d.Editoriales.editoriales1,
                                d.Idiomas.Idioma,
                                d.numeroPaginas,
                                d.descripcionLibro,
                                d.ISBN,
                              d.estado

                          };

            DataTable dLibro = tLibros.CopyAnonymusToDataTable();
            dgLibros.DataSource = dLibro;
            dgLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            var tAutor = from d in entity.Autores
                         where d.estado == true
                         select new
                          {
                              d.idAutor,
                              d.nombreCompletoAutor,
                              
                          };
            DataTable dAutor = tAutor.CopyAnonymusToDataTable();
            cmbAutor.DataSource = dAutor;            
            cmbAutor.DisplayMember = dAutor.Columns[1].ColumnName;
            cmbAutor.ValueMember = dAutor.Columns[0].ColumnName;

            var tCategoria = from d in entity.Categorias
                             where d.estadi == true
                             select new
                         {
                             d.idCategoria,
                             d.categoria                        
                         };
            DataTable dCategoria = tCategoria.CopyAnonymusToDataTable();
            cmbCategoría.DataSource = dCategoria;
            cmbCategoría.DisplayMember = dCategoria.Columns[1].ColumnName;
            cmbCategoría.ValueMember = dCategoria.Columns[0].ColumnName;

            var tEditorial = from d in entity.Editoriales
                             where d.estado == true
                             select new
                         {
                             d.idEditoriales,
                             d.editoriales1
                         };
            DataTable dEditorial = tEditorial.CopyAnonymusToDataTable();
            cmbEditorial.DataSource = dEditorial;
            cmbEditorial.DisplayMember = dEditorial.Columns[1].ColumnName;
            cmbEditorial.ValueMember = dEditorial.Columns[0].ColumnName;

            var tIdioma = from d in entity.Idiomas
                          where d.estado == true
                             select new
                             {
                                 d.idIdioma,
                                 d.Idioma
                             };
            DataTable dIdioma = tIdioma.CopyAnonymusToDataTable();
            cmbIdioma.DataSource = dIdioma;
            cmbIdioma.DisplayMember = dIdioma.Columns[1].ColumnName;
            cmbIdioma.ValueMember = dIdioma.Columns[0].ColumnName;
        }
       
        
        public bool verificarISBN(string ISBN)
        {

            return entity.Libros.Any(x => x.ISBN == ISBN);

        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Equals("") || (txtNPaginas.Text.Equals("")) || (txtISBN.Text.Equals("")) || (rtxtDescripcion.Text.Equals("")) || (cmbAutor.Text.Equals("")) || (cmbCategoría.Text.Equals("")) || (cmbEditorial.Text.Equals("")) || (cmbIdioma.Text.Equals("")))
            {
                MessageBox.Show("¡Algunos campos están vacíos!");
                return;
            }
            else if (verificarISBN(txtISBN.Text))
                {  
                MessageBox.Show("¡Los datos del libro que ingreso ya existen en la base de datos!");
                
                return;
            }
            else if (txtISBN.Text.Length != 13)
            {
                MessageBox.Show("¡El ISBN tiene una cantidad de caracteres fuera del rango, lo normal son 13!");

                return;
            }

            else if (editar)
            {
                var tLibros = entity.Libros.FirstOrDefault(x => x.idLibro == idLibro);
                tLibros.titulo = txtTitulo.Text;
                tLibros.numeroPaginas = Convert.ToInt32(txtNPaginas.Text);
                tLibros.ISBN = txtISBN.Text;
                tLibros.descripcionLibro = rtxtDescripcion.Text;
                tLibros.fechaLanzamiento = dtpFechaLanzamiento.Value;
                tLibros.idAutor = Convert.ToInt32(cmbAutor.SelectedIndex + 1);
                tLibros.idCategoria = Convert.ToInt32(cmbCategoría.SelectedIndex + 1);
                tLibros.idEditorial = Convert.ToInt32(cmbEditorial.SelectedIndex + 1);
                tLibros.idIdioma = Convert.ToInt32(cmbIdioma.SelectedIndex + 1);
                tLibros.estado = ckEstado.Checked;
                entity.SaveChanges();
            }
            else
            {
                Libros taLibros = new Libros();
                taLibros.titulo = txtTitulo.Text;
                taLibros.numeroPaginas = Convert.ToInt32(txtNPaginas.Text);
                taLibros.ISBN = txtISBN.Text;
                taLibros.descripcionLibro = rtxtDescripcion.Text;
                taLibros.fechaLanzamiento = dtpFechaLanzamiento.Value;
                taLibros.idAutor = Convert.ToInt32(cmbAutor.SelectedIndex + 1);
                taLibros.idCategoria = Convert.ToInt32(cmbCategoría.SelectedIndex + 1);
                taLibros.idEditorial = Convert.ToInt32(cmbEditorial.SelectedIndex + 1);
                taLibros.idIdioma = Convert.ToInt32(cmbIdioma.SelectedIndex + 1);
                taLibros.estado = ckEstado.Checked;
                entity.Libros.Add(taLibros);

                entity.SaveChanges();//se confirma la insercion
            }

            txtTitulo.Text = "";
            txtNPaginas.Text = "";
            txtISBN.Text = "";
            rtxtDescripcion.Text = "";
            dtpFechaLanzamiento.Value = DateTime.Now;
            cmbAutor.Text = "";
            cmbCategoría.Text = "";
            cmbEditorial.Text = "";
            cmbIdioma.Text = "";
            ckEstado.Checked = false;
            idLibro = 0;
            editar = false;

            var tbLibros = from d in entity.Libros
                          
                          select new
                          {
                              d.idLibro,
                              d.titulo,
                              d.fechaLanzamiento,
                              d.Autores.nombreCompletoAutor,
                              d.Categorias.categoria,
                              d.Editoriales.editoriales1,
                              d.Idiomas.Idioma,
                              d.numeroPaginas,
                              d.descripcionLibro,
                              d.ISBN,
                              d.estado
                          };
            dgLibros.DataSource = tbLibros.CopyAnonymusToDataTable();

            MessageBox.Show("¡Datos guardados correctamente!");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtNPaginas.Text = "";
            txtISBN.Text = "";
            rtxtDescripcion.Text = "";
            dtpFechaLanzamiento.Value = DateTime.Now;
            cmbAutor.Text = "";
            cmbCategoría.Text = "";
            cmbEditorial.Text = "";
            cmbIdioma.Text = "";
            ckEstado.Checked = false;
            editar = false;
        }

        private void dgLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgLibros.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idLibro = Convert.ToInt64(dgLibros.SelectedCells[0].Value);
                    var tLibro = entity.Libros.FirstOrDefault(x => x.idLibro == idLibro);
                    txtTitulo.Text = tLibro.titulo;
                    txtNPaginas.Text = Convert.ToString(tLibro.numeroPaginas);
                    txtISBN.Text = tLibro.ISBN;
                    rtxtDescripcion.Text = tLibro.descripcionLibro;
                    dtpFechaLanzamiento.Value = tLibro.fechaLanzamiento;
                    cmbAutor.SelectedIndex = tLibro.idAutor-1;
                    cmbCategoría.SelectedIndex = tLibro.idCategoria-1;
                    cmbEditorial.SelectedIndex = tLibro.idEditorial-1;
                    cmbIdioma.SelectedIndex = tLibro.idIdioma-1;
                    ckEstado.Checked = tLibro.estado;
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }

        private void btnNAutor_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAutores autor = new FrmAutores();
            autor.ShowDialog();
            
        }

        private void btnNCategoria_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmCategorias categoria = new FrmCategorias();
            categoria.ShowDialog();
            
        }

        private void btnNEditorial_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmEditoriales editorial = new FrmEditoriales();
            editorial.ShowDialog();
          
        }

        private void btnNIdioma_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmIdiomas idioma = new FrmIdiomas();
            idioma.ShowDialog();
            
        }
    }
}
