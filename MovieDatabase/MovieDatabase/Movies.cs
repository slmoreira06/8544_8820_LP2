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
    /// <summary>
    /// Class utilizada para buscar todos os filmes inseridos na class Movie de modo a conretizar
    /// uma procura previamente pedida pelo utilizador e atualizar dados desses filmes
    /// </summary>
    public class Movies
    {
        #region Member Variables
        static Movie[] movieList;
        static MovieDescription[] movieRatingList;
        #endregion



        #region Constructors
        public Movies()
        {
            movieList = new Movie[500];
            movieRatingList = new MovieDescription[500];
        }

        public Movies(Movie movieList, MovieDescription movieRatingList)
        {
            this.MovieList = movieList;
            this.MovieRatingList = movieRatingList;
        }
        #endregion



        #region Properties
        public Movie MovieList { get; }
        public MovieDescription MovieRatingList { get; }
        #endregion



        /// <summary>
        /// Funções que utilizam uma string para procurar se um filme existe através do seu título, 
        /// devole o índice desse filme e poder chamar uma função dentro da class Movie ou MovieDescription
        /// para editar o Rating ou o estado do filme (visto ou não)
        /// </summary>   
        #region Functions 

        //corrigir o movieList destas funções, com erro de System Null Refference Exception
        public static Movie GetMovie(string u)
        {
            /*for (int i = 0; i < movieList.Length; i++)
            {
                if (String.Compare(u, movieList[i].Title) == 0)
                {
                    return movieList[i];
                }
            }* é o mesmo que */

            int x = GetMovieIndex(u);

            if (x != -1) return movieList[x];
            else return null;
        }
        public static int GetMovieIndex(string u)
        {
            for (int i = 0; i < movieList.Length; i++)
            {
                if (String.Compare(u, movieList[i].Title) == 0)
                {
                    return i;
                }
            }
            for (int j = 0; j < movieRatingList.Length; j++)
            {
                if (String.Compare(u, movieRatingList[j].Title) == 0)
                {
                    return j;
                }
            }
            return -1;
        }
        public static bool UpdateMovieStatus(string u, WatchList a)
        {
            int aux;
            
            aux = GetMovieIndex(u);
            if (aux != -1) 
            {
                movieList[aux].UpdateStatus(a);
                return true; 
            }
            return false;
        }
        public static bool AddMovie(Movie movie)
        {
            for (int i = 0; i < movieList.Length; i++)
            {
                if (movieList[i].Title == movie.Title) return false;
                else if (movieList[i] == null)
                {
                        movieList[i] = movie;
                        return true;
                }
            }
            return false;
        }


        //corrigir o movieReadingList destas funções, com erro de System Null Refference Exception
        public static MovieDescription GetMovieDescription(string u)
        {
            int x = GetMovieIndex(u);

            if (x != -1) return movieRatingList[x];
            else return null;
        }
        public static bool UpdateMovieRating(string u, MovieRating i)
        {
            int aux;

            aux = GetMovieIndex(u);
            if (aux != -1)
            {
                movieRatingList[aux].UpdateDescription(i);
                return true;
            }

            return false;
        }
        public static bool AddDescription(MovieDescription description)
        {
            for (int j = 0; j < movieRatingList.Length; j++)
            {
                if (movieRatingList[j].Title == description.Title) return false;
                else if (movieRatingList[j] == null)
                {
                    movieRatingList[j] = description;
                    return true;
                }
            }return false;
        }
        #endregion
    }


}
