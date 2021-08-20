using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace PersoChecker
{
    public class Tests
    {
    
        [Test]
        public void CheckMyPerso()
        {
            //chomedriver will execute the Selenium
            var chromeOptions = new ChromeOptions();

            //This headless argument is needed to be able to run the test inside the GitHub Actions.
            //Headless means, that no visible Browser Window is openend. (Not exactly, but this explanation is suitable for most cases)
            chromeOptions.AddArguments("headless");

            //open the Website
            IWebDriver driver = new ChromeDriver(chromeOptions);
            driver.Url = "https://www17.muenchen.de/Passverfolgung/";

            //get the Input field and fill in the Ausweisnummer
            IWebElement ausweisnummer = driver.FindElement(By.Name("ifNummer"));
            ausweisnummer.SendKeys("LF0841ZT47");

            //click on the Button
            IWebElement abfragen = driver.FindElement(By.Name("pbAbfragen"));
            abfragen.Click();

            //the Portal is not using an id or a name for the HTML Element... Thats why i need to search for the Red one... :(
            //I mean, come on Munich, you can do better!
            IWebElement antwort = driver.FindElement(By.CssSelector("b[style='color: red']"));

            //get the text from the Red Label.
            string a = antwort.Text;

            //If the text is still "noch nicht zur Abholung bereit.", than the Test will pass, and i will not recieve a notification.
            //As soon, as the Text changes, the Test will break and i will get a Notification by Email. :)
            Assert.AreEqual(a, "noch nicht zur Abholung bereit.");
        }
    }
}