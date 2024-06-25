using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMarkSample
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }   
        public ViewModel() 
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model() { XValue = "Group A", YValue = 50});
            Data.Add(new Model() { XValue = "Group B", YValue = 60});
            Data.Add(new Model() { XValue = "Group C", YValue = 70});
        }
    }
}
