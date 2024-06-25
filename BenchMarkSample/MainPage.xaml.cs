using Syncfusion.Maui.Charts;
using System.Xml.Serialization;

namespace BenchMarkSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //var chart = new SfCartesianChart();
            //var primaryAxis = new CategoryAxis();
            //primaryAxis.ShowMajorGridLines = false;
            //primaryAxis.PlotOffsetStart = 10;
            //chart.XAxes.Add(primaryAxis);

            //var secondaryAxis = new NumericalAxis();
            //secondaryAxis.Maximum = 80;
            //secondaryAxis.ShowMajorGridLines = false;
            //secondaryAxis.ShowMinorGridLines = false;
            //secondaryAxis.AxisLineStyle = new ChartLineStyle()
            //{
            //    Stroke = Colors.Transparent,
            //};
            //chart.YAxes.Add(secondaryAxis);

            //var series = new ColumnSeries();
            //series.ItemsSource = new ViewModel().Data;
            //series.XBindingPath = "XValue";
            //series.YBindingPath = "YValue";
            //series.ShowDataLabels = true;
            //series.DataLabelSettings = new CartesianDataLabelSettings()
            //{
            //    LabelStyle = new ChartDataLabelStyle()
            //    {
            //        LabelFormat = "0'%",
            //        TextColor = Colors.White,
            //    }
            //};

            //chart.Series.Add(series);

            //var horizontalLineAnnotation = new HorizontalLineAnnotation()
            //{
            //    Y1 = 62,
            //    StrokeWidth = 6,
            //    Stroke = Colors.Orange,
            //    Text = "Benchmark",
            //    LabelStyle = new ChartAnnotationLabelStyle()
            //    {
            //        HorizontalTextAlignment = ChartLabelAlignment.Start,
            //        VerticalTextAlignment = ChartLabelAlignment.End,
            //    },
            //};

            //chart.Annotations.Add(horizontalLineAnnotation);

            //this.Content = chart;
        }
    }
}
