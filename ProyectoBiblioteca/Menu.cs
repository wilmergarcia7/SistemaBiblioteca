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
    public partial class Menu : Form
    {   
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLibros libro = new FrmLibros();
            libro.ShowDialog();
            this.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuarios usuario = new FrmUsuarios();
            usuario.ShowDialog();
            this.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblUser.Text = Login.idUsuario.ToString();
            lblNUsuario.Text = Login.Usuario.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLectores lector = new FrmLectores();
            lector.ShowDialog();
            this.Show();
        }
    }
}
