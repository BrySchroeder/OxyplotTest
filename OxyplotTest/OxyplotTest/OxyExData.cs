using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Threading.Tasks;

namespace OxyplotTest
{
    public class OxyExData
    {
        public PlotModel MyModel { get; set; }
        Random numgen = new Random();
        int x = 6;
        int y = 10;

        public OxyExData()
        {
            MyModel = CreateChart();
            AnimationLoop();
        }

        public PlotModel CreateChart()
        {
            var model = new PlotModel { Title = "My Chart" };
            var ls = new LineSeries
            {
                StrokeThickness = 3,
            };
            ls.Points.Add(new DataPoint(0, 10));
            ls.Points.Add(new DataPoint(1, 10));
            ls.Points.Add(new DataPoint(2, 10));
            ls.Points.Add(new DataPoint(3, 10));
            ls.Points.Add(new DataPoint(4, 10));
            ls.Points.Add(new DataPoint(5, 10));
            model.Series.Add(ls);
            return model;
        }

        async Task AnimationLoop()
        {
            while(true)
            {
                int increment = numgen.Next(-1, 2);
                y += increment;

                (MyModel.Series[0] as LineSeries).Points.Add(new DataPoint(x, y));
                if ((MyModel.Series[0] as LineSeries).Points.Count > 500) 
                    (MyModel.Series[0] as LineSeries).Points.RemoveAt(0);

                MyModel.InvalidatePlot(true);
                x++;
                await Task.Delay(30);
            }
        }
    }
}