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
    /// Class principal que contem os filmes e a sua informação principal
    /// </summary>
    public class Movie
    {
        #region Member Variables
        private  string title;
        private DateTime releaseDate;
        private int duration;
        private WatchList watched;
        private int userID;
        private string userName;
        

        #endregion



        #region Constructors

        //Construtor base
        public Movie()
        {
            title = "Insert movie title";
            releaseDate = DateTime.MinValue;
            duration = 0;
            watched = 0;
        }

        //Construtor para inserção de dados manuais
        public Movie(string title, DateTime releaseDate, int duration, WatchList watched, int userID, string userName)
        {
            this.title = title;
            this.releaseDate = releaseDate;
            this.duration = duration;
            this.watched = watched;
            this.userID = userID;
            this.userName = userName;
        }
               
        #endregion



        #region Properties

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                this.title = value;
            }
        }

        public DateTime ReleaseDate 
        {
            get 
            {
                return releaseDate;
            }
            set
            {
                this.releaseDate = value;
            }
        }

        public int Duration 
        {
            get 
            {
                return duration;
            }
            set 
            {
                this.duration = value;
            }
        }

        public WatchList Watched 
        {
            get
            {
                return watched;
            }
            set 
            {
                this.watched = value;
            }
        }

        public void UpdateStatus(WatchList watched)
        {
            this.watched = watched;
        }
        #endregion



        #region Functions
        public override string ToString()
        {
            return String.Format("{0} - Release Date {1} - Duration {2} - Watched: {3} - by: {4}{5}", 
                this.title, this.releaseDate.ToShortDateString(), this.duration, this.watched, this.userID, this.userName);
        }
           
        #endregion
        
    }

    #region Enums
    public enum WatchList
    {
        No,
        Watched,
        Later,
    }
    #endregion

}
