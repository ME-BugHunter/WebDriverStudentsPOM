using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverStudentsPOM.Pages;

namespace WebDriverStudentsPOM.Tests
{
    public class ViewStudentsPageTests : BaseTest
    {
        private ViewStudentsPage page;

        [SetUp]
        public void Setup()
        {
            this.page = new ViewStudentsPage(driver);
            page.Open();
        }

        [Test]
        public void Test_ViewStudentsPage_OpenViewStudentsPage()
        {
            page.OpenViewStudentsPage();
            page.IsPageOpen();
        }

        [Test]
        public void Test_ViewStudentsPage_CheckTitle()
        {
            Assert.That(page.GetPageTitle(), Is.EqualTo("Students"));
        }
        [Test]
        public void Test_ViewStudentsPage_CheckHeading()
        {
            var actual = page.GetPageHeading();

            Assert.That(actual, Is.EqualTo("Registered Students"));
        }

        [Test]
        public void Test_ViewStudentsPage_CheckFirstStudent()
        {
            var actual = page.GetFirstStudent();

            Assert.That(actual, Is.EqualTo("Marry (marry@gmail.com)"));
        }

        [Test]
        public void Test_ViewStudentsPage_CheckSecondStudent()
        {
            Assert.That(page.GetSecondStudent(), Is.EqualTo("Steve (steve@yahoo.com)"));
        }

        [Test]
        public void Test_ViewStudentsPage_CheckStudentsIsNotEmpty()
        {
            Assert.That(page.GetFirstStudent, Is.Not.Empty);
        }
    }
}
