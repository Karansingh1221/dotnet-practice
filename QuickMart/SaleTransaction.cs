using System;
namespace Entity{
    class SaleTrasaction{
        public string invoice_no;
        public string c_name;
        public string i_name;
        public int quantity;
        public decimal purchaseAmount;
        public decimal sellingAmount;
        public string pl_status;
        public decimal pl_amount;
        public decimal pl_margin;
        public void getInfo(){
            Console.Write("Enter Invoice No: ");
            invoice_no=Console.ReadLine();
            Console.Write("Enter Customer Name: ");
            c_name=Console.ReadLine();
            Console.Write("Enter Item Name:  ");
            i_name=Console.ReadLine();
            Console.Write("Enter Quantity:  ");
            quantity=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Purchase Amount (total): ");   
            purchaseAmount=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Selling Amount (total): ");
            sellingAmount=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Transaction saved successfully.");
            if(sellingAmount>=purchaseAmount){
                pl_status="PROFIT";
            }else{
                pl_status="LOSS";
            }
            Console.WriteLine("Status: "+pl_status);
            pl_amount=Math.Abs(sellingAmount-purchaseAmount);
            Console.WriteLine($"Profit/Loss Amount: {pl_amount}");
            pl_margin=(pl_amount/purchaseAmount)*100;
            if(pl_status=="PROFIT"){
                Console.WriteLine($"Profit Margin (%): {pl_margin:F2}");
            }else{
                Console.WriteLine($"Loss Margin (%): {pl_margin:F2}");
            }
        }
        public void displayInfo(){
            if(quantity==0){
                Console.WriteLine("No transaction available. Please create a new transaction first.");
            }else{
            Console.WriteLine($"Invoice No: {invoice_no}");
            Console.WriteLine($"Customer Name: {c_name}");
            Console.WriteLine($"Item Name:  {i_name}");
            Console.WriteLine($"Quantity:  {quantity}");
            Console.WriteLine($"Purchase Amount : {purchaseAmount}");   
            Console.WriteLine($"Selling Amount : {sellingAmount}");
            Console.WriteLine($"Status: "+pl_status);
            Console.WriteLine($"Profit/Loss Amount: {pl_amount}");
            if(pl_status=="PROFIT"){
                Console.WriteLine($"Profit Margin (%): {pl_margin:F2}");
            }else{
                Console.WriteLine($"Loss Margin (%): {pl_margin:F2}");
            }
            }
        }

    }
}