using System;

namespace QuartzDotnetAndGenericHost.Services
{
    public class MyService
    {
        public MyService()
        {

        }

        public void MyVoidMethod()
        {
            Console.WriteLine("Void 메서드 실행!!");
        }

        public int MyIntMethod()
        {
            Console.WriteLine("Int 메서드 실행!!");

            return default;
        }
    }
}
