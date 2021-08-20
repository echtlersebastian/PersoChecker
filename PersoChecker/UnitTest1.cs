using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace PersoChecker
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [Test]
        public void CheckMyPerso()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            IWebDriver driver = new ChromeDriver(chromeOptions);
            driver.Url = "https://www17.muenchen.de/Passverfolgung/";
            IWebElement ausweisnummer = driver.FindElement(By.Name("ifNummer"));
            ausweisnummer.SendKeys("LF0841ZT47");



            IWebElement abfragen = driver.FindElement(By.Name("pbAbfragen"));
            abfragen.Click();



            IWebElement antwort = driver.FindElement(By.CssSelector("b[style='color: red']"));
            string a = antwort.Text;
            Console.WriteLine("Test");
            Assert.AreEqual(a, "noch nicht zur Abholung bereit.");
        }
    }
}