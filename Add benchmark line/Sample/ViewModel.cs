using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
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
