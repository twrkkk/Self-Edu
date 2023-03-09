using System.Collections.Generic;

namespace StructBenchmarking
{
    interface IExperiment
    {
        ITask CreateTask(int size);
    }

    public class ClassArray : IExperiment
    {
        public ITask CreateTask(int size)
        {
            return new ClassArrayCreationTask(size);
        }
    }

    public class StructArray : IExperiment
    {
        public ITask CreateTask(int size)
        {
            return new StructArrayCreationTask(size);
        }
    }

    public class ClassMethod : IExperiment
    {
        public ITask CreateTask(int size)
        {
            return new MethodCallWithClassArgumentTask(size);
        }
    }

    public class StructMethod : IExperiment
    {
        public ITask CreateTask(int size)
        {
            return new MethodCallWithStructArgumentTask(size);
        }
    }

    public class Experiments
    {
        private static List<ExperimentResult> MakeExperiment(IBenchmark benchmark, IExperiment experiment, int repetitionCount)
        {
            List<ExperimentResult> results = new List<ExperimentResult>();

            foreach (var size in Constants.FieldCounts)
            {
                double time = benchmark.MeasureDurationInMs(experiment.CreateTask(size), repetitionCount);
                ExperimentResult result = new ExperimentResult(size, time);
                results.Add(result);
            }

            return results;
        }

        public static ChartData BuildChartDataForArrayCreation(
            IBenchmark benchmark, int repetitionCount)
        {
            List<ExperimentResult> classesTimes = MakeExperiment(benchmark, new ClassArray(), repetitionCount);
            List<ExperimentResult> structuresTimes = MakeExperiment(benchmark, new StructArray(), repetitionCount);

            return new ChartData
            {
                Title = "Create array",
                ClassPoints = classesTimes,
                StructPoints = structuresTimes,
            };
        }

        public static ChartData BuildChartDataForMethodCall(
            IBenchmark benchmark, int repetitionCount)
        {
            List<ExperimentResult> classesTimes = MakeExperiment(benchmark, new ClassMethod(), repetitionCount);
            List<ExperimentResult> structuresTimes = MakeExperiment(benchmark, new StructMethod(), repetitionCount);

            return new ChartData
            {
                Title = "Call method with argument",
                ClassPoints = classesTimes,
                StructPoints = structuresTimes,
            };
        }
    }
}