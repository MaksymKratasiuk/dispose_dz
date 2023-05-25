using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispose_dz
{
    public class Play : IDisposable
    {
        

        public StringBuilder Title { get; set; }
        public StringBuilder Author{ get; set; }
        public StringBuilder Genre{ get; set; }
        public StringBuilder Year{ get; set; }

        public Play()
        {
           Title = new StringBuilder();
            Author = new StringBuilder();
            Genre = new StringBuilder();
            Year = new StringBuilder();
        }

        

        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Year: " + Year);
            
        }

        public void Dispose()
        {
            Title.Clear();
            Author.Clear();
            Genre.Clear();

        }

        ~Play()
        {
            Dispose();
        }
    }

    internal class Task1
    {
        public static void task1()
        {
            using(var play = new Play())
            {
                play.Title.Append("Romeo and Juliet");
                play.Author.Append("William Shakespeare");
                play.Genre.Append("Tragedy");
                play.Year.Append("1597");
                play.Display();
            }



        }

    }
}
