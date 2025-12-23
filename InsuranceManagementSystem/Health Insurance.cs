using System;
using InsuranceClass;
namespace HealthInsuranceClass{
    class HealthInsurance:InsurancePolicy{
        public sealed override int CalculatePremium(){
            return Premium+=2000;
        }
    }
}