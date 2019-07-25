using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace AutomatedTest.Tests
{
    public class TestCase3
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void ThisTestWillClickOnKeyPressesOnMenu_ItWillClickon4KeysAndAssertTheTextDisplayed_AfterEveryKeyPress()
        {
            var driver = new ChromeDriver(); //Intialising a new instance of the ChromeDriver class
            driver.Url = "http://the-internet.herokuapp.com/"; //Directing the url for this automation test

            //Using the FindElementByLinkText to click on the Key Presses page
            driver.FindElement(By.LinkText("Key Presses")).Click();

            //Using the FindElementById to find the input box on the Key Presses page which is called target
            var inputField = driver.FindElementById("target");
            //Using the FindElementById to find the result field and display this to a string
            driver.FindElement(By.Id("result")).ToString();
           
            //Using SendKeys to send Key LeftAlt
            inputField.SendKeys(Keys.LeftAlt);
            Thread.Sleep(5000);
            //Asserting the text displayed to be equal to result
            Assert.That("result", Is.EqualTo("result"));

            //Using SendKeys to send Key Backspace
            inputField.SendKeys(Keys.Backspace);
            Thread.Sleep(5000); //test will wait for 5 seconds and carry on with executing the test
            //Asserting the text displayed to be equal to result
            Assert.That("result", Is.EqualTo("result"));

            //Using SendKeys to send Key Escape
            inputField.SendKeys(Keys.Escape);
            Thread.Sleep(5000);
            //Asserting the text displayed to be equal to result
            Assert.That("result", Is.EqualTo("result"));

            //Using SendKeys to send Key Enter
            inputField.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            //Asserting the text displayed to be equal to result
            Assert.That("result", Is.EqualTo("result"));
        }
    }
}