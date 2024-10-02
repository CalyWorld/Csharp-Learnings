// // /*Random random = new Random();
// // int daysUntilExpiration = random.Next(12);
// // int discountPercentage = 0;

// // if (daysUntilExpiration == 0)
// // {
// //     Console.WriteLine("Your subscription has expired.");
// // }
// // else if (daysUntilExpiration == 1)
// // {
// //     Console.WriteLine("Your subscription expires within a day!");
// //     discountPercentage = 20;
// // }
// // else if (daysUntilExpiration <= 5)
// // {
// //     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
// //     discountPercentage = 10;
// // }
// // else if (daysUntilExpiration <= 10)
// // {
// //     Console.WriteLine("Your subscription will expire soon. Renew now!");
// // }

// // if (discountPercentage > 0)
// // {
// //     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// // } */

// // Random random = new Random();
// // string[] orderIDs = new string[5];
// // // Loop through each blank orderID
// // for (int i = 0; i < orderIDs.Length; i++)
// // {
// //     // Get a random value that equates to ASCII letters A through E
// //     int prefixValue = random.Next(65, 70);
// //     // Convert the random value into a char, then a string
// //     string prefix = Convert.ToChar(prefixValue).ToString();
// //     // Create a random number, pad with zeroes
// //     string suffix = random.Next(1, 1000).ToString("000");
// //     Console.WriteLine("" + suffix);
// //     // Combine the prefix and suffix together, then assign to current OrderID
// //     orderIDs[i] = prefix + suffix;
// // }
// // // Print out each orderID
// // foreach (var orderID in orderIDs)
// // {
// //     Console.WriteLine(orderID);
// // }

// string str = "The quick brown fox jumps over the lazy dog.";
// // convert the message into a char array
// char[] charMessage = str.ToCharArray();
// // Reverse the chars
// Array.Reverse(charMessage);
// int x = 0;
// // count the o's
// foreach (char i in charMessage) { if (i == 'o') { x++; } }
// // convert it back to a string
// string new_message = new String(charMessage);
// // print it out
// Console.WriteLine(new_message);
// Console.WriteLine($"'o' appears {x} times.");

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");