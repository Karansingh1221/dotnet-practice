using System;
namespace Bakery{
    class Chocolate{
        public string flavour{get;set;}
        public int quantity{get;set;}
        public int priceperunit{get;set;}
        public double totalprice{get;set;}
        public double discountPrice{get;set;}
        public bool ValidateFlavour(){
            if(flavour=="Dark"||flavour=="Milk"||flavour=="White"){
                return true;
            }
            return false;
        }
        
    }
}