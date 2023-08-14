using FundamentalsChallenge.Models;

// Set encoding to UTF8 to display accents
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal hourlyPrice = 0;

Console.WriteLine("Welcome to the parking system!\n" +
                  "Enter the initial price:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Now enter the hourly price:");
hourlyPrice = Convert.ToDecimal(Console.ReadLine());

// Instantiate the Parking class with the previously obtained values
Parking parking = new Parking(initialPrice, hourlyPrice);

string option = string.Empty;
bool displayMenu = true;

// Menu loop
while (displayMenu)
{
    Console.Clear();
    Console.WriteLine("Enter your option:");
    Console.WriteLine("1 - Register vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Exit");

    switch (Console.ReadLine())
    {
        case "1":
            parking.AddVehicle();
            break;

        case "2":
            parking.RemoveVehicle();
            break;

        case "3":
            parking.ListVehicles();
            break;

        case "4":
            displayMenu = false;
            break;

        default:
            Console.WriteLine("Invalid option");
            break;
    }

    Console.WriteLine("Press a key to continue");
    Console.ReadLine();
}

Console.WriteLine("The program has ended");
