using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string NoteText { get; set; }
        public DateTime CreationDatetime { get; set; }
        public int NotebookId { get; set; }
    }
}
