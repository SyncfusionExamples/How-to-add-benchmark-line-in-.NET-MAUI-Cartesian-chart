namespace BenchMarkSample
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("default", typeof(MainPage));
            Routing.RegisterRoute("customDrawing", typeof(CustomDrawing));
        }
    }
}
