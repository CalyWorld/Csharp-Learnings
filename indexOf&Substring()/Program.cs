// See https://aka.ms/new-console-template for more information

string message = "Find what is (inside the parenthesis)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));

