// See https://aka.ms/new-console-template for more information

// Random random = new Random();
// int current = random.Next(1,11);

// do{
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// }while(current != 7);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing atleast three characters:");
// do{
//     readResult = Console.ReadLine();
//     if(readResult != null)
//     {
//         if(readResult.Length >= 3){
//             validEntry = true;
//         }else{
//             Console.WriteLine("Your input is invalid, please try again");
//         }
//     }
// }while(validEntry == false);

// while(validEntry != true){
//     Console.WriteLine("Enter a string containing atleast three characters:");
//     readResult = Console.ReadLine();
//     if(readResult != null){
//         if(readResult.Length >= 3){
//             validEntry = true;
//         }else{
//             Console.WriteLine("Your input is invalid, please try again");
//         }
//     }
// }


/*
Since you always need the user to enter a string (at least once) before checking if it's valid, the do-while loop is the better choice because it guarantees the input prompt will show up at least once.

If you already had a valid string before the loop started, then a while loop could skip the prompt. But that's not your case here, so do-while makes more sense!
*/

// string? readResult;
// string valueEntered = "";
// int numericValue = 0;
// bool validNumber = false;
// Console.WriteLine("Enter an integer value between 5 and 10.");
// do{
//     readResult = Console.ReadLine();
//      if(readResult != null){
//         valueEntered = readResult;
//     }
//     validNumber = int.TryParse(valueEntered, out numericValue);
//     if(validNumber == true){
//         if(numericValue <= 5 || numericValue >= 10){
//             validNumber = false;
//             Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
//         }
//     }else{
//         Console.WriteLine("Sorry you entered an inavid number, try again");
//     }
// }while(validNumber == false);
// Console.WriteLine($"Your input value ({numericValue}) has been accepted.");

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}