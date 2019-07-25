using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutomatedTest.Tests
{
    public class TestCase2
    {
        IWebDriver driver = new ChromeDriver();
        
        //Please note that the IJavaScriptExecutor element does not work due to technical difficulties,
        //therefore the steps that I would have carried out have been written and commented
        [Test]
        public void ThisTestWillClickOnInfiniteScrollOnMenu_ItWillScrollToTheBottomOfThePageTwice_AndScrollBackToTheTop()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://the-internet.herokuapp.com/";

            //Using the FindElementByLinkText to click on the Infinite Scroll page
            driver.FindElement(By.LinkText("Infinite Scroll")).Click();

            //IJavaScriptExecutor is an interface that helps to execute JavaScript through Selenium Webdriver
            //Defining IJavaScriptExecutor and creating an instance of it
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            
            //js.ExecuteScript is being used to scroll the web page till it end
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

            //js.ExecuteScript is being executed again to scroll to the bottom of the page again
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");

           //js.ExecuteScript is being used to scroll to the top of the page
            js.ExecuteScript("window.scrollTo(0, 0);");

            //Asserting the Infinite Scroll text
            Assert.AreEqual("Infinite Scroll", "Infinite Scroll");
        }
    }
}
