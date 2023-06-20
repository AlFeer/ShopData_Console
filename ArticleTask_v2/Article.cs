using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleTask_v2
{
    public class Article
    {
        private string productName;
        private string storeName;
        private int cost;

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }

        }
        public string StoreName
        {
            get
            {
                return storeName;
            }
            set
            {
                storeName = value;
            }
        }
        public int Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public Article(string productName, string storeName, int cost)
        {
            ProductName = productName;
            StoreName = storeName;
            Cost = cost;
        }
    }
}
