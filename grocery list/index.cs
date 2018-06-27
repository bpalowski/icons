using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "cereal", "rice"};
//    int[] groceryListPrices = {3, 6, 4, 2, 5};
    Console.WriteLine("My grocery list:");
//    foreach (string groceryItem in myGroceryList)
//    {
//      Console.WriteLine(groceryItem);
//    }
//    int total = 0;
//    foreach (int price in groceryListPrices)
//    {
//      total += price;
//    }
//    Console.WriteLine("your total for this shopping trip will be the $" + //total);
//  }
//}
  for (int index = 0; index < myGroceryList.Length; index ++)
  {
    Console.WriteLine(myGroceryList[index]);
    }
  }
}
