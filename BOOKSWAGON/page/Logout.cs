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
    public class Logout
    {
        public static IWebDriver driver;
        public Logout(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/form[@id='aspnetForm']/div[@id='site-wrapper']/div[1]/div[1]/div[1]/div[4]/div[1]/ul[1]/li[1]/a[1]/span[1]")]
        [CacheLookup]
        public IWebElement Profile;

        [FindsBy(How = How.Id, Using = "ctl00_lnkbtnLogout")]
        [CacheLookup]
        public IWebElement LogoutBtn;

        [FindsBy(How = How.XPath, Using = "//div[@id='site-wrapper']")]
        [CacheLookup]
        public IWebElement Loginpage;
    }
}
