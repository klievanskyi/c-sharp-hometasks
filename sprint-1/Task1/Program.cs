// See https://aka.ms/new-console-template for more information
//Please, create MyAccessModifiers class with next members:

//int field birthYear is unavailable anywhere except this class

//string field personalInfo that is accessible within descendants of this class

//string field IdNumber that is accessible only within descendants in the current assembly

//constructor should be available from everywhere in the program and accept int for birth year, string for idNumber, string for personalInfo parameters to initialize three fields mentioned above. (Note, that the order of parameters must be exact as described)

//int property Age which returns the difference between the current year and birthYear and can be accessed everywhere, but only for reading

//common for all instances of the class byte field averageMiddleAge with default value 50

//string property Name accessible anywhere in the current assembly

//string property NickName that can be read anywhere in the program and set only in the current assembly

//method HasLivedHalfOfLife available only for descendants of the class in other assemblies and for all in the current.

//overload operator ==. The operator returns true if name, age, and personalInfo  of objects are equal

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyAccessModifiers asd = new MyAccessModifiers();
        }
    }
    class MyAccessModifiers
    {
        private int birthYear;

        protected string personalInfo;

        private protected string IdNumber;

        public MyAccessModifiers()
        {
            this.birthYear = 1988;
            this.IdNumber = "1";
            this.personalInfo = "Mykola";
        }

        public MyAccessModifiers(int birthYear)
        {
            this.birthYear = birthYear;
        }

        public MyAccessModifiers(int birthYear, string IdNumber)
        {
            this.birthYear = birthYear;
            this.IdNumber = IdNumber;
        }

        public MyAccessModifiers(int birthYear, string IdNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.IdNumber = IdNumber;
            this.personalInfo = personalInfo;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.birthYear;
            }
        }

        public byte averageMiddleAge = 50;

        internal string Name
        {
            get; set;
        }

        public string NickName
        {
            get; internal set;
        }

        protected internal bool HasLivedHalfOfLife()
        {
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static bool operator == (MyAccessModifiers first, MyAccessModifiers second)
        {
            return first.Name == second.Name &&
                first.Age == second.Age &&
                first.personalInfo == second.personalInfo;
        }

        public static bool operator !=(MyAccessModifiers first, MyAccessModifiers second)
        {
            return first.Name == second.Name ||
                first.Age == second.Age ||
                first.personalInfo == second.personalInfo;
        }
    }
}
