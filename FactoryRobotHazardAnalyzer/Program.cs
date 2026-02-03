using System;
class RobotSafetyException : Exception{
    public RobotSafetyException(string message): base(message){}
}
class MainClass{
    public static void Main(string[] args){
        double arm_precision;
        int worker_density;
        string machinery_state;
        Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
        arm_precision=Convert.ToDouble(Console.ReadLine());
        if(arm_precision<0.0 || arm_precision>1.0){
            throw new RobotSafetyException("Error:  Arm precision must be 0.0-1.0");
        }

        Console.WriteLine("Enter Worker Density (1 - 20):");
        worker_density=Convert.ToInt32(Console.ReadLine());
        if(worker_density<1 || worker_density>20){
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }

        Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
        machinery_state=Console.ReadLine();
        if(machinery_state!="Worn" && machinery_state!="Faulty" && machinery_state!="Critical"){
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }
        double machineRiskFactor;
        if(machinery_state=="Worn"){
            machineRiskFactor=1.3;
        }else if(machinery_state=="Faulty"){
            machineRiskFactor=2.0;
        }else{
            machineRiskFactor=3.0;
        }
        double hazard_risk=((1.0 - arm_precision) * 15.0) + (worker_density * machineRiskFactor);
        Console.WriteLine($"Robot Hazard Risk Score: {hazard_risk}");
    }
}