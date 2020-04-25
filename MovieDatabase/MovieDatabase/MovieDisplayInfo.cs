/*
 * 
 * <copyright file = "$safeitemrootname$"   Developers: Sara Moreira e Emanuel Carvalho </copyright>
 * <student number>A8544 + A8820</student>
 * <date>$time$</date>
 * <description>1st stage of the project for Programing Languages II class</description>
 * 
 */


using System;
using System.Threading;

namespace MovieDatabase
{
    /// <summary>
    /// Class filha de Movie que contém os dados multimédia do filme, como cartaz e trailer,
    /// inclui um timer com o segundo atualizado do trailer a decorrer
    /// </summary>
    class MovieDisplayInfo:Movie
    {
        #region Member Variables
        private string moviePosterURL;
        private string movieTrailerURL;
        private int movieTrailerLenght;
        private bool trailerIsPlaying = false;
        private int currentDuration = 0;
        Timer timer;
        #endregion



        #region Constructors

        //Construtor vazio pois não estamos a chamar a class base explicitamente, logo o construtor base do pai vai ser implicito
        public MovieDisplayInfo() { }

        //Construtor para inserção de dados manuais
        public MovieDisplayInfo(string title, int duration, string moviePosterURL, string movieTrailerURL, int movieTrailerLenght) 
        {
            this.Title = title;
            this.Duration = duration;
            this.moviePosterURL = moviePosterURL;
            this.movieTrailerURL = movieTrailerURL;
            this.movieTrailerLenght = movieTrailerLenght;
        }
        #endregion




        #region Properties
        public string MoviePosterURL 
        { 
            get 
            {
                return moviePosterURL;
            } 
            set 
            {
                this.moviePosterURL = value;
            }
        }
        public string MovieTrailerURL 
        {
            get
            {
                return movieTrailerURL;
            }
            set
            {
                this.movieTrailerURL = value;
            }
        }
        #endregion




        #region Functions
        /// <summary>
        /// Funções Play, Stop e TimerCallback para simular o clique no play e stop do trailer do filme,
        /// com contagem dos segundos reproduzidos do vídeo
        /// </summary>
        public void Play() 
        {
            if (!trailerIsPlaying)
            {
                trailerIsPlaying = true;
                Console.WriteLine("Trailer is currently playing!");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object trailer)
        {
            if(currentDuration < movieTrailerLenght)
            {
                currentDuration++;
                Console.WriteLine("Movie Trailer at {0}s", currentDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()  
        {
            if (trailerIsPlaying)
            {
                trailerIsPlaying = false;
                Console.WriteLine("Stopped at {0}s", currentDuration);
                currentDuration = 0;
                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - Duration {1} \n Movie Poster: {2} \n Movie Trailer: {3}", 
                this.Title, this.Duration, this.moviePosterURL, this.movieTrailerURL);

        }
        #endregion



    }
}
