using System;
using Bakery;
class MainClass{
    public static Chocolate CalculateDiscountPrice(Chocolate c){
        double perc=0;
            switch(c.flavour){
                case "Dark":
                    perc=18;
                    break;
                case "Milk":
                perc=12;
                break;
                case "White":
                perc=6;
                break;
            }
            c.totalprice=c.quantity*c.priceperunit;
            c.discountPrice=c.totalprice-(c.totalprice*perc/100);
            return c;
    }
    public static void Main(string[] args){
        Chocolate c=new Chocolate();
        Console.WriteLine("Enter Chocolate Flavour: ");
        c.flavour=Console.ReadLine();
        if(!c.ValidateFlavour()){
            Console.WriteLine("Invalid Flavour");
            return;
        }
        Console.WriteLine("Enter quantity: ");
        c.quantity=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter price per unit: ");
        c.priceperunit=int.Parse(Console.ReadLine());
        c=CalculateDiscountPrice(c);
        Console.WriteLine($"Flavour: {c.flavour}");
        Console.WriteLine($"Quantity: {c.quantity}");
        Console.WriteLine($"Price Per Unit: {c.priceperunit}");
        Console.WriteLine($"Total Price: {c.totalprice}");
        Console.WriteLine($"Discounted Price: {c.discountPrice}");
    }
}