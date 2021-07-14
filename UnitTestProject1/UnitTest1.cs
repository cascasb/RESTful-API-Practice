using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using RESTful_API_Practice.Controllers;
using RESTful_API_Practice.Models;

namespace UnitTestProject1
{
    /*[TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetMenu()
        {
            IBakeryProduct[] correctInv = new IBakeryProduct[3];

            correctInv[0] = (new FoodProduct { ProductName = "Croissant", Calories = 250, Price = "$3.00", NumInStock = 3 });
            correctInv[1] = (new DrinkProduct { ProductName = "Latte", Calories = 200, Price = "$2.50", IsDecaf = false, NumInStock = 0 });
            correctInv[2] = (new DishesProduct { ProductName = "Souvenir Mug", Price = "$5.00", Color = "Blue", NumInStock = 2, IsDishwasherSafe = true });

            BakeryController bakeryController = new BakeryController();
            IBakeryProduct[] retrievedArray = bakeryController.GetMenu().ToArray();



            for(int x = 0; x < retrievedArray.Length; x++)
            {
                Assert.AreEqual(correctInv[x].ProductName, retrievedArray[x].ProductName);
                Assert.AreEqual(retrievedArray[x].Price, retrievedArray[x].Price);
                Assert.AreEqual(retrievedArray[x].NumInStock, retrievedArray[x].NumInStock);
                if (retrievedArray[x] is FoodProduct)
                {
                    Assert.AreEqual(retrievedArray[x].Calories == correctInv[x].Calories);
                }
                if (retrievedArray[x] is IDrinkProduct)
                {

                }
                if (retrievedArray[x] is DishesProduct)
                {

                }
            }
            foreach (IFoodProduct food in retrievedArray)
            {
                Assert.AreEqual(retrievedArray[])
            }
        }

        [TestMethod]
        public void TestGetItemNames()
        {
            List<string> correctList = new List<string>();
            correctList.Add("Croissant");
            correctList.Add("Latte");
            correctList.Add("Souvenir Mug");

            BakeryController bakeryController = new BakeryController();
            List<String> list = bakeryController.GetItemNames().ToList();

            CollectionAssert.AreEquivalent(list, correctList);
        }

        [TestMethod]
        public void TestGetItemByNameBlackCoffee()
        {
            DrinkProduct correctItem = (new DrinkProduct { ProductName = "Latte", Calories = 200, Price = "$2.50", IsDecaf = false, NumInStock = 0 });

            BakeryController bakeryController = new BakeryController();
            IBakeryProduct item = bakeryController.GetItemByName("Latte");

            Assert.AreEqual(item.ProductName, correctItem.ProductName);
            Assert.AreEqual(item.Price, correctItem.Price);
            Assert.AreEqual(item.NumInStock, correctItem.NumInStock);
            
        }

        [TestMethod]
        public void TestGetItemByNameCroissant()
        {
            MenuItem correctItem = new MenuItem { ItemName = "Croissant", Calories = 250, Price = "$3.00" };

            BakeryController bakeryController = new BakeryController();
            MenuItem item = bakeryController.GetItemByName("Croissant");

            Assert.AreEqual(item.ItemName, correctItem.ItemName);
            Assert.AreEqual(item.Calories, correctItem.Calories);
            Assert.AreEqual(item.Price, correctItem.Price);
        }

        [TestMethod]
        public void TestGetItemByNameCheesecakeSlice()
        {
            MenuItem correctItem = new MenuItem { ItemName = "Cheesecake Slice", Calories = 400, Price = "$3.50" };

            BakeryController bakeryController = new BakeryController();
            MenuItem item = bakeryController.GetItemByName("Cheesecake Slice");

            Assert.AreEqual(item.ItemName, correctItem.ItemName);
            Assert.AreEqual(item.Calories, correctItem.Calories);
            Assert.AreEqual(item.Price, correctItem.Price);
        }

        [TestMethod]
        public void TestGetItemByCal1()
        {
            MenuItem correctItem = new MenuItem { ItemName = "Black Coffee", Calories = 1, Price = "$1.00" };

            BakeryController bakeryController = new BakeryController();
            MenuItem item = bakeryController.GetItemByCal(1);

            Assert.AreEqual(item.ItemName, correctItem.ItemName);
            Assert.AreEqual(item.Calories, correctItem.Calories);
            Assert.AreEqual(item.Price, correctItem.Price);
        }

        [TestMethod]
        public void TestGetItemByCal250()
        {
            MenuItem correctItem = new MenuItem { ItemName = "Croissant", Calories = 250, Price = "$3.00" };

            BakeryController bakeryController = new BakeryController();
            MenuItem item = bakeryController.GetItemByCal(250);

            Assert.AreEqual(item.ItemName, correctItem.ItemName);
            Assert.AreEqual(item.Calories, correctItem.Calories);
            Assert.AreEqual(item.Price, correctItem.Price);
        }

        [TestMethod]
        public void TestGetItemByCal400()
        {
            MenuItem correctItem = new MenuItem { ItemName = "Cheesecake Slice", Calories = 400, Price = "$3.50" };

            BakeryController bakeryController = new BakeryController();
            MenuItem item = bakeryController.GetItemByCal(400);

            Assert.AreEqual(item.ItemName, correctItem.ItemName);
            Assert.AreEqual(item.Calories, correctItem.Calories);
            Assert.AreEqual(item.Price, correctItem.Price);
        }
    }*/
}
