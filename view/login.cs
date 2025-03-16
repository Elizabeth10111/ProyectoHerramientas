using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                txtcon.PasswordChar = '\0';
            }
            else
            {
                txtcon.PasswordChar = '*';

            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string usuario = txtusu.Text;
            string contraseña = txtcon.Text;

            if ((usuario == "simon" && contraseña == "admin") || (usuario == "fredy" && contraseña == "1234"))
            {
                Servicios servicios = new Servicios(usuario, contraseña);
                servicios.Show(); 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
                txtcon.Text = "";
                txtusu.Text = "";
            }
        }




    }
}
