//Для полного закрепления понимания простых типов найдите любой чек,
//либо фотографию этого чека в интернете и схематично нарисуйте его в консоли

using System;

namespace Task_4
{
    class Receipt
    {
        static void Main(string[] args)
        {
            string todaysDate = DateTime.Today.ToShortDateString();
            string shopName = "Adidas";
            char hashTag = '#';
            int receiptNumber = 12345;
            string productName = "Sports shoes";
            float price = 99.99f;
            char priceSign = '$';
            Console.WriteLine($"-----------------------------------------");
            Console.WriteLine($"----Date---{todaysDate}---------------------");
            Console.WriteLine($"----Shop---{shopName}------------------------");
            Console.WriteLine($"----Receipt{hashTag}---{receiptNumber}---------------------");
            Console.WriteLine($"----Product---{productName}---------------");
            Console.WriteLine($"----Price---{price}{priceSign}-----------------------");
            Console.WriteLine($"-----------------------------------------");

            Console.ReadKey();
        }
    }
}
