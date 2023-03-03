using MauiApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
    public class NotesPageViewModel
    { 
 
        public ObservableCollection <Note> notes { get; set; }

        public NotesPageViewModel()
        {
            notes = new ObservableCollection<Note>();

        }

        protected internal void AddSavedNote(Note noteFromEditor)
        {
            notes.Add(noteFromEditor);
        }
    }
}