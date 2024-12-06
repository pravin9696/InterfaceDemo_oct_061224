namespace InterfaceDemo_oct_061224
{
    class A
    {
        public static int stn = 33;
        public int nn;
    }
    class B : A
    {
        public void Bmethod()
        {
            int x = nn;
            int y = stn;
        }
    }



    abstract class abClass
    {
        abstract public void show();
    }

    interface IInter1
    {
        public int MyProp { get; set; }//valid
        public static int stVar = 111;//valid
        //public int x;           //invalid
        public const float PI = 3.14f;
        public void show();
       
        public void myMethod()
        {
            Console.WriteLine("this is my method from interface ");
        }


    }

    class BB : IInter1
    {
        public void show()
        {

        }
       
        int IInter1.MyProp { get; set; }


        public void BBMethod()
        {
            int x = IInter1.stVar;
            float y = IInter1.PI;


        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            int n = IInter1.stVar;
            float m = IInter1.PI;
            BB obj = new BB();
            IInter1 I1 = new BB();
            I1.MyProp = 33;

            I1.myMethod();
           
        }
    }
}
