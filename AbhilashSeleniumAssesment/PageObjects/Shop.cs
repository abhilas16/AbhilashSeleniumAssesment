using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System.Text.RegularExpressions;

namespace AbhilashSeleniumAssesment.PageObjects
{
    public class Shop
    {
        private IWebDriver driver;
        public Shop(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        //Add Items to the Cart
        public List<IWebElement> addItems => driver.FindElements(By.XPath(".//a[ text()= \"Add to cart\"]")).ToList();
        
      

        List<int> randomNumber = new List<int>();
        public void addItemsToCart()
        {
            //for (int j = 1; j < 5; j++)
            //{
            //    Random rnd = new Random();
            //    randomNumber.Add(rnd.Next(1,9));
            //    addItems[randomNumber[j]].Click();
            //    Thread.Sleep(200);

            //}

            addItems[3].Click();
            Thread.Sleep(200);
            addItems[4].Click();
            Thread.Sleep(200);
            addItems[7].Click();
            Thread.Sleep(200);
            addItems[8].Click();
            Thread.Sleep(200);

        }





    }

}





//public void AddRandomItems()
//{
//    addItems[3].Click();
//    addItems[5].Click();
//    addItems[7].Click();
//    // randomItems3.Click();
//    Thread.Sleep(500);
//    //cart.Click();

//   // int a = noOfProducts.Count;
//    String b = test(lowestProduct[2].Text);

//    int d = Int32.Parse(b);


//    for (int i =0;i<lowestProduct.Count;i++)
//    {
//        c.Add(Int32.Parse(test(lowestProduct[i].Text)));
//    }

//    int index = c.IndexOf(c.Min());

//    remove[index].Click();
//    Thread.Sleep(50);



//    Console.WriteLine("Hello World");
//}



// driver.FindElement(Accept).Click();
//driver.FindElement(Search).SendKeys(a);



//    IWebElement searchBox = driver.FindElement(By.XPath(".//textarea[@id=\"APjFqb\"]"));
//searchBox.SendKeys(selenium);

