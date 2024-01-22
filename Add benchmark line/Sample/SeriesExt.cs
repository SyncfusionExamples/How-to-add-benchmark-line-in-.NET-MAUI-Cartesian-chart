using Syncfusion.Maui.Charts;
using System.Collections.ObjectModel;

namespace Sample
{
    public class SeriesExt : ColumnSeries
    {
        public static readonly BindableProperty SpecificYValueProperty = BindableProperty.Create(nameof(SpecificYValue), typeof(double), typeof(SeriesExt),0.0,BindingMode.Default);

        public double SpecificYValue
        {
            get { return (double)GetValue(SpecificYValueProperty); }
            set { SetValue(SpecificYValueProperty, value); }
        }
       
        protected override void DrawSeries(ICanvas canvas, ReadOnlyObservableCollection<ChartSegment> segments, RectF clipRect)
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
}
