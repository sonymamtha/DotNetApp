using System;

namespace SampleWithClassSyntax
{
    public class Program
    {
        public static void Main()
        {
            var p1 = new Person("John Doe", 12);
            var p2 = new Person("Mary Doe", 8);

            p1.SayHello("John Doe");
            p1.CelebrateBirthday(12);
            p2.SayHello("Mary Doe");
            p2.CelebrateBirthday(8);
           
        }
    }
    public class Person
    {
        public Person(string nameValue, int ageValue)
        {
            name = nameValue;
            age = ageValue;
        }
        public string name{get; set;}
        public int age {get; set;}

        public void SayHello(string nameValue)
        {
            Console.WriteLine($"Hello my name is {nameValue} ");
        }

        public void CelebrateBirthday(int ageValue)
        {
            ageValue = ageValue + 1;
            Console.WriteLine($"Happy Birthday! You're now {ageValue} years old.");
        }
    }
}