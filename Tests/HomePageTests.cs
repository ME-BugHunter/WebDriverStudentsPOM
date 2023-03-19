using WebDriverStudentsPOM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDriverStudentsPOM.Tests
{
    public class HomePageTests : BaseTest
    {
        private HomePage page;

        [SetUp]
        public void Setup()
        {
            this.page = new HomePage(driver);
            page.Open();
        }

        [Test]
        public void Test_HomePage_OpenHomePage()
        {
            page.OpenHomePage();
            page.IsPageOpen();
        }

        [Test]
        public void Test_HomePage_CheckTitle()
        {
            Assert.That(page.GetPageTitle(), Is.EqualTo("MVC Example"));
        }

        [Test]
        public void Test_HomePage_CheckRegisteredStudentsLabel()
        {
            string actual = page.GetRegisteredStudentsLabel();

            StringAssert.StartsWith("Registered students:", actual);
        }

        [Test]
        public void Test_HomePage_CheckHeading()
        {
            var actual = page.GetPageHeading();

            Assert.That(actual, Is.EqualTo("Students Registry"));
        }
    }
}
