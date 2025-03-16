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
    public partial class Servicios : Form

    {
        public Servicios(string usuario, string contraseña)
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                lavado lavadoForm = new lavado();
                lavadoForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de lavado: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            parqueadero parqueaderoForm = new parqueadero();
            parqueaderoForm.Show(); // Mostrar el formulario de parqueadero
            this.Hide();  // Oculta el formulario de servicios 
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            lavado lavadoForm = new lavado();
            lavadoForm.Show();
            this.Hide();
        }
    }
    }

