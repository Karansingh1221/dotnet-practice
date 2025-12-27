using System;
namespace Entity{
    class Patient{
        public string bill_id;
        public string p_name;
        public bool has_insurance;
        public decimal consultant_fee;
        public decimal lab_charges;
        public decimal medical_charges;
        public decimal gross_amount;
        public decimal discount_amount;
        public decimal final_amount;
        public void getDetails(){
            Console.WriteLine("Enter Bill Id: ");
            bill_id=Console.ReadLine();
            Console.Write("Enter Patient Name: ");
            p_name=Console.ReadLine();
            Console.WriteLine("Is the patient insured? (Y/N): ");
            char c=Convert.ToChar(Console.ReadLine());
            if(c=='Y'){
                has_insurance=true;
            }else{
                has_insurance=false;
            }
            Console.Write("Enter Consultation Fee: ");
            consultant_fee=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Lab Charges: ");
            lab_charges=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Medicine Charges: ");
            medical_charges=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Bill Created Successfully");
            calculateBill();
            Console.WriteLine($"Gross Amount: {gross_amount:F2}");
            Console.WriteLine($"Discount Amount: {discount_amount:F2}");
            Console.WriteLine($"Final Payable: {final_amount:F2}");

        }
        public void calculateBill(){
            decimal cf=consultant_fee;
            decimal mc=medical_charges;
            decimal lc=lab_charges;
            gross_amount=cf+mc+lc;
            if(gross_amount>0 && has_insurance==true){
                discount_amount=10*gross_amount/100;
                final_amount=gross_amount-discount_amount;
            }else{
                discount_amount=0;
                final_amount=gross_amount;
            }
        }
        public bool checklastbill(){
            bool has_lastbill=false;
            if(gross_amount>0){
                has_lastbill=true;
                Console.WriteLine("-----Last Bill-----");
                display();
            }else{
                Console.WriteLine("Create a Bill first");
                has_lastbill=false;
            }
            return false;
        }
        public void display(){
            Console.WriteLine($"BillId: {bill_id}");
            Console.WriteLine($"Patient: {p_name}");
            if(has_insurance){
                Console.WriteLine($"Insured: Yes");
            }else{
                Console.WriteLine($"Insured: No");
            }
            Console.WriteLine($"Consultation Fee: {consultant_fee}");
            Console.WriteLine($"Lab Charges: {lab_charges}");
            Console.WriteLine($"Medicine Charges: {medical_charges}");
            Console.WriteLine($"Gross Amount: {gross_amount}");
            Console.WriteLine($"Discount Amount: {discount_amount}");
            Console.WriteLine($"Final Payable: {final_amount}");
        }
        public void Clear(){
            consultant_fee = 0;
            lab_charges = 0;
            medical_charges = 0;

            gross_amount = 0;
            discount_amount = 0;
            final_amount = 0;
        }
    }
}