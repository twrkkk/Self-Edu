using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using NUnit.Framework;

namespace StructBenchmarking
{
    public class Benchmark : IBenchmark
    {
        public void WarmUpTask(ITask task)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Restart();
            task.Run();
            Thread.Sleep(1000);
            stopwatch.Stop();
        }

        public double MeasureDurationInMs(ITask task, int repetitionCount)
        {
            GC.Collect();                   // Эти две строчки нужны, чтобы уменьшить вероятность того,
            GC.WaitForPendingFinalizers();  // что Garbadge Collector вызовется в середине измерений
                                            // и как-то повлияет на них.
            Stopwatch watch = new Stopwatch();
            WarmUpTask(task); // вызов для "разогрева"
            watch.Restart();

            for (int i = 0; i < repetitionCount; i++)
                task.Run();
            watch.Stop();

            return (double)watch.ElapsedMilliseconds / repetitionCount;
        }
    }

    [TestFixture]
    public class BuilderTest : ITask
    {
        public void Run()
        {
            StringBuilder builder = new StringBuilder();
            int size = Constants.ArraySize;
            for (int i = 0; i < size; i++)
                builder.Append('a');
            builder.ToString();
        }
    }

    public class ConstructorTest : ITask
    {
        public void Run()
        {
            string str = new string('a', Constants.ArraySize);
        }
    }

    public class RealBenchmarkUsageSample
    {
        [Test]
        public void StringConstructorFasterThanStringBuilder()
        {
            Benchmark benchmark = new Benchmark();
            BuilderTest stringBuilderTest = new BuilderTest();
            ConstructorTest stringTest = new ConstructorTest();
            double builderTime = benchmark.MeasureDurationInMs(stringBuilderTest, Constants.ArraySize);
            double constructorTime = benchmark.MeasureDurationInMs(stringTest, Constants.ArraySize);
            Assert.Less(constructorTime, builderTime);
        }
    }
}
