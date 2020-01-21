using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Threading.Tasks;

namespace NunitFrameworkBasic
{
    public  class Nunit
    {
       IWebDriver driver;

        [SetUp]
        public  void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public  void OpenWebsite()
        {    
            driver.Navigate().GoToUrl("https://demo.nopcommerce.com");           
            Thread.Sleep(3000);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }

    }
}