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
    public partial class FrmGenero : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idGenero = 0;
        bool editar = false;
        public FrmGenero()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtGenero.Text = "";
            ckEstado.Checked = false;
            idGenero = 0;
            editar = false;
        }
        private bool verificar(string neditorial)
        {
            return entity.Editoriales.Any(x => x.editoriales1 == neditorial);

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtGenero.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre de un género para continuar!");
                return;
            }
            else if (verificar(txtGenero.Text))
            {
                MessageBox.Show("¡El género que intento ingresar ya existe!");
                return;
            }
            else
            {
                if (editar)
                {
                    var tGenero = entity.Generos.FirstOrDefault(x => x.idGenero == idGenero);
                    tGenero.genero = txtGenero.Text;
                    tGenero.estado = ckEstado.Checked;
                    entity.SaveChanges();
                }
                else
                {
                    Generos tbGenero = new Generos();
                    tbGenero.genero = txtGenero.Text;
                    tbGenero.estado = ckEstado.Checked;
                    entity.Generos.Add(tbGenero);
                    entity.SaveChanges();//se confirma la insercion
                }

                txtGenero.Text = "";
                ckEstado.Checked = false;
                idGenero = 0;
                editar = false;

                var taGenero = from d in entity.Generos
                              
                               select new
                                  {
                                      d.idGenero,
                                      d.genero,
                                   d.estado
                               };
                dgGenero.DataSource = taGenero.CopyAnonymusToDataTable();

                MessageBox.Show("¡Datos guardados correctamente!");
            }
        }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            var tGenero = from d in entity.Generos
                         
                          select new
                             {
                                 d.idGenero,
                                 d.genero,
                              d.estado
                          };
            DataTable dGenero = tGenero.CopyAnonymusToDataTable();
            dgGenero.DataSource = dGenero;
            dgGenero.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgGenero_SelectionChanged(object sender, EventArgs e)
        {
            if (dgGenero.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idGenero = Convert.ToInt64(dgGenero.SelectedCells[0].Value);
                    var tGenero = entity.Generos.FirstOrDefault(x => x.idGenero == idGenero);
                    txtGenero.Text = tGenero.genero;
                    ckEstado.Checked = tGenero.estado;
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
