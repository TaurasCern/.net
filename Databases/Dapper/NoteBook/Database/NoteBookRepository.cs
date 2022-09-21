using Dapper;
using Microsoft.Data.Sqlite;
using NoteBook.Database.Dapper;
using NoteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Database
{
    public class NoteBookRepository
    {
        private readonly DatabaseConfig _databaseConfig;

        public NoteBookRepository(DatabaseConfig databaseConfig)
        {
            _databaseConfig = databaseConfig;
        }

        public void Create(Models.NoteBook notebook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO NoteBook (Title, Description, CreationDateTime, Priority)
                VALUES (@Title, @Description, @CreationDateTime, @Priority);", notebook);
        }

        public IEnumerable<Models.NoteBook> Get()
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            return connection.Query<Models.NoteBook>(@"
                SELECT rowid AS Id, Title, Description, CreationDateTime, Priority
                FROM Notebook");
        }
        public int Delete(string title)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var affectedRows = connection.Execute(@"
                DELETE FROM Notebook
                WHERE Name = @Name;", new { Name = title });

            return affectedRows;
        }
    }
}
