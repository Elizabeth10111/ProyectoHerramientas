using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class parqueadero : Form
    {
        public parqueadero()
        {
            InitializeComponent();
        }

        private void parqueadero_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string dato1 = txtpro.Text;
            string dato2 = comboBox1.Text;
            string dato3 = txtdocu.Text;
            string dato4 = txtplaca.Text;
            string dato5 = txtprecio.Text;

            verparquea form3 = new verparquea(dato1, dato2, dato3, dato4, dato5);

            using (StreamWriter sw = new StreamWriter("parqueadero.xls", true))
            {
                sw.WriteLine($"{dato1}, {dato2}, {dato3}, {dato4}, {dato5}");
            }
            MessageBox.Show("Guardado 👍");
        
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string dato1 = txtpro.Text;
            string dato2 = comboBox1.Text;
            string dato3 = txtdocu.Text;
            string dato4 = txtplaca.Text;
            string dato5 = txtprecio.Text;
            verparquea form3 = new verparquea(dato1, dato2, dato3, dato4, dato5);
            form3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtdocu.Text = "";
            txtpro.Text = "";
            txtprecio.Text = "";
            txtplaca.Text = "";
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usuario = "simon";
            string contraseña = "admin";
            Servicios servicios = new Servicios(usuario,contraseña);
            servicios.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message =
                "Deseas Salir";
            const string caption = "Porque te vas bro";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            if (result == DialogResult.No)
            {
                //this.Hide();
                return;
            }
        }
    }
}
