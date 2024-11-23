using _9_dars.Api.Models;
using System.Reflection;

namespace _9_dars.Api.Services;

public class PostService
{
    public List<Post> posts;

    public PostService()
    {
        posts = new List<Post>();
    }

    public Post AddPost(Post post)
    {
        post.Id = Guid.NewGuid();
        posts.Add(post);

        return post;
    }

    public Post GetPostById(Guid postId)
    {
        foreach (var post in posts)
        {
            if(post.Id == postId)
            {
                return post;
            }
        }

        return null;
    }

    public bool DeletePost(Guid postId)
    {
        var PostsFromDb = GetPostById(postId);
        if (PostsFromDb is null)
        {
            return false;
        }
        posts.Remove(PostsFromDb);
        return true;
    }


    public bool UpdatePost(Post post)
    {
        var PostsFromDb = GetPostById(post.Id);
        if (PostsFromDb is null)
        {
            return false;

        }
        var index = posts.IndexOf(PostsFromDb);
        posts[index] = post;
        return true;
    }

    public List<Post> GetAllPosts()
    {
        return posts;
    }







    public Post GetMostViewedPost()
    {
        var mostViewedPost = posts[0];

        for (var i = 1; i < posts.Count; i++)
        {
            if (mostViewedPost.QuantityViews < posts[i].QuantityViews)
            {
                mostViewedPost = posts[i];
            }
        }
        return mostViewedPost;
    }

    public Post GetMostLikedPost()
    {
        var mostLikedPost = posts[0];
        for (var i = 1; i < posts.Count; i++)
        {
            if (mostLikedPost.QuantityLikes < posts[i].QuantityLikes)
            {
                mostLikedPost = posts[i];
            }
        }
        return mostLikedPost;
    }

    public Post GetMostCommentedPost()
    {

    }

    public List<Post> GetPostsByComment(string comment)
    {
        

        return ;
    }
}
}


