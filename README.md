# Polymorphism

1. MathOperation
Create a class MathOperations, which should have 3 times method Add(). Method Add() have to be invoked
with:
 Add(int, int): int
 Add(double, double, double): double
 Add(decimal, decimal, decimal): decimal

2. Animals
Create a class Animal, which hold two fields:
 name: string
 favouriteFood: string
Animal have one virtual method ExplainMyself(): string
You should add two new classes Cat and Dog. There override ExplainMyself() method by adding concrete animal
sound on new line. (Look at examples below)

3. Shapes
Create class hierarchy, starting with abstract class Shape:
 Abstract methods:
o calculatePerimeter(): doulbe
o calculateArea(): double
 Virtual methods:
o Draw(): string
Extend Shape class with two children:
 Rectangle
 Circle
Each of them need to have:
 Fields:
o height and width for Rectangle
o radius for Circle
 Encapsulation for this fields
 Public constructor
 Concrete methods for calculations (perimeter and area)
 Override methods for drawing

Problem 1. Vehicles
Write a program that models 2 vehicles (Car and Truck) and will be able to simulate driving and refueling them. Car
and truck both have fuel quantity, fuel consumption in liters per km and can be driven given distance and refueled
with given liters. But in the summer both vehicles use air conditioner and their fuel consumption per km is
increased by 0.9 liters for the car and with 1.6 liters for the truck. Also the truck has a tiny hole in his tank and when
it gets refueled it gets only 95% of given fuel. The car has no problems when refueling and adds all given fuel to its
tank. If a vehicle cannot travel the given distance its fuel does not change.
Input
 On the first line - information about the car in format {Car {fuel quantity} {liters per km}}
 On the second line – info about the truck in format {Truck {fuel quantity} {liters per km}}
 On the third line - number of commands N that will be given on the next N lines
 On the next N lines – commands in format
o Drive Car {distance}
o Drive Truck {distance}
o Refuel Car {liters}
o Refuel Truck {liters}
Output
After each Drive command print whether the Car/Truck was able to travel the given distance in the formats below.
If it’s successful:
Car/Truck travelled {distance} km
Or if it is not:
Car/Truck needs refueling
Finally print the remaining fuel for both car and truck rounded to 2 digits after the floating point in format:
Car: {liters}
Truck: {liters}

Problem 2. Vehicles Extension
Use your solution of the previous task for starting point and add more functionality. Add new vehicle – Bus. Now
every vehicle has tank capacity and fuel quantity cannot fall below 0 (If fuel quantity become less than 0 print on
the console “Fuel must be a positive number”).
The car and the bus cannot be filled up with more fuel than their tank capacity. If you try to put more fuel in the
tank than the available space, print on the console “Cannot fit fuel in tank” and do not add any fuel in vehicles
tank.
Add new command for the bus. The bus can drive with or without people. If the bus is driving with people, the air-
conditioner is turned on and its fuel consumption per kilometer is increased with 1.4 liters. If there are no people
in the bus when driving the air-conditioner is turned off and does not increase the fuel consumption.
Input
 On the first three lines you will receive information about the vehicles in format:
Vehicle {initial fuel quantity} {liters per km} {tank capacity}
 On fourth line - number of commands N that will be given on the next N lines
 On the next N lines – commands in format
o Drive Car {distance}
o Drive Truck {distance}
o Drive Bus {distance}
o DriveEmpty Bus {distance}
o Refuel Car {liters}
o Refuel Truck {liters}
o Refuel Bus {liters}
Output
 After each Drive command print whether the Car/Truck was able to travel given distance in format if it’s
successful:
Car/Truck/Bus travelled {distance} km
 Or if it is not:
Car/Truck/Bus needs refueling
 If given fuel is ≤ 0 print “Fuel must be a positive number”.
 If given fuel cannot fit in car or bus tank print “Cannot fit in tank”
 Finally print the remaining fuel for both car and truck rounded 2 digits after floating point in format:
Car: {liters}
Truck: {liters}
Bus: {liters}

3.Wild Farm
Your task is to create a class hierarchy like in the picture below. All the classes except Vegetable, Meat, Mouse,
Tiger, Cat &amp; Zebra should be abstract. Override method ToString().
Input should be read from the console. Every odd line will contain information about the Animal in following format:
{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]
On the even lines you will receive information about the food that you should give to the Animal. The line will
consist of FoodType and quantity separated by a whitespace.
{FoodType} {Quantiy}
You should build the logic to determine if the animal is going to eat the provided food. The Mouse and Zebra should
check if the food is a Vegetable. If it is they will eat it - otherwise you should print a message in the format:
{AnimalType in plural} are not eating that type of food!
Cats eat any kind of food, but Tigers accept only Meat. If Vegetable is provided to a Tiger message like the one
above should be printed on the console.
Override ToString() method to print the information about the animal in format:
{AnimalType}[{AnimalName}, {CatBreed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]
After you read information about the Animal and Food then invoke the MakeSound() method of the current animal
and then feed it. At the end print the whole object and proceed reading information about the next animal/food.
The input will continue until you receive “End” for animal information.
Sounds produced by the animals:
 Mouse – “SQUEEEAAAK!”
 Zebra – “Zs”
 Cat – “Meowwww”
 Tiger – “ROAAR!!!”
Input
You will receive lines on the Console until the command “End” is received. On every odd line you will be provided
with information about an animal. On every even line you will receive the food which is given to the animal.
Output
For each animal you have read, print two lines on the Console:
 On the first line: the sound produced by the animal
 On the second line: all the information about the animal in the format described above
