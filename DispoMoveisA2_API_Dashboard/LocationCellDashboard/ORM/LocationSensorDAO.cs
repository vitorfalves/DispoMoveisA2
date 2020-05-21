using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LocationCellDashboard.ORM
{
    public class LocationSensorDAO
    {
        public static List<LocationCellAPI.Models.LocationSensor> InitializeGetLocationSensor()
        {
            try
            {
                List < LocationCellAPI.Models.LocationSensor > locationSensorList = GetLocationSensor();
                return locationSensorList;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao trazer lista de informações do banco de dados, contate o administrador do site.");
            }
        }

        private static List<LocationCellAPI.Models.LocationSensor> GetLocationSensor()
        {
            SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["BI_LOCATIONCELL_Connection"].ConnectionString);
            connection.Open();

            List<LocationCellAPI.Models.LocationSensor> locationSensorList = new List<LocationCellAPI.Models.LocationSensor>();
            string procName = "GetLocationSensor";
            SqlCommand cmd = new SqlCommand(procName, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while ((dr.Read()))
            {
                LocationCellAPI.Models.LocationSensor locationSensor = new LocationCellAPI.Models.LocationSensor();
                locationSensor.Latitude = dr["Latitude"].ToString();
                locationSensor.Longitude = dr["Longitude"].ToString();
                locationSensor.Cidade = dr["Cidade"].ToString();
                locationSensor.Estado = dr["Estado"].ToString();
                locationSensor.Bairro = dr["Bairro"].ToString();
                locationSensor.Cidade = dr["Cidade"].ToString();
                locationSensor.Rua = dr["Rua"].ToString();
                locationSensor.Pais = dr["Pais"].ToString();
                locationSensor.Luminosidade = dr["Luminosidade"].ToString();
                locationSensor.Temperatura = dr["Temperatura"].ToString();
                locationSensor.Umidade = dr["Umidade"].ToString();
                locationSensor.Proximidade = dr["Proximidade"].ToString();
                locationSensorList.Add(locationSensor);
            }
            connection.Close();

            return locationSensorList;
        }
    }
}