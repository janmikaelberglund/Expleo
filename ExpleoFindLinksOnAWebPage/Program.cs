using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ExpleoFindLinksOnAWebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://expleogroup.com";
            IWebDriver driver = new ChromeDriver();
            driver.Url = url;

            var webElements = driver.FindElements(By.XPath("//a"));


            foreach (var element in webElements)
            {
                Console.WriteLine(element.GetAttribute("href"));
            }
            Console.WriteLine($"{webElements.Count} Links on {url}");

            driver.Quit();
        }
    }
}
