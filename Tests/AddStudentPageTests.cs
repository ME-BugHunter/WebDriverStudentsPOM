using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverStudentsPOM.Pages;

namespace WebDriverStudentsPOM.Tests
{
    public class AddStudentPageTests : BaseTest
    {
        private AddStudentPage page;

        [SetUp]
        public void Setup()
        {
            this.page = new AddStudentPage(driver);
            page.Open();
        }

        [Test]
        public void Test_AddStudentPage_OpenAddStudentsPage()
        {
            page.OpenAddStudentPage();
            page.IsPageOpen();
        }

        [Test]
        public void Test_AddStudentPage_CheckTitle()
        {
            Assert.That(page.GetPageTitle(), Is.EqualTo("Add Student"));
        }

        [Test]
        public void Test_AddStudentPage_CheckHeading()
        {
            var actual = page.GetPageHeading();

            Assert.That(actual, Is.EqualTo("Register New Student"));
        }

        [Test]
        public void Test_AddStudentPage_TryAddStudentWithEmptyName()
        {
            page.RegisterNewStudent("", "maria@yahoo.com");
            string actual = page.GetErrorMessage();

            Assert.That(actual, Is.EqualTo("Cannot add student. Name and email fields are required!"));
        }

        [Test]
        public void Test_AddStudentPage_TryAddStudentWithEmptyEmail()
        {
            page.RegisterNewStudent("Maria", "");
            string actual = page.GetErrorMessage();

            Assert.That(actual, Is.EqualTo("Cannot add student. Name and email fields are required!"));
        }
    }
}
