using StoryUP_main.TextElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryUP_main.Interfaces
{
    public interface IRenderElement : IUpdatable
    {
        public Point Point { get; set; }

        public TextBlock Text { get; set; }

        public bool IsVisible { get; set; }
    }
}
