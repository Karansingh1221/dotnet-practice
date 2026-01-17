using System;
using PostClass;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using MiniSocialMedia;
using RepositoryClass;
using UserClass;
using UserExtensionsClass;
namespace SocialUtilsClass
{
    public static class SocialUtils{
        public static string FormatTimeAgo(DateTime pastTime){
            TimeSpan diff=DateTime.UtcNow-pastTime;
            if(diff.TotalSeconds<60){
                return "JustNow";
            }
            else if(diff.TotalMinutes<60){
                return $"{(int)diff.TotalMinutes}min ago";
            }
            else if(diff.TotalHours<24){
                return $"{(int)diff.TotalHours}h ago";
            }
            return pastTime.ToString("MMM dd");//pastTime.ToString("MMM dd,yyyy")
        }
    }
}