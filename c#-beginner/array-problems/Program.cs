// /*
// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";
// // fraudulentOrderIDs[3] = "D000";
// */

// // string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

// // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// // fraudulentOrderIDs[0] = "F000";

// // Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// // Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


// // string[] names = {"Rowena", "Robin", "Bao"};
// // foreach(string name in names){
// //     Console.WriteLine(name);
// // }

// int[] inventory = {200, 450, 700, 175, 250};
// int sum = 0;
// int bin = 0;
// foreach(int items in inventory){
//     sum+=items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in our inventory");

//code challenge

// string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// foreach(string orderID in orderIDs){
//     if(orderID.StartsWith("B")){
//         Console.WriteLine($"The name starts with 'B' ! {orderID}");
//     }
// }

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");