/*
 * project = BookswagonAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 05/10/2021
 */

using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;

namespace BOOKSWAGON
{

    [TestFixture]
    [AllureNUnit]
    public class Tests : Base.BaseClass
    {
        
        [Test, Order(0)]
        public void SigningUp()
        {
            Actions.ActionsDo.AssertAfterLauching(driver);
            Actions.ActionsDo.SignUpOption(driver);
        }

        [Test(Description = "login")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        //[Test, Order(1)]
        public void Login()
        {
            Actions.ActionsDo.LoginToBookswagen(driver);
        }

        [Test, Order(2)]
        public void Search()
        {
            Actions.ActionsDo.SerchingABook(driver);
        }

        [Test(Description = "AddToWishList")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]

        //[Test,Order(3)]
        public void WISHLIST()
        {
            Actions.ActionsDo.AddtoWishlist(driver);
        }

        [Test,Order(4)]
        public void PlacingOrder()
        {
            Actions.ActionsDo.PlaceOrder(driver);
        }

        [Test, Order(5)]
        public void Shipping()
        {
            Actions.ActionsDo.BuyProduct(driver);
        }


        [Test,Order(6)]
        public void LogoutOption()
        {
            Actions.ActionsDo.Logout(driver);
        }

        [Test,Order(7)]
        public void InvalidPassword()
        {
            Actions.ActionsDo.LoginWithInvalidPassword(driver);
            TakeScreenshot(driver);
        }

        [Test,Order(8)]
        public void InvalidSignupPassword()
        {
            Actions.ActionsDo.SignUpWithInvalidPassword(driver);
        }

        
    }
}