

namespace SyntaxSugarDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicit typing
            int number = 10;
            string word;

            //Inferred typing
            var thing = false;
            var otherThing = 33;


            //Inline if/Ternary operator

            var age = 30;

            Console.WriteLine(age >= 18 ? "You're an adult" : age < 5 ? "You're a baby" : "You're a minor");

            //String interpolation vs concatenation

            var middleInitial = 'S';

            Console.WriteLine($"Brandon {middleInitial} Bowman");
            Console.WriteLine("Brandon" + " " + middleInitial + " " + "Bowman");
        }
    }
}
