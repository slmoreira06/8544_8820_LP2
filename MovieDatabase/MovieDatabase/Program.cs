/*
 * 
 * <copyright file = "$safeitemrootname$"   Developers: Sara Moreira e Emanuel Carvalho </copyright>
 * <student number>A8544 + A8820</student>
 * <date>$time$</date>
 * <description>1st stage of the project for Programing Languages II class</description>
 * 
 */

using System;

namespace MovieDatabase
{
    class Program
    {
        /// <summary>
        /// Repositório de filmes contendo informações do filme, e do User que o publicou
        /// </summary>
        /// <param name="args">MovieDatabase</param>
        static void Main(string[] args)
        {

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("New User");
            Console.WriteLine("\nPersonal Data:");
            Person person = new Person("Sara", "Moreira", 25, Person.Genders.Female);
            Console.WriteLine(person.ToString());
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("User info:");
            User user1 = new User(person.FirstName, person.LastName, "slmoreira");
            Console.WriteLine(user1.ToString());
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Movie:");
            Movie movie = new Movie("Batman", new DateTime(1994, 02, 08), 150, WatchList.Watched, user1.UserID, user1.UserName);
            Console.WriteLine(movie.ToString());
            Movies.AddMovie(movie); //corrigir o erro em movieList
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Description:");
            MovieDescription movie1 = new MovieDescription(movie.Title, movie.Duration, MovieDescription.MovieGenre.Action,
                "Movie about a man who ate a bat", "Marvel", MovieRating._5_, "En");
            Console.WriteLine(movie1.ToString());
            //Movies.AddDescription(movie1); corrigir o erro em movieRatingList
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Display:");
            MovieDisplayInfo movie2 = new MovieDisplayInfo("Cinderella", 160,
                "https://upload.wikimedia.org/wikipedia/pt/c/c2/Cinderella_2015_official_poster.jpg",
                "http:movietrailer.com", 100);
            Console.WriteLine(movie2.ToString());

            Console.WriteLine("\nPress any key to start the video");
            Console.ReadKey();
            movie2.Play();
            Console.WriteLine("\nPress any key to stop the video");
            Console.ReadKey();
            movie2.Stop();
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //movie = Movies.GetMovie("Batman");  mesmo erro que em cima de movieList

            Console.ReadLine();

        }
    }
}
