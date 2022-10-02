using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQoperations
{
    internal class ProductReviewManager
    {
        //UC1 Add product details.
        public static void AddingProductReview(List<ProductReview> products)
        {
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Good", rating = 4, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 2, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 4, review = "Good", rating = 4, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 5, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 1, userId = 1, review = "Very Good", rating = 5, isLike = true });
            products.Add(new ProductReview() { productId = 2, userId = 6, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 4, userId = 7, review = "Good", rating = 4, isLike = true });
            products.Add(new ProductReview() { productId = 9, userId = 8, review = "Average", rating = 3, isLike = true });
            products.Add(new ProductReview() { productId = 3, userId = 9, review = "Bad", rating = 1, isLike = false });
            products.Add(new ProductReview() { productId = 5, userId = 4, review = "Average", rating = 2, isLike = true });
          //  DisplayRecord(products);
        }
        public static void DisplayRecord(List<ProductReview> products)
        {
            foreach (ProductReview product in products)
            {
                Console.WriteLine("ProductId:{0}\t UserId:{1}\t Review:{2}\tRating:{3}\tIsLike:{4}\t", product.productId, product.userId, product.review, product.rating, product.isLike);
            }
        }
        /// UC2 Retrieve Top Three Records Whose Rating is High
        public static void RetrieveTopThreeRating(List<ProductReview> products)
        {
            AddingProductReview(products);
            Console.WriteLine("\nRetrieving Top Three Records Based On Rating\n");
            var res = (from product in products orderby product.rating descending select product).Take(3).ToList();
            DisplayRecord(res);
            
        }
        /// 
    }
}
