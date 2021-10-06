/*
 * project = BookswagonAutomation
 * Author = Lavanya Gollapudi
 * Created Date = 06/10/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace BOOKSWAGON.page
{
    public class SignupPassword
    {
        public static IWebDriver driver;
        public SignupPassword(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Signup')]")]
        [CacheLookup]
        public IWebElement SignupBtn;

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

        [FindsBy(How = How.XPath, Using = "//span[@id='ctl00_phBody_SignUp_cvPassword']")]
        [CacheLookup]
        public IWebElement ErrorMsg;

    }
}
