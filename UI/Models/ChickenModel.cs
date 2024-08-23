using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagerApp.Entities;

namespace ManagerApp.UI.Models
{
    internal class ChickenModel
    {
        public Chicken chicken {  get; set; }
        public Button Kill { get; set; }
        public ProgressBar LifeBar { get; set; }
        public ProgressBar ProductBar { get; set; }
        public Image Image { get; set; }
    }
}
