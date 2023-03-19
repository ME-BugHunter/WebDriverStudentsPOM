using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverStudentsPOM.Pages
{
    public class AddStudentPage : BasePage
    {
        public AddStudentPage(WebDriver driver) : base(driver) { }
        public override string BaseUrl => "https://studentregistry.softuniqa.repl.co/add-student";
        public IWebElement NameLabel => driver.FindElement(By.XPath("//label[@for='name'][contains(.,'Name:')]"));
        public IWebElement EmailLabel => driver.FindElement(By.XPath("//label[@for='email'][contains(.,'Email:')]"));
        public IWebElement NameInputField => driver.FindElement(By.Id("name"));
        public IWebElement EmailInputField => driver.FindElement(By.Id("email"));
        public IWebElement AddBtn => driver.FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement ErrorMessage => driver.FindElement(By.CssSelector("body > div"));

        public string GetNameValue()
        {
            return NameInputField.Text;
        }

        public string GetEmailValue()
        {
            return EmailInputField.Text;
        }

        public void ClickAddBtn()
        {
            AddBtn.Click();
        }

        public void RegisterNewStudent(string name, string email)
        {
            NameInputField.SendKeys(name);
            EmailInputField.SendKeys(email);
            ClickAddBtn();
        }

        public string GetErrorMessage()
        {
            return ErrorMessage.Text;
        }
    }
}
