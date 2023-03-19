using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebDriverStudentsPOM.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(WebDriver driver) : base(driver)
        {
        }
        public override string BaseUrl => "https://studentregistry.softuniqa.repl.co/";
        public IWebElement RegisteredStudentsLabel => driver.FindElement(By.XPath("/html/body/p"));

        public string GetRegisteredStudentsLabel()
        {
            return RegisteredStudentsLabel.Text;
        }
    }
}
