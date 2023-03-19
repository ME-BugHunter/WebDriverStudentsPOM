using OpenQA.Selenium;

namespace WebDriverStudentsPOM.Pages
{
    public class HomePage : BasePage
    {
        private readonly IWebDriver driver;
        public HomePage(WebDriver driver) : base(driver) { }
        public override string BaseUrl => "https://studentregistry.softuniqa.repl.co/";
        public IWebElement RegisteredStudentsLabel => driver.FindElement(By.CssSelector("body > p"));
      
    }
}
