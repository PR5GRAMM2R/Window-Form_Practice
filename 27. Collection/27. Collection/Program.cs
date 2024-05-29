using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            Console.WriteLine("Count : {0}", myAL.Count);
            Console.WriteLine("Capacity : {0}", myAL.Capacity);
            Console.Write("Values :");
            PrintValues(myAL);
        }

        static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
            {
                Console.Write(" {0}", obj);
            }
            Console.WriteLine();
        }
    }
}