using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverStudentsPOM.Pages
{
    public class ViewStudentsPage: BasePage
    {
        public ViewStudentsPage(WebDriver driver) : base(driver)
        {
        }
        public override string BaseUrl => "https://studentregistry.softuniqa.repl.co/students";
        public ReadOnlyCollection<IWebElement> StudentsList => driver.FindElements(By.CssSelector("body > ul > li"));

        public string GetFirstStudent()
        {
            return StudentsList[0].Text;
        }
        public string GetSecondStudent()
        {
            return StudentsList[1].Text;
        }
    }
}
