using System;

namespace Selections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            string age = Console.ReadLine();

            int ageNum = int.Parse(age);

            if (ageNum > 17) {

                Console.Write("Please enter your gender: ");
                string gender = Console.ReadLine();

                if (gender == "M") {
                    Console.WriteLine("M is an adult");
                } else if (gender == "F"){
                    Console.WriteLine("F is an adult");
                } else {
                    Console.WriteLine("Please enter M or F");
                }
            } else {
                Console.WriteLine("Legally not adult age");
            }
        }
    }
}
