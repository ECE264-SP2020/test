using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;


namespace ThreeNumSumTests
{
    //public class MyFixture :IDisposable
    //{
    //    public int score;
    //    //private readonly ITestOutputHelper output;
    //    public ITestOutputHelper output;
    //    public MyFixture()
    //    {
    //        score = new int();
    //        //this.output = output;
    //    }

    //    public void Dispose()
    //    {
    //        //output.WriteLine("Score: {0}", score);
    //        Debug.WriteLine("Dispose Fixture called");
    //    }
    //}

    public class UnitTest1
    {
        
        private readonly ITestOutputHelper output;
        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
            //score = 0;
        }
        
        [Fact]
        public void Test1()
        {
            // setup the output
            var content = new StringBuilder();
            var writer = new StringWriter(content);
            Console.SetOut(writer);

            var reader = new StringReader("5\n4\n7\n");
            Console.SetIn(reader);


            ThreeNumSum.Program.Main(null);
            Assert.Equal("16", content.ToString().TrimEnd());
           
            output.WriteLine("Score: +25");
        }

        [Fact]
        public void Test2()
        {
            // setup the output
            var content = new StringBuilder();
            var writer = new StringWriter(content);
            Console.SetOut(writer);

            var reader = new StringReader("bob\n4\n7\n");
            Console.SetIn(reader);
            ThreeNumSum.Program.Main(null);
            Assert.Equal("Bad Input", content.ToString().TrimEnd());

            output.WriteLine("Score: +50");
        }
        [Fact]
        public void Test3()
        {
            output.WriteLine("Score: +25");
        }
    }
}
