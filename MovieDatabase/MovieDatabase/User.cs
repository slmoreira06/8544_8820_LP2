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
/// Class utilizada para controlar os dados do User, 
/// sendo que o nome e o ID são inalteráveis, e o ID é automático
/// </summary>
    class User : Person
    {
        #region Member Variables
        private static int currentUserID;
        private string userName;
        private int userID;
        #endregion

        #region Constructors

        //Construtor base que vai buscar a informação do construtor base do pai
        public User():base()
        {
            userName = "Random User Name";
            userID = 0;
        }

        //Construtor para inserção de dados manuais
        public User(string firstName, string lastName,string userName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.userName = userName;
            this.userID = NextUserID();
        }

        //Auxiliar para somar os ID's dos Users
        protected int NextUserID()
        {
            return ++currentUserID;
        }
        #endregion



        #region Properties
        public string UserName 
        {
            get
            {
                return userName;
            }
            set
            {
                this.userName = value;
            }
        }

        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                this.userID = value;
            }
        }
        #endregion




        #region Functions
         public override string ToString()
        {
            return String.Format("Full Name: {0} {1} - UserID: {2} - UserName {3}", this.FirstName, this.LastName, this.userID, this.userName);
        }
        #endregion

    }
}
