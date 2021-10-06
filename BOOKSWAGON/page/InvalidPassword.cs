/*
 * project = BookswagonAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 06/10/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOOKSWAGON.page
{
    public class InvalidPassword
    {
        public static IWebDriver driver;
        public InvalidPassword(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Login')]")]
        [CacheLookup]
        public IWebElement SigninBtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignIn_txtEmail']")]
        [CacheLookup]
        public IWebElement Email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtPassword")]
        [CacheLookup]
        public IWebElement Password;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$btnLogin")]
        [CacheLookup]
        public IWebElement LoginBtn;

        [FindsBy(How = How.XPath, Using = "//label[@id='ctl00_phBody_SignIn_lblmsg']")]
        [CacheLookup]
        public IWebElement ErrorMsg;

    }
}
