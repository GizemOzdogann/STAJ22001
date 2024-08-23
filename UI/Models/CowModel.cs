using ManagerApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerApp.UI.Models
{
    public class CowModel
    {
        public Cow Cow { get; set; }
        public Button Kill { get; set; }
        public ProgressBar LifeBar { get; set; }
        public ProgressBar ProductBar { get; set; }
    }
}
