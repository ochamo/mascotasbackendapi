﻿using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DataAccess.DBAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration config;

        public SqlDataAccess(IConfiguration config)
        {
            this.config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, P>(string sql, P parameters, string connectionId = "Default")
        {
            using MySqlConnection connection = new MySqlConnection(config.GetConnectionString(connectionId));

            return await connection.QueryAsync<T>(sql, parameters, commandType: CommandType.StoredProcedure);

        }

        public async Task SaveData<T>(string sql, T data, string connectionId = "Default")
        {
            using MySqlConnection connection = new MySqlConnection(config.GetConnectionString(connectionId));

            await connection.QueryAsync<T>(sql, data, commandType: CommandType.StoredProcedure);

        }
    }
}
