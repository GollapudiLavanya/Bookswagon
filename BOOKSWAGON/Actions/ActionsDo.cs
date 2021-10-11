/*
 * project = BookswagonAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 05/10/2021
 */

using BOOKSWAGON.page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using log4net;
using System;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace BOOKSWAGON.Actions
{
    public class ActionsDo : Base.BaseClass
    {
        public static Login login;
        private static readonly ILog log = LogManager.GetLogger(typeof(Tests));

        public static void AssertAfterLauching(IWebDriver driver)
        {
            string title1 = "Online Bookstore | Buy Books Online | Read Books Online";
            string title = driver.Title;
            Assert.AreEqual(title1, title);
        }
        public static void SignUpOption(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\BOOKSWAGON\BOOKSWAGON\TestDataFiles\Bookswagen Credentials.xlsx");

                SignUp signup = new SignUp(driver);

                signup.SignupBtn.Click();
                System.Threading.Thread.Sleep(1000);

                Assert.IsTrue(signup.SignupPage.Displayed);

                signup.Email.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(1000);

                signup.Password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);

                signup.ConfirmPassword.SendKeys(ExcelOperations.ReadData(1, "ConfirmPassword"));
                System.Threading.Thread.Sleep(1000);

                signup.CreateAccount.Click();
                System.Threading.Thread.Sleep(1000);

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");
            }
        }

        public static void LoginToBookswagen(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\BOOKSWAGON\BOOKSWAGON\TestDataFiles\BookswagenLogin.xlsx");
                login = new Login(driver);

                login.SignInBtn.Click();
                System.Threading.Thread.Sleep(1000);

                login.Email.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(1000);

                login.Password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);

                login.LoginBtn.Click();
                System.Threading.Thread.Sleep(1000);

                log.Info("Loggin Succesfull");
                System.Threading.Thread.Sleep(1000);

                String actualUrl = "https://www.bookswagon.com/myaccount.aspx";
                String expectedUrl = driver.Url;
                Assert.AreEqual(actualUrl, expectedUrl);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");

            }
        }

        public static void SerchingABook(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\BOOKSWAGON\BOOKSWAGON\TestDataFiles\Bookswagen search.xlsx");

                Search search = new Search(driver);

                search.SearchBar.SendKeys(ExcelOperations.ReadData(1, "Author"));
                if (search.SearchBar != null)
                {
                    search.SearchBar.SendKeys(Keys.ArrowDown);
                    search.SearchBar.SendKeys(Keys.ArrowDown);
                    search.SearchBar.SendKeys(Keys.Enter);
                    System.Threading.Thread.Sleep(1000);

                    //search.Book.Click();
                    //System.Threading.Thread.Sleep(1000);
                }

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");
            }
        }

        public static void AddtoWishlist(IWebDriver driver)
        {
            try
            {
                Wishlist list = new Wishlist(driver);

                Actions.ActionsDo.LoginToBookswagen(driver);

                Actions.ActionsDo.SerchingABook(driver);

                list.WishlistBtn.Click();
                System.Threading.Thread.Sleep(1000);

                Assert.IsTrue(list.wishlist.Displayed);


            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");
            }
        }

        public static void PlaceOrder(IWebDriver driver)
        {
            Actions.ActionsDo.LoginToBookswagen(driver);
            Actions.ActionsDo.SerchingABook(driver);

            Order order = new Order(driver);

            order.BuynowBtn.Click();
            System.Threading.Thread.Sleep(2000);

            driver.SwitchTo().Frame(0);

            order.QuantityBtn.SendKeys(Keys.ArrowRight);
            order.QuantityBtn.SendKeys(Keys.Backspace);
            order.QuantityBtn.SendKeys("3");
            //order.QuantityBtn.SendKeys(Keys.Enter);

            order.PlaceorderBtn.Click();
            System.Threading.Thread.Sleep(2000);
        }

        public static void BuyProduct(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\BOOKSWAGON\BOOKSWAGON\TestDataFiles\BookSwagonAddresss.xlsx");

                Shipping shipping = new Shipping(driver);

                Actions.ActionsDo.PlaceOrder(driver);

                shipping.ContinueBtn.Click();
                System.Threading.Thread.Sleep(1000);

                shipping.RecipientName.SendKeys(ExcelOperations.ReadData(1, "Name"));
                System.Threading.Thread.Sleep(1000);

                shipping.CompanyName.SendKeys(ExcelOperations.ReadData(1, "CompanyName"));
                System.Threading.Thread.Sleep(1000);

                shipping.StreetAddress.SendKeys(ExcelOperations.ReadData(1, "Address"));
                System.Threading.Thread.Sleep(1000);

                shipping.Landmark.SendKeys(ExcelOperations.ReadData(1, "Landmark"));
                System.Threading.Thread.Sleep(1000);

                shipping.Country.SendKeys(ExcelOperations.ReadData(1, "Country"));
                System.Threading.Thread.Sleep(1000);

                shipping.State.SendKeys(ExcelOperations.ReadData(1, "State"));
                System.Threading.Thread.Sleep(1000);

                shipping.City.SendKeys(ExcelOperations.ReadData(1, "City"));
                System.Threading.Thread.Sleep(1000);

                shipping.Pincoode.SendKeys(ExcelOperations.ReadData(1, "Pincode"));
                System.Threading.Thread.Sleep(1000);

                shipping.Mobile.SendKeys(ExcelOperations.ReadData(1, "Mobile"));
                System.Threading.Thread.Sleep(1000);

                shipping.Checkbox.Click();
                System.Threading.Thread.Sleep(1000);

                shipping.Save.Click();
                System.Threading.Thread.Sleep(1000);

                shipping.SaveAndContinue.Click();
                System.Threading.Thread.Sleep(1000);

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");

            }
        }

        public static void Logout(IWebDriver driver)
        {
            try
            {
                Logout logout = new Logout(driver);

                Actions.ActionsDo.LoginToBookswagen(driver);

                logout.Profile.Click();
                System.Threading.Thread.Sleep(1000);

                logout.LogoutBtn.Click();
                System.Threading.Thread.Sleep(1000);

                Assert.IsTrue(logout.Loginpage.Displayed);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");
            }
        }

        public static void LoginWithInvalidPassword(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\BOOKSWAGON\BOOKSWAGON\TestDataFiles\BookswagonInvalidPassword.xlsx");

                InvalidPassword pwd = new InvalidPassword(driver);

                pwd.SigninBtn.Click();
                System.Threading.Thread.Sleep(1000);

                pwd.Email.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(1000);

                pwd.Password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);

                pwd.LoginBtn.Click();
                System.Threading.Thread.Sleep(1000);

                log.Info("Error Messsage Displayed");
                System.Threading.Thread.Sleep(1000);

                Assert.IsTrue(pwd.ErrorMsg.Displayed);

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");

            }
        }

        public static void SignUpWithInvalidPassword(IWebDriver driver)
        {
            try
            {
                ExcelOperations.PopulateInCollection(@"C:\Users\lavanya.g\source\repos\BOOKSWAGON\BOOKSWAGON\TestDataFiles\BookswagonSignPassword.xlsx");

                SignupPassword signup = new SignupPassword(driver);

                signup.SignupBtn.Click();
                System.Threading.Thread.Sleep(1000);

                signup.Email.SendKeys(ExcelOperations.ReadData(1, "Username"));
                System.Threading.Thread.Sleep(1000);

                signup.Password.SendKeys(ExcelOperations.ReadData(1, "Password"));
                System.Threading.Thread.Sleep(1000);

                signup.ConfirmPassword.SendKeys(ExcelOperations.ReadData(1, "ConfirmPassword"));
                System.Threading.Thread.Sleep(1000);

                signup.CreateAccount.Click();
                System.Threading.Thread.Sleep(1000);

                Assert.IsTrue(signup.ErrorMsg.Displayed);

            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchSessionException, "Chrome session not established");

            }
        }

    }
}
