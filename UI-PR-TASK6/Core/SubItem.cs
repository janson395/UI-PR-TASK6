using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UI_PR_TASK6.Core
{
    public class SubItem
    {
        public string Name { get; private set; }
        public UserControl UControl { get; private set; }
        public SubItem(string name, UserControl uControl = null)
        {
            Name = name;
            UControl = uControl;
        }
    }
}
