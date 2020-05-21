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
    public class SensorDAO
    {
        public static void InitializeInsertSensor(JsonSensor jsonSensor)
        {
            Models.Sensor sensor = new Models.Sensor()
            {
                Luminosidade = jsonSensor.Luminosidade,
                Temperatura = jsonSensor.Temperatura,
                Umidade = jsonSensor.Umidade,
                Proximidade = jsonSensor.Proximidade
            };

            InsertSensor(sensor);
        }

        private static void InsertSensor(Models.Sensor sensor)
        {
            SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["BI_LOCATIONCELL_Connection"].ConnectionString);

            string procName = "InsertSensor";
            SqlCommand command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@paramLuminosidade", SqlDbType.NVarChar)).Value = sensor.Luminosidade;
            command.Parameters.Add(new SqlParameter("@paramTemperatura", SqlDbType.NVarChar)).Value = sensor.Temperatura;
            command.Parameters.Add(new SqlParameter("@paramUmidade", SqlDbType.NVarChar)).Value = sensor.Umidade;
            command.Parameters.Add(new SqlParameter("@paramProximidade", SqlDbType.NVarChar)).Value = sensor.Proximidade;
            command.Parameters.Add(new SqlParameter("@paramDataCriacao", SqlDbType.DateTime)).Value = DateTime.Now;

            //SqlParameter ParamId = cmd.Parameters.Add("@Id", SqlDbType.Int);
            //ParamId.Direction = ParameterDirection.InputOutput;
            //command.Parameter.Add(ParamId);

            connection.Open();
            command.ExecuteNonQuery();
            //int ID = ParamId.Value;
            connection.Close();
        }
    }
}