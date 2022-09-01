using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1


    {
        FirefoxDriver driver = new FirefoxDriver();

        [TestMethod]
        public void TestMethod1()
        {
           
            ChromeDriver driver1 = new ChromeDriver();

            driver.Url;


            //WebElement driver.get("https://github.com//");



            WebElement element = (WebElement)driver.FindElement(By.XPath("//input[@name='emailid']"));
            element.SendKeys("abc@gmail.com");

            WebElement button = (WebElement)driver.FindElement(By.XPath("//input[@name='btnLogin']"));
            button.Click();


        }
    }
}
