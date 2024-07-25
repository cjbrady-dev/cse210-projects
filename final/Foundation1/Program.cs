using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Amazing Cats", "John Doe", 300);
        Video video2 = new Video("Funny Dogs", "Jane Smith", 200);
        Video video3 = new Video("Cooking Tutorial", "Chef Alex", 600);

        
        video1.AddComment(new Comment("Alice", "This is hilarious!"));
        video1.AddComment(new Comment("Bob", "I love cats!"));
        video1.AddComment(new Comment("Charlie", "So cute!"));

       
        video2.AddComment(new Comment("Dave", "Dogs are the best!"));
        video2.AddComment(new Comment("Eve", "Such a funny video!"));
        video2.AddComment(new Comment("Frank", "Loved it!"));

        
        video3.AddComment(new Comment("Grace", "Great recipe!"));
        video3.AddComment(new Comment("Heidi", "Yummy!"));
        video3.AddComment(new Comment("Ivan", "I will try this at home."));

        
        List<Video> videos = new List<Video> { video1, video2, video3 };

       
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}

class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; }
    public List<Comment> Comments { get; private set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}

class Comment
{
    public string CommenterName { get; private set; }
    public string CommentText { get; private set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}
