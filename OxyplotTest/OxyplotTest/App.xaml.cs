using OxyPlot.Xamarin.Forms;
using OxyPlot;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OxyPlot.Series;
using OxyplotTest;

namespace OxyplotTest
{
    public partial class App : Application
    {
        public App()
        {
            var vSampleData = new OxyExData();
            var vTabMain = new TabbedPage();
            vTabMain.Children.Add(new ChartEx { Title = "Pie", BindingContext = vSampleData });
            MainPage = vTabMain;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
