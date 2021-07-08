using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using RESTful_API_Practice.Controllers;
using RESTful_API_Practice.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetMenu()
        {
            MenuItem[] correctArray = new MenuItem[3];
            correctArray[0] = (new MenuItem { ItemName = "Black Coffee", Calories = 1, Price = "$1.00" });
            correctArray[1] = (new MenuItem { ItemName = "Croissant", Calories = 250, Price = "$3.00" });
            correctArray[2] = (new MenuItem { ItemName = "Cheesecake Slice", Calories = 400, Price = "$3.50" });

            BakeryController bakeryController = new BakeryController();
            MenuItem[] array = bakeryController.GetMenu().ToArray();

            for(int x = 0; x < array.Length; x++)
            {
                Assert.AreEqual(array[x].ItemName, correctArray[x].ItemName);
                Assert.AreEqual(array[x].Calories, correctArray[x].Calories);
                Assert.AreEqual(array[x].Price, correctArray[x].Price);
            }
        }

        [TestMethod]
        public void TestGetItemNames()
        {
            List<string> correctList = new List<string>();
            correctList.Add("Black Coffee");
            correctList.Add("Croissant");
            correctList.Add("Cheesecake Slice");

            BakeryController bakeryController = new BakeryController();
            List<String> list = bakeryController.GetItemNames().ToList();

            CollectionAssert.AreEquivalent(list, correctList);
        }

        [TestMethod]
        public void TestGetItemByNameBlackCoffee()
        {
            MenuItem correctItem = new MenuItem { ItemName = "Black Coffee", Calories = 1, Price = "$1.00" };

            BakeryController bakeryController = new BakeryController();
            MenuItem item = bakeryController.GetItemByName("Black Coffee");

            Assert.AreEqual(item.ItemName, correctItem.ItemName);
            Assert.AreEqual(item.Calories, correctItem.Calories);
            Assert.AreEqual(item.Price, correctItem.Price);
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
    }
}
