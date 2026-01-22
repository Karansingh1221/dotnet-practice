namespace AssignmentDll
{
    public interface I1
    {
        void M1();
        void M2();
    }
    public interface I2
    {
        void M3();
    }
    public interface I3
    {
        void M4();
    }
    public class ClassA:I1
    {
        public void M1()
        {
            Console.WriteLine("M1 method called");
        }
        public void M2()
        {
            Console.WriteLine("M2 method called");
        }
        public void M3()
        {
            Console.WriteLine("M3 method called");
        }
        public void M4()
        {
            Console.WriteLine("M4 method called");
        }
    }
    public class ClassB : ClassA
    {
        public void M5()
        {
            Console.WriteLine("M5 method called");
        }
    }
}
