using LocationCellAPI.JSON.Input;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LocationCellAPI.ORM
{
    public class LocationSensorDAO
    {
        public static void InitializeInsertLocationSensor(JsonLocationSensor jsonLocation)
        {
            Models.LocationSensor locationSensor = new Models.LocationSensor()
            {
                Latitude = jsonLocation.Latitude,
                Longitude = jsonLocation.Longitude,
                Bairro = jsonLocation.Bairro,
                Cidade = jsonLocation.Cidade,
                Estado = jsonLocation.Estado,
                Pais = jsonLocation.Pais,
                Rua = jsonLocation.Rua,
                Luminosidade = jsonLocation.Luminosidade,
                Temperatura = jsonLocation.Temperatura,
                Umidade = jsonLocation.Umidade,
                Proximidade = jsonLocation.Proximidade
            };

            InsertLocationSensor(locationSensor);
        }

        private static void InsertLocationSensor(Models.LocationSensor locationSensor)
        {
            SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["BI_LOCATIONCELL_Connection"].ConnectionString);

            string procName = "InsertLocationSensor";
            SqlCommand command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@paramLatitude", SqlDbType.NVarChar)).Value = locationSensor.Latitude;
            command.Parameters.Add(new SqlParameter("@paramLongitude", SqlDbType.NVarChar)).Value = locationSensor.Longitude;
            command.Parameters.Add(new SqlParameter("@paramCidade", SqlDbType.NVarChar)).Value = locationSensor.Cidade;
            command.Parameters.Add(new SqlParameter("@paramEstado", SqlDbType.NVarChar)).Value = locationSensor.Estado;
            command.Parameters.Add(new SqlParameter("@paramRua", SqlDbType.NVarChar)).Value = locationSensor.Rua;
            command.Parameters.Add(new SqlParameter("@paramBairro", SqlDbType.NVarChar)).Value = locationSensor.Bairro;
            command.Parameters.Add(new SqlParameter("@paramPais", SqlDbType.NVarChar)).Value = locationSensor.Pais;
            command.Parameters.Add(new SqlParameter("@paramLuminosidade", SqlDbType.NVarChar)).Value = locationSensor.Luminosidade;
            command.Parameters.Add(new SqlParameter("@paramTemperatura", SqlDbType.NVarChar)).Value = locationSensor.Temperatura;
            command.Parameters.Add(new SqlParameter("@paramUmidade", SqlDbType.NVarChar)).Value = locationSensor.Umidade;
            command.Parameters.Add(new SqlParameter("@paramProximidade", SqlDbType.NVarChar)).Value = locationSensor.Proximidade;
            command.Parameters.Add(new SqlParameter("@paramDataCriacao", SqlDbType.DateTime)).Value = DateTime.Now;

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}