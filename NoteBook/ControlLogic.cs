using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook
{
    class ControlLogic
    {
        private static Dictionary<int, Fields> _instances = new Dictionary<int, Fields>();
        static public void Start()
        {
            Console.WriteLine("Hell C++++ World! Please, select what you want to do:\n1 Create new note\n2) Edit one of previous ones\n3) Delete one of previous ones\n4) View all notes\n5) Exit");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    CreateNote();
                    break;
                case 2:
                    EditNote();
                    break;
                case 3:
                    DeleteNote();
                    break;
                case 4:
                    ViewAllNotes();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Choose something:");
                    Start();
                    break;
            }
        }
        static int count = 1;
        public static void CreateNote()
        {
            Console.Clear();
            Fields NewNote = new Fields();
            Console.WriteLine("Enter family name");
            NewNote.LastName = Console.ReadLine();
            Console.WriteLine("Enter name");
            NewNote.Name = Console.ReadLine();
            Console.WriteLine("Enter father name");
            NewNote.FathersName = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            NewNote.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter country");
            NewNote.Country = Console.ReadLine();
            Console.WriteLine("Enter date of birth");
            NewNote.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter company");
            NewNote.Company = Console.ReadLine();
            Console.WriteLine("Enter position");
            NewNote.Position = Console.ReadLine();
            Console.WriteLine("Enter miscellaneous");
            NewNote.Miscellaneous = Console.ReadLine();
            _instances.Add(count, NewNote);
            count += 1;
            Start();

        }
        public static void EditNote()
        {
            Console.Clear();
            Console.WriteLine("Select which note to edit:");
            ViewAllNotesInShort();
            Console.Write("Enter your choice: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter family name");
            _instances[x].LastName = Console.ReadLine();
            Console.WriteLine("Enter name");
            _instances[x].Name = Console.ReadLine();
            Console.WriteLine("Enter father name");
            _instances[x].FathersName = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            _instances[x].PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter country");
            _instances[x].Country = Console.ReadLine();
            Console.WriteLine("Enter date of birth");
            _instances[x].DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter company");
            _instances[x].Company = Console.ReadLine();
            Console.WriteLine("Enter position");
            _instances[x].Position = Console.ReadLine();
            Console.WriteLine("Enter miscellaneous");
            _instances[x].Miscellaneous = Console.ReadLine();
            Start();
        }
        public static void DeleteNote()
        {
            Console.Clear();
            Console.WriteLine("Select which note to delete:");
            ViewAllNotesInShort();
            Console.Write("Enter your choice: ");
            int x = Convert.ToInt32(Console.ReadLine());
            _instances.Remove(x);
            Start();
        }
        public static void ViewAllNotes()
        {
            Console.Clear();
            foreach (var person in _instances)
            {
                Console.WriteLine($"{person.Key}) {person.Value.LastName}\n{person.Value.Name}\n{person.Value.FathersName}\n{person.Value.PhoneNumber}\n{person.Value.Country}\n{person.Value.DateOfBirth}\n{person.Value.Company}\n{person.Value.Position}\n{person.Value.Miscellaneous}");
            }
            Start();
        }
        public static void ViewAllNotesInShort()
        {
            Console.Clear();
            foreach (var person in _instances)
            {
                Console.WriteLine($"{person.Key}) {person.Value.LastName}\n{person.Value.Name}\n{person.Value.PhoneNumber}");
            }
        }
    }
}
