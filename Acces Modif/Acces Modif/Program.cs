using System;
using Acces_Modif.Models;

namespace Acces_Modif
{
    internal class Program
    {
        static void Main(string[] args)
        {  Student []students=new Student[1];
            for (int i = 0; i <students.Length; i++)
            {
                Console.WriteLine("zehmet olmasa adnizi daxil edin");
                string name = Console.ReadLine();
                Console.WriteLine("zehmet olmasa soyadnizi daxil edin");
                string surname = Console.ReadLine();
                Console.WriteLine("zehmet olmasa yasnizi daxil edin");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("zehmet olmasa pointi daxil edin");
                int point = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(point, name, age)
                {
                    Surname = surname
                };
                students[i]=student;
                student.Info();

            }  
           
            


        }
    }
}
