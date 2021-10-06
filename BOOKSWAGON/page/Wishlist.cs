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
    public class Wishlist
    {
        public static IWebDriver driver;
        public Wishlist(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
       
        [FindsBy(How = How.XPath, Using = "//*[@class='btn-black']")]
        [CacheLookup]
        public IWebElement WishlistBtn;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_lblheading")]
        [CacheLookup]
        public IWebElement wishlist;
    }
}
