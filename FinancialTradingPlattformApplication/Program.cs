Console.WriteLine($"Method name: Main, Thread Id: {Thread.CurrentThread.ManagedThreadId}");

StockMarketTechnicalAnalysisData stockMarketTechnicalAnalysisData =
    new StockMarketTechnicalAnalysisData("STKZA", new DateTime(2023, 1, 1), new DateTime(2021, 1, 1));

DateTime dateBefore = DateTime.Now;
// Call methods synchronously
// decimal[] data1 = stockMarketTechnicalAnalysisData.GetDailyPrices();
// decimal[] data2 = stockMarketTechnicalAnalysisData.GetClosingPrices();
// decimal[] data3 = stockMarketTechnicalAnalysisData.GetPriceHighs();
// decimal[] data4 = stockMarketTechnicalAnalysisData.GetPriceLows();
// decimal[] data5 = stockMarketTechnicalAnalysisData.CalculateStockastics();
// decimal[] data6 = stockMarketTechnicalAnalysisData.CalculateFastMovingAverage();
// decimal[] data7 = stockMarketTechnicalAnalysisData.CalculateSlowMovingAverage();
// decimal[] data8 = stockMarketTechnicalAnalysisData.CalculateUpperBoundBollingBand();
// decimal[] data9 = stockMarketTechnicalAnalysisData.CalculateLowerBoundBollingBand();

// Call methods asynchronously
List<Task<decimal[]>> tasks = new List<Task<decimal[]>>();

Task<decimal[]> getOpeningPricesTask = Task.Run(() => stockMarketTechnicalAnalysisData.GetDailyPrices());
Task<decimal[]> getClosingPricesTask = Task.Run(() => stockMarketTechnicalAnalysisData.GetClosingPrices());
Task<decimal[]> getPriceHighsTask = Task.Run(() => stockMarketTechnicalAnalysisData.GetPriceHighs());
Task<decimal[]> getPriceLowsTask = Task.Run(() => stockMarketTechnicalAnalysisData.GetPriceLows());
Task<decimal[]> getCalculateStockasticsTask = Task.Run(() => stockMarketTechnicalAnalysisData.CalculateStockastics());
Task<decimal[]> getCalculateFastMovingAverageTask = Task.Run(() => stockMarketTechnicalAnalysisData.CalculateFastMovingAverage());
Task<decimal[]> getCalculateSlowMovingAverageTask = Task.Run(() => stockMarketTechnicalAnalysisData.CalculateSlowMovingAverage());
Task<decimal[]> getCalculateUpperBoundBollingBandTask = Task.Run(() => stockMarketTechnicalAnalysisData.CalculateUpperBoundBollingBand());
Task<decimal[]> getCalculateLowerBoundBollingBandTask = Task.Run(() => stockMarketTechnicalAnalysisData.CalculateLowerBoundBollingBand());



tasks.Add(getOpeningPricesTask);
tasks.Add(getClosingPricesTask);
tasks.Add(getPriceHighsTask);
tasks.Add(getPriceLowsTask);
tasks.Add(getCalculateStockasticsTask);
tasks.Add(getCalculateFastMovingAverageTask);
tasks.Add(getCalculateSlowMovingAverageTask);
tasks.Add(getCalculateUpperBoundBollingBandTask);
tasks.Add(getCalculateLowerBoundBollingBandTask);
Task.WaitAll(tasks.ToArray());

decimal[] data1 = tasks[0].Result;
decimal[] data2 = tasks[1].Result;
decimal[] data3 = tasks[2].Result;
decimal[] data4 = tasks[3].Result;
decimal[] data5 = tasks[4].Result;
decimal[] data6 = tasks[5].Result;
decimal[] data7 = tasks[6].Result;
decimal[] data8 = tasks[7].Result;
decimal[] data9 = tasks[8].Result;

DateTime dateAfter = DateTime.Now;
TimeSpan timeSpan = dateAfter.Subtract(dateBefore);
Console.WriteLine($"Total time taken for the processes to execute: {timeSpan.Seconds} {(timeSpan.Seconds>1? "seconds": "second")}");
DisplayDataOnChart(data1, data2, data3, data4);
static void DisplayDataOnChart(decimal[] data1, decimal[] data2, decimal[] data3, decimal[] data4)
{
    Console.WriteLine($"Data is displayed on the chart.");
}

public class StockMarketTechnicalAnalysisData
{
    public StockMarketTechnicalAnalysisData(String stockSymbol, DateTime dateTimeStart, DateTime dateTimeEnd)
    {
        // code here gets stock market data from remote server.
    }

    public decimal[] GetDailyPrices()
    {
        decimal[] data;
        Console.WriteLine($"Method name: {nameof(GetDailyPrices)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);

        data = new decimal[] { };
        return data;
    }

    public decimal[] GetClosingPrices()
    {
        decimal[] data;
        Console.WriteLine(
            $"Method name: {nameof(GetClosingPrices)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);

        data = new decimal[] { };
        return data;
    }

    public decimal[] GetPriceHighs()
    {
        decimal[] data;
        Console.WriteLine($"Method name: {nameof(GetPriceHighs)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);

        data = new decimal[] { };
        return data;
    }

    public decimal[] GetPriceLows()
    {
        decimal[] data;
        Console.WriteLine($"Method name: {nameof(GetPriceLows)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);

        data = new decimal[] { };
        return data;
    }

    public decimal[] CalculateStockastics()
    {
        decimal[] data;
        Console.WriteLine(
            $"Method name: {nameof(CalculateStockastics)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(10000);

        data = new decimal[] { };
        return data;
    }

    public decimal[] CalculateFastMovingAverage()
    {
        decimal[] data;
        Console.WriteLine(
            $"Method name: {nameof(CalculateFastMovingAverage)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(6000);

        data = new decimal[] { };
        return data;
    }

    public decimal[] CalculateSlowMovingAverage()
    {
        decimal[] data;
        Console.WriteLine(
            $"Method name: {nameof(CalculateSlowMovingAverage)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(6000);

        data = new decimal[] { };
        return data;
    }

    public decimal[] CalculateUpperBoundBollingBand()
    {
        decimal[] data;
        Console.WriteLine(
            $"Method name: {nameof(CalculateUpperBoundBollingBand)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(5000);

        data = new decimal[] { };
        return data;
    }

    public decimal[] CalculateLowerBoundBollingBand()
    {
        decimal[] data;
        Console.WriteLine(
            $"Method name: {nameof(CalculateLowerBoundBollingBand)}, Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(5000);

        data = new decimal[] { };
        return data;
    }
}