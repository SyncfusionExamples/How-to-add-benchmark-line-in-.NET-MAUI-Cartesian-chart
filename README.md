# How-to-add-benchmark-line-in-.NET-MAUI-Cartesian-chart
This article in the Syncfusion Knowledge Base explains how to add benchmark line in .NET MAUI Cartesian chart

Creating a benchmark line in a [.NET MAUI Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) can effectively compare data points against a specific reference value visually. This article will guide you through adding a benchmark line to your chart.
Create an extension class inheriting from the [ColumnSeries](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ColumnSeries.html) class with a bindable property named `SpecificYValueProperty`  for retrieving the specific y-axis value.

**[C#]**
```
public class SeriesExt : ColumnSeries
{
    public static readonly BindableProperty SpecificYValueProperty = BindableProperty.Create(nameof(SpecificYValue), typeof(double), typeof(SeriesExt),0.0,BindingMode.Default);

    public double SpecificYValue
    {
        get { return (double)GetValue(SpecificYValueProperty); }
        set { SetValue(SpecificYValueProperty, value); }
    }   
}
```
Override the DrawSeries() method to draw a horizontal line at the specified y-value, as shown in the following code sample.

**[C#]**
```
public class SeriesExt : ColumnSeries
{
    . . .   
    protected override void DrawSeries(ICanvas canvas, ReadOnlyObservableCollection<chartsegment> segments, RectF clipRect)
    {
        base.DrawSeries(canvas, segments, clipRect);
        if (ActualXAxis != null && ActualYAxis != null)
        {
            float startPoint = (float)clipRect.Left;
            float endPoint = (float)clipRect.Right;
            var yPoint = ActualYAxis.ValueToPoint(SpecificYValue);
            canvas.StrokeColor = Colors.Black;
            canvas.StrokeSize = 5;
            canvas.DrawLine(startPoint, yPoint, endPoint, yPoint);
        }
    }
}
```
In the following section, where a SeriesExt is added to the chart, the `SpecificYValue` property is set to 65. This indicates that a horizontal line will be drawn on the chart at the position of 65 on the y-axis.

**[XAML]**
```
<chart:SfCartesianChart>
. . .
    <model:SeriesExt ItemsSource="{Binding Data}" 
                     XBindingPath="XValue" 
                     YBindingPath="YValue" 
                     SpecificYValue="65"/>

</chart:SfCartesianChart>
```
**Output**

![benchmark line.png](https://support.syncfusion.com/kb/agent/attachment/article/14541/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE1MjU4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.43SyyKNM9JQOL6NyyvP-rFEqZRtWge2ZNC12Sw1wbk8)
Explore the runnable demo from this GitHub [location](https://github.com/SyncfusionExamples/How-to-add-benchmark-line-in-.NET-MAUI-Cartesian-chart)