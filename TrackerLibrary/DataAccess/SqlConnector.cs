using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize in the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information and its Id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            using (IDbConnection connection = new SqlConnection(builder.ConnectionString = "Server=tcp:tournament-tracker-project.database.windows.net,1433;Initial Catalog=Tournaments;Encrypt=True;TrustServerCertificate=False;Connection Timeout=1200;Authentication=\"Active Directory Default\";"))
            {
                connection.Open();

                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }
    }
}
