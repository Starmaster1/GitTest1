using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lesson12_Selenium.SeleniumTests
{
    [TestFixture]
    public class BaseTest
    {
        protected WebDriver driver;
        protected string expectedUrl_AR = "https://the-internet.herokuapp.com/add_remove_elements/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15); //Добавляем 15 секунд
        }

        [TearDown]
        public void TearDown()
        {
            // driver.Close(); // Закрывает текущую вкладку
           driver.Quit();
        }
    }
}