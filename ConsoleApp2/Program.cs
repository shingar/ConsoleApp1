using System;

namespace ConsoleApp2
{
    class Program
    {
        class Driver
        {
            static Fruit head = new Fruit("head", 0, null, null);
            static Fruit tail = new Fruit("tail", 0, null, null);
            static void Main(String[] args)
            {
                FruitBasket basket1 = new FruitBasket();
                Fruit apple = new Fruit("Apple", 100, head, null);
                head.nextFruit = apple;
                basket1.firstFruit = apple;
                Fruit mango = new Fruit("Mango", 100, apple, null);
                Fruit pineapple = new Fruit("pineapple", 100, mango, tail);
                apple.nextFruit = mango;
                mango.nextFruit = pineapple;
                tail.previousFruit = pineapple;
                Driver.traverseLinkedList();
            }

            public static void traverseLinkedList()
            {
                int TotalCalories = 0;
                Fruit currentNode = tail;
                while (!((currentNode.fruitName).Equals("head")))
                {
                    Console.WriteLine(currentNode.fruitName);
                    TotalCalories += currentNode.Calories;
                    currentNode = currentNode.previousFruit;
                }
                Console.WriteLine("total calories is {0}", TotalCalories);

                // get a handle on the first node
                // get a handle on the next node
                // keep going till End of List = TAIL

            }

        }
        class FruitBasket
        {
            public Fruit firstFruit;
        }

        class Fruit
        {
            public Fruit(String thisFruitName, int thisCalories, Fruit pFruit, Fruit nFruit)
            {
                fruitName = thisFruitName;
                Calories = thisCalories;
                nextFruit = nFruit;
                previousFruit = pFruit;
            }
            public String fruitName = "";
            public int Calories;
            public Fruit nextFruit;
            public Fruit previousFruit;
        }
        // to do: write a method to traverse the LL, print out the names of the fruits,
        // and sum the calories
    }

}
