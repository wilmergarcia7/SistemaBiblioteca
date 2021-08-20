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
    public partial class Pais : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idPais = 0;
        bool editar = false;
        public Pais()
        {
            InitializeComponent();
        }

  

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FrmAutores autor = new FrmAutores();
            autor.ShowDialog();
        }

        private void Pais_Load(object sender, EventArgs e)
        {
            var tPais = from d in entity.Paises
                        
                           select new
                           {
                               d.idPais,
                               d.Pais,
                               d.estado
                           };
            DataTable dPais = tPais.CopyAnonymusToDataTable();
            dgPaises.DataSource = dPais;
            dgPaises.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPais.Text = "";
            ckEstado.Checked = false;
            idPais = 0;
            editar = false;
        }

        private bool verificar(string nombrePais)
        {
            return entity.Paises.Any(x => x.Pais == nombrePais);
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPais.Text.Equals(""))
            {
                MessageBox.Show("¡Ingrese un nombre de país para continuar!");
                return;
            }
            else if (verificar(txtPais.Text))
            {
                MessageBox.Show("¡El país que intento ingresar ya existe!");
                return;
            }
            else
            {
                if(editar)
                {
                    var tPais = entity.Paises.FirstOrDefault(x => x.idPais == idPais);
                    tPais.Pais = txtPais.Text;
                    tPais.estado = ckEstado.Checked;
                    entity.SaveChanges();
                }
                else
                {
                    Paises tbPais = new Paises();
                    tbPais.Pais = txtPais.Text;
                    tbPais.estado = ckEstado.Checked;
                    entity.Paises.Add(tbPais);

                    entity.SaveChanges();//se confirma la insercion
                }

                txtPais.Text = "";
                ckEstado.Checked = false;
                idPais = 0;
                editar = false;

                var taPais = from d in entity.Paises
                            
                             select new
                             {
                                 d.idPais,
                                 d.Pais,
                                 d.estado
                             };
                dgPaises.DataSource = taPais.CopyAnonymusToDataTable();

                MessageBox.Show("¡Datos guardados correctamente!");
            }
        }

        private void dgPaises_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPaises.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idPais = Convert.ToInt64(dgPaises.SelectedCells[0].Value);
                    var tPais = entity.Paises.FirstOrDefault(x => x.idPais == idPais);
                    txtPais.Text = tPais.Pais;
                    ckEstado.Checked = tPais.estado;
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
