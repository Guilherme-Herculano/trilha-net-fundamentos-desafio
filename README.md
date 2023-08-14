# DIO - .NET Track - Fundamentals
www.dio.me

## Project Challenge
For this challenge, you will need to apply the knowledge you've gained from the fundamentals module of the DIO .NET track.

## Context
You have been hired to develop a system for a parking lot, which will be used to manage parked vehicles and perform operations such as adding a vehicle, removing a vehicle (including displaying the charged amount during the stay), and listing the vehicles.

## Proposal
You need to construct a class called "Parking" following the provided diagram:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**initialPrice**: Decimal type. It's the price charged for parking a vehicle.

**hourlyPrice**: Decimal type. It's the price per hour that a vehicle remains parked.

**vehicles**: A list of strings, representing a collection of parked vehicles. It contains only the vehicle's license plate.

The class includes three methods:

**AddVehicle**: Method responsible for receiving a license plate entered by the user and storing it in the **vehicles** variable.

**RemoveVehicle**: Method responsible for checking if a specific vehicle is parked. If so, it will ask for the number of hours it stayed in the parking lot. After that, it performs the following calculation:  **initialPrice** * **hourlyPrice**, displaying it to the user.

**ListVehicles**: Lists all the vehicles currently in the parking lot. If there are none, display the message "There are no vehicles parked."

Finally, you need to create an interactive menu with the following implemented actions:

1. Register vehicle
2. Remove vehicle
3. List vehicles
4. Exit


## Solution
The code is halfway done, and you need to continue following the rules described above so that, in the end, we have a functional program. Look for the commented word "TODO" in the code, then implement it according to the rules mentioned above.
