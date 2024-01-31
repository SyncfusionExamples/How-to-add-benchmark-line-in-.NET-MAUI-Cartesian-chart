using System.Collections.ObjectModel;


namespace HowToAddBenchmarkLine
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model {  XValue = "Group A", YValue = 50 },
                new Model {  XValue = "Group B", YValue = 60 },
                new Model {  XValue = "Group C", YValue = 70 },
                new Model {  XValue = "Group D", YValue = 40 }
            };
        }
    }
}
