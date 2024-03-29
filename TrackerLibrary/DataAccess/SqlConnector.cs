﻿using Dapper;
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
        private const string connectionString = "Server=tcp:tournament-tracker-project.database.windows.net,1433;Initial Catalog=Tournaments;Encrypt=True;TrustServerCertificate=False;Connection Timeout=7600;Authentication=\"Active Directory Default\";";

        /// <summary>
        /// Saves a new prize in the database
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information and its Id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            using (IDbConnection connection = new SqlConnection(builder.ConnectionString = connectionString))
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

        public PersonModel CreatePerson(PersonModel model)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            using (IDbConnection connection = new SqlConnection(builder.ConnectionString = connectionString))
            {
                connection.Open();

                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellPhoneNumber);
                p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@Id");

                return model;
            }
        }
        
        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            using (IDbConnection connection = new SqlConnection(builder.ConnectionString = connectionString))
            {
                connection.Open();
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }
    }
}
