﻿//There are children that stand in a circle. They use a counter to get them one by one out of the circle. Counter characteristic is a number of syllables. Children cont themselves with the counter and the child on whom the counter ends, leaves the circle.

//You need to create class CircleOfChildren, add a constructor with IEnumerable<string> parameter that will represent children in the circle.

//Add named iterator  GetChildrenInOrder that takes two int parameters: first for syllables count and second for a count of children that should leave the circle.

//if syllables count is equal to or less than 0 than no children leave the circle.

//We should be able to call GetChildrenInOrder with only one parameter. In this case, all children leave the circle. 

//If the second parameter is bigger than the total amount of children in a circle than all children should leave the circle. The same with 0 or less value.


//For example, we have a circle with nicknames: Halya1,  Olya2, Ira3, Andriy4, Josh5 and suppose, all children should leave the circle. The counter has 3 syllables.

//Then exit order should be: Ira3, Halya1, Josh5, Olya2, Andriy4

//Also create OutputUtils class with static ExitOutput method that takes 3 parameters: CircleOfChildren, syllables count and count of children that should leave the circle

//The last parameter - optional.

//The method should print to console the names of children in the order of their living the circle. Print space after every name.

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] child = { "Halya1", "Olya2", "Ira3", "Andriy4", "Josh5" };
            CircleOfChildren circleOfChildren = new CircleOfChildren(child);
            OutputUtils.ExitOutput(circleOfChildren, 3);
        }
    }

    public class CircleOfChildren
    {
        List<string> children { get; set; }

        public CircleOfChildren(IEnumerable<string> children)
        {
            this.children = children.ToList();
        }

        public IEnumerable GetChildrenInOrder(int syllables, int countOfChildren = default)
        {
            int countToRemoveKids = children.Count();
            if (syllables <= 0)
            {
                yield break;
            }
            else if (countOfChildren != 0)
            {
                countToRemoveKids = countOfChildren < children.Count ? countOfChildren : children.Count;
            }

            int index = 0;
            while (countToRemoveKids > 0)
            {
                index = (index + syllables - 1) % children.Count;

                yield return children.ElementAt(index);

                children.RemoveAt(index);
                countToRemoveKids--;
            }
        }
    }

    public class OutputUtils
    {
        public static void ExitOutput(CircleOfChildren children, int syllables, int countOfChildren = default)
        {
            foreach (var kid in children.GetChildrenInOrder(syllables, countOfChildren))
            {
                Console.WriteLine(kid + " ");
            }
        }
    }
}