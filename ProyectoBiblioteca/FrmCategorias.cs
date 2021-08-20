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
    public partial class FrmCategorias : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idCategoria = 0;
        bool editar = false;
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmLibros libro = new FrmLibros();
            libro.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCategoria.Text = "";
            ckEstado.Checked = false;
            idCategoria = 0;
            editar = false;
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            var tCategoria = from d in entity.Categorias
                             
                             select new
                        {
                           d.idCategoria,
                           d.categoria,
                                 d.estadi
                             };
            DataTable dCategoria = tCategoria.CopyAnonymusToDataTable();
            dgCategorias.DataSource = dCategoria;
            dgCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private bool verificar(string categoria)
        {
            return entity.Categorias.Any(x => x.categoria == categoria);

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese una categoría!");
                return;
            }
            else if (verificar(txtCategoria.Text))
            {
                MessageBox.Show("¡La categoría que intento ingresar ya existe!");
                return;
            }
            else
            {
                if (editar)
                {
                    var tCategoria = entity.Categorias.FirstOrDefault(x => x.idCategoria == idCategoria);
                    tCategoria.categoria = txtCategoria.Text;
                    tCategoria.estadi = ckEstado.Checked;
                    entity.SaveChanges();
                }
                else
                {
                    Categorias tbCategoria = new Categorias();
                    tbCategoria.categoria = txtCategoria.Text;
                    tbCategoria.estadi = ckEstado.Checked;
                    entity.Categorias.Add(tbCategoria);

                    entity.SaveChanges();//se confirma la insercion
                }

                txtCategoria.Text = "";
                ckEstado.Checked = false;
                idCategoria = 0;
                editar = false;

                var taCategoria = from d in entity.Categorias
                                  
                                  select new
                             {
                                 d.idCategoria,
                                 d.categoria,
                                      d.estadi
                                  };
                dgCategorias.DataSource = taCategoria.CopyAnonymusToDataTable();

                MessageBox.Show("¡Datos guardados correctamente!");
            }
        }

        private void dgCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCategorias.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idCategoria = Convert.ToInt64(dgCategorias.SelectedCells[0].Value);
                    var tCategoria = entity.Categorias.FirstOrDefault(x => x.idCategoria == idCategoria);
                    txtCategoria.Text = tCategoria.categoria;
                    ckEstado.Checked = tCategoria.estadi;
                    editar = true;


                }
                catch (Exception)
                {

                }
            }
        }
    }
}
