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
    public class SignUp
    {
        public static IWebDriver driver;
        public SignUp(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Signup')]")]
        [CacheLookup]
        public IWebElement SignupBtn;

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[4]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[6]")]
        [CacheLookup]
        public IWebElement SignupPage;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignUp_txtEmail']")]
        [CacheLookup]
        public IWebElement Email;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignUp_txtPassword']")]
        [CacheLookup]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//input[@id='ctl00_phBody_SignUp_txtConfirmPwd']")]
        [CacheLookup]
        public IWebElement ConfirmPassword;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$btnSubmit")]
        [CacheLookup]
        public IWebElement CreateAccount;

    }
}
