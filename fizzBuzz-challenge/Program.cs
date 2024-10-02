// See https://aka.ms/new-console-template for more information

for(int i = 1; i < 101; i++){
    // Console.WriteLine("" + i);
    if((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine($"{i} - fizzBuzz");
    else if(i % 3 == 0) Console.WriteLine($"{i} - fizz");
    else if(i % 5 == 0) Console.Write($"{i} - Buzz\n");
    else Console.WriteLine($"{i}");
}
