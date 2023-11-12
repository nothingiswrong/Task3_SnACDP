using System;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;

namespace Plots.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ISeries[] BHeapIncreaseSeries { get; set; } =
    {
        new LineSeries<ObservablePoint>
        {
            Values = new ObservablePoint[]
            {
                new ObservablePoint(0, 4),
                new ObservablePoint(1, 3),
                new ObservablePoint(3, 8),
                new ObservablePoint(18, 6),
                new ObservablePoint(20, 12)
            }
        }
    };

    public ISeries[] ArarayIncreaseSeries { get; set; } =
    {
        new LineSeries<ObservablePoint>
        {
            Values = new ObservablePoint[]
            {
                new ObservablePoint(0, 4),
                new ObservablePoint(1, 3),
                new ObservablePoint(3, 8),
                new ObservablePoint(18, 6),
                new ObservablePoint(20, 12)
            }
        }
    };

    public ISeries[] BHeapExtractMaxSeries { get; set; } =
    {
        new LineSeries<ObservablePoint>
        {
            Values = new ObservablePoint[]
            {
                new ObservablePoint(0, 4),
                new ObservablePoint(1, 3),
                new ObservablePoint(3, 8),
                new ObservablePoint(18, 6),
                new ObservablePoint(20, 12)
            }
        }
    };

    public ISeries[] ArrayExtractMaxSeries { get; set; } =
    {
        new LineSeries<ObservablePoint>
        {
            Values = new ObservablePoint[]
            {
                new ObservablePoint(0, 4),
                new ObservablePoint(1, 3),
                new ObservablePoint(3, 8),
                new ObservablePoint(18, 6),
                new ObservablePoint(20, 12)
            }
        }
    };

    public ISeries[] BHeapInsertSeries { get; set; } =
    {
        new LineSeries<ObservablePoint>
        {
            Values = new ObservablePoint[]
            {
                new ObservablePoint(0, 4),
                new ObservablePoint(1, 3),
                new ObservablePoint(3, 8),
                new ObservablePoint(18, 6),
                new ObservablePoint(20, 12)
            }
        }
    };
    public ISeries[] ArrayInsertSeries{ get; set; } =
    {
        new LineSeries<ObservablePoint>
        {
            Values = new ObservablePoint[]
            {
                new ObservablePoint(0, 4),
                new ObservablePoint(1, 3),
                new ObservablePoint(3, 8),
                new ObservablePoint(18, 6),
                new ObservablePoint(20, 12)
            }
        }
    };

    public void Calc()
    {
        ArrayInsertSeries = new ISeries[]
        {
            new LineSeries<ObservablePoint>()
        };
        Console.WriteLine("fwefwf");  
    }

    public string Greeting => "Welcome to Avalonia!";
}