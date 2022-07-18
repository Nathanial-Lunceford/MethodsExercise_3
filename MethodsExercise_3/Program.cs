// See https://aka.ms/new-console-template for more information


internal class Program
{
    public static void PrintTwoThousandNums()
    {
        for (int i = -1000; i < 1000; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void ThousandByThrees()
    {
        for(int i = 3; i < 1000; i+= 3)
        {
            Console.WriteLine(i);
        }
    }

    public static bool CheckIfEqual(int num1, int num2)
    {
        return num1 == num2;
    }

    public static void CheckIfEven()
    {
        Console.WriteLine("Give me a number, I'll check if its even");

        int.TryParse(Console.ReadLine(), out int numResult);

        if (numResult % 2 == 0)
        {
            Console.WriteLine($"{numResult} is even");
        }
        else
        {
            Console.WriteLine($"{numResult} is odd");
        }
    }

    public static void CheckIfPositive()
    {
        Console.WriteLine("Give me a number, I'll check if its positive");

        int.TryParse(Console.ReadLine(), out int numResult);

        if (numResult >= 0)
        {
            Console.WriteLine($"{numResult} is positive");
        }
        else
        {
            Console.WriteLine($"{numResult} is negative");
        }
    }

    public static void CanTheyVote()
    {
        Console.WriteLine("How Old Are You?");

        int.TryParse(Console.ReadLine(), out int numResult);

        if (numResult >= 18)
        {
            Console.WriteLine($"You can vote because you're {numResult}");
        }
        else
        {
            Console.WriteLine("You are not old enough to vote");
        }
    }

    public static void WithinTenOfZero()
    {
        Console.WriteLine("Give me a number. I will see if it " +
            "is between -10 and 10");

        int.TryParse(Console.ReadLine(), out int num1);

        if (num1 <= 10 && num1 >= -10)
        {
            Console.WriteLine($"{num1} is between -10 and 10");
        }
        else
        {
            Console.WriteLine($"{num1} is not between -10 and 10");
        }
    }

    public static void MultiplicationTable()
    {
        Console.WriteLine("Give me a number. I will give you the " +
            "multiplication table for that number up to *12");

        int.TryParse(Console.ReadLine(), out int num1);

        for (int i = 1; i < 13; i++)
        {
            Console.Write(num1 * i + " ");
        }
    }

    private static void Main(string[] args)
    {
        PrintTwoThousandNums();

        ThousandByThrees();

            Console.WriteLine("Give me an int. You will then be prompted" +
                "to give a second number, and a program will run to see " +
                "if they are even");

            int.TryParse(Console.ReadLine(), out int equalsNum1);

            Console.WriteLine("Give me a second int.");

            int.TryParse(Console.ReadLine(), out int equalsNum2);

            Console.WriteLine(CheckIfEqual(equalsNum1, equalsNum2));

        CheckIfEven();

        CheckIfPositive();

        CanTheyVote();

        WithinTenOfZero();

        MultiplicationTable();

    }
}