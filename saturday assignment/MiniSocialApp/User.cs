using System;
using PostClass;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using MiniSocialMedia;
using RepositoryClass;
using SocialUtilsClass;
using UserExtensionsClass;
using System.Text.RegularExpressions;
namespace UserClass
{
    public partial class User:IPostable,IComparable<User>{
        public string Username{get;init;}
        public string Email{get;init;}
        private List<Post> Posts;
        private readonly HashSet<string> following;
        public event Action<string> OnNewPost;
        
        public User(string username,string email){
            if(string.IsNullOrWhiteSpace(username) || username.Length==0){
                throw new SocialException("Invalid Username="+username);
            }
            string pattern=@"^\w+@\w+\.\w+$";
            username=username.Trim();
            this.Username=username;
            email=email.Trim().ToLower();
            if(!Regex.IsMatch(email,pattern)){
                throw new SocialException("Invalid Email Format");
            }
            this.Email=email;
            Posts=new List<Post>();
            following=new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        }
        public void Follow(string fname)
        {
            if (string.Equals(Username,fname,StringComparison.OrdinalIgnoreCase))
            {
                throw new SocialException("Cannot follow yourself");
            }
            following.Add(fname);
        }
        public bool IsFollowing(string s)=>following.Contains(s);

        public void AddPost(string content){
            if(string.IsNullOrWhiteSpace(content)){
                throw new SocialException("Post content cannot be empty");
            }
            if(content.Length>280){
                throw new SocialException("Post too long (max 280 characters)");
            }
            content=content.Trim();
            Post post=new Post(this,content);
            Posts.Add(post);
            OnNewPost?.Invoke(post.ToString());
        }
        public IReadOnlyList<Post> GetPosts(){
            return Posts;
        }
        public int CompareTo(User other){
            if(other==null){
                return 1;
            }
            return string.Compare(this.Username,other.Username
            ,StringComparison.OrdinalIgnoreCase);
        }
        public override string ToString(){
            return "@"+this.Username;
        }
    }
    public partial class User{
        public string GetDisplayName(){
            return "User: "+this.Username+" "+this.Email;
        }
    }
}