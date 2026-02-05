using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace Library_ns{
    public class Book{
        public int Id{get;set;}
        public string Name{get;set;}
        public string Publisher{get;set;}
        public int Price{get;set;}

        public override string ToString(){
            return $"Id:{Id}, Name:{Name}, Publisher:{Publisher}, Price:{Price}";
        }
    }
    public static class Library{
        public static List<Book> repository=new List<Book>();
        public static void AddBook(){
            Console.WriteLine("Enter Book Id:");
            int id=int.Parse(Console.ReadLine());
            if(repository.Any(b=>b.Id==id)){
                Console.WriteLine("Book with this id already exist");
                return;
            }
            Book b=new Book();
            b.Id=id;
            Console.WriteLine("Enter Book Name:");
            b.Name=Console.ReadLine();
            Console.WriteLine("Enter Publisher Name:");
            b.Publisher=Console.ReadLine();
            Console.WriteLine("Enter Price:");
            b.Price=int.Parse(Console.ReadLine());
            repository.Add(b);
        }
        
        public static void SearchBookByName(){
            Console.WriteLine("Enter the book name:");
            string name=Console.ReadLine();
            Book b=repository.FirstOrDefault(b=>b.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
            if(b==null){
                Console.WriteLine("Book Not Found");
                return;
            }
            Console.WriteLine($"Book Found");
            Console.WriteLine(b);
        }

        public static void SearchBookByPublisher(){
            Console.WriteLine("Enter the publisher name:");
            string name=Console.ReadLine();
            Book b=repository.FirstOrDefault(b=>b.Publisher.Equals(name,StringComparison.OrdinalIgnoreCase));
            if(b==null){
                Console.WriteLine("Book Not Found");
                return;
            }
            Console.WriteLine($"{b.Name} is published by {name}");
        }

        public static void HighestPriceBook(){
            if(repository.Count==0){
                Console.WriteLine("There is no book in the library");
                return;
            }
            var b=repository.OrderByDescending(b=>b.Price).First();
            Console.WriteLine($"{b.Name} is having highest price of {b.Price}");
        }

        public static void LowestPriceBook(){
            if(repository.Count==0){
                Console.WriteLine("There is no book in the library");
                return;
            }
            var b=repository.OrderBy(b=>b.Price).First();
            Console.WriteLine($"{b.Name} is having lowest price of {b.Price}");
        }
        
        public static void UpdateBook(){
            if(repository.Count==0){
                Console.WriteLine("There is no book in the library");
                return;
            }
            Console.WriteLine("Enter book id to be updated:");
            int id=int.Parse(Console.ReadLine());
            var book=repository.FirstOrDefault(b=>b.Id==id);
            if(book==null){
                Console.WriteLine($"No book is having id {id}");
                return;
            }
            Console.WriteLine("Enter the updated price");
            int price=int.Parse(Console.ReadLine());
            book.Price=price;
            Console.WriteLine("Price Updated Succesfully");
        }

        public static void DeleteBook(){
            if(repository.Count==0){
                Console.WriteLine("There is no book in the library");
                return;
            }
            Console.WriteLine("Enter the book id which you want to delete:");
            int id=int.Parse(Console.ReadLine());
            // for(int i=0;i<repository.Count;i++){
            //     if(repository[i].Id==id){
            //         repository.RemoveAt(i);
            //         i--;
            //     }
            // }
            var book=repository.FirstOrDefault(b=>b.Id==id);
            if(book==null){
                Console.WriteLine("Book Not Found");
                return;
            }
            repository.Remove(book);
            Console.WriteLine("Book Removed Successfully");
        }
        public static void ViewAllBooks(){
            if(repository.Count==0){
                Console.WriteLine("There is no book in the library");
                return;
            }
            Console.WriteLine("Books in the library are=>");
            foreach(Book b in repository){
                Console.WriteLine(b);
            }
        }   
    }
}