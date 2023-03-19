using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverStudentsPOM.Pages
{
    public class BasePage
    {
        protected readonly WebDriver driver;

        public BasePage (WebDriver driver)
        {
            this.driver = driver;
        }

        public virtual string BaseUrl { get; }
        public IWebElement HomeLink => driver.FindElement(By.LinkText("Home"));
        public IWebElement ViewStudentsLink => driver.FindElement(By.LinkText("View Students"));
        public IWebElement AddStudentsLink => driver.FindElement(By.LinkText("Add Student"));
        public IWebElement PageHeadingLabel => driver.FindElement(By.CssSelector("body > h1"));

        public void Open ()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }

        public bool IsPageOpen()
        {
            return driver.Url == BaseUrl;
        }

        public string GetPageHeading()
        {
            return PageHeadingLabel.Text;
        }

        public void OpenHomePage()
        {
            HomeLink.Click();
        }

        public void OpenViewStudentsPage()
        {
            ViewStudentsLink.Click();
        }

        public void OpenAddStudentPage()
        {
            AddStudentsLink.Click();
        }
    }
}
