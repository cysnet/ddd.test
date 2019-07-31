using System;

namespace test.console
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Test.失败;
            Test b = (Test)(-1);
        }
    }
    enum Test
    {
        成功=1,
        失败=2
    }
}
