using System;
using UserClass;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using MiniSocialMedia;
using SocialUtilsClass;
using UserExtensionsClass;
using PostClass;
namespace RepositoryClass
{
    public class Repository<T>where T:class{
        private readonly List<T> items=new List<T>();
        public void Add(T item)=>items.Add(item);
        public IReadOnlyList<T> GetAll()=>items;
        public T? Find(Predicate<T>match)=>items.Find(match);
        
    }
}