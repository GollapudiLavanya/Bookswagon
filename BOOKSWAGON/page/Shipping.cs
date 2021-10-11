using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOOKSWAGON.page
{
    public class Shipping
    {
        public static IWebDriver driver;
        public Shipping(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Continue')]")]
        [CacheLookup]
        public IWebElement ContinueBtn;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewRecipientName")]
        [CacheLookup]
        public IWebElement RecipientName;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewCompanyName")]
        [CacheLookup]
        public IWebElement CompanyName;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewAddress")]
        [CacheLookup]
        public IWebElement StreetAddress;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewLandmark")]
        [CacheLookup]
        public IWebElement Landmark;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCountry")]
        [CacheLookup]
        public IWebElement Country;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewState")]
        [CacheLookup]
        public IWebElement State;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCities")]
        [CacheLookup]
        public IWebElement City;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewPincode")]
        [CacheLookup]
        public IWebElement Pincoode;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewMobile")]
        [CacheLookup]
        public IWebElement Mobile;

        [FindsBy(How = How.Id, Using = "ctl00_cpBody_chkNewDefault")]
        [CacheLookup]
        public IWebElement Checkbox;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$imgSaveNew")]
        [CacheLookup]
        public IWebElement Save;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ShoppingCart$lvCart$savecontinue")]
        [CacheLookup]
        public IWebElement SaveAndContinue;




    }
}
