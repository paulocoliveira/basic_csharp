using System;
using System.Collections.Generic;

namespace basic_csharp.collections{
    class UsingDictionaries{
        public static void Run(){
            var movies = new Dictionary<int, string>();
            movies.Add(2000, "Gladiator");
            movies.Add(2002, "Spiderman");
            movies.Add(2004, "The Incredibles");
            movies.Add(2006, "The Prestige");

            System.Console.WriteLine("2004: " + movies[2004]);
            System.Console.WriteLine("2008: " + movies.GetValueOrDefault(2008));
            
            System.Console.WriteLine(movies.ContainsValue("Amnesia"));

            System.Console.WriteLine($"Removed? {movies.Remove(2004)}");

            movies.TryGetValue(2006, out string movie2006);
            System.Console.WriteLine($"Movie: {movie2006}!");

            foreach (var key in movies.Keys){
                System.Console.WriteLine(key);
            }

            foreach (var value in movies.Values){
                System.Console.WriteLine(value);
            }

            foreach (KeyValuePair<int, string> movie in movies){
                System.Console.WriteLine($"{movie.Value} is from {movie.Key}");
            }

            foreach (var movie in movies){
                System.Console.WriteLine($"{movie.Value} is from {movie.Key}");
            }

        }
    }
}