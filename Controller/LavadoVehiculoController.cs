using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class LavadoVehiculoController
    {
        public bool GuardarLavado(LavadoVehiculoModel lavado)
        {
            try
            {
                if (lavado.Guardar())
                {
                    GuardarEnArchivo(lavado);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void GuardarEnArchivo(LavadoVehiculoModel lavado)
        {
            using (StreamWriter sw = new StreamWriter("lavado.xls", true))
            {
                sw.WriteLine($"{lavado.Propietario}, {lavado.TipoLavado}, {lavado.TipoVehiculo}, {lavado.DocumentoPropietario}, {lavado.Placa}, {lavado.Precio}");
            }
        }
    }
}

