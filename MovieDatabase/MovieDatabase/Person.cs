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
    class Person
    {
        /// <summary>
        /// Class para criar os dados de uma pessoa que irá conter um UserName e UserID de outr class
        /// </summary>

        #region Member Variables
        private string firstName;
        private string lastName;
        private int age;
        private Genders gender;
        #endregion




        #region Constructors

        //Construtor base
        public Person()
        {
            firstName = "Random First Name";
            lastName = "Random Last Name";
            age = 0;
            gender = 0;
        }

        //Construtor para inserção de dados manuais
        public Person(string firstName, string lastName, int age, Genders gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
        }
        #endregion




        #region Properties
        public string FirstName 
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        //if para inverter o sinal caso o valor inserido para a idade seja negativo
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0) this.age = -value;
                else this.age = value;
            }
        }

        public Genders Gender
        { 
            get 
            {
                return gender;
            } 
            set 
            {
                this.gender = value;
            } 
        }
        #endregion




        #region Functions
        public override string ToString()
        {
            return String.Format("Full Name: {0} {1} - Age: {2} - Gender: {3}", this.FirstName, this.LastName, this.Age, this.Gender);

        }
        #endregion




        #region Enums
        public enum Genders
        {
            Male,
            Female
        }
        #endregion
    }
}
