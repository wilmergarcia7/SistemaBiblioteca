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
    public partial class MenuNoAdmin : Form
    {
        Login global = new Login();
        public MenuNoAdmin()
        {
            InitializeComponent();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            FrmPrestamos prestamo = new FrmPrestamos();
            prestamo.ShowDialog();
            
        }

        private void btnLector_Click(object sender, EventArgs e)
        {
          
            FrmLectores lector = new FrmLectores();
            lector.ShowDialog();
            
        }

        private void MenuNoAdmin_Load(object sender, EventArgs e)
        {
            lblUser.Text= Login.idUsuario.ToString();
            lblNUsuario.Text = Login.Usuario.ToString();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            FrmDevoluciones devolucion = new FrmDevoluciones();
            devolucion.ShowDialog();
        }
    }
}
