// See https://aka.ms/new-console-template for more information
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
