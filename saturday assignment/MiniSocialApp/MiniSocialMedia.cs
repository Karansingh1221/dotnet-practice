using System;
using PostClass;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UserExtensionsClass;
using SocialUtilsClass;
using RepositoryClass;
using UserClass;
namespace MiniSocialMedia{
    class SocialException:Exception{
        public SocialException(string message):base(message){}
        public SocialException(string message,Exception inner):base(message,inner){}
    }
    interface IPostable{
        void AddPost(string content);
        IReadOnlyList<Post> GetPosts();
    }
    public class SavedPost
    {
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class SavedUser
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public List<string> Following { get; set; }
        public List<SavedPost> Posts { get; set; }
    }
    public static class Logger
    {
        public static void Log(string message)
        {
            File.AppendAllText("log.txt",
                DateTime.Now + " : " + message + Environment.NewLine);
        }
    }
}