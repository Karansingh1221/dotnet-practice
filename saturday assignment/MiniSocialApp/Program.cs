using System;
using System.IO;
using System.Text.Json;
using MiniSocialMedia;
using UserClass;
using PostClass;
using System.Threading;
using RepositoryClass;
using SocialUtilsClass;
class MainClass{
    private static Repository<User> users=new Repository<User>();
    private static User CurrentUser=null;
    private static readonly string datafile="social-data.json";
    public static void Main(string[] args){
        Console.WriteLine("MiniSocial - Console Edition");
        Console.WriteLine("=== MiniSocial ===");
        LoadData();
        while(true){
        if(CurrentUser==null){
            ShowLoginMenu();
        }else{
            ShowMainMenu();
        }
        }
    }
    public static void ShowLoginMenu(){
        try{
            int option=-1;
            do{
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                option=int.Parse(Console.ReadLine());
                switch(option){
                    case 1:
                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                    case 0:
                        SaveData();
                        Console.WriteLine("Exiting Login Menu");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }while(option!=0);
        }
        catch(SocialException e){
            Console.WriteLine(e.Message);
        }
    }
    private static void ShowMainMenu(){
        try{
            int option=-1;
            do{
                Console.WriteLine("1.Post message");
                Console.WriteLine("2.View my posts");
                Console.WriteLine("3.View timeline(feed");
                Console.WriteLine("4.Follow user");
                Console.WriteLine("5.List users");
                Console.WriteLine("6.Logout");
                Console.WriteLine("0.Exit and save");
                Console.Write("Enter your choice: ");
                option=int.Parse(Console.ReadLine());
                switch(option){
                    case 1:
                        PostMessage();
                        break;
                    case 2:
                        ViewPost(CurrentUser.GetPosts());
                        break;
                    case 3:
                        ViewFeed();
                        break;
                    case 4:
                        FollowUser();
                        break;
                    case 5:
                        ListUser();
                        break;
                    case 6:
                        LogOut();
                        break;
                    case 0:
                        SaveData();
                        Console.WriteLine("Exiting main menu");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }while(option!=0);
        }catch(SocialException ex){
            Console.WriteLine(ex.Message);
        }
    }
    public static void LogOut(){
        Console.WriteLine("Logging Out");
        Thread.Sleep(1000);
        CurrentUser=null;
        Environment.Exit(0);
    }
    public static void SaveData(){
        var data =users.GetAll().Select(u => new SavedUser
            {
                Username = u.Username,Email = u.Email,
                Following = users.GetAll().Where(x => u.IsFollowing(x.Username))
                            .Select(x => x.Username).ToList(),
                Posts = u.GetPosts().Select(p => new SavedPost
                        {
                            Content = p.Content,CreatedAt = p.CreatedAt
                        })
                        .ToList()
            })
            .ToList();
            string json = JsonSerializer.Serialize(data,new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(datafile, json);
            Console.WriteLine("Data saved.");
    }
    public static void ListUser(){
        Console.WriteLine("Registered users:");
        var Sorted=users.GetAll().OrderBy(x=>x.Username);
        foreach(User u in Sorted){
            Console.WriteLine($"@{u.Username} : {u.Email}");
        }
    }
    public static void FollowUser(){
        if(CurrentUser==null){
            Console.WriteLine("No user logged in");
            return;
        }
        Console.WriteLine("Enter username to follow: ");
        string name=Console.ReadLine();
        name=name.Trim();
        if(string.IsNullOrWhiteSpace(name)){
            Console.WriteLine("Cancelled.");
            return;
        }
        bool flag=false;
        foreach(User u in users.GetAll()){
            if(string.Equals(u.Username,name,StringComparison.OrdinalIgnoreCase)){
                flag=true;
                break;
            }
        }
        if(flag==false){
            Console.WriteLine("User not found.");
            return;
        }
        CurrentUser.Follow(name);
        Console.WriteLine($"Now following @{name}");
    }
    public static void PostMessage(){
        if(CurrentUser==null){
            Console.WriteLine("No user logged in");
            return;
        }
        Console.WriteLine("Write a Post");
        string content=Console.ReadLine();
        CurrentUser.AddPost(content);
        Console.WriteLine("Successfully Post");
    }
    public static void ViewPost(IReadOnlyList<Post> l){
        if(l.Count==0){
            Console.WriteLine("Not done any post yet");
            return;
        }
        if(l.Count>20){
            for(int i=0;i<20;i++){
                Console.WriteLine(l[i].ToString());
            }
            return;
        }
        for(int i=0;i<l.Count;i++){
            Console.WriteLine(l[i].ToString());
        }
    }
    public static void ViewFeed(){
        if(CurrentUser==null){
            Console.WriteLine("No user logged in.");
            return;
        }
        List<Post> timeline=new List<Post>();
        timeline.AddRange(CurrentUser.GetPosts());
        foreach(User u in users.GetAll()){
            if(CurrentUser.IsFollowing(u.Username)){
                timeline.AddRange(u.GetPosts());
            }
        }
        timeline=timeline.OrderByDescending(x=>x.CreatedAt).ToList();
        Console.WriteLine("=== Your Timeline ===");
        foreach(Post p in timeline){
            Console.WriteLine(p);
        }
    }
    public static void Login(){
        Console.Write("Enter username: ");
        string name=Console.ReadLine();
        Console.Write("Enter email: ");
        string email=Console.ReadLine();
        User user=new User(name,email);
        var found = users.Find(x =>string.Equals(x.Username, name, StringComparison.OrdinalIgnoreCase));
        if(found == null){
            Console.WriteLine("User Not Found");
            return;
        }
        CurrentUser=found;
        Console.WriteLine("Logged in as "+CurrentUser.Username+"!");
        // CurrentUser.OnNewPost?.Invoke("Logged in Successfully");
        ShowMainMenu();
    }
    public static void Register(){
        Console.Write("Enter username: ");
        string name=Console.ReadLine();
        Console.Write("Enter email: ");
        string email=Console.ReadLine();
        User u=new User(name,email);
        var found = users.Find(x =>string.Equals(x.Username, name, StringComparison.OrdinalIgnoreCase));
        if(found != null){
            Console.WriteLine("User already Exist");
            return;
        }
        users.Add(u);
        Console.WriteLine("Welcome on Mini Social Media App");
        CurrentUser=u;
        ShowMainMenu();
    }
    public static void LoadData(){
        try{
            if(!File.Exists(datafile)){
                Console.WriteLine("File Not Found");
                return;
            }
            string json = File.ReadAllText(datafile);
            if(string.IsNullOrWhiteSpace(json)){
                // Console.WriteLine("No user found");
                return;
            }
            List<SavedUser> list = JsonSerializer.Deserialize<List<SavedUser>>(json);
            if(list == null)
                return;
            foreach(var su in list){
                User u = new User(su.Username, su.Email);
                foreach(var p in su.Posts){
                    u.AddPost(p.Content);
                }
                foreach(var name in su.Following){
                    u.Follow(name);
                }
                users.Add(u);
            }
            Console.WriteLine("Data loaded.");
        }
        catch(Exception ex){
            Logger.Log(ex.Message);
            Console.WriteLine("Failed to load data.");
        }
    }

     
}