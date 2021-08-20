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
    public partial class Login : Form
    {
        BDBibliotecaEntities entity = new BDBibliotecaEntities();
        Usuarios user = new Usuarios();

        internal static int idUsuario;
        internal static string Usuario;


        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool verificarUsuario(string usuario)
        {

            return entity.Usuarios.Any(x => x.usuario == usuario);

        }

        public bool verificarPass(string pass)
        {

            return entity.Usuarios.Any(x => x.pass == pass);

        }

        
       

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           

            if (verificarUsuario(txtUsuario.Text) && verificarPass(txtPass.Text))
            {
                var tUsuarios = from d in entity.Usuarios
                                where d.estado == true
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

                if (dgUsuarios.RowCount > 0)
                {
                    try
                    {
                        // Al dar clic en el id que se muestra en la tabla los datos de los demás campos se llenaran
                       
                        var taUsuario = entity.Usuarios.FirstOrDefault(x => x.usuario == txtUsuario.Text);
                        lblAdmin.Text = taUsuario.Admin.ToString();
                        lblIdUser.Text = taUsuario.idUsuario.ToString();
                        lblUsuario.Text = taUsuario.usuario.ToString();
                    }
                    catch (Exception)
                    {

                    }
                }
                if (lblAdmin.Text=="1")
                {
                    
                    idUsuario = Convert.ToInt32(lblIdUser.Text);
                    Usuario = lblUsuario.Text;
                    MessageBox.Show("¡Bienvenido "+Usuario+" !");
                    this.Hide();
                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Show();
                }
                else 
                {
                    
                    idUsuario = Convert.ToInt32(lblIdUser.Text);
                    Usuario = lblUsuario.Text;
                    MessageBox.Show("¡Bienvenido " + Usuario + " !");
                    this.Hide();
                    MenuNoAdmin menun = new MenuNoAdmin();
                    menun.ShowDialog();
                    this.Show();
                }
                
                
            }
            else 
            {
                MessageBox.Show("¡Datos incorrectos!");
            }

            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var tUsuarios = from d in entity.Usuarios
                            where d.estado == true
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
                                d.Admin
                            };

            DataTable dUsuarios = tUsuarios.CopyAnonymusToDataTable();
        }
    }
}
