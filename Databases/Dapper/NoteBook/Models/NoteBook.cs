using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Models
{
    public class NoteBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string Priority { get; set; }

        //  connection.Execute(@"
        //          CREATE TABLE Product (
        //          Id INTEGER PRIMARY KEY AUTOINCREMENT,
        //          Title VARCHAR(100) NOT NULL,
        //          Description VARCHAR(1000) NOT NULL,
        //          CreationDateTime DATETIME DEFAULT current_timestamp,
        //          Priority VARCHAR(100) NULL);");

    }
}
