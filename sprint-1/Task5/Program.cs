﻿//Please, make refactoring of the code:

//We know that adult  doesn't have childIDNumber 

//child doesn't have passportNumber.

//Create a public constructor in each class to initialize all their fields (make the first parameter of type int and the second one for name initialization).

//Accessibility of the fields should be the least possible, but the same in all assemblies.

//Add ToString() method to Child and Adult classes that will return a string in the format: "name document_number"


//    public class Person
//{
//    protected string childIDNumber;
//}

//public class Child
//{
//    private int yearOfBirth;
//    private string healthInfo;
//    private string name;
//    public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
//}

//public class Adult
//{
//    private int yearOfBirth;
//    private string healthInfo;
//    private string passportNumber;
//    private string name;
//    public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
//}

namespace Task5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person Mykola = new Child(1988, "good", "Mykola", "8");
            string? status = Mykola.GetHealthStatus();
            Console.WriteLine(status);
        }

        public class Person
        {
            protected int yearOfBirth;
            protected string healthInfo;
            protected string name;
            public Person(int yearOfBirth, string name, string healthInfo)
            {
                this.yearOfBirth = yearOfBirth;
                this.healthInfo = healthInfo;
                this.name = name;
            }
            public string GetHealthStatus()
            {
                return name + ": " + yearOfBirth + ". " + healthInfo;
            }

            public override string ToString()
            {
                return this.name;
            }
        }

        public class Child : Person
        {
            private string childIDNumber;

            public Child(int yearOfBirth, string name, string healthInfo, string childIDNumber) : base(yearOfBirth, name, healthInfo)
            {
                this.yearOfBirth = yearOfBirth;
                this.healthInfo = healthInfo;
                this.name = name;
                this.childIDNumber = childIDNumber;
            }

            public override string ToString()
            {
                return base.ToString() + " " + childIDNumber;
            }

        }

        public class Adult : Person
        {
            private string passportNumber;

            public Adult(int yearOfBirth, string name, string healthInfo, string passportNumber) : base(yearOfBirth, name, healthInfo)
            {
                this.yearOfBirth = yearOfBirth;
                this.healthInfo = healthInfo;
                this.name = name;
                this.passportNumber = passportNumber;
            }

            public override string ToString()
            {
                return base.ToString() + " " + passportNumber;
            }
        }
    }
}
