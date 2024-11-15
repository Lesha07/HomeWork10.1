using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input name and first name: ");
        string NameAndFirstname = Console.ReadLine();

        string[] parts = NameAndFirstname.Split(' ');

        if (parts.Length == 2)
        {
            string name = parts[0];
            string firstname = parts[1];
            if (char.ToLower(name[0]) == char.ToLower(firstname[0]))
            {
                Console.WriteLine("Last name begins with the same letter as first name");
            }
            else
            {
                Console.WriteLine("The surname does not begin with the same letter as the first name");
            }
        }
        else
        {
            Console.WriteLine("Incorect input name and first name!");
        }
    }
}