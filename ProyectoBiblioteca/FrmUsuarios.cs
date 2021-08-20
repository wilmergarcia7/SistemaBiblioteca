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
    public partial class FrmUsuarios : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idUsuario = 0;
        bool editar = false;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            rtxtDireccion.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtEdad.Text = "";
            cmbGenero.Text = "";
            cmbAdmin.Text = "";
            ckEstado.Checked = false;
            editar = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtPrimerNombre.Text.Equals("") || (txtSegundoNombre.Text.Equals("")) || (txtPrimerApellido.Text.Equals("")) || (txtSegundoApellido.Text.Equals("")) || (txtTelefono.Text.Equals("")) || (txtCorreo.Text.Equals("")) || (rtxtDireccion.Text.Equals("")) || (txtUsuario.Text.Equals("")) || (txtUsuario.Text.Equals("")) || (txtPass.Text.Equals("")) || (cmbGenero.Text.Equals("")))
            {
                MessageBox.Show("¡Algunos campos están vacíos!");
                return;
            }else if (txtTelefono.Text.Length !=8)
            {
                MessageBox.Show("¡Número ingresado no tiene la cantidad correcta, deben ser 8 digitos!");
                return;
            }
         

            else if (editar)
            {
                var tUsuario = entity.Usuarios.FirstOrDefault(x => x.idUsuario == idUsuario);
                tUsuario.primerNombre = txtPrimerNombre.Text;
                tUsuario.segundoNombre = txtSegundoNombre.Text;
                tUsuario.primerApellido = txtPrimerApellido.Text;
                tUsuario.segundoApellido = txtSegundoApellido.Text;
                tUsuario.telefono = txtTelefono.Text;
                tUsuario.correoElectronico = txtCorreo.Text;
                tUsuario.direccion = rtxtDireccion.Text;
                tUsuario.usuario = txtUsuario.Text;
                tUsuario.pass = txtPass.Text;
                tUsuario.edad = Convert.ToInt32(txtEdad.Text);
                tUsuario.idGenero = Convert.ToInt32(cmbGenero.SelectedIndex+1);
                tUsuario.Admin = cmbAdmin.SelectedIndex+1;
                tUsuario.estado = ckEstado.Checked;
                entity.SaveChanges();
            }
            else
            {
                Usuarios taUsuario = new Usuarios();              
                taUsuario.primerNombre = txtPrimerNombre.Text;
                taUsuario.segundoNombre = txtSegundoNombre.Text;
                taUsuario.primerApellido = txtPrimerApellido.Text;
                taUsuario.segundoApellido = txtSegundoApellido.Text;
                taUsuario.telefono = txtTelefono.Text;
                taUsuario.correoElectronico = txtCorreo.Text;
                taUsuario.direccion = rtxtDireccion.Text;
                taUsuario.usuario = txtUsuario.Text;
                taUsuario.pass = txtPass.Text;
                taUsuario.edad = Convert.ToInt32(txtEdad.Text);
                taUsuario.idGenero = Convert.ToInt32(cmbGenero.SelectedIndex + 1);
                taUsuario.Admin = cmbAdmin.SelectedIndex + 1;
                taUsuario.estado = ckEstado.Checked;
                entity.Usuarios.Add(taUsuario);

                entity.SaveChanges();//se confirma la insercion
            }

            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            rtxtDireccion.Text = "";
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtEdad.Text = "";
            cmbGenero.Text = "";
            cmbAdmin.Text = "";
            ckEstado.Checked = false;
            idUsuario = 0;
            editar = false;

            var tbUsuarios = from d in entity.Usuarios
                             
                             select new
                            {
                                d.idUsuario,
                                d.primerNombre,
                                d.segundoNombre,
                                d.primerApellido,
                                d.segundoApellido,
                                d.telefono,
                                d.correoElectronico,
                                d.direccion,
                                d.idGenero,
                                d.usuario,
                                d.pass,
                                d.edad,
                                d.Admin,
                                 d.estado
                             };
            dgUsuarios.DataSource = tbUsuarios.CopyAnonymusToDataTable();

            var tGenero = from d in entity.Generos
                          where d.estado == true
                          select new
                          {
                              d.idGenero,
                              d.genero,

                          };
            cmbGenero.DataSource = tGenero.CopyAnonymusToDataTable();

            var tAdmin = from d in entity.Administradores

                         select new
                         {
                             d.idAdmin,
                             d.Admin,

                         };
           
            cmbAdmin.DataSource = tAdmin.CopyAnonymusToDataTable();
            
            MessageBox.Show("¡Datos guardados correctamente!");
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            var tUsuarios = from d in entity.Usuarios
                            
                            select new
                          {
                              d.idUsuario,
                              d.primerNombre,
                              d.segundoNombre,
                              d.primerApellido,
                              d.segundoApellido,
                              d.telefono,
                              d.correoElectronico,
                              d.direccion,
                              d.idGenero,
                              d.usuario,
                              d.pass,
                              d.edad,
                              d.Admin,
                                d.estado
                            };

            DataTable dUsuarios = tUsuarios.CopyAnonymusToDataTable();
            dgUsuarios.DataSource = dUsuarios;
            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            var tGenero = from d in entity.Generos
                          where d.estado == true
                          select new
                         {
                             d.idGenero,
                             d.genero,

                         };
            DataTable dGenero = tGenero.CopyAnonymusToDataTable();
            cmbGenero.DataSource = dGenero;
            cmbGenero.DisplayMember = dGenero.Columns[1].ColumnName;
            cmbGenero.ValueMember = dGenero.Columns[0].ColumnName;

            var tAdmin = from d in entity.Administradores
                          select new
                          {
                              d.idAdmin,
                              d.Admin,

                          };
            DataTable dAdmin = tAdmin.CopyAnonymusToDataTable();
            cmbAdmin.DataSource = dAdmin;
            cmbAdmin.DisplayMember = dAdmin.Columns[1].ColumnName;
            cmbAdmin.ValueMember = dAdmin.Columns[0].ColumnName;
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuarios.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idUsuario = Convert.ToInt64(dgUsuarios.SelectedCells[0].Value);
                    var taUsuario = entity.Usuarios.FirstOrDefault(x => x.idUsuario == idUsuario);
                    txtPrimerNombre.Text = taUsuario.primerNombre;                     
                    txtSegundoNombre.Text = taUsuario.segundoNombre;                     
                    txtPrimerApellido.Text = taUsuario.primerApellido;                   
                    txtSegundoApellido.Text = taUsuario.segundoApellido;                   
                    txtTelefono.Text = taUsuario.telefono;                    
                    txtCorreo.Text = taUsuario.correoElectronico;                   
                    rtxtDireccion.Text = taUsuario.direccion;                    
                    txtUsuario.Text = taUsuario.usuario;                    
                    txtPass.Text = taUsuario.pass;                    
                    txtEdad.Text = taUsuario.edad.ToString();
                    cmbGenero.SelectedIndex = Convert.ToInt32(taUsuario.idGenero-1);
                    cmbAdmin.SelectedIndex = Convert.ToInt32(taUsuario.Admin-1);
                    ckEstado.Checked = taUsuario.estado;
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
            FrmGenero genero = new FrmGenero();
            genero.Show();
        }
    }
}
