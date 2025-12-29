using System;
class MainClass{
    public static void Main(string[] args){
        // Calculator();
        // Example();
        // int power(int a,int b){
        //     if(b==0){
        //         return 1;
        //     }
        //     b--;
        //     return a*power(a,b);
        // }
        // Console.WriteLine(power(2,5));
        // int num = Convert.ToInt32("50");
        // Console.WriteLine(num);

        IntefaceImp i=new IntefaceImp();
        i.Print();
    }
    interface Example{
        public void Print();
        // public void Scan();
    }
    class IntefaceImp:Example{

        public void Print(){
            Console.WriteLine($"qwerty {age}");
        }
    }
    
    // public static void Calculator(){
    //     int a=10;
    //     int b=5;
    //     void Add(){
    //         Console.WriteLine(a+b);
    //     }
    //     void Subtract(){
    //         Console.WriteLine(a-b);
    //     }
    //     Add();
    //     Subtract();
    // }


    // public static void Example()
    // {
    // int Square(int x)
    // {
    //     return x * x;
    // }
    // Func<int, int> squareLambda = x => x * x;

    // Console.WriteLine(Square(4));
    // Console.WriteLine(squareLambda(4));
    // }
}