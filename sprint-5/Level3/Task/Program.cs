//Note! this is additional task that requires understanding of HashSet, so please, read the article: HashSet before implementing the task.
//https://www.dotnetcurry.com/csharp/1362/hashset-csharp-with-examples

//Implement class Student : add the constructor (with field initializations) and necessary methods into it.

//Add public static GetCommonStudents() method to Student class that returns a HashSet of common elements of two student lists.

//For example, for a given list1 [Student [Id=1, Name=Ivan], Student[Id = 2, Name = Petro], Student[Id = 3, Name = Stepan]] and list2[Student[Id = 1, Name = Ivan], Student[Id = 3, Name = Stepan], Student[Id = 4, Name = Andriy]] you should get [Student [Id=3, name=Stepan], Student[Id = 1, Name = Ivan]].

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Student
    {
        public int Id { get; }
        public string Name { get; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static HashSet<Student> GetCommonStudents(List<Student> fisrtList, List<Student> secondList)
        {
            HashSet<Student> firstStudents = new HashSet<Student>(fisrtList);
            HashSet<Student> secondStudents = new HashSet<Student>(secondList);
            firstStudents.IntersectWith(secondStudents);
            return firstStudents ?? null;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Student student = obj as Student;
            return Id == student.Id && Name == student.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}
