using System;

namespace Acces_Modif.Models
{
    internal class Student : Person
    {//Student class (Person-dan miras alır)

        //- Point

        //Point təyin olunmamış bir Student obyekti yaratmaq olmaz.

        //Point dəyəri minimum 0 maximum 100 ola bilər.
        private int _point;
        public int Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                   _point = value;

                }
                else
                {
                    Console.WriteLine("Poinnt duzgun verilmemisdir");
                } 



            }
        }

        public Student(int pointt, string name, int age) : base(name, age)
        {
           Point = pointt;

        } public void Info()
        {
            Console.WriteLine($"Name : {Name}\n" +
                $"Surname  {Surname}\n" +
                $"Age : {Age}\n" +
                $"Point : {Point}");
        }
    }
}
