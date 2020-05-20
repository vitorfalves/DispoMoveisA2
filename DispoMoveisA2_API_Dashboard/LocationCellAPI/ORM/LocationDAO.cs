using LocationCellAPI.JSON.Input;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace LocationCellAPI.ORM
{
    public class LocationDAO
    {
        public static void InitializeInsertLocation(JsonLocation jsonLocation)
        {
            Models.Location location = new Models.Location()
            {
                Latitude = jsonLocation.Latitude,
                Longitude = jsonLocation.Longitude,
                Bairro = jsonLocation.Bairro,
                Cidade = jsonLocation.Cidade,
                Estado = jsonLocation.Estado,
                Pais = jsonLocation.Pais,
                Rua = jsonLocation.Rua
            };

            InsertLocation(location);
        }

        private static void InsertLocation(Models.Location location)
        {
            SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["BI_LOCATIONCELL_Connection"].ConnectionString);

            string procName = "InsertLocation";
            SqlCommand command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@paramLatitude", SqlDbType.NVarChar)).Value = location.Latitude;
            command.Parameters.Add(new SqlParameter("@paramLongitude", SqlDbType.NVarChar)).Value = location.Longitude;
            command.Parameters.Add(new SqlParameter("@paramCidade", SqlDbType.NVarChar)).Value = location.Cidade;
            command.Parameters.Add(new SqlParameter("@paramEstado", SqlDbType.NVarChar)).Value = location.Estado;
            command.Parameters.Add(new SqlParameter("@paramRua", SqlDbType.NVarChar)).Value = location.Rua;
            command.Parameters.Add(new SqlParameter("@paramBairro", SqlDbType.NVarChar)).Value = location.Bairro;
            command.Parameters.Add(new SqlParameter("@paramPais", SqlDbType.NVarChar)).Value = location.Pais;

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