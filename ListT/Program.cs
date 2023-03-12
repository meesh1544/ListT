using System;
namespace listT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> apples = new List<string> { "Mackintosh", "Yellow Delicious", "Green", "Paula Red", "Ambrosia" };
            string tempName = "Fuji";
            apples.Add(tempName);
            apples.Insert(0, "Gala");

            Console.WriteLine($"There original lists has {apples.Count()}  apples");
            string[] memberArr = new string[] { "Empire", "HoneyCrisp", "Zister" };
            apples.AddRange(memberArr);
            Console.WriteLine($"The new list now has {apples.Count} apples");

            Console.WriteLine("-----Original List-----");
            for (int i = 0; i < apples.Count; i++)
                Console.WriteLine(apples[i]);

            apples.Remove("Empire");
            apples.Remove(apples[8]);

            Console.WriteLine($"The revised list now has {apples.Count()} apples");
            Console.WriteLine("-----Revised List----");
            for (int i = 0;i < apples.Count();i++)
                Console.WriteLine(apples[i]);

            apples.Sort();
            Console.WriteLine("----Sorted List----");
            foreach (string a in apples)
                Console.WriteLine(a);
            apples.Reverse();
            Console.WriteLine("----Reverse List----");
            foreach (string a in apples)
                Console.WriteLine(a);

        }
    }
}
