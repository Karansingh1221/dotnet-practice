using System;
using UserClass;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using MiniSocialMedia;
using RepositoryClass;
using SocialUtilsClass;
using UserExtensionsClass;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
namespace PostClass
{
    public class Post{
            public User Author;
            public string Content{get;init;}
            public DateTime CreatedAt{get;}=DateTime.UtcNow;
            public Post(User a,string content){
                if(a==null){
                    throw new SocialException("Invalid Author");
                }
                this.Author=a;
                this.Content=content;
            }
            public override string ToString(){
                StringBuilder sb= new StringBuilder();
                sb.AppendLine($"{Author.Username}.{CreatedAt}");
                sb.AppendLine($"{Content}");
                string pattern=@"#[A-Za-z]+";
                MatchCollection hashtags=Regex.Matches(Content,pattern);
                if (hashtags.Count > 0)
                {
                    sb.Append("Tags: ");
                    sb.AppendJoin(", ",hashtags.Cast<Match>().Select(m=>m.Value));
                }
                return sb.ToString().TrimEnd();
            }
        }
}