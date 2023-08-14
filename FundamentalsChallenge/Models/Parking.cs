namespace FundamentalsChallenge.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal hourlyPrice = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal hourlyPrice)
        {
            this.initialPrice = initialPrice;
            this.hourlyPrice = hourlyPrice;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Enter the vehicle's license plate to park:");
            vehicles.Add(Console.ReadLine());
        }

        public void RemoveVehicle()
        {
            string licensePlate = "";
            Console.WriteLine("Enter the vehicle's license plate to remove:");
            licensePlate = Console.ReadLine();

            // Check if the vehicle exists
            if (vehicles.Any(x => x.ToUpper() == licensePlate.ToUpper()))
            {
                int hours = 0;
                decimal totalCost = 0;
                Console.WriteLine("Enter the number of hours the vehicle was parked:");
                hours = Convert.ToInt32(Console.ReadLine());
                totalCost = initialPrice + hourlyPrice * hours;
                vehicles.Remove(licensePlate);
                Console.WriteLine($"The vehicle {licensePlate} has been removed, and the total cost is: $ {totalCost}");
            }
            else
            {
                Console.WriteLine("Sorry, this vehicle is not parked here. Please make sure you entered the correct license plate.");
            }
        }

        public void ListVehicles()
        {
            // Check if there are vehicles in the parking
            if (vehicles.Any())
            {
                Console.WriteLine("The parked vehicles are:");
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
            else
            {
                Console.WriteLine("There are no vehicles parked.");
            }
        }
    }
}
