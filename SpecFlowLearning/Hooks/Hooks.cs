using System;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Reqnroll;

namespace SpecFlowLearning.Hooks;

[Binding]
public class Hooks(ScenarioContext scenarioContext)
{
    [BeforeScenario("@staging", Order = 1)]
    public async Task BeforeScenario()
    {
        Console.WriteLine("Before scenario 1");
        
        IPlaywright playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false});
        var page = await browser.NewPageAsync();

        await page.SetViewportSizeAsync(1920, 1080);

        scenarioContext["page"] = page;
        scenarioContext["browser"] = browser;
    }

    [BeforeScenario("@prod", Order = 2)]
    public static void BeforeScenarioNew()
    {
        Console.WriteLine("Before scenario 2");
    }

    [AfterScenario]
    public async Task AfterScenario()
    {
        Console.WriteLine("After scenario");

        try
        {
            if (scenarioContext.TryGetValue("browser", out var browserObj) && browserObj is IBrowser browser)
            {
                await browser.CloseAsync();
            }

            if (scenarioContext.TryGetValue("page", out var pageObj) && pageObj is IPage page)
            {
                await page.CloseAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during cleanup: {ex.Message}");
        }
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