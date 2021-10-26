using System;
using System.Collections.Generic;

namespace Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            //Movie m = new Movie("Shrek", Genre.Comedy, 105, "Get out of my swamp", "Donkey shows up", "They visit the dragon");
            // m.PrintInfo();
          //  Console.WriteLine(m);
          //  m.PrintScenes();
            Console.WriteLine("Here's some info on Tommy Boy:\n");
            VHS d = new VHS("Tommy Boy", Genre.Comedy, 120, "He flunks college", "He sells stuff", "David spade is sarcastic");
            d.PrintInfo();

            Console.WriteLine("\nNow we'll play the movie:\n");
            d.Play();

            Console.WriteLine("\nWould you like to see a [V]Hs...:");

            //initializing blockbuster:
            Blockbuster blockbuster = new Blockbuster();


            List<VHS> VHSmovies = new List<VHS>();

            //for (int i = 0; i < VHSmovies.Count; i++)
            //{
            //    PrintInfo(vhsMovies);
            //}

            

            //Blockbuster store = new Blockbuster();
            //List<Movie> results = store.SearchByGenres();



            //store.GetMovie(4);
        }
    }
}
