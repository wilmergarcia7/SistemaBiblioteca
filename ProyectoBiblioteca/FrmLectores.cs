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
    public partial class FrmLectores : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        long idLector = 0;

        bool editar = false;
        public FrmLectores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            rtxtDireccion.Text = "";
            rtxtObservaciones.Text = "";
            txtEdad.Text = "";
            ckEstado.Checked = false;
            editar = false;
        }

        public bool verificarNombre(string nombre)
        {           
            return entity.Lectores.Any(x => x.nombreLector == nombre);
        }
        public bool verificarApellido(string apellido)
        {            
            return entity.Lectores.Any(x => x.apellidoLector == apellido);
        }
        public bool verificarTelefono(int telefono)
        {
            return entity.Lectores.Any(x => x.telefono == telefono);
        }
        public bool verificarEdad(int edad)
        {
            return entity.Lectores.Any(x => x.edad == edad);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals("") || (txtNombre.Text.Equals("")) || (txtTelefono.Text.Equals("")) || (txtEdad.Text.Equals("")) || (rtxtDireccion.Text.Equals("")))
            {
                MessageBox.Show("¡Algunos campos están vacíos!");
                return;
            }
            if (verificarNombre(txtNombre.Text) && verificarApellido(txtApellido.Text) && verificarTelefono(Convert.ToInt32(txtTelefono.Text)) && verificarEdad(Convert.ToInt32(txtEdad.Text)))
            {
                MessageBox.Show("¡Los datos del lector que ingreso ya existen en la base de datos!");
                return;
            }
            else if (txtTelefono.Text.Length != 8)
            {
                MessageBox.Show("¡Número ingresado no tiene la cantidad correcta, deben ser 8 digitos!");
                return;
            }
            if (editar)
            {
                var tLector = entity.Lectores.FirstOrDefault(x => x.idLector == idLector);
                tLector.nombreLector = txtNombre.Text;
                tLector.apellidoLector = txtApellido.Text;
                tLector.telefono = Convert.ToInt32(txtTelefono.Text);
                tLector.direccion = rtxtDireccion.Text;
                tLector.observaciones = rtxtObservaciones.Text;
                tLector.edad = Convert.ToInt32(txtEdad.Text);
                tLector.estado = ckEstado.Checked;
                entity.SaveChanges();
            }
            else
            {
                Lectores tbLector = new Lectores();
                tbLector.nombreLector = txtNombre.Text;
                tbLector.apellidoLector = txtApellido.Text;
                tbLector.telefono = Convert.ToInt32(txtTelefono.Text);
                tbLector.direccion = rtxtDireccion.Text;
                tbLector.observaciones = rtxtObservaciones.Text;
                tbLector.edad = Convert.ToInt32(txtEdad.Text);
                tbLector.estado = ckEstado.Checked;
                entity.Lectores.Add(tbLector);

                entity.SaveChanges();//se confirma la insercion
            }
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            rtxtDireccion.Text = "";
            rtxtObservaciones.Text = "";
            ckEstado.Checked = false;
            idLector = 0;
            editar = false;

            var taLectores = from d in entity.Lectores
                            
                             select new
                            {
                                d.idLector,
                                d.nombreLector,
                                d.apellidoLector,
                                d.telefono,
                                d.edad,
                                d.direccion,                                
                                d.observaciones,
                                 d.estado
                             };
            dgLectores.DataSource = taLectores.CopyAnonymusToDataTable();

            MessageBox.Show("¡Datos guardados correctamente!");
        }

        private void FrmLectores_Load(object sender, EventArgs e)
        {
            var tLectores = from d in entity.Lectores
                            
                            select new
                           {
                               d.idLector,
                               d.nombreLector,
                               d.apellidoLector,
                               d.telefono,
                               d.edad,
                               d.direccion,
                               d.observaciones,
                               d.estado
                           };

            DataTable dLector = tLectores.CopyAnonymusToDataTable();
            dgLectores.DataSource = dLector;
            dgLectores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgLectores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgLectores.RowCount > 0)
            {
                try
                {
                    // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                    idLector = Convert.ToInt64(dgLectores.SelectedCells[0].Value);
                    var tLector = entity.Lectores.FirstOrDefault(x => x.idLector == idLector);
                    txtNombre.Text = tLector.nombreLector;
                    txtApellido.Text = tLector.apellidoLector;
                    txtTelefono.Text = Convert.ToString(tLector.telefono);
                    rtxtDireccion.Text = tLector.direccion;
                    rtxtObservaciones.Text = tLector.observaciones;
                    txtEdad.Text = Convert.ToString(tLector.edad);
                    ckEstado.Checked = tLector.estado;

                    editar = true;

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
