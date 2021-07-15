using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;

namespace NUnitTestProject1
{
    public class Tests

        
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This is setup");
       // Driver = new EdgeDriver();
            Driver = new ChromeDriver();
           

        }

        [Test]
        public void Test1()
        {
           Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

           // Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

             IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
           // IWebElement comboControl = Driver.FindElement(By.XPath("//div[@class='awe-display combobox']"));

            comboControl.Clear();
            comboControl.SendKeys("Almond");
            

           // Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();


           
            Assert.Pass();
        }
    }
}