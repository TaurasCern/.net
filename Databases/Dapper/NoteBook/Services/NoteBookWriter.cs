using NoteBook.Database;
using NoteBook.Database.Dapper;
using NoteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook.Services
{
    public class NoteBookWriter : INoteBookWriter
    {
        private readonly DatabaseConfig _databaseConfig;
        private readonly NoteBookRepository _notebookRepository;

        public NoteBookWriter()
        {
            _databaseConfig = new DatabaseConfig();
            _notebookRepository = new NoteBookRepository(_databaseConfig);
        }

        public void Run()
        {
            char selection;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add notebook");
                Console.WriteLine("2. List notebooks");
                Console.WriteLine("3. Remove notebooks by name");
                Console.WriteLine("4. Update notebooks by id");
                Console.WriteLine("5. Add note to a notebook");
                Console.WriteLine("q. Quit");

                selection = Console.ReadKey().KeyChar;

                switch (selection)
                {
                    case '1':
                        AddNotebooks();
                        break;
                    case '2':
                        DisplayNotebooks();
                        break;
                    case '3':
                        RemoveNotebook();
                        break;
                    case '4':
                        UpdateNotebook();
                        break;
                    case '5':
                        AddNote();
                        break;
                    case 'q':
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                PauseScreen();
            }
        }
        public void DisplayNotebooks()
        {
            var notebooks = _notebookRepository.Get();

            foreach (var notebook in notebooks)
            {
                Console.WriteLine($"{notebook.Id}. {notebook.Title} - {notebook.Description}");
                foreach (var note in _notebookRepository.GetNotes(notebook))
                {
                    Console.WriteLine($"    {note.Id}. {note.NoteText}");
                }
            }
        }

        public void AddNotebooks()
        {
            var newProduct = new Models.NoteBook();
            Console.WriteLine("enter name:");
            newProduct.Title = Console.ReadLine();
            Console.WriteLine("enter description:");
            newProduct.Description = Console.ReadLine();


            _notebookRepository.Create(newProduct);
            Console.WriteLine("irasas pridetas");
        }
        private void PauseScreen()
        {
            Console.WriteLine("{0}{1}Press any key to continue..", Environment.NewLine, Environment.NewLine);
            Console.ReadKey();
        }
        public void RemoveNotebook()
        {
            Console.WriteLine("enter name to be deleted:");
            var nameToDelete = Console.ReadLine();


            var notebooksDeletedCount = _notebookRepository.Delete(nameToDelete);
            Console.WriteLine("isttrintu irasu kieki: {0}", notebooksDeletedCount);
        }
        public void UpdateNotebook()
        {
            Console.WriteLine("enter id to be updated:");
            var idToDelete = int.Parse(Console.ReadLine());

            Console.WriteLine("title:");
            var title = Console.ReadLine();

            Console.WriteLine("description:");
            var description = Console.ReadLine();

            Console.WriteLine("priority:");
            var priority = Console.ReadLine();

            var notebookUpdate = new Models.NoteBook() { Title = title, Description = description, Priority = priority };

            var notebooksDeletedCount = _notebookRepository.Update(idToDelete, notebookUpdate);
            Console.WriteLine("atnaujintu irasu kiekis: {0}", notebooksDeletedCount);
        }
        public void AddNote()
        {
            Console.WriteLine("enter notebook id:");
            var notebookId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter note text:");
            var noteText = Console.ReadLine();

            var newNote = new Note() { NoteText = noteText, NotebookId = notebookId };

            _notebookRepository.CreateNote(newNote);
        }
    }
}
