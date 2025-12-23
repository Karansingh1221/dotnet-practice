using System;
using BookClass;
namespace LibraryClass{
    class Library{
        private Dictionary<int,string> books=new Dictionary<int,string>();
        public string this[int id]{
            get{
                if(books.ContainsKey(id)){
                    return books[id];
                }else{
                    return "Book Not Found";
                }
            }
            set{
                books[id]=value;
            }
        }
        public string this[string title]{
            get{
                return books.FirstOrDefault(b=>b.Value==title).Value;
                
            }
        }
    }
}