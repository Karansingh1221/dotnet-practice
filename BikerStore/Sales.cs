using System;
namespace Sales{
    class Customers{
        public int Customer_Id{get;set;}
        public string First_Name{get;set;}
        public string Last_Name{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public string Street{get;set;}
        public string City{get;set;}
        public string State {get;set;}
        public string Zip_Code{get;set;}
        public List<Orders> Product_Ordered{get;set;}=new List<Orders>();
        public void Add_Order(Order ord){
            Product_Ordered.Add(ord);
        }

    }
    class Orders{
        public int Order_Id{get;set;}
        public int Customer_Id{get;set;}
        public string Order_Status{get;set;}
        public DateTime Order_Date{get;set;}
        public DateTime Required_Date{get;set;}
        public DateTime Shipped_Date{get;set;}
        public int Store_Id {get;set;}
        public int Staff_Id{get;set;}
        private List<Order_Items> Ordered_Items=new List<Order_Items>();

    }
    class Staff{
        public int Staff_Id{get;set;}
        public string First_Name{get;set;}
        public string Last_Name{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public bool Active{get;set;}
        public int Store_Id {get;set;}
        public int Manager_Id{get;set;}

    }
    class Stores{
        public int Store_Id{get;set;}
        public string Store_Name{get;set;}
        public string Phone{get;set;}
        public string Email{get;set;}
        public string Street{get;set;}
        public string City{get;set;}
        public string State {get;set;}
        public string Zip_Code{get;set;}
        public List<Staff> staffs{get;set;}=new List<Staff>();
         
    }
    class Order_Items{
        public int Order_Id{get;set;}
        public int Item_Id{get;set;}
        public int Product_Id{get;set;}
        public int Quantity{get;set;}
        public double List_Price{get;set;}
        public double Discount{get;set;}
    }
}