using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class lavado : Form

    {


        public lavado()
        {
            InitializeComponent();

            string conexionstring = "server=DESKTOP-1LDVAO4\\SQLEXPRESS01; database=ServicioVehicular;integrated security=true";
            MessageBox.Show(conexionstring);
            SqlConnection conexion = new SqlConnection(conexionstring);
        }

        private LavadoVehiculoController controller = new LavadoVehiculoController();
    

        private bool ValidarCampos()
        {
            bool valido = true;
            errorLavado.Clear();

            if (string.IsNullOrWhiteSpace(txtPropietario.Text))
            {
                errorLavado.SetError(txtPropietario, "Este campo es obligatorio");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(cmbTipoDeLavado.Text))
            {
                errorLavado.SetError(cmbTipoDeLavado, "Seleccione un tipo de lavado");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(cmbTipoVehiculoLavado.Text))
            {
                errorLavado.SetError(cmbTipoVehiculoLavado, "Seleccione un tipo de vehículo");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtDocumentoPropietarioLavado.Text))
            {
                errorLavado.SetError(txtDocumentoPropietarioLavado, "Ingrese el documento del propietario");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtplaca.Text))
            {
                errorLavado.SetError(txtplaca, "Ingrese la placa del vehículo");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                errorLavado.SetError(txtprecio, "Ingrese el precio del lavado");
                valido = false;
            }
            
            return valido;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            //if (cmbTipoDeLavado == "")
            if (!ValidarCampos()) return;

            LavadoVehiculoModel lavado = new LavadoVehiculoModel
            {
                Propietario = txtPropietario.Text,
                TipoLavado = cmbTipoDeLavado.Text,
                TipoVehiculo = cmbTipoVehiculoLavado.Text,
                DocumentoPropietario = txtDocumentoPropietarioLavado.Text,
                Placa = txtplaca.Text,
                Precio = decimal.Parse(txtprecio.Text)
            };

            if (controller.GuardarLavado(lavado))
            {
                MessageBox.Show("Guardado exitosamente 👍");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string dato1 = txtPropietario.Text;
            string dato2 = cmbTipoDeLavado.Text;
            string dato3 = cmbTipoVehiculoLavado.Text;
            string dato4 = txtDocumentoPropietarioLavado.Text;
            string dato5 = txtplaca.Text;
            string dato6 = txtprecio.Text;

            verlavado lavado = new verlavado(dato1, dato2, dato3, dato4, dato5, dato6);
            lavado.Show();
            this.Hide();
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtPropietario.Clear();
            cmbTipoDeLavado.SelectedIndex = -1;
            cmbTipoVehiculoLavado.SelectedIndex = -1;
            txtDocumentoPropietarioLavado.Clear();
            txtplaca.Clear();
            txtprecio.Clear();
            errorLavado.Clear();
        }
        private void lavado_Load(object sender, EventArgs e)
        { }
    }
    
}
    







