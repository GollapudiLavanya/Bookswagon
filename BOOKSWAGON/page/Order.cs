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
    public class Order
    {
        public static IWebDriver driver;
        public Order(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[1]/div[1]/a[1]/input[1]")]
        [CacheLookup]
        public IWebElement BuyBtn;

        [FindsBy(How = How.XPath, Using = "//input[@id='BookCart_lvCart_imgPayment']")]
        [CacheLookup]
        public IWebElement OrderBtn;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Continue')]")]
        [CacheLookup]
        public IWebElement ContinueBtn;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$lvCustomerAdd$ctrl0$btnUseAddress")]
        [CacheLookup]
        public IWebElement Address;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ShoppingCart$lvCart$savecontinue")]
        [CacheLookup]
        public IWebElement Save;


    }
}
