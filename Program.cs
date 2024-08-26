//Author:Mehmet Akif Hatunoğlu
//Calculator ver.1.0
Console.WriteLine("U are using Akif's Calculator!");
Console.Write("Which math operation you want to do (+,-,*,/,%): ");
string chosenOperation = Console.ReadLine();
int x;
int y;
if(chosenOperation == "+" || chosenOperation == "-" || chosenOperation == "*" || chosenOperation == "/" || chosenOperation == "%"){
    if(chosenOperation == "+"){
        Console.Write("Please enter the first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x+y);
    }
    if(chosenOperation == "-"){
        Console.Write("Please enter the first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x-y);
    }
    if(chosenOperation == "*"){
        Console.Write("Please enter the first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x*y);
    }
    if(chosenOperation == "/"){
        Console.Write("Please enter the first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x/y);
    }
    if(chosenOperation == "%"){
        Console.Write("Please enter the first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(x%y);
    }
}
else{
    Console.WriteLine("You should enter one of these: (+,-,*,/,%). Please try again!");
}
