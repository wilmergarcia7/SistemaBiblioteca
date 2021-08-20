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
    public partial class FrmIdiomas : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idIdioma = 0;
        bool editar = false;
        public FrmIdiomas()
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
            txtIdioma.Text = "";
            ckEstado.Checked = false;
            idIdioma = 0;
            editar = false;
        }
        private bool verificar(string idioma)
        {
            return entity.Idiomas.Any(x => x.Idioma == idioma);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdioma.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese el nombre de un idioma para continuar!");
                return;
            }
            else if (verificar(txtIdioma.Text))
            {
                MessageBox.Show("¡El idioma que intento ingresar ya existe!");
                return;
            }
            else
            {
                if (editar)
                {
                    var tIdioma = entity.Idiomas.FirstOrDefault(x => x.idIdioma == idIdioma);
                    tIdioma.Idioma = txtIdioma.Text;
                    tIdioma.estado = ckEstado.Checked;
                    entity.SaveChanges();
                }
                else
                {
                    Idiomas taIdioma = new Idiomas();
                    taIdioma.Idioma = txtIdioma.Text;
                    taIdioma.estado = ckEstado.Checked;
                    entity.Idiomas.Add(taIdioma);

                    entity.SaveChanges();//se confirma la insercion
                }

                txtIdioma.Text = "";
                ckEstado.Checked = false;
                idIdioma = 0;
                editar = false;

                var tbIdioma = from d in entity.Idiomas
                               
                               select new
                               {
                                   d.idIdioma,
                                   d.Idioma,
                                   d.estado
                               };
                dgIdioma.DataSource = tbIdioma.CopyAnonymusToDataTable();

                MessageBox.Show("¡Datos guardados correctamente!");
            }
        }

        private void FrmIdiomas_Load(object sender, EventArgs e)
        {
            var tIdioma = from d in entity.Idiomas
                          
                          select new
                          {
                              d.idIdioma,
                              d.Idioma,
                              d.estado
                          };
            DataTable dIdioma = tIdioma.CopyAnonymusToDataTable();
            dgIdioma.DataSource = dIdioma;
            dgIdioma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgIdioma_SelectionChanged(object sender, EventArgs e)
        {
            if (dgIdioma.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idIdioma = Convert.ToInt64(dgIdioma.SelectedCells[0].Value);
                    var tIdioma = entity.Idiomas.FirstOrDefault(x => x.idIdioma == idIdioma);
                    txtIdioma.Text = tIdioma.Idioma;
                    ckEstado.Checked = false;
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
