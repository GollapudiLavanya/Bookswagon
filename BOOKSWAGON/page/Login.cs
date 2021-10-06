/*
 * project = BookswagonAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 05/10/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOOKSWAGON.page
{
    public class Login
    {
        public static IWebDriver driver;
        public Login(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        [CacheLookup]
        public IWebElement SignInBtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_txtEmail']")]
        [CacheLookup]
        public IWebElement Email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtPassword")]
        [CacheLookup]
        public IWebElement Password;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$btnLogin")]
        [CacheLookup]
        public IWebElement LoginBtn;

    }
}
