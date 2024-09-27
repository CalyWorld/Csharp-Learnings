// See https://aka.ms/new-console-template for more information

/* switch case */

// int employeeLevel = 201;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel){
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break; 
//     case 400:
//         title = "Associate";
//         break;
//     default:
//         title = "Associate";
//         break;
//         }
// Console.WriteLine($"{employeeName}, {title}");

/*Modify a switch section to include multiple labels*/

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch(employeeLevel){
//     case 100:
//     case 200:
//         title: "Senior Associate";
//         break;
//     case 300:
//         title: "Manager";
//         break;
//     case 400:
//         title: "Senior Manager";
//         break;
//     default :
//         title = "Associate";
//         break;
// }
// Console.WriteLine($"{employeeName}, {title}");


/* Rewrite if else else if statements to switch case */

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

// if (product[0] == "01")
// {
//     type = "Sweat shirt";
// } else if (product[0] == "02")
// {
//     type = "T-Shirt";
// } else if (product[0] == "03")
// {
//     type = "Sweat pants";
// }
// else
// {
//     type = "Other";
// }

// if (product[1] == "BL")
// {
//     color = "Black";
// } else if (product[1] == "MN")
// {
//     color = "Maroon";
// } else
// {
//     color = "White";
// }

// if (product[2] == "S")
// {
//     size = "Small";
// } else if (product[2] == "M")
// {
//     size = "Medium";
// } else if (product[2] == "L")
// {
//     size = "Large";
// } else
// {
//     size = "One Size Fits All";
// }

/* Rewrite if else else if statements to switch case */
switch (product[0]){
    case "01":
        type = "Sweat Shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1]){
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        type = "White";
        break;
}

switch (product[2]){
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");


