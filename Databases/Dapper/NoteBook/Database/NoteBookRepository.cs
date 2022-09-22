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
        public int Update(int id, Models.NoteBook notebook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            var affectedRows = connection.Execute(@"
                UPDATE Notebook
                SET Title = @Title,
                    Description = @Description,
                    CreationDateTime = @CreationDateTime,
                    Priority = @Priority
                WHERE Id = @Id",
                new { Title = notebook.Title,
                      Description = notebook.Description,
                      CreationDateTime = notebook.CreationDateTime,
                      Priority = notebook.Priority,
                      Id = id });
                
            return affectedRows;
        }
        public void CreateNote(Note note)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            connection.Execute(@"
                INSERT INTO Note (NoteText, CreationDateTime, NotebookId)
                VALUES (@NoteText, @CreationDateTime, @NotebookId);", 
                new { NoteText = note.NoteText, CreationDateTime = note.CreationDatetime, NotebookId = note.NotebookId });
        }

        public IEnumerable<Note> GetNotes(Models.NoteBook notebook)
        {
            using var connection = new SqliteConnection(_databaseConfig.ConnString);

            return connection.Query<Note>(@"
                SELECT *
                FROM Note
                WHERE NotebookId = @Id", new { Id = notebook.Id });
        }
    }
}
