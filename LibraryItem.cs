using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LibraryItem
    {
        string title;
        string author;
        bool isAvailable;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

        public LibraryItem(string title, string author, bool isAvailable)
        {
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }
        public string GetItemType() {  return title; }
    }
}
