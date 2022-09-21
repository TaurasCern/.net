using Dapper;
using DapperExample.Database.Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExample.Database 
{
    public class DatabaseBootStrap : IDatabaseBootstrap
    {
        private readonly DatabaseConfig _databaseConfig;
        public DatabaseBootStrap(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public void Setup()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);


            var table = connection.Query<string>(@"
                SELECT name
                FROM sqlite_master
                WHERE type = 'table'
                    AND name = 'Product';");
            var tableName = table.FirstOrDefault();
            if(!string.IsNullOrEmpty(tableName) && tableName == "Product") { return; }

            connection.Execute(@"
                CREATE TABLE Product (
                Name VARCHAR(100) NOT NULL,
                Description VARCHAR(1000) NULL);");
        }
    }
}
