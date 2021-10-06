/*
 * project = BookswagonAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 05/10/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOOKSWAGON.page
{
    public class Search
    {
        public static IWebDriver driver;
        public Search(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        [CacheLookup]
        public IWebElement SearchBar;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Here, There and Everywhere')]")]
        [CacheLookup]
        public IWebElement Book;

    }
}
