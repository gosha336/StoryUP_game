using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.Interfaces
{
    internal interface IColorable
    {
        public ColorStyle ColorStyle { get; set; }
        public Color? ForegroundColor { get; }
        public Color? BackgroundColor { get; }
    }
}
