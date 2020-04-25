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
    public class MovieDescription: Movie
    {
        #region Member Variables
        private MovieGenre genre;
        private string sinopse;
        private string production;
        private MovieRating rating;
        private string language;
        #endregion





        #region Constructors
        //Construtor base que vai buscar a informação do construtor base do pai
        public MovieDescription():base()
        {
            genre = 0;
            sinopse = "Please insert the description of the movie";
            production = "Please insert the company which produced the movie";
            rating = MovieRating._0_;
            language = "En";
        }

        public MovieDescription(string title, int duration, MovieGenre genre, string sinopse, string production, MovieRating rating, string language)
        {
            this.Title = title;
            this.Duration = duration;
            this.genre = genre;
            this.sinopse = sinopse;
            this.production = production;
            this.rating = rating;
            this.language = language;
        }
        #endregion




        #region Properties

        public string Language 
        {
            get
            {
                return language;
            }
            set
            {
                this.language = value;
            }
        }

        public MovieGenre Genre
        {
            get
            {
                return genre;
            }
            set
            {
                this.genre = value;
            }
        }

        public string Sinopse 
        {
            get 
            {
                return sinopse;
            }
            set
            {
                this.sinopse = value;
            }      
        }

        public string Production 
        { 
            get 
            {
                return production;
            } 
            set 
            {
                this.production = value;
            } 
        }

        public void UpdateDescription(MovieRating rating)
        {
            this.rating = rating;
        }

        #endregion




        #region Functions
        public override string ToString()
        {
            return String.Format("{0} - Duration {1} - Genre: {2} \nSinopse: {3} \nProduction: {4} - Rating: {5} - Language: {6}",
                this.Title, this.Duration, this.genre, this.sinopse, this.production, this.rating, this.language);
        }
        #endregion




        #region Enums
        public enum MovieGenre
        {
            Action,         //0
            Animation,      //1
            Comedy,         //2
            Crime,          //3
            Drama,          //4
            Experimental,   //5
            Fantasy,        //6
            Historical,     //7
            Horror,         //8
            Romance,        //9
            SciFi,          //10
            Thriller,       //11
            Western,        //12
            Other,          //13
        }
        #endregion

    }
    #region Enums
    public enum MovieRating
    {
        _0_,
        _1_,
        _2_,
        _3_,
        _4_,
        _5_,
        _6,
        _7_,
        _8_,
        _9_,
        _10_,
    }
    #endregion
}