using System;

namespace ThreeStrings
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please answer the below questions.\n");
			Console.Write("Enter your street number: ");
			string streetNumber = Console.ReadLine();

			Console.Write("Enter your street address: ");
			string streetAddress = Console.ReadLine();

			Console.Write("Enter your city: ");
			string city = Console.ReadLine();

			string address = streetNumber + " " + streetAddress + " " + city;

			Console.WriteLine("\nYour address is " + address + ".");
			Console.ReadLine();
        }
    }
}
