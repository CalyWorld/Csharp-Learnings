// See https://aka.ms/new-console-template for more information

//addition
//subtraction
//division
//multiplication
//present a menu to choose an operation
//record previous games in a list and menu to show previous games
Console.WriteLine("Welcome to Math game");
string? choice = "";
int num1 = 0;
int nextNumber = 0;
int score = 0;
int mathSign = 0;
List<string> results = new List<string>();

Console.WriteLine("Enter number ");
string? t = Console.ReadLine();
if (t != null)
    num1 = int.Parse(t);
else
    Console.WriteLine("Please enter a number");

Dictionary<int, string> operations = new Dictionary<int, string>{
    {1, "+"},
    {2, "-"},
    {3, "*"},
    {4, "/"},
};

do
{
    Console.WriteLine("Please pick a number to run the following operations\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Results?");
    string? sign = Console.ReadLine();
    if (sign != null)
        mathSign = int.Parse(sign);
    else return;

    if (mathSign == 5)
    {
        if (results.Count == 0)
            Console.WriteLine("No Results yet");
        else
            Console.WriteLine("Here are the previous math results");
        foreach (string s in results)
            Console.WriteLine(s);
        continue;
    }
    else
    {
        Console.WriteLine("Enter another number");
        string? u = Console.ReadLine();
        if (u != null)
            nextNumber = int.Parse(u);
        else
            Console.WriteLine("Please enter a number");

        switch (mathSign)
        {
            case 1:
                score = num1 + nextNumber;
                break;
            case 2:
                score = num1 - nextNumber;
                break;
            case 3:
                score = num1 * nextNumber;
                break;
            case 4:
                if (nextNumber == 0)
                {
                    Console.WriteLine("Cannot divide by Zero");
                    continue;
                }
                score = num1 / nextNumber;
                break;
        }
    }

    Console.WriteLine($"The score of {num1} {operations[mathSign]} {nextNumber} = {score}");
    results.Add($"{num1} {operations[mathSign]} {nextNumber} = {score}");
    num1 = score;

    Console.WriteLine("Do you want to keep playing? (yes/no) ");
    choice = Console.ReadLine()?.ToLower();

} while (choice != "no" && choice != "n");


