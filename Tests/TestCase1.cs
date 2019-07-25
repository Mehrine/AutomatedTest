using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutomatedTest.Tests
{
    public class Test
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void ThisTestWillLogin_WithTheCorrectUsernameAndIncorrectPassword_AndAssertLoginValidation()
        {
            var driver = new ChromeDriver(); //Intialising a new instance of the ChromeDriver class
            driver.Url = "http://the-internet.herokuapp.com/"; //Directing the url for this automation test

            //Using the FindElementByLinkText to click on the Form authentication page
            driver.FindElement(By.LinkText("Form Authentication")).Click();

            //Using the FindElementById to find the username and password boxes
            var username = driver.FindElementById("username");
            var password = driver.FindElementById("password");

            //Using SendKeys to send the assigned username, passwords assigned by me
            username.SendKeys("tomsmith");
            password.SendKeys("wrongpassword");

            //Using FindElementByClassName to find the class used to define the submit button
            var submit = driver.FindElementByClassName("radius");
            submit.Click();

            //Asserting that the username input by the user is the same as the username
            Assert.AreEqual(username, username);
            //Asserting that the password input by the user is the same as the password
            Assert.AreEqual(password, password);

            driver.Close();
        }


        [Test]
        public void ThisTestWillLogin_WithTheIncorrectUsernameAndCorrectPassword_AndAssertLoginValidation()
        {
            var driver = new ChromeDriver(); 
            driver.Url = "http://the-internet.herokuapp.com/"; 

            driver.FindElement(By.LinkText("Form Authentication")).Click();

            var username = driver.FindElementById("username");
            var password = driver.FindElementById("password");

            //Using SendKeys to send the assigned username, passwords assigned by me
            username.SendKeys("JohnDoe");
            password.SendKeys("SuperSecretPassword!");

            //Using FindElementByClassName to find the class used to define the submit button
            var submit = driver.FindElementByClassName("radius");
            submit.Click();

            //Asserting that the username input by the user is the same as the username
            Assert.AreEqual(username, username);
            //Asserting that the password input by the user is the same as the password
            Assert.AreEqual(password, password);

            driver.Close();
        }


        [Test]
        public void ThisTestWillLogin_WithTheCorrectUserCredentials_AndThenLogout()
        {
            var driver = new ChromeDriver();
            driver.Url = "http://the-internet.herokuapp.com/";

            driver.FindElement(By.LinkText("Form Authentication")).Click();

            //Using the FindElementById to find the username and password boxes
            var username = driver.FindElementById("username");
            var password = driver.FindElementById("password");

            //Using SendKeys to send the assigned username, passwords assigned by me
            username.SendKeys("tomsmith");
            password.SendKeys("SuperSecretPassword!");

            //Using FindElementByClassName to find the class used to define the submit button
            var submit = driver.FindElementByClassName("radius");
            submit.Click();

            //Using FindElementByLinkText to find Logout button and click it
            driver.FindElement(By.LinkText("Logout")).Click();

            driver.Close();
        }
    }
}