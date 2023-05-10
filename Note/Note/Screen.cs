using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note
{
    class Screen
    {
        List<Note> notes = new List<Note>();
        List<NoteLink> notesLinks = new List<NoteLink>();

        public Screen()
        {
            notes.Add(new Note { Title = "hej jeg er note 1", Content = "Hello Hello Hello", Tags = new Tag { Tags = "Tag1" } });
            notes.Add(new Note { Title = "hej jeg er note 2", Content = "Bye Bye Bye", Tags = new Tag { Tags = "Tag2" } });
            notes.Add(new Note { Title = "hej jeg er note 3", Content = "Bye Bye Bye", Tags = new Tag { Tags = "Tag2" } });
            notes.Add(new Note { Title = "hej jeg er note 4", Content = "Bye Bye Bye", Tags = new Tag { Tags = "Tag2" } });

            notesLinks.Add(new NoteLink { Title = "hej jeg er note 4", Content = "Bye Bye Bye", Tags = new Tag { Tags = "Tag2" }, Link = "https://www.dr.dk/drtv/" });
        }

        //Controller
        public void ScreenControler()
        {
            int notesCount = notes.Count();
            Console.Clear();

            Console.WriteLine("Velkommen til noter");
            Screen.Menu();

            Console.Write(">");
            string lineReadString = Console.ReadLine();
            //response, screen to se after, max written number in console
            int response = IntConverter(lineReadString, "Screen", 3);

            //See note
            if(response == 1)
            {
                ShowNotes();
                Console.Write(">");
                lineReadString = Console.ReadLine();
                response = IntConverter(lineReadString, "ShowNotes", notesCount);

                //Show note that has this
                ShowNote(response);

                Console.Write(">");
                Console.ReadKey();
                ScreenControler();
            }
            //Create note
            else if (response == 2)
            {
                CreateNotes();

                Console.Write(">");
                Console.ReadKey();
                ScreenControler();

            }
            //Create Link note
            else if (response == 3)
            {
                CreateLinkNotes();

                Console.Write(">");
                Console.ReadKey();
                ScreenControler();

            }
            Console.ReadKey();
        }

        //Main menu
        private static void Menu()
        {
            Console.WriteLine("1) - Se noter");
            Console.WriteLine("2) - Opret noter");
            Console.WriteLine("3) - Opret link noter");

        }

        //Show Notes
        private void ShowNotes()
        {
            Console.Clear();
            foreach (Note note in notes)
            {
                Console.WriteLine($"({note.Id}) - {note.Title}");
            }
            Console.WriteLine("To see note enter number");
        }
        
        //Show Note
        private void ShowNote(int NoteId)
        {
            Console.Clear();
            //Find note on Id (Helped from google, indstead of (Console.WriteLine("Title: " + notes[NoteId].Title);)
            var filteredNotes = notes.Where(notes => notes.Id == NoteId);
            var note = filteredNotes.First();
            Console.WriteLine("---------");
            Console.WriteLine("Tryk på en vilkårlig tast for at gå tilbage");
            Console.WriteLine("---------");

            Console.WriteLine($"Title: {note.Title}");
            Console.WriteLine("");
            Console.WriteLine("Note:");
            Console.WriteLine(note.Content);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Tag: {note.Tags.Tags}");
        }
        
        //Create Notes
        private void CreateNotes()
        {
            Console.Clear();
            Console.WriteLine($"Enter a title");
            Console.Write(">");
            string lineReadTitleString = Console.ReadLine();

            Console.WriteLine($"Enter note");
            Console.Write(">");
            string lineReadNoteString = Console.ReadLine();


            Console.WriteLine($"Enter tags");
            Console.Write(">");
            string lineReadTagString = Console.ReadLine();

            notes.Add(new Note { Title = lineReadTitleString, Content = lineReadNoteString, Tags = new Tag { Tags = lineReadTagString } });
            Console.WriteLine("---------");
            Console.WriteLine("Tryk på en vilkårlig tast for at gå tilbage");
            Console.WriteLine("---------");
        }

        //Create Link Notes
        private void CreateLinkNotes()
        {


            Console.Clear();
            Console.WriteLine($"Enter a title");
            Console.Write(">");
            string lineReadTitleString = Console.ReadLine();

            Console.WriteLine($"Enter note");
            Console.Write(">");
            string lineReadNoteString = Console.ReadLine();

            Console.WriteLine($"Enter Link");
            Console.Write(">");
            string lineReadLinkString = Console.ReadLine();

            Console.WriteLine($"Enter tags");
            Console.Write(">");
            string lineReadTagString = Console.ReadLine();

            notesLinks.Add(new NoteLink { Title = lineReadTitleString, Content = lineReadNoteString, Tags = new Tag { Tags = lineReadTagString }, Link = lineReadLinkString });
            Console.WriteLine("---------");
            Console.WriteLine("Tryk på en vilkårlig tast for at gå tilbage");
            Console.WriteLine("---------");
        }

        //Try convert to int and menu condition else Error
        private int IntConverter(string response, string WhatScreen, int maxResponseNumber)
        {
            int newInt;
            int.TryParse(response, out newInt);
            if(newInt <= 0 || newInt > maxResponseNumber)
            {
                Error(response, WhatScreen);
                return -1;
            }
            return newInt;
        }

        //Error Screen
        private void Error(string enteredResponse,string WhatScreen)
        {
            Console.Clear();
            Console.WriteLine($"Undskyld, '{enteredResponse}' er ikke et gyldigt svar");
            Console.WriteLine($"Tryk på en vilkårlig tast for at gå tilbage");
            Console.Write(">");
            Console.ReadKey();
            if (WhatScreen == "Screen")
            {
                ScreenControler();
            }
            else if (WhatScreen == "ShowNotes")
            {
                ShowNotes();
            } 
        }
    }
}