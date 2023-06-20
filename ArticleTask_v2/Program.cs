using System;

namespace ArticleTask_v2
{
    public class Program
    {
        static int Main(string[] args)
        {
            var store = new Store();

            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            store.GetArticle(name);

            return 0;
        }
    }
}
