using System;
namespace Production{
    class Categories{
        public int Category_Id{get;set;}
        public string Category_Name{get;set;}
    }
    class Products{
        public int Product_Id{get;set;}
        public string Product_Name{get;set;}
        public int Branch_Id{get;set;}
        public int Category_Id{get;set;}
        public int Model_Year{get;set;}
        public double List_Price{get;set;}
    }
    class Stocks{
        public int Store_Id{get;set;}
        public int Product_Id{get;set;}
        public int Quantity{get;set;}
    }
    class Brands{
        public int Brand_Id;
        public string Branch_Name{get;set;}
    }
}