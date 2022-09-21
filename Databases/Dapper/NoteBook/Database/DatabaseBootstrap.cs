using Dapper;
using Microsoft.Data.Sqlite;
using NoteBook.Database.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Database
{
    public class DatabaseBootstrap
    {
        private readonly DatabaseConfig _databaseConfig;
        public DatabaseBootstrap(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public void Setup()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);


            var tableName = connection.Query<string>(@"
                SELECT name
                FROM sqlite_master
                WHERE type = 'table'
                    AND name = 'Notebook';").FirstOrDefault();
            if (!string.IsNullOrEmpty(tableName) && tableName == "Product") { return; }
            connection.Execute(@"
                CREATE TABLE Notebook (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Title VARCHAR(100) NOT NULL,
                Description VARCHAR(1000) NOT NULL,
                CreationDateTime DATETIME DEFAULT current_timestamp,
                Priority VARCHAR(100) NULL);");
        }
    }
}
