using System;
using BenchmarkDotNet.Running;

namespace TasksInUnit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
                var summary = BenchmarkRunner.Run<Testing>();
        }
    }
}
