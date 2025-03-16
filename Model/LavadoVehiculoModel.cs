using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class LavadoVehiculoModel
    {
        private static string connectionString = "server=DESKTOP-1LDVAO4; database=ServicioVehicular; integrated security=true";

        public string Propietario { get; set; }
        public string TipoLavado { get; set; }
        public string TipoVehiculo { get; set; }
        public string DocumentoPropietario { get; set; }
        public string Placa { get; set; }
        public decimal Precio { get; set; }

        public bool Guardar()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO LavadoVehiculo (propietario, tipoLavado, tipoVehiculo, documentoPropietario, placa, precio) " +
                                   "VALUES (@propietario, @tipoLavado, @tipoVehiculo, @documentoPropietario, @placa, @precio)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@propietario", Propietario);
                    cmd.Parameters.AddWithValue("@tipoLavado", TipoLavado);
                    cmd.Parameters.AddWithValue("@tipoVehiculo", TipoVehiculo);
                    cmd.Parameters.AddWithValue("@documentoPropietario", DocumentoPropietario);
                    cmd.Parameters.AddWithValue("@placa", Placa);
                    cmd.Parameters.AddWithValue("@precio", Precio);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar en la base de datos: " + ex.Message);
            }
        }
    }
}

