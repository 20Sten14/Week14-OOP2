using System;
using System.IO;

namespace ObjectsFromFile
{
    class Program
    {
        class Movie
        {
            public string title;
            public string rating;
            public string year;
            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

            static void Main(string[] args)
            {
                foreach (string movie in GetDataFromFile()) 
                {

                    string[] temarrays = movie.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    Movie NewMovie = new Movie(temarrays[0], temarrays[1], temarrays[2]);

                    Console.WriteLine($"Title: {NewMovie.title},  rating {NewMovie.rating}, year: {NewMovie.year}");
                }
                Console.WriteLine($"Title:, rating:, year:");
            }
            public static string[] GetDataFromFile()
            {
                string filepath = @"C:\Users\opilane\samples\Movies.txt";
                string[] datafromfile = File.ReadAllLines(filepath);
                return datafromfile;
            }
            public static void DisplayArraysElements(string[] someArrays)
            {
                foreach (string element in someArrays)
                {
                    Console.WriteLine(element);

                }

            }
        }
    }
}
