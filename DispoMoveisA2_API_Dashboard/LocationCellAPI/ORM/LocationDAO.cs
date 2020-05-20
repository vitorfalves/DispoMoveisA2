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
                Altitude = Convert.ToInt64(jsonLocation.Altitude),
                Longitude = Convert.ToInt64(jsonLocation.Longitude)
            };

            InsertLocation(location);
        }

        private static void InsertLocation(Models.Location location)
        {
            SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["BI_LOCATIONCELL_Connection"].ConnectionString);

            string procName = "InsertLocation";
            SqlCommand command = new SqlCommand(procName, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@paramAltitude", SqlDbType.BigInt)).Value = location.Altitude;
            command.Parameters.Add(new SqlParameter("@paramLongitude", SqlDbType.BigInt)).Value = location.Longitude;

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