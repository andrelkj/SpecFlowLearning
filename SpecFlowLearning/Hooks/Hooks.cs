using System;
using Reqnroll;

namespace SpecFlowLearning.Hooks;

[Binding]
public class Hooks
{
    [BeforeScenario(Order = 1)]
    public static void BeforeScenario()
    {
        Console.WriteLine("Before scenario 1");
    }

    [BeforeScenario(Order = 2)]
    public static void BeforeScenarioNew()
    {
        Console.WriteLine("Before scenario 2");
    }

    [AfterScenario]
    public static void AfterScenario()
    {
        Console.WriteLine("After scenario");
    }

    [BeforeStep]
    public static void BeforeStep()
    {
        Console.WriteLine("Before step");
    }

    [AfterStep]
    public static void AfterStep()
    {
        Console.WriteLine("After step");
    }

    [BeforeFeature]
    public static void BeforeFeature()
    {
        Console.WriteLine("Before feature");
    }

    [AfterFeature]
    public static void AfterFeature()
    {
        Console.WriteLine("After feature");
    }

    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        Console.WriteLine("Before test run");
    }

    [AfterTestRun]
    public static void AfterTestRun()
    {
        Console.WriteLine("After test run");
    }
}