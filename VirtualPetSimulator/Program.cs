﻿using System;

class Program
{   
    public static void Main(string[] args)
    {
        // Declaring the variables and initializing the pet types
        int pet_type;
        string pet1 = "Dog";
        string pet2 = "Cat";
        string pet3 = "Horse";

        //Displaying the welcome message 
        Console.WriteLine("\n\n\n\n-----------------Welcome to Virtual Pet Simulator------------");
        Console.WriteLine("\n\n----------------------------------------");
        Console.WriteLine($"Please choose a type of pet: \n1. {pet1}\n2. {pet2}\n3. {pet3}");
        Console.WriteLine("----------------------------------------");

        //This loop will run until the user provides valid input
        while (true)
        {
            Console.Write("Enter the number of your pet: ");

            //Getting the user input and storing it in pet_type. 
            if (int.TryParse(Console.ReadLine(), out pet_type))
            {
                //Checking the pet selected by user and asking for the name
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
                Console.WriteLine("***Invalid Input. Please enter valid number***");
                Console.WriteLine("----------------------------------------");
            }
        }

        //Getting the pet name from the user
        string petName = Console.ReadLine();
        Console.WriteLine("----------------------------------------");
        Console.Write("Pet Name: ");
        Console.WriteLine($"Nice name, {petName}! Let's take a look on what we can do with {petName}.");
        Console.WriteLine("----------------------------------------");

        int petAction;

        // Initializing the level of the pet
        int hunger_level = 1;
        int happiness_level = 6;
        int health_level = 9;
        int time = 0;
        int limit = 3;

        //
        while (true)
        {
            if (time >= limit)
            {
                
                Console.WriteLine($"{time} hours has passed. {petName}'s hunger has increased and happiness has decreased.");
                if (hunger_level == 10)
                {
                    hunger_level = 10;
                }
                else
                {
                    hunger_level++;
                }

                if (happiness_level == 0)
                {
                    happiness_level = 0;
                }
                else
                {
                    happiness_level--;
                }
                time = 0; // Reset the time
            }

            Console.WriteLine($"Main Menu: \n1. Feed {petName}\n2. Play with {petName}\n3. Let {petName} Rest");
            Console.WriteLine($"4. Check {petName}'s Status\n5. Exit\n");
            Console.Write("Enter your choice: ");

            
            //takes integer input else throws exception
            if (int.TryParse(Console.ReadLine(), out petAction))
            {
                switch(petAction)
                {
                    case 1://Feed
                        if (hunger_level == 10)
                        {
                            Console.WriteLine($"{petName} is refusing to eat as he is full right now");
                            break;
                        }
                        else
                        {
                            //Action for feeding the pet
                            Console.WriteLine($"Thanks for feeding {petName}. His hunger is gonna decrease and health increases.");
                            if (hunger_level == 0)
                            {
                                hunger_level = 0;
                            }
                            else
                            {
                                hunger_level--;
                            }

                            if (health_level == 10)
                            {
                                health_level = 10;
                            }
                            else
                            {
                                health_level++;
                            }
                            time++;
                            
                            break;
                        }
                        
                    case 2:
                        //Action for playing with pet
                        Console.WriteLine($"Thanks for playing with {petName}. His hunger level and happiness is going to increase.");

                        if (hunger_level == 10)
                        {
                            hunger_level = 10;
                        }
                        else
                        {
                            hunger_level++;
                        }

                        if (happiness_level == 10)
                        {
                            happiness_level = 10;
                        }
                        else
                        {
                            happiness_level++;
                        }
                        time++;
                        break;
                    case 3:
                        //Action for resting the pet
                        Console.WriteLine($"Thanks for letting {petName} rest. His health is now going to improve but happiness may decreses.");

                        if (health_level == 10)
                        {
                            health_level = 10;
                        }
                        else
                        {
                            health_level++;
                        }

                        if (happiness_level == 0)
                        {
                            happiness_level = 0;
                        }
                        else
                        {
                            happiness_level--;
                        }
                        time++;
                        break;
                    case 4:
                        //Checking the status of the pet
                        Console.WriteLine("----------------");
                        Console.WriteLine($"{petName}'s Status: ");
                        Console.WriteLine("----------------");
                        Console.WriteLine($"|Hxunger:    {hunger_level}");
                        Console.WriteLine($"|Happiness: {happiness_level}");
                        Console.WriteLine($"|Health:    {health_level}");
                        Console.WriteLine("----------------\n");

                        if (hunger_level <= 2)
                        {
                            Console.WriteLine($"Warning: {petName} is very hungry! Please feed them soon.\n");
                        }
                        if (happiness_level <= 2)
                        {
                            Console.WriteLine($"Warning: {petName} is feeling sad. Spend time playing with them.\n");
                        }
                        if (health_level <= 2)
                        {
                            Console.WriteLine($"Warning: {petName} is in poor health! Let them rest or care for them.\n2");
                        }
                        Console.WriteLine(time);
       
                        break;
                    case 5:
                        //Exiting the game
                        Console.WriteLine($"Thank you for playing with {petName}. Goodbye!");
                        return; //Exiting the program
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("***Invalid Input. Please enter valid number***");
                Console.WriteLine("----------------------------------------");
            }

        }




    }
}