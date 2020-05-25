using System;

namespace basic_csharp.classesAndMethods{
    public enum Genre{Action, Adventure, Thriller, Animation, Comedy};

    class Movie{
        public string Title;
        public Genre MovieGenre;
    }
    class Enums{
        public static void Run(){
            int id = (int) Genre.Animation;
            System.Console.WriteLine(id);

            var movieToFamily = new Movie();
            movieToFamily.Title = "Sharknardo 17";
            movieToFamily.MovieGenre = Genre.Comedy;
            System.Console.WriteLine("{0} is {1}", movieToFamily.Title, movieToFamily.MovieGenre);
        }
    }
}