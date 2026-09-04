List<string> validProducts = new List<string>();
Console.WriteLine("Enter product names.");
Console.WriteLine("Type 'Exit' to finish. ");
while (true)
{
    Console.Write("Product: ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("ERROR: Input cannot be empty . ");
        continue;
    }
    //exit condition
    if (input.ToUpper() == "EXIT")
    {
        break;
    }
    //check for Empty input
    if (!input.Contains("-"))
    {
        Console.WriteLine("ERROR: Product must contain a dash(-).");
        
        continue;
    }
    string[] parts = input.Split('-');

    if (parts.Length != 2)
    {
        Console.WriteLine("ERROR: Product name in the format LETTER-NUMBER.");
        
        continue;
    }

    string leftpart = parts[0];
    string rightpart = parts[1];

    bool validLeft = true;

    foreach (char s in leftpart)
    {
        if (s < 'A' || s > 'Z')
        {
            validLeft = false;
            break;
        }
    }
    if (validLeft == false)
    {
        Console.WriteLine("ERROR: The left side must contain letters only.");
        continue;

    }

    bool validRight = true;

    foreach (char s in rightpart)
        {
          if(char.IsDigit(s) == false)
        {
            validRight = false;
            break;
        }
    }

    if (validRight == false)
    {
        Console.WriteLine("ERROR: The right side must contain numbers only.");
        continue;
    }

    int number = int.Parse(rightpart);

    if (number <200 || number > 500 )
    {
        Console.WriteLine("ERROR: The numeric part must be between 200 and 500.");
        continue;
    }

    validProducts.Add(input);
    

   
    
    
}
validProducts.Sort();
Console.WriteLine("\nSorted valid products:");

   foreach (string Products in validProducts)
   {
    Console.WriteLine(Products);
   }

Console.WriteLine("\nPress any key to continue...");
Console.ReadKey();
