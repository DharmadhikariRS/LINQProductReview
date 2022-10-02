namespace LINQoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prodcut Review Management!!!!!!!!");
            Console.WriteLine("Adding a Prodcut Review In list");
            Console.WriteLine("Enter Option: " + "\n1.Add Values to list");
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review 
            List<ProductReview> productReviews = new List<ProductReview>();
            switch (option)
            {
                case 1:
                    ProductReviewManager.AddingProductReview(productReviews);
                    break;
                default:
                    Console.WriteLine("Enter correct number");
                    break;
            }
        }
    }
}