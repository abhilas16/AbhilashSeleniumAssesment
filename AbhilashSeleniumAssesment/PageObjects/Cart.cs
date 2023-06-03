using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Conventions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AbhilashSeleniumAssesment.PageObjects
{
    public class Cart
    {
        private IWebDriver driver;
        public Cart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            

    }

        List<int> c = new List<int>();

        //Navigate to Cart
        public IWebElement cart => driver.FindElement(By.XPath(".//a[text()=\"Cart\"]"));

        //Find total no of products in Cart

        public List<IWebElement> noOfProducts => driver.FindElements(By.XPath(".//td[@class= \"product-price\"]")).ToList();
      //  public List<IWebElement> noOfProducts => driver.FindElements(By.XPath(".//td[@class = \"product-name\"]")).ToList();

        //Find the cheapest product
        public List<IWebElement> lowestProduct => driver.FindElements(By.XPath(".//td[@class = \"product-price\"]/span[@class = \"woocommerce-Price-amount amount\"]")).ToList();

        //Remove the cheapest product
        public List<IWebElement> remove => driver.FindElements(By.XPath(".//a[@class=\"remove\"]")).ToList();

       
        //Method to remove special character from price
        public static string test(string text)
        {
            return Regex.Replace(text, "[^0-9A-Za-z _-]", "");
        }


        //Method to go to Cart
        public void goToCart()
        {
            cart.Click();
        }


        //Method to find total no of products
        public int totalNumberOfProducts()

        {
            int x = noOfProducts.Count;
            return x;
            
        }

        //Method to find the index of cheapest product
        public int findLowestPrice()
        {
            for (int i = 0; i < lowestProduct.Count; i++)
            {
                c.Add(Int32.Parse(test(lowestProduct[i].Text)));
            }

            int d = c.IndexOf(c.Min());
            return d;

        }

        //method to remove cheapest product 
        public void removeCheapProduct(int index)
        {
            int f = index;

            remove[index].Click();
        }


     
    }
}
