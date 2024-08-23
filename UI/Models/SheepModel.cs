using ManagerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.UI.Models
{
    internal class SheepModel
    {
        public Sheep sheep {  get; set; }
        public Button Kill {  get; set; }
        public ProgressBar Progress { get; set; }
        public ProgressBar ProductBar { get; set; }



    }
}
