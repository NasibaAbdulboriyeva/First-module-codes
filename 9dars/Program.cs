using _9_dars.Api.Models;
using _9_dars.Api.Services;


namespace _9dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartFrontend();
        }
    }
    public static void StartFrontend()
    {
        var postService = new PostService();
        while (true)
        {
            Console.WriteLine("1.Add post : ");
            Console.WriteLine("2.Delete post : ");
            Console.WriteLine("3.Update post : ");
            Console.WriteLine("4.Read post : ");
            Console.WriteLine("5.Show most liked post: ");
            Console.WriteLine("6.Show most viewed post: ");
            Console.WriteLine("7.Show most commented post: ");
            Console.WriteLine("8.Add comment to post: ");
            Console.WriteLine("9.Add like to post: ");
            Console.WriteLine("10.Add view to post: ");
            Console.WriteLine("11.Get post by sameComment ");

            Console.Write("Choose an option : ");
            var option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                var post = new Post();
                Console.Write("Enter name : ");
                post.OwnerName = Console.ReadLine();
                Console.Write("Enter description : ");
                post.Description = Console.ReadLine();
                Console.Write("Enter type : ");
                post.Type = Console.ReadLine();
                Console.Write("Enter menu : ");
                post.QuantityLikes = int.Parse(Console.ReadLine());
                post.QuantityViews = int.Parse(Console.ReadLine());
                post.PostedTime = DateTime.Now;

            }

        }
    }
}
