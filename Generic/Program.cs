using System;
struct PriceSnapshot{
    public string stock_symbol;
    public double stock_price;
}
abstract class Trade{
    public int trade_id{get;set;}
    public string stock_symbol{get;set;}
    public int quantity{get;set;}
    public abstract double Calculate_value();
    public override string ToString(){
        return $"{trade_id}, {stock_symbol}, {quantity}";
    }
}
class EquityTrade:Trade{
    public double? marketprice{get;set;}
    public override double Calculate_value(){

        double price=marketprice??0.0;
        return price*quantity;
    }
    public void display(){
        Console.WriteLine("Parent Matching");
    }
}
class TradeRepository<T> where T:EquityTrade{
    private List<T> l=new List<T>();
    public void add(T x){
        l.Add(x);
    }
    public int TradeCount(){
        return l.Count;
    }
}
static class TradeAnalytics{
    public static int total_trade;
    public static void display(){
        Console.WriteLine(total_trade);
    }
}
static class Extensions{
    public static double price=100000;
    public static double Brokerage(this double amt){
        price+=amt;
        return price;
    }
    public static double Tax(this double t){
        return t*price/100;
    }
}
class MainClass{
    public static void Main(string[] args){
        PriceSnapshot ps=new PriceSnapshot{stock_symbol="Appl",stock_price=12000};
        Console.WriteLine($"Stock Symbol={ps.stock_symbol}, Stock Price={ps.stock_price}");
        EquityTrade t=new EquityTrade();
        t.trade_id=1;
        t.stock_symbol="tcs";
        t.quantity=100;
        t.marketprice=123;
        Console.WriteLine(t);
        Console.WriteLine(t.Calculate_value());
        TradeRepository<EquityTrade> tr=new TradeRepository<EquityTrade>();
        tr.add(new EquityTrade{trade_id=1,stock_symbol="jag",quantity=90});
        tr.add(new EquityTrade{trade_id=2,stock_symbol="kar",quantity=100});
        Console.WriteLine(tr.TradeCount());
        TradeAnalytics.total_trade=1234;
        TradeAnalytics.display();
        double broker=1200;
        double tax=10;
        Console.WriteLine(broker.Brokerage());
        Console.WriteLine(tax.Tax());
        //parent matching
        Trade trade=new EquityTrade();
        if(trade is EquityTrade et){
            et.display();
        }
        //Box And Unboxing;
        int total_count=12;
        object trc=total_count;
        int total_count2=(int) trc;
        Console.WriteLine(trc);
        Console.WriteLine(total_count2);
    }
}