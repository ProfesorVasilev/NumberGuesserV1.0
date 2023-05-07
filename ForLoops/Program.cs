using System.Text;

while (true)
{
    Console.WriteLine("Choose a number:");
    int number = int.Parse(Console.ReadLine());
    for (int i = 1; i < 40; i++)
        Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine("Guess the number!");
    int tries = 0;

    while (true)
    {
        int guess = int.Parse(Console.ReadLine());
        if (guess != number)
        {
            Console.WriteLine("Wrong, try again!");
            tries = tries + 1;
            if (tries >= 10) //hint after 10th try
            {
                if (guess > number)
                {
                    Console.WriteLine("Your last guess is bigger than the actual number!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your last guess is smaller than the actual number!");
                }
                else if (guess == number)
                {
                    Console.WriteLine("Good job, you guessed the number!");
                    break;
                }
            }
        }
        else if (guess == number)
        {
            Console.WriteLine("Good job, you guessed the number!");
            break;
        }
    }
}

















