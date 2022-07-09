﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess.DbAccess;

public class SqlAccess : ISqlAccess
{
	private readonly IConfiguration _config;

	public SqlAccess(IConfiguration config)
	{
		_config = config;
	}

	public async Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "default")
	{

		using (IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId)))
		{
			return await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
		};


	}

	public async Task SaveData<T>(string storedProcedure, T parameters, string connectionId = "default")
	{

		using (IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId)))
		{
			await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
		};

	}
}
