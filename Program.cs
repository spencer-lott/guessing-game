using System;
using System.Collections.Generic;
using System.Text;

Prompt();

int numberOfinvokes = 0;
int theSecretNumber = Roll();

int Roll()
{
    Random rand = new Random();
    return rand.Next(1, 101);
}

Main();

void Main()
{
    
    // Console.ReadLine();
    string promptAnswer = Console.ReadLine();
    int parsedchoice = int.Parse(promptAnswer);
    if (parsedchoice == 1) {
        Easy();
    }
    else if (parsedchoice == 2) {
        Medium();
    }
    else if (parsedchoice == 3) {

    Hard();
    }
    else if (parsedchoice == 4) {
        Cheater();
    }
    else {
        Console.WriteLine("Please input one of the integers provided");
    }

}

void Easy()
{
    
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine("Guess the secret number...");
        numberOfinvokes += 1;

        string answer = Console.ReadLine();

        int parsedInput = int.Parse(answer);

        int secretNum = theSecretNumber;
        Console.WriteLine($"SECRET NUMBER: {secretNum}");

        if (parsedInput == secretNum)
        {
            Console.WriteLine("SUCCESS");
            break;
        }
        else
        {
            Console.WriteLine($"Wrong. Your guesses: ({numberOfinvokes}/8)");
            if (parsedInput > secretNum) {
                Console.WriteLine("Too high bro");
            }
            else {
                Console.WriteLine("Too Low");
            }

        }

    }

}

void Medium()
{
    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("Guess the secret number...");
        numberOfinvokes += 1;

        string answer = Console.ReadLine();

        int parsedInput = int.Parse(answer);

        int secretNum = theSecretNumber;
        Console.WriteLine($"SECRET NUMBER: {secretNum}");

        if (parsedInput == secretNum)
        {
            Console.WriteLine("SUCCESS");
            break;
        }
        else
        {
            Console.WriteLine($"Wrong. Your guesses: ({numberOfinvokes}/6)");
            if (parsedInput > secretNum) {
                Console.WriteLine("Too high bro");
            }
            else {
                Console.WriteLine("Too Low");
            }

        }

    }

}

void Hard()
{
    Console.WriteLine("Guess the secret number...");
    for (int i = 0; i < 4; i++)
    {
        numberOfinvokes += 1;

        string answer = Console.ReadLine();

        int parsedInput = int.Parse(answer);

        int secretNum = theSecretNumber;
        Console.WriteLine($"SECRET NUMBER: {secretNum}");

        if (parsedInput == secretNum)
        {
            Console.WriteLine("SUCCESS");
            break;
        }
        else
        {
            Console.WriteLine($"Wrong. Your guesses: ({numberOfinvokes}/4)");
            if (parsedInput > secretNum) {
                Console.WriteLine("Too high bro");
            }
            else {
                Console.WriteLine("Too Low");
            }

        }

    }

}

void Cheater()
{
    Console.WriteLine("Guess the secret number... You have infinite guesses");
    numberOfinvokes += 1;
    string answer = Console.ReadLine();

    int parsedInput = int.Parse(answer);

    int secretNum = theSecretNumber;

    if (parsedInput == secretNum)
    {
        Console.WriteLine("You win");
    }

    else
    {
            if (parsedInput > secretNum) {
                Console.WriteLine("Too high bro");
            }
            else {
                Console.WriteLine("Too Low");
            }
    }

    while (parsedInput != secretNum)
    {
        numberOfinvokes += 1;
        Console.WriteLine($"Wrong. Your guesses: ({numberOfinvokes})");
        string answer2 = Console.ReadLine();

        int parsedInput2 = int.Parse(answer2);

        int secretNum2 = 42;

        if (parsedInput2 == secretNum2)
        {
            Console.WriteLine("SUCCESS!! YOU WEiNNER!");
            break;
        }

        else
        {
            if (parsedInput2 > secretNum2) {
                Console.WriteLine("Too high bro");
            }
            else {
                Console.WriteLine("Too Low");
            };
        }
    }
}


    void Prompt()
{
    Console.WriteLine("Hello, User!");
    Console.WriteLine($@"Select a Difficulty:
    Easy Mode: enter {1} to select 
    Medium - enter {2} to select 
    Hard - enter {3} to select
    Cheater - enter {4}");


}
