using System;

namespace SampleWithClassSyntax
{
    public class Program
    {
        public static void Main()
        {
            var p1 = new Person("John Doe", 12);
            var p2 = new Person("Mary Doe", 8);
            var p3 = new Person();
            var p4 = new Student("A");

            p1.SayHello("John Doe");
            p1.CelebrateBirthday(12);
            p2.SayHello("Mary Doe");
            p2.CelebrateBirthday(8);
            p3.SayHello();
            p3.CelebrateBirthday();
            p4.SayHello("Marc");
            p4.Study();
           
        }
    }
    public class Person
    {
        public static string defaultName = "Unknown";
        public static int defaultage = 0;

        public Person(string nameValue, int ageValue)
        {
            name = nameValue;
            age = ageValue;
        }
        public Person()
        {
            name = defaultName;
            age = defaultage;
        }
        private string name {get; set;}
        private int age {get; set;}

        public virtual void SayHello(string nameValue)
        {
            Console.WriteLine($"Hello my name is {nameValue} ");
        }
        public virtual void SayHello()
        {
            Console.WriteLine($"Hello my name is {defaultName} ");
        }

        public void CelebrateBirthday(int ageValue)
        {
            ageValue = ageValue + 1;
            Console.WriteLine($"Happy Birthday! You're now {ageValue} years old.");
        }
        public void CelebrateBirthday()
        {
            var ageValue = defaultage + 1;
            Console.WriteLine($"Happy Birthday! You're now {ageValue} years old.");
        }
    }

    public class Student : Person
    {
        private string grade {get; set;}

        public Student(string gradeValue)
        {
            grade = gradeValue;
        }
        public void Study()
        {
            Console.WriteLine("Studying hard for the next exam!");
        }
        public override void SayHello()
        {   
            base.SayHello();
            Console.WriteLine($"and I am in grade {grade}.");
        }
        public override void SayHello(string name)
        {   
            base.SayHello(name);
            Console.WriteLine($"and I am in grade {grade}.");
        }
    }
}