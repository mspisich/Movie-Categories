using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string title;
        private string category;

        public Movie(string title, string category)
        {
            SetTitle(title);
            SetCategory(category);
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public void SetCategory(string category)
        {
            this.category = category;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public void PrintTitle()
        {
            string title = GetTitle();
            Console.WriteLine(title);
        }

        public string GetCategory()
        {
            return this.category;
        }
    }
}
