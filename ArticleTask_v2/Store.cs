using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleTask_v2
{
    public class Store
    {
        private Article[] articles = new Article[]
        {
            new Article("Product 1", "Store 1", 45),
            new Article("Product 2", "Store 2", 60),
            new Article("Product 3", "Store 3", 75)
        };

        public void GetArticle(string name)
        {
            foreach (var item in articles)
            {
                if (item.ProductName.ToLower() == name.ToLower())
                {
                    Console.WriteLine("Store name: {0}", item.StoreName);
                    Console.WriteLine("Cost: {0}", item.Cost);
                }
            }
        }
    }
}