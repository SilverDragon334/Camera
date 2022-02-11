using System;

class Car
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! You will be asked to input three cars information!");
        Console.WriteLine("But first, enter the speed limit!");
        string speedLimitss = Console.ReadLine();
        int speedLimit = Convert.ToInt32(speedLimitss);
        Console.WriteLine();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter the cars make and model: ");
            string makeModel = Console.ReadLine();

            Console.WriteLine("Enter the cars speed in mph: ");
            string carSpeedStrung = Console.ReadLine();

            int carSpeed = Convert.ToInt32(carSpeedStrung);

            Console.WriteLine(makeModel + " " + carSpeed + " mph");
            if (carSpeed > speedLimit)
            {
                Console.WriteLine("The " + makeModel + " is over the speed limit!");
                int over = carSpeed - 45;
                int demerits = over / 5;
                if (demerits >= 10)
                {
                    Console.WriteLine("Since it was " + (over) + " mph over the speed limit, the " + (makeModel) + " has had its liscense suspended!");
                }
                else
                {
                    Console.WriteLine("Since it was " + (over) + " mph over the speed limit, the " + (makeModel) + " has received " + (demerits) + " demerits!");
                }
                
            }
            else
            {
                Console.WriteLine("The " + (makeModel) + " was not over the speed limit. :)");
            }
            Console.WriteLine();

        }

        Console.WriteLine("Thank you for playing!");
        
    }

}
