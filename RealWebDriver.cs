using OpenQA.Selenium.Chrome;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string [] args)
        { //we specify the address of our remote selenium server and second the capabilities we want(what browser the test will run on, ie: chrome or ff). 
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub") DesiredCapabilities("firefox", "", new Platform(PlatformType.Mac)));

            driver.Url = "http://www.google.com";

            var searchBox - driver.FindElement(By.Id("gbqfq"));
            searchBox.SendKeys("pluralsight");

            WebDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            var imagesLink = wait.Until(d =>){

                var elements = driver.FindElements(By.ClassName("k1"));
                if(elements.Count > 0)
                    return elements[0];
                return null;
            });


            imagesLink.Click();

            var ul = driver.FindElement(By.ClassName("rg_ul"));
            var firstImageLink = ul.FindElements(By.TagName("a"))[0];
            firstImageLink.Click();
        }
    }
}