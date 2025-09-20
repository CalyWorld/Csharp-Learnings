// See https://aka.ms/new-console-template for more information

/******Remove method*****/
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

/*****Replace method*******/

// string message = "This--is--ex-amp-le--da-ta";

// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

/**challenge**/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Quantity: 5000
// Output: <h2>Widgets &reg;</h2><span>5000</span>


int openQuantity = input.IndexOf("<span>");
int closeQuantity = input.IndexOf("</span>");
openQuantity += 6;
int lengthOfQuantity = closeQuantity - openQuantity;
quantity = $"Quantity: {input.Substring(openQuantity, lengthOfQuantity)}";

int openOutput = input.IndexOf("<div>");
int closeOutput = input.IndexOf("</div>");
openOutput += 5;
int lengthOfOutput = closeOutput - openOutput;
string firstOutput = input.Substring(openOutput, lengthOfOutput);
string secondString = firstOutput.Replace("trade", "reg");

output = $"Output: {secondString}";

Console.WriteLine(quantity);
Console.WriteLine(output);


