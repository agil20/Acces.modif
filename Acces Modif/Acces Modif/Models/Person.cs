using System;

namespace Acces_Modif.Models
{
    internal class Person
    {
        private string _name;
        private string _surname;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (NameSurname(value) == true && value.Length >= 3 && value.Length <= 30)
                {
                    _name = value;
                }
                else
                {
                     Console.WriteLine("Name duzgun deyildir");
                }
            }

        } //Name dəyəri minumum 3 maximum 30 hərfdən ibarət ola bilər.
        public string Surname //Surname dəyəri minumum 3 maximum 35 hərfdən ibarət ola bilər.
        {
            get
            { return _surname;
            }
            set
            {
                if (NameSurname(value)==true && value.Length >= 3 && value.Length <= 35)
                {
                    _surname = value;
                }
                else
                {
                     Console.WriteLine("surname duzgun verilmemisdir");
                }
            }
        }
        public int Age { get; set; }
        public Person(string name, int age)   //Name və Age təyin olunmamış bir Person obyekti yaratmaq olmaz.
        {
            Name = name; Age = age;

        }
        //Name və Surname dəyərləri mütləq böyük hərf ilə başlamalıdı.
        public bool NameSurname(string word) //name ve surname ucun bir metod yaratdim
        {
            bool a;
            bool b = Char.IsUpper(word[0]);
            if (b==true)
            {
                a = true;

            }
            else
            {
                a = false;
            }
            return a;





        }

    }
}
