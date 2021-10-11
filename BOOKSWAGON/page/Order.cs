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
        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[3]/div[2]/div[1]/div[4]/div[5]/a[1]/input[1]")]
        [CacheLookup]
        public IWebElement BuynowBtn;

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/form[1]/div[3]/div[2]/div[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[3]/input[1]")]
        [CacheLookup]
        public IWebElement QuantityBtn;

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[3]/div[2]/div[1]/div[1]/div[4]/table[1]/tbody[1]/tr[1]/td[3]/input[1]")]
        [CacheLookup]
        public IWebElement PlaceorderBtn;


    }
}
