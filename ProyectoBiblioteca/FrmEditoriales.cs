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
    public partial class FrmEditoriales : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idEditorial = 0;
        bool editar = false;
        public FrmEditoriales()
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
            txtEditorial.Text = "";
            ckEstado.Checked = false;
            idEditorial = 0;
            editar = false;
        }

        private bool verificar(string neditorial)
        {
            return entity.Editoriales.Any(x => x.editoriales1 == neditorial);

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtEditorial.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese un nombre de una editorial para continuar!");
                return;
            }
            else if (verificar(txtEditorial.Text))
            {
                MessageBox.Show("¡La editorial que intento ingresar ya existe!");
                return;
            }
            else
            {
                if (editar)
                {
                    var tEditoriales = entity.Editoriales.FirstOrDefault(x => x.idEditoriales == idEditorial);
                    tEditoriales.editoriales1 = txtEditorial.Text;
                    tEditoriales.estado = ckEstado.Checked;
                    entity.SaveChanges();
                }
                else
                {
                    Editoriales tbEditorial = new Editoriales();
                    tbEditorial.editoriales1 = txtEditorial.Text;
                    tbEditorial.estado = ckEstado.Checked;
                    entity.Editoriales.Add(tbEditorial);

                    entity.SaveChanges();//se confirma la insercion
                }

                txtEditorial.Text = "";
                ckEstado.Checked = false;
                idEditorial = 0;
                editar = false;

                var taEditorial = from d in entity.Editoriales
                                  
                                  select new
                             {
                                 d.idEditoriales,
                                 d.editoriales1,
                                      d.estado
                                  };
                dgEditorial.DataSource = taEditorial.CopyAnonymusToDataTable();

                MessageBox.Show("¡Datos guardados correctamente!");
            }
        }

        private void FrmEditoriales_Load(object sender, EventArgs e)
        {
            var tEditorial = from d in entity.Editoriales
                             
                             select new
                        {
                            d.idEditoriales,
                            d.editoriales1,
                                 d.estado
                             };
            DataTable dEditorial = tEditorial.CopyAnonymusToDataTable();
            dgEditorial.DataSource = dEditorial;
            dgEditorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgEditorial_SelectionChanged(object sender, EventArgs e)
        {
            if (dgEditorial.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idEditorial = Convert.ToInt64(dgEditorial.SelectedCells[0].Value);
                    var tEditorial = entity.Editoriales.FirstOrDefault(x => x.idEditoriales == idEditorial);
                    txtEditorial.Text = tEditorial.editoriales1;
                    ckEstado.Checked = tEditorial.estado;
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
