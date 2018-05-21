using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumTest
{
    class MainClass
    {

        //Create reference for browser
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initialize(){
            
            //Navigate to webpage
            driver.Navigate().GoToUrl("http://cgross.github.io/angular-busy/demo/");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest(){
            
            //Click opration on Demo button
            IWebElement element = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[1]/form/div[6]/button"));
            element.Click();

            bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
            if (IsElementPresent(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div/div[2]/div/div[2]")))
            {
                
                Console.WriteLine("Wait Indicator exist");
            }
            else
            {
                Console.WriteLine("Wait Indicator is not exist");
            }
            Console.WriteLine("Executed Test");
            
        }

        public static void Main(string[] args)
        {

         

        }
    }
}
