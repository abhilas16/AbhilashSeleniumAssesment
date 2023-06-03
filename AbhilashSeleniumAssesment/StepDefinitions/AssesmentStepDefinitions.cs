using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AbhilashSeleniumAssesment.PageObjects;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace AbhilashSeleniumAssesment.StepDefinitions
{
    [Binding]
    public class AssesmentStepDefinitions
    {
        private static IWebDriver driver = new ChromeDriver();
        Cart c = new Cart(driver);

        public static int index;

        [Given(@"I add four random item to my cart")]
        public void GivenIAddFourRandomItemToMyCart()
        {
           
            driver.Url = "https://cms.demo.katalon.com/";
            Shop s = new Shop(driver);
            s.addItemsToCart();
        }

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
          
            c.goToCart();
        }

        [Then(@"I find total four items listed in my cart")]
        public void ThenIFindTotalFourItemsListedInMyCart()
        {
            
            int y = c.totalNumberOfProducts();
            Assert.IsTrue(c.totalNumberOfProducts() == 4);
        }

        [When(@"I search for lowest price item")]
        public void WhenISearchForLowestPriceItem()
        {
        
            index = c.findLowestPrice();
        }

        [When(@"I am able to remove lowest price item from my cart")]
        public void WhenIAmAbleToRemoveLowestPriceItemFromMyCart()
        {

            
            c.removeCheapProduct(index);
        }

        [Then(@"I am able to verify three items in my cart")]
        public void ThenIAmAbleToVerifyThreeItemsInMyCart()
        {
            int d =  c.noOfProducts.Count();
            Assert.IsTrue(c.totalNumberOfProducts() == 3);
        }
    }
}
