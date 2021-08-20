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
    public partial class FrmAutores : Form
    {
        
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idAutor = 0;
       
        bool editar = false;
        public FrmAutores()
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
            //reestablece los campos que se van a llenar
            txtNombreAutor.Text = "";
            cmbPaises.Text = "";
            ckEstado.Checked = false;
            editar = false;
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // carga los datos que se requiere, provienen de la base de datos y apareceran solo los que tengan
            // estado true, en caso de ser contrario en el combobox no aparecera 
            var tPaises = from d in entity.Paises
                          where d.estado == true
                          select new
                          {
                              d.idPais,
                              d.Pais
                          };
            DataTable dPaises = tPaises.CopyAnonymusToDataTable();
            cmbPaises.DataSource = dPaises;
            cmbPaises.DisplayMember = dPaises.Columns[1].ColumnName;
            cmbPaises.ValueMember = dPaises.Columns[0].ColumnName;


            // carga los datos que se requiere en el datagrid, provienen de la base de datos 
           
            var tAutores = from d in entity.Autores
                           
                           select new
                           {
                               d.idAutor,
                               d.nombreCompletoAutor,
                               d.Paises.Pais,
                               d.estado                               
                           };

            DataTable dAutores = tAutores.CopyAnonymusToDataTable();
            dgAutores.DataSource = dAutores;
            dgAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        //verifica si los datos ya existen en la base de datos
        public bool verificarNombre(string nombre)
        {
         
          return entity.Autores.Any(x => x.nombreCompletoAutor == nombre);
            
        }

     
        public bool verificarPais(int pais)
        {
            
            return entity.Autores.Any(x => x.idPais == pais);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreAutor.Text.Equals("")||  (cmbPaises.Text.Equals("")))
            {
                MessageBox.Show("¡Algunos campos están vacíos!");
                return;
            }
             if (verificarNombre(txtNombreAutor.Text) && verificarPais(cmbPaises.SelectedIndex+1))
            {
                MessageBox.Show("¡Los datos del autor que ingreso ya existen en la base de datos!");
                return;
            }

            //verifica que editar sea verdadero y si lo es los datos se podran modificar
            if (editar)
                {
                //esta parte del codigo se encarga de verificar que el id que esta en el datagrid sea el mismo que el de la
                //base de datos, si es verdad entonces estos campos se podran modificar correctamente
                    var tAutor = entity.Autores.FirstOrDefault(x => x.idAutor == idAutor);
                    tAutor.nombreCompletoAutor = txtNombreAutor.Text;
                    tAutor.estado = ckEstado.Checked;
                    tAutor.idPais = Convert.ToInt32(cmbPaises.SelectedIndex+1);
                    entity.SaveChanges();
                }
                else
                {
                // Se encarga de agregar nuevos datos a la base de datos se accede cuando editar es falso
                    Autores tbAutor = new Autores();
                    tbAutor.nombreCompletoAutor = txtNombreAutor.Text;
                    tbAutor.estado = ckEstado.Checked;
                    tbAutor.idPais = Convert.ToInt32(cmbPaises.SelectedIndex+1);

                    entity.Autores.Add(tbAutor);

                    entity.SaveChanges();//se confirma la insercion
                }

            // los campos del formulario se reestablecen
                txtNombreAutor.Text = "";
                cmbPaises.Text = "";
                ckEstado.Checked = false;
                idAutor = 0;
                editar = false;


            // recarga el datagrid con los agregados
                var taAutor = from d in entity.Autores
                              
                              select new
                             {
                                 d.idAutor,
                                 d.nombreCompletoAutor,
                                 d.Paises.Pais,
                                 d.estado
                              };
                dgAutores.DataSource = taAutor.CopyAnonymusToDataTable();

                MessageBox.Show("¡Datos guardados correctamente!");
            
        }

        private void dgAutores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgAutores.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idAutor = Convert.ToInt64(dgAutores.SelectedCells[0].Value);
                    var tAutor = entity.Autores.FirstOrDefault(x => x.idAutor == idAutor);
                    txtNombreAutor.Text = tAutor.nombreCompletoAutor;
                    lblIdAutor.Text = tAutor.idAutor.ToString();
                    ckEstado.Checked = tAutor.estado;
                    cmbPaises.Text = tAutor.Paises.Pais;
                    
                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }

        private void btnNPais_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Pais pais = new Pais();
            pais.ShowDialog();
           
        }

        
    }
}
