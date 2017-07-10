using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string animalInfo = Console.ReadLine();

            while (animalInfo != "End")
            {
                var foodToEat = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var foodType = foodToEat[0];
                var foodQuantity = int.Parse(foodToEat[1]);

                Food currentFood = null;
                if (foodType == "Vegetable")
                {
                    currentFood = new Vegetable(foodQuantity);
                }
                else
                {
                    currentFood = new Meat(foodQuantity);
                }

                var animalTokens = animalInfo.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var animalType = animalTokens[0];
                var animalName = animalTokens[1];
                var animalWeight = double.Parse(animalTokens[2]);
                var livingRegion = animalTokens[3];

                Animal currentAnimal = null;
                if (animalTokens.Length == 5)
                {
                    var catBreed = animalTokens[4];
                    currentAnimal = new Cat(animalName, animalType, animalWeight, livingRegion, catBreed);
                }
                else
                {
                    switch (animalType)
                    {
                        case "Tiger":
                            currentAnimal = new Tiger(animalName, animalType, animalWeight, livingRegion);
                            break;
                        case "Zebra":
                            currentAnimal = new Zebra(animalName, animalType, animalWeight, livingRegion);
                            break;
                        case "Mouse":
                            currentAnimal = new Mouse(animalName, animalType, animalWeight, livingRegion);
                            break;
                    }
                }

                currentAnimal.MakeSound();
                currentAnimal.Eat(currentFood);
                Console.WriteLine(currentAnimal);

                animalInfo = Console.ReadLine();
            }
        }
    }
}
