using System;
using System.Linq;

namespace Intro
{
    //todo UGLY CODE just playground
    public static class ExtensionMethods
    {
        public static int SuperMethod(this string str)
        {

            return 0;
        }
    }

    public delegate int MySuperDelegate(string name);



    class Program
    {
        public static int TTTT(string ggg)
        {
            return 0;
        }

        public static int TTTT2(string ggg)
        {
            return 0;
        }
        public static int Test1(int a, int b)
        {
            return 0;
        }
        public static int Test1(double a)
        {

            return 0;
        }


        static void Main(string[] args)
        {
            var test4 = new Test4
            {
                BirthDate = DateTime.UtcNow
            };
            var a = Boolean.Parse("das");
            // bool test;
            // var bbb = Boolean.TryParse("asdas", out test);
            if(Boolean.TryParse("asdas", out var aaaaaaaa)){
                
                // tests
                // test
            }

            //test4.BirthDate.Value.

            var test24 = new Test4();


            // Test4.SuperAge

            ExtensionMethods.SuperMethod("asdas");
            MySuperDelegate mySuperDelegate = TTTT;
            mySuperDelegate += TTTT2;
            mySuperDelegate?.Invoke(("asd"));
            mySuperDelegate += g =>
            {
                System.Console.WriteLine("BU");
                return 0;
            };

            var items = new[] { "asd", "asdas" };
            var ittems2 = items.Where(items => items.Length > 2);
            ittems2.ToList();

            "".SuperMethod();
            var test2 = new System.Collections.Generic.List<int>();
            test2.Where(i => true);
            //var a = Test1(5);
            var a2 = Test1(b: 5, a: 7);
            var ab = Test1(5.5);


            Console.WriteLine("Hello World!");
            var test = new Test(55);
            var b = test as ITest;

            test.TestMethod3();
        }
    }

    public class DisposableCusotmObject : IDisposable
    {
        public void Dispose()
        {
            System.Console.WriteLine("Disposed");
        }
    }

    public class AbrakaDabra
    {
        private string name2;
        public string Name2
        {
            get { return name2; }

        }

        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }


        public string Name3 => "";

        public string Name34()
        {
            return "";
        }

        public AbrakaDabra()
        {
            //Name2 = "asdas";
            var tt = Name2;
        }

    }
    public class Test4
    {
        public readonly int MyAge = 0;
        private readonly ITest test;

        public DateTime? BirthDate { get; set; } = DateTime.UtcNow;


        public Test4()
        {

        }
        public Test4(ITest test, DateTime birthDate)
        {
            BirthDate = birthDate;
            MyAge = 87878;
            this.test = test;
        }

        public void Magic(Test4 test4)
        {
            // MyAge = 44;
        }
    }

    public abstract class TestBase
    {
        protected int test8 = 5;
        protected TestBase(int aa)
        {
            MyProperty = aa;
        }
        public int MyProperty { get; set; }

        // public TestBase()
        // {
        //     MyProperty = 48;
        // }

        public abstract void TestMethod();

        public virtual void TestMethod3()
        {
            TestMethod();
            System.Console.WriteLine("Test");
        }
    }

    public class Test : TestBase, ITest
    {
        public Test(int aa) : base(aa)
        {
            this.test8 = 4;
        }

        public int Test2()
        {
            throw new NotImplementedException();
        }

        public override void TestMethod()
        {
            throw new NotImplementedException();
        }

        public override sealed void TestMethod3(){

        }
    }

    public class Test8 : TestBase
    {
        public Test8(int aa) : base(aa)
        {
        }

        public override void TestMethod()
        {
            throw new NotImplementedException();
        }

        public override void TestMethod3(){

        }

    }


    public interface ITest
    {
        int Test2();

        public void DefaultInterfaceMethod()
        {
            System.Console.WriteLine("Bu");
        }
    }


}
