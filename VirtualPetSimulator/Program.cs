using System;

class Program
{
    public static void Main(string[] args)
    {
        int pet_type;
        string pet1 = "Dog";
        string pet2 = "Cat";
        string pet3 = "Horse";
        Console.WriteLine("\n\n\n\n-----------------Welcome to Virtual Pet Simulator------------");
        Console.WriteLine("\n\n----------------------------------------");
        Console.WriteLine($"Please choose a type of pet: \n1. {pet1}\n2. {pet2}\n3. {pet3}");
        Console.WriteLine("----------------------------------------");

        while (true)
        {
            Console.Write("Enter the number of your pet: ");

            if (int.TryParse(Console.ReadLine(), out pet_type))
            {
                if (pet_type == 1)
                {
                    Console.WriteLine($"You've chosen a {pet1}. What would you like to name your pet?");
                    break;
                }
                else if (pet_type == 2)
                {
                    Console.WriteLine($"You've chosen a {pet2}. What would you like to name your pet?");
                    break;
                }
                else if (pet_type == 3)
                {
                    Console.WriteLine($"You've chosen a {pet3}. What would you like to name your pet?");
                    break;
                }
                else
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("***Invalid input. Please enter the number between 1 to 3***");
                    Console.WriteLine("----------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("***Invalid Input. Please enter valid integer***");
                Console.WriteLine("----------------------------------------");
            }
        }



    }
}