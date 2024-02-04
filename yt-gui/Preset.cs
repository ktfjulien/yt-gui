using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace yt_gui
{
    internal class Preset
    {
        public string Name { get; set; }
        public string[] Switches { get; set; }

        public Preset(string[] args) 
        {    
            Switches = args;
        }

        
    }
}
