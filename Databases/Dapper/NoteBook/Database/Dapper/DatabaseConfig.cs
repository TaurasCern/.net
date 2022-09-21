using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Database.Dapper
{
    public class DatabaseConfig
    {
        public DatabaseConfig()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            ConnString = "Data Source=" + Path.Join(path, "NoteBook.db");
        }

        public string ConnString { get; }
    }
}
